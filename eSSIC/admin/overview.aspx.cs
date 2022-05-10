using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;
using System.Collections.Specialized;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;

namespace eSSIC.admin
{
    public partial class Overview : BasePage
    {
        protected void Page_Init(object s, EventArgs e)
        {
            ScriptReferenceCollection scripts = ScriptManager.GetCurrent(this.Page).Scripts;
            ScriptReference rsa = new ScriptReference("~/Scripts/jsRSA.min.js");
            scripts.Add(rsa);
        }

        protected void Page_Load(object s, EventArgs e)
        {
            AuthorizeAccess(9);

            Page.Title = Master.appNameTitle + "Admin";

            if (!IsPostBack)
            {
                SetFunctionAccess();
                SetPublicKeys(s, e);
            }
        }

        //Disable non-related function or button
        protected void SetFunctionAccess()
        {
            //Search Function
            ((Button)Master.FindControl("searchBtn")).Enabled = false;
            ((Button)Master.FindControl("searchBtn")).Text = "build";
            ((Button)Master.FindControl("searchBtn")).ToolTip = "";

            ((TextBox)Master.FindControl("search")).Text = "System Administration";
            ((TextBox)Master.FindControl("search")).Enabled = false;

            ((Button)Master.FindControl("mobileSearchBtn")).Enabled = false;
            ((Button)Master.FindControl("mobileSearchBtn")).Text = "build";
            ((Button)Master.FindControl("mobileSearchBtn")).ToolTip = "";

            ((TextBox)Master.FindControl("mobileSearch")).Text = "System Administration";
            ((TextBox)Master.FindControl("mobileSearch")).Enabled = false;

            // Hash Fixer
            //if (Request.Url.Host == "localhost")
            //{
                tabBtn3.Visible = true;
                tabBtn3.Enabled = true;

                hashRs.Enabled = true;
                hashFn.Enabled = true;
                hashFx.Enabled = true;
            //}
        }

        protected internal void SetPublicKeys(object s, EventArgs e)
        {
            try
            {
                String[] publicKey = new Crypter().GenerateKey();
                mk.Value = publicKey[0];
                en.Value = publicKey[1];
                ud.Value = publicKey[2];
            }
            catch { }
        }

        //Tab switcher
        protected void SwitchTab(object s, EventArgs e)
        {
            Button[] tabList = { tabBtn1, tabBtn2, tabBtn3, tabBtn4 };
            Button source = (Button)s;
            Int32 tabIdx = Convert.ToInt32(source.CommandArgument);

            syncTab.ActiveViewIndex = tabIdx;
            
            foreach (Button btn in tabList)
            {
                if (btn.Visible && btn.CssClass == "syncTabActive")
                {
                    btn.CssClass = "syncTab";
                    break;
                }
            }
            source.CssClass = "syncTabActive";
        }

        //Set table page size
        protected void SetPagerSize(object s, EventArgs e)
        {
            mosProfileGV.PageSize = Convert.ToInt32(((DropDownList)s).SelectedValue);
        }

        //Set fields back to default
        protected void ResetAddField(object s, EventArgs e)
        {
            usrAddGid.Text = "";
            usrAddUid.Text = "";
            usrAddName.Text = "";
            usrAddEmail.Text = "";
            usrAddRole.SelectedValue = "0";
            usrAddRole.Enabled = false;
            usrAddHub.SelectedValue = "0";
            usrAddHub.Enabled = false;
            usrAddSave.Enabled = false;
            usrAddReset.Enabled = false;
            usrAddMsg.Text = "";
        }
        protected void ResetUsrList(object s, EventArgs e)
        {
            schUser.Text = "";
            mosProfileGV.PageIndex = 0;
            mosProfileGV.PageSize = 10;

            ResetAddField(s, e);
        }

        //Locate new user from AD - [LegacyID][Username]*[Email][OU][Name][Title][Department][Base][Company][Country]*[Type][Indicator]
        protected void FindUser(object s, EventArgs e)
        {
            String uid = usrAddGid.Text;
            String[][] userInfoArray = new String[][] { };
            Boolean userExist = false;

            ResetAddField(s, e);
            if (!String.IsNullOrEmpty(uid))
            {
                try
                {
                    userInfoArray = new Finder().RetreiveUser(uid, false);
                }
                catch
                {
                    usrAddMsg.Text = "Unable to establish AD connection to validate user";
                }

                if (userInfoArray.Length > 0)
                {
                    userExist = CheckDuplicateUser(userInfoArray[0][1].ToLower());

                    if (userExist)
                    {
                        usrAddMsg.Text = "User already exist";
                        schUser.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(userInfoArray[0][1].ToLower());

                        Helper.SendLog("Existing user profile found [UID: " + uid + "]", 1, 2104, "A");
                    }
                    else
                    {
                        usrAddUid.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(userInfoArray[0][1].ToLower());
                        usrAddName.Text = userInfoArray[0][4];
                        usrAddEmail.Text = userInfoArray[0][2];

                        usrAddRole.Enabled = true;
                        usrAddHub.Enabled = true;
                        usrAddReset.Enabled = true;
                        usrAddSave.Enabled = true;
                    }
                }
                else
                {
                    usrAddMsg.Text = "Unable to locate '" + uid + "' in Active Directory";
                }
            }
        }

        //Verify any existing entry
        protected bool CheckDuplicateUser(String uid)
        {
            Boolean exist = false;
            String result = null;

            String[] column = new String[] { "uid" };
            String[] value = new String[] { uid };
            String sqlStr = "SELECT rec FROM adm_sys_user WHERE uid=@uid";

            result = new Helper().SearchDatabase(sqlStr, column, value);

            if (result == "error")
            {
                Helper.SendLog("User profile search error - unable to establish database connection", 0, 2004, "A");
            }
            else
            {
                exist = String.IsNullOrEmpty(result) ? false : true;
            }
            return exist;
        }

        //Add new record
        protected void InsertNew(object s, EventArgs e)
        {
            String cat = ((Button)s).CommandArgument;

            String[] column = new String[] { };
            String[] value = new String[] { };
            String[] hashed = new String[] { };
            String passcode = null;
            String sqlStr = null;
            Boolean result = false;

            String uid = null;
            String role = null;
            String hub = null;
            String ou = null;
            String name = null;
            String email = null;

            switch (cat)
            {
                case "USR":
                    sqlStr = "INSERT INTO adm_sys_user (uid,pc,na,ou,role,hub,name,email) VALUES (@uid,@pc,@na,@ou,@role,@hub,@name,@email)";
                    uid = usrAddUid.Text;
                    role = usrAddRole.SelectedValue;
                    hub = usrAddHub.SelectedValue;
                    ou = usrAddOu.SelectedValue;
                    name = usrAddName.Text;
                    email = usrAddEmail.Text;

                    passcode = new Crypter().GenerateCode(1, 12);
                    hashed = new Crypter().RetreiveHashed("", passcode);

                    column = new String[] { "uid", "pc", "na", "ou", "role", "hub", "name", "email" };
                    value = new String[] { uid, hashed[0], hashed[1], ou, role, hub, name, email };
                    break;
            }
            result = new Helper().UpdateDatabase(sqlStr, column, value);

            switch (cat)
            {
                case "USR":
                    if (result)
                    {
                        Helper.SendLog("New user profile created successfully [UID: " + uid + "][Role: " + role + "][Hub: " + hub + "]", 1, 2101, "A");

                        //Send notification email to new user
                        if (value[5] != "" && value[3] != "")
                        {
                            String[] manualArray = new Helper().StartEmail(2, passcode, email, usrAddRole.SelectedItem.Text);
                            passcode = null;
                        }
                    }
                    else
                    {
                        Helper.SendLog("Insert new user profile error - unable to insert entry into database [Email: " + email + "]", 0, 2001, "A");
                    }
                    mosProfileGV.DataBind();
                    ResetAddField(s, e);
                    break;
            }
        }

        //Reset user password
        protected void ResetPin(object s, EventArgs e)
        {
            LinkButton pin = s as LinkButton;
            String email = pin.CommandArgument;
            String uid = HttpContext.Current.User.Identity.Name;

            String[] column = new String[] { };
            String[] value = new String[] { };
            String[] hashed = new String[] { };
            String passcode = null;
            String sqlStr = null;
            Boolean result = false;

            passcode = new Crypter().GenerateCode(1, 12);
            hashed = new Crypter().RetreiveHashed("", passcode);

            sqlStr = "UPDATE adm_sys_user SET pc=@pc,na=@na WHERE email=@email";
            column = new String[] { "pc", "na", "email" };
            value = new String[] { hashed[0], hashed[1], email };

            result = new Helper().UpdateDatabase(sqlStr, column, value);

            if (result)
            {
                Helper.SendLog("User profile passcode reset successfully [UID: " + uid + "][Profile: " + email + "]", 1, 2108, "A");

                String[] manualArray = new Helper().StartEmail(3, passcode, email, "");
                passcode = null;
                Array.Clear(hashed, 0, hashed.Length);

                pin.Text = "check";
                pin.CssClass = "material-icons statusIndIconCheck";
                pin.ToolTip = "Reset Completed";
            }
            else
            {
                Helper.SendLog("User passcode reset error - unable to save new pin into database [UID: " + uid + "][Profile: " + email + "]", 0, 2008, "A");

                pin.Text = "close";
                pin.CssClass = "material-icons statusIndIconCross";
                pin.ToolTip = "Reset Failed";
            }
        }

        //Log row update action
        protected void LogRowUpdate(object s, GridViewUpdatedEventArgs e)
        {
            String status = null;
            String role = null;
            String hub = null;

            String uid = HttpContext.Current.User.Identity.Name;
            String profile = e.Keys["uid"].ToString();

            OrderedDictionary updatedValue = (OrderedDictionary)e.NewValues;
            OrderedDictionary originalValue = (OrderedDictionary)e.OldValues;

            Boolean isChangeState = (updatedValue[0].ToString() != originalValue[0].ToString()) ? true : false;
            Boolean isEdit = (updatedValue[1].ToString() != originalValue[1].ToString() || updatedValue[2].ToString() != originalValue[2].ToString()) ? true : false;

            Boolean currentState = Boolean.TryParse(updatedValue[0].ToString(), out bool state) ? state : false;

            if (e.Exception == null && e.AffectedRows == 1)
            {
                status = updatedValue[0].ToString();
                role = updatedValue[1].ToString();
                hub = updatedValue[2].ToString();

                if (isEdit)
                {
                    Helper.SendLog("Profile assignment updated successfully [UID: " + uid + "][Profile: " + profile + "][Role: " + role + "][Hub: " + hub + "][Enabled: " + status + "]", 1, 2102, "A");
                }
                if (isChangeState)
                {
                    Helper.SendLog("User profile " + (currentState ? "enabled" : "disabled") + " successfully [UID: " + uid + "][Profile: " + profile + "]", 1, 2103, "A");
                }
            }
            else
            {
                if (isEdit)
                {
                    Helper.SendLog("Update user profile error - unable to save changes into database [UID: " + uid + "][Profile: " + profile + "]", 0, 2002, "A");
                }
                if (isChangeState)
                {
                    Helper.SendLog("Update user status error - unable to save status into database[UID: " + uid + "][Profile: " + profile + "]", 0, 2003, "A");
                }
                e.ExceptionHandled = true;
            }
        }

        //Hash function
        protected void HashField(object s, EventArgs e)
        {
            String[] hashed = new String[] { };

            String passcode = new Crypter().RetreiveDecoded(ud.Value, cp.Value);

            if (!String.IsNullOrEmpty(passcode))
            {
                hashed = new Crypter().RetreiveHashed("", passcode);
                passcode = null;

                hashField.Text = hashed[0];
                saltField.Text = hashed[1];
            }

            SetPublicKeys(s, e);
        }
        protected void ResetHashField(object s, EventArgs e)
        {
            passField.Text = "";
            hashField.Text = "";
            saltField.Text = "";
        }
        protected void FixPasscode(object s, EventArgs e)
        {
            Boolean isFixed = false;
            String salt = null;
            String pass = null;
            String hashStr = null;
            String[] column = new String[] { };
            String[] hashed = new String[] { };
            String[][] hashable = new String[][] { };

            SqlConnection sqlConn = null;
            SqlCommand sqlCmd = null;
            String sqlStr;
            try
            {
                try
                {
                    var connStr = ConfigurationManager.ConnectionStrings["dataReadStr"].ConnectionString;
                    sqlConn = new SqlConnection(connStr);
                    sqlConn.Open();

                    sqlStr = "SELECT rec,pc,na FROM adm_sys_user";
                    sqlCmd = new SqlCommand(sqlStr, sqlConn);
                    sqlCmd.Parameters.Clear();
                    using (SqlDataReader sdr = sqlCmd.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            if (String.IsNullOrEmpty(sdr["na"].ToString().Trim()))
                            {
                                hashed = new Crypter().RetreiveHashed("", sdr["pc"].ToString().Trim());
                                pass = hashed[0];
                                salt = hashed[1];

                                hashStr += sdr["rec"].ToString().Trim() + ";" + pass + ";" + salt + "|";

                                //Reset for next row
                                Array.Clear(hashed, 0, hashed.Length);
                                pass = null;
                                salt = null;
                            }
                        }
                    }
                }
                catch { }
                finally { sqlConn.Close(); }
                
                hashStr = String.IsNullOrEmpty(hashStr) ? "" : hashStr.Substring(0, hashStr.Length - 1);
                hashable = String.IsNullOrEmpty(hashStr) ? new String[][] { } : hashStr.Split('|').Select(x => x.Split(';')).ToArray();

                if (hashable.Length > 0)
                {
                    column = new String[] { "rec", "pc", "na" };
                    sqlStr = "UPDATE adm_sys_user SET pc=@pc,na=@na WHERE rec=@rec";
                    isFixed = new Helper().UpdateDatabase(sqlStr, column, hashable);

                    if (isFixed)
                    {
                        Helper.SendLog("User profile passcode hash remedy completed", 1, 2105, "A");
                    }
                    else
                    {
                        Helper.SendLog("User profile passcode hash fix error", 0, 2005, "A");
                    }
                }
                else
                {
                    Helper.SendLog("User profile passcode hash remedy not required", 1, 2106, "A");
                }
                
            }
            catch
            {
                Helper.SendLog("User profile passcode hash fix error", 0, 2005, "A");
            }
            finally
            {
                
            }
            Array.Clear(hashable, 0, hashable.Length);
        }

    }

}