using ADSearch;
using RSAEncrypt;
using eMosWF;
using OSIsoft.AF.PI;
using OSIsoft.AF.Search;
using System;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Net.Mail;
using System.Net.Sockets;
using System.Linq;
using System.Security.Principal;
using System.Collections.Generic;
using System.Activities;
using System.Diagnostics;

namespace eSSIC.admin
{
    public partial class Helper
    {
        private const string logName = "eSSIC MOS System Log";
        private const string sourceName = "eMosAgent";
        EventLog log = new EventLog(logName, ".", sourceName);

        protected internal bool UpdateDatabase(String sqlStr, String[] column, String[] value)
        {
            return Boolean.TryParse(QueryDatabase(false, sqlStr, column, value), out bool status) ? status : false;
        }

        protected internal int UpdateDatabase(String sqlStr, String[] column, String[] value, Boolean insertMode)
        {          
            return Int32.TryParse(QueryDatabase(true, sqlStr, column, value), out int id) ? id : 0;
        }

        protected internal bool UpdateDatabase(String sqlStr, String[] column, String[][] value)
        {
            return QueryDatabase(sqlStr, column, value);
        }

        protected internal string SearchDatabase(String sqlStr, String[] column, String[] value)
        {
            return QueryDatabase(sqlStr, column, value);
        }

        protected internal string[] SearchDatabase(String[] selection, String sqlStr, String[] column, String[] value)
        {
            return QueryDatabase(selection, sqlStr, column, value);
        }
        
        protected internal int GetUserGroup() 
        {
            int groupRole = 0;
            string[] domainGroup = { ConfigurationManager.AppSettings["guestGroup"].ToString(), ConfigurationManager.AppSettings["userGroup"].ToString(), ConfigurationManager.AppSettings["approverGroup"].ToString(), ConfigurationManager.AppSettings["adminGroup"].ToString() };
            
            //get domain group to cross check
            for (int x = 0; x < domainGroup.Length; x++)
            {
                if (!String.IsNullOrEmpty(domainGroup[x]))
                {
                    if (HttpContext.Current.User.IsInRole(domainGroup[x]))
                    {
                        groupRole = x + 1;
                        break;                        
                    }
                }
            }
            return groupRole;
        }

        protected internal string GetUserId()
        {
            WindowsIdentity identity = HttpContext.Current.Request.LogonUserIdentity;

            return String.IsNullOrEmpty(identity.Name) ? "guest" : identity.Name.Substring(identity.Name.IndexOf("\\") + 1).ToLower();
        }

        protected internal static void SendLog(string logStr, int status, int eventId, string origin)
        {
            new Helper().UpdateLog(logStr, status, eventId, origin);
        }


        // =============== Reference Functions =============== //

        protected internal string[] FindMosTag(String mask)
        {
            return SearchMosTag(mask);
        }

        protected internal string[][] FindMosTag(String[] tags)
        {
            return SearchMosTag(tags);
        }

        protected internal string[] GetMosOverrideTag()
        {
            return RetreiveMosTag();
        }
                
        protected internal string[] StartEmail(int mode, string value, string email, string role)
        {
            Boolean sendSuccess = false;
            String emailDataStr = null;

            String[] manualData = new String[] { };
            String[] emailData = new String[] { };

            emailDataStr = SetupEmailInstance(mode, value, email, role); // mode[1-LOGIN][2-ACCESS][3-...][4-...][5-...]

            if (!String.IsNullOrEmpty(emailDataStr)) // [0-content][1-subject][2-recipient][3-sender][4-senderName][5-manualContent]
            {
                emailData = emailDataStr.Split('|');
                sendSuccess = SendBySMTP(mode, emailData[0], emailData[1], emailData[2], emailData[3], emailData[4]);

                if (!sendSuccess)
                {
                    manualData = emailData.ToArray();
                }
            }
            return manualData;
        }

        protected internal string[] GetWorkFlowState(Int32 recId, Int32 curMode, Int32 curRole, Int32 curState, Int32 extCount)
        {
            String[] state = new String[6]; //[0-nextRole][1-nextState][2-nextFunction][3-isEditMode][4-isNeedAction][5-nextCount]

            Dictionary<string, object> arguments = new Dictionary<string, object>();
            arguments.Add("curMode", curMode); 
            arguments.Add("curRole", curRole);
            arguments.Add("curState", curState);
            arguments.Add("extCount", extCount);

            WorkflowInvoker asyncInvoke = new WorkflowInvoker(new MosWF());

            IAsyncResult result = asyncInvoke.BeginInvoke(arguments, null, recId.ToString()); // Alt: ==> invoker.BeginInvoke(inputs,new AsyncCallback(WorkflowCompletedCallbackMethod), redId.ToString());

            IDictionary<string, object> outputs = asyncInvoke.EndInvoke(result); // Alt: ==> IDictionary<string, object> outputs = WorkflowInvoker.Invoke(new MosWF(), arguments);

            state[0] = String.IsNullOrEmpty(outputs["nextRole"].ToString()) ? "0" : outputs["nextRole"].ToString(); // <== Minimum [0] - NoAccess
            state[1] = String.IsNullOrEmpty(outputs["nextState"].ToString()) ? "1" : outputs["nextState"].ToString(); // <== Minimum [1] - Submitted
            state[2] = String.IsNullOrEmpty(outputs["nextFunction"].ToString()) ? "1" : outputs["nextFunction"].ToString(); // <== Minimum [1] - Submit
            state[3] = String.IsNullOrEmpty(outputs["isEditMode"].ToString()) ? "false" : outputs["isEditMode"].ToString();
            state[4] = String.IsNullOrEmpty(outputs["isNeedAction"].ToString()) ? "false" : outputs["isNeedAction"].ToString();
            state[5] = String.IsNullOrEmpty(outputs["nextCount"].ToString()) ? "0" : outputs["nextCount"].ToString();

            return state;
        }

        
        // =============== Base Functions =============== //

        private void UpdateLog(string logStr, int status, int eventId, string originator)
        {
            switch (status)
            {
                case 0:
                    log.WriteEntry(logStr + ".[" + originator + "]", EventLogEntryType.Error, eventId);
                    break;
                case 1:
                    log.WriteEntry(logStr + ".[" + originator + "]", EventLogEntryType.Information, eventId);
                    break;
                case 2:
                    log.WriteEntry(logStr + ".[" + originator + "]", EventLogEntryType.Warning, eventId);
                    break;
            }
        }

        private string SetupEmailInstance(int mode, string value, string userEmail, string userRole)
        {
            String body = null;
            String subject = null;
            String content = null;
            String comboStr = null;
            String recipient = null;
            String contentAlt = null;

            String sender = ConfigurationManager.AppSettings["adminEmail"].ToString();
            String senderName = ConfigurationManager.AppSettings["adminName"].ToString();

            //String nextLine = "%0D%0A" + "%0D%0A";

            switch (mode)
            {
                case 1:
                    subject = " [eSSIC] - Request For Access";
                    body = "The following user is requesting access to the eSSIC-MOS site:";
                    recipient = sender;
                    break;
                case 2:
                    subject = " [eSSIC] - Account Created";
                    body = "An account has been created on your behalf for accessing eSSIC-MOS site. Kindly use the following credential for your initial access.";
                    recipient = userEmail;
                    break;
                case 3:
                    subject = " [eSSIC] - New Account Password Created";
                    body = "A new account password has been created on your behalf for accessing eSSIC-MOS site. Kindly use the following credential for your access";
                    recipient = userEmail;
                    break;
            }

            try
            {
                // Prepare and format email body content
                content += "<!DOCTYPE html><html><head><meta http-equiv='Content-Type' content='text/html; charset=utf-8' /><title></title></head><body style='font-family:Verdana, Arial, Helvetica, sans-serif;font-size:14px;'>";
                content += "<table width='100%' border='0' cellspacing='5' cellpadding='0'><tr><td width='515' style='line-height:25px;font-weight:bold;'>";

                content += (mode==1) ? "Dear Support" : "Dear User";
                content += "</td></tr><tr><td style='line-height:18px;'>";

                content += body;

                content += "</td></tr><tr><td height='20'></td></tr>";
                content += "<tr><td><strong style='color:#0000FF'>";

                switch (mode)
                {
                    case 1:
                        content += "User GID: " + (userEmail.IndexOf("@") != -1 ? userEmail.Substring(0, userEmail.IndexOf("@")) : "N/A") + " (" + userEmail + ")";
                        break;
                    case 2:
                        content += "Initial Login PW: " + value;
                        break;
                    case 3:
                        content += "New Login PW: " + value;
                        break;
                }                
                content += "</strong></td></tr><tr><td><strong style='color:#0000FF'>";

                if(mode != 3)
                {
                    content += "User Role: " + userRole;
                }                

                content += "</strong></td></tr><tr><td height='30'></td></tr>";                
                content += "<tr><td style='line-height:30px'>";
                content += "Thank You.";
                content += "</td></tr><tr><td>";
                content += "This is a system generated email, DO NOT reply to this address.";                
                content += "</td></tr></table></body></html>";

                // combine all parameter for return
                comboStr = content + "|" + subject + "|" + recipient + "|" + sender + "|" + senderName + "|" + contentAlt;
            }
            catch
            {
                comboStr = null;
            }
            finally { }

            return comboStr;
        }

        private bool SendBySMTP(Int32 mode, String content, String subject, String toEmail, String fromEmail, String fromName)
        {
            Boolean serverOnline = false;
            Boolean sendStatus = false;
            
            SmtpClient smtpClient = new SmtpClient();

            using (TcpClient tcp = new TcpClient())
            {
                tcp.Connect(smtpClient.Host, smtpClient.Port);
                if (tcp.Connected)
                {
                    serverOnline = true;
                }
                else
                {
                    SendLog("Send notification error - SMTP resource not available [Type: " + (mode == 1 ? "LOGIN" : "ACCESS") + "]", 2, 8201, "A"); // mode [1-LOGIN][2-ACCESS]
                }
                tcp.Close();
            }

            if (!String.IsNullOrEmpty(toEmail) && serverOnline)
            {
                MailMessage mailMessage = new MailMessage();

                mailMessage.From = new MailAddress(fromEmail, fromName);
                mailMessage.To.Add(new MailAddress(toEmail));

                mailMessage.Priority = MailPriority.High;
                mailMessage.IsBodyHtml = true;

                mailMessage.Subject = subject;
                mailMessage.Body = content;
                
                try
                {
                    smtpClient.Send(mailMessage);
                    sendStatus = true;

                    SendLog("Notification send successfully [Type: " + (mode == 1 ? "LOGIN" : "ACCESS") + "]", 1, 8101, "A");
                }
                catch
                {
                    SendLog("Send notification error - unable to send notification [Type: " + (mode == 1 ? "LOGIN" : "ACCESS") + "]", 0, 8001, "A");
                }
                finally
                {
                    mailMessage.Dispose();
                }
            }
            return sendStatus;
        }
                
        private string QueryDatabase(Boolean insertMode, String sqlStr, String[] column, String[] value)
        {
            Int32 newRecId = 0;
            Boolean result = false;
            SqlConnection sqlConn = null;
            SqlCommand sqlCmd = null;
            try
            {
                var connStr = ConfigurationManager.ConnectionStrings["dataWriteStr"].ConnectionString;
                sqlConn = new SqlConnection(connStr);
                sqlConn.Open();

                if (insertMode)
                {
                    sqlStr += ";SELECT CAST(scope_identity() AS int)";
                }                

                sqlCmd = new SqlCommand(sqlStr, sqlConn);
                sqlCmd.Parameters.Clear();

                for (int x = 0; x < column.Length; x++)
                {
                    sqlCmd.Parameters.AddWithValue("@" + column[x], value[x]);
                }

                if (insertMode)
                {
                    newRecId = (Int32)sqlCmd.ExecuteScalar();
                }
                else
                {
                    sqlCmd.ExecuteScalar();
                    result = true;
                }
            }
            catch { }
            finally
            {
                sqlConn.Close();
            }

            if (insertMode)
            {
                return newRecId.ToString();
            }
            else
            {
                return result.ToString();
            }                
        }

        private string[] QueryDatabase(String[] selection, String sqlStr, String[] column, String[] value)
        {
            String[] result = (selection.Length < 1) ? new String[] { "" } : new String[selection.Length];
            SqlConnection sqlConn = null;
            SqlCommand sqlCmd = null;

            try
            {
                var connStr = ConfigurationManager.ConnectionStrings["dataReadStr"].ConnectionString;
                sqlConn = new SqlConnection(connStr);
                sqlConn.Open();

                sqlCmd = new SqlCommand(sqlStr, sqlConn);
                sqlCmd.Parameters.Clear();

                for (int x = 0; x < column.Length; x++)
                {
                    sqlCmd.Parameters.AddWithValue("@" + column[x], value[x]);
                }

                SqlDataReader sdr = sqlCmd.ExecuteReader();
                if (sdr.HasRows)
                {
                    while (sdr.Read())
                    {
                        for (int i = 0; i < selection.Length; i++)
                        {
                            result[i] = sdr[selection[i]].ToString().Trim();
                        }
                    }
                }
            }
            catch
            {
                result[0] = "error";
            }
            finally
            {
                sqlConn.Close();
            }

            return result;
        }

        private string QueryDatabase(String sqlStr, String[] column, String[] value)
        {
            String result = null;
            SqlConnection sqlConn = null;
            SqlCommand sqlCmd = null;
            Object contentData = null;

            try
            {
                var connStr = ConfigurationManager.ConnectionStrings["dataReadStr"].ConnectionString;
                sqlConn = new SqlConnection(connStr);
                sqlConn.Open();

                sqlCmd = new SqlCommand(sqlStr, sqlConn);
                sqlCmd.Parameters.Clear();

                for (int x = 0; x < column.Length; x++)
                {
                    sqlCmd.Parameters.AddWithValue("@" + column[x], value[x]);
                }
                contentData = sqlCmd.ExecuteScalar();
                result = (String.IsNullOrEmpty(Convert.ToString(contentData).Trim())) ? "" : Convert.ToString(contentData).Trim();

                //String colVal = null;
                //for (int x = 0; x < column.Length; x++) { colVal += column[x] + "=@" + column[x]; colVal += (x < column.Length - 1) ? "," : ""; }
            }
            catch
            {
                result = "error";
            }
            finally
            {
                sqlConn.Close();
            }
            return result;
        }

        private bool QueryDatabase(String sqlStr, String[] column, String[][] value)
        {
            Boolean result = false;
            SqlConnection sqlConn = null;
            SqlCommand sqlCmd = null;

            try
            {
                var connStr = ConfigurationManager.ConnectionStrings["dataWriteStr"].ConnectionString;
                sqlConn = new SqlConnection(connStr);
                sqlConn.Open();
                sqlCmd = new SqlCommand(sqlStr, sqlConn);

                for (int x = 0; x < value.Length; x++)
                {
                    sqlCmd.Parameters.Clear();
                    for (int y = 0; y < column.Length; y++)
                    {
                        sqlCmd.Parameters.AddWithValue("@" + column[y], value[x][y]);
                    }
                    sqlCmd.ExecuteScalar();
                }
                result = true;
            }
            catch { }
            finally
            {
                sqlConn.Close();
            }
            return result;
        }

        private string[] SearchMosTag(String mask)
        {
            String[] tagListArray;
            String tagListStr = null;
            PIServer server = new PIServers()[ConfigurationManager.AppSettings["PIServer"].ToString()];
            
            try
            {                
                server.Connect();
                IEnumerable<PIPoint> points = PIPoint.FindPIPoints(server, mask + "*.MOS", true, null, AFSearchTextOption.Contains);
                
                foreach (var tag in points)
                {
                    tagListStr += tag.Name + "|";
                }
            }
            catch { }
            finally { server.Disconnect(); }

            tagListArray = (!String.IsNullOrEmpty(tagListStr)) ? tagListStr.Substring(0, tagListStr.Length - 1).Split('|') : new String[] { };
            
            return tagListArray;
        }

        private string[][] SearchMosTag(String[] maskList)
        {
            String[][] tagValueArray;
            String tagListStr = null;
            PIServer server = new PIServers()[ConfigurationManager.AppSettings["PIServer"].ToString()];
            
            try
            {
                IEnumerable<PIPoint> points;
                server.Connect();

                for (int x = 0; x < maskList.Length; x++)
                {
                    points = PIPoint.FindPIPoints(server, maskList[x], true, null, AFSearchTextOption.Contains);

                    foreach (var tag in points)
                    {
                        tagListStr += maskList[x] + ";" + tag.CurrentValue().ToString() + "|"; // Alt: [tag.CurrentValue().Timestamp] or [tag.Name]
                    }
                    points = null;                    
                }
            }
            catch { }
            finally { server.Disconnect(); }

            tagValueArray = (!String.IsNullOrEmpty(tagListStr)) ? tagListStr.Substring(0, tagListStr.Length - 1).Split('|').Select(x => x.Split(';')).ToArray() : new String[][] { };

            return tagValueArray;
        }

        private string[] RetreiveMosTag()
        {
            String[] tagValueArray;
            String[] valueMask = new String[] { "ON","OVERRIDE","ENABLED"};

            String tagListStr = null;
            PIServer server = new PIServers()[ConfigurationManager.AppSettings["PIServer"].ToString()];
            IEnumerable<PIPoint> points;

            try
            {
                server.Connect();
                for (int x = 0; x < valueMask.Length; x++)
                {
                    points = PIPoint.FindPIPoints(server, "Tag:.MOS AND Value:=\"" + valueMask[x] + "\"", true, null, AFSearchTextOption.EndsWith);
                    foreach (var tag in points)
                    {
                        tagListStr += tag.Name + "|"; // Alt: [tag.CurrentValue().Timestamp] or [tag.Name]
                    }
                }           
            }
            catch { }
            finally { server.Disconnect(); }

            tagValueArray = (!String.IsNullOrEmpty(tagListStr)) ? tagListStr.Substring(0, tagListStr.Length - 1).Split('|') : new String[] { };
            
            return tagValueArray;
        }

    }

    public partial class Finder : FindFn
    {
        //Return string array of user info
        protected internal string[][] RetreiveUser(String uid)
        {
            return GetUser(uid);
        }
        protected internal string[][] RetreiveUser(String uid, Boolean basic)
        {
            return GetUser(uid, basic);
        }
        protected internal string[][] RetreiveUser(String uid, Boolean basic, String domain)
        {
            return GetUser(uid, basic, domain);
        }
        protected internal string[][] RetreiveUser(String uid, Boolean basic, String domain, Boolean isDefault)
        {
            return GetUser(uid, basic, domain, isDefault);
        }

        // Return True or False
        protected internal bool ValidateUser(String uid)
        {
            return FindUser(uid);
        }
        protected internal bool ValidateUser(String uid, String domain)
        {
            return FindUser(uid, domain);
        }
    }

    public partial class Crypter : CryptoFn
    {
        /// <summary>
        /// Generate unique random code string.
        /// </summary>
        /// <param name="mode">[1] URL friendly - [2] Normal mode</param>
        /// <param name="length">Length of string required.</param>
        protected internal string GenerateCode(int mode, int length)
        {
            return GetCode(mode, length);
        }
        protected internal string[] GenerateKey()
        {
            return GetKey(HttpContext.Current.Session.SessionID);
        }
        protected internal string[] RetreiveHashed(String salt, String source)
        {
            return GetHash(salt, source);
        }
        protected internal string RetreiveDecoded(String name, String source)
        {
            return Decrypt(name, source);
        }
    }
}

namespace eSSIC
{
    public partial class BasePage : Page
    {
        //Access Level Verification
        protected void AuthorizeAccess(int minRole)
        {
            int userRole = Convert.ToInt32(GetSessionVar("domainRole"));
            if (userRole != minRole && userRole != 9) // [9] is Administrator
            {
                String originUrl = (Request.UrlReferrer == null) ? "~/" : Request.UrlReferrer.OriginalString;
                String targetUrl = Request.Url.AbsolutePath;

                HttpContext.Current.Session["accessDeniedStatus"] = "0" + "|" + userRole + "|" + minRole + "|" + targetUrl; // [groupStatus,userRole,minRole,targetUrl] - groupStatus=0 equal not in group
                Response.Redirect(originUrl);
            }
        }
        
        //Validate and replace HTML non-compliance characters in Text fields
        protected void TextValidation(object s, EventArgs e)
        {
            String input = (s is TextBox) ? ((TextBox)s).Text : ((Label)s).Text;
            if (input.IndexOf("<") == 0)
            {
                input = input.Substring(1);

                if (input.IndexOf(">") == input.Length - 1)
                {
                    input = input.Substring(0, input.Length - 1);
                }
            }
            if (s is TextBox)
            {
                ((TextBox)s).Text = input;
            }
            else
            {
                ((Label)s).Text = input;
            }
        }

        //Sum duration into hours & minutes that exceed 24hrs
        protected string TimeStrConvert(int sec, int mode)
        {
            String timeStr = null;
            int hour = 0;
            int minute = 0;
            //int second = 0;

            try
            {
                hour = sec / 3600;
                minute = (sec % 3600) / 60;
                //second = sec % 3600;
            }
            catch { }
            switch (mode)
            {
                case 1:
                    timeStr = hour.ToString("D" + 2) + " h " + minute.ToString("D" + 2) + " m";
                    break;
                case 2:
                    timeStr = hour.ToString("D" + 2) + ":" + minute.ToString("D" + 2);
                    break;
            }
            return timeStr;
        }

        //Check and return session variable value
        protected string GetSessionVar(String para)
        {
            String result = null;
            try
            {
                result = (HttpContext.Current.Session[para] != null) ? (HttpContext.Current.Session[para].ToString().Trim() ?? "") : "";
            }
            catch
            {
                result = "";
            }

            return result;
        }

        //Check and return URL parameter value
        protected string GetParameter(String para)
        {
            return Request.QueryString[para] ?? "";
        }


        // =============== Web Services Functions =============== //

        [WebMethod(EnableSession = true)]
        public static void DismissPrompt(string para)
        {
            ProcessDenyPrompt(para);
        }

        [WebMethod(EnableSession = true)]
        public static string[] SearchMosTag(string mask)
        {
            return ProcessFindMosTag(mask);
        }

        [WebMethod(EnableSession = true)]
        public static bool MosOverrideStatus()
        {
            return GetOverrideStatus();
        }

        [WebMethod(EnableSession = true)]
        public static string[] MosOverrideTags()
        {
            return GetOverrideTags();
        }

        [WebMethod(EnableSession = true)]
        public static string MosOverrideTime()
        {
            return GetOverrideTime();
        }

        // =============== Web Services Sub Functions =============== //

        private static void ProcessDenyPrompt(string cat)
        {
            switch (cat)
            {
                case "1":
                    HttpContext.Current.Session["accessDeniedStatus"] = null;
                    break;
            }
        }

        private static string[] ProcessFindMosTag(string mask)
        {
            String[] result = new admin.Helper().FindMosTag(mask);
            return result;
        }
        
        private static bool GetOverrideStatus()
        {
            Boolean result = false;
            result = Boolean.TryParse(HttpContext.Current.Application["mosOverrideStatus"].ToString(), out bool state) ? state : false;

            return result;
        }

        private static string[] GetOverrideTags()
        {
            String[] result = new String[] { };
            result = HttpContext.Current.Application["mosOverrideTags"] as String[];

            return result;
        }

        private static string GetOverrideTime()
        {
            String result = null;
            result = HttpContext.Current.Application["mosOverrideTime"] as String;

            return result;
        }
    }
        
}