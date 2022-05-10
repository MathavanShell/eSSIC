using System;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eSSIC
{
    public partial class SiteMaster : MasterPage
    {
        public string appNameTitle = "SSIC" + " | ";
        //public string schedulerSvcName = "eSsicScheduler";
        public Int32 maxText = 300;

        //Path is based on the location of the report pages - Any modification HERE MUST modify js script var [picBasePath] counter-part also!
        public string mediaLoadPath = "App_Themes/Media/"; // <== To Be Determine
        public string picBasePath = "App_Themes/baseObjects/";
        public string placeHolder = "App_Themes/baseObjects/markupPlaceholder.png";

        protected void Page_Init(object s, EventArgs e)
        {
            SetFunctionMenu();
        }

        protected void Page_Load(object s, EventArgs e)
        {
            CheckForPrompt();

            ScriptManager.RegisterStartupScript(Page, GetType(), "SetTopBar", "preSetTopBar();", true);
        }

        protected void SetFunctionMenu()
        {
            // Dashboard
            mainBtn1.Visible = true;  
            sideNavBtn1.Visible = true;
            
            // Manage
            mainBtn2.Visible = true; 
            sideNavBtn2.Visible = true;

            // Monitor
            mainBtn3.Visible = true;
            sideNavBtn3.Visible = true;

            // Report
            mainBtn5.Visible = true;
            sideNavBtn5.Visible = true;

            // Reload user session variable for Persist Login function
            if (Request.IsAuthenticated)
            {
                Boolean isNeeded = (Session["domainRole"] != null) ? false : true;
                
                if (isNeeded)
                {   
                    String[] column = new String[] { };
                    String[] value = new String[] { };
                    String[] select = new String[] { };
                    String[] profile = new String[] { };
                    String sqlStr = null;

                    select = new String[] { "role", "hub" };
                    profile = new String[select.Length];

                    column = new String[] { "uid" };
                    value = new String[] { HttpContext.Current.User.Identity.Name };
                    
                    try
                    {
                        sqlStr = "SELECT role,hub FROM adm_sys_user WHERE uid=@uid AND status=1";
                        profile = new admin.Helper().SearchDatabase(select, sqlStr, column, value);

                        if (!String.IsNullOrEmpty(profile[0]) && profile[0] != "error" && profile[0] != "0")
                        {
                            HttpContext.Current.Session["domainRole"] = profile[0];
                            HttpContext.Current.Session["domainHub"] = profile[1];
                        }
                    }
                    catch
                    {
                        admin.Helper.SendLog("Session reconnect validation failure [UID: " + value[0] + "]", 0, 1001, "A");
                    }                    
                }

                //mainBtn3.Visible = true;
                //sideNavBtn3.Visible = true;
                //mainBtn4.Visible = true;
                //sideNavBtn4.Visible = true;
            }
        }

        protected void CheckForPrompt()
        {
            if (HttpContext.Current.Session["accessDeniedStatus"] != null)
            {
                String[] status = HttpContext.Current.Session["accessDeniedStatus"].ToString().Split('|');
                Int32 minRole = Int32.TryParse(status[2], out int min) ? min : 0; // [groupStatus,userRole,minRole,targetUrl]

                switch (minRole)
                {
                    case 9:
                        deniedDesc.Text = "Site administrator only";
                        accessDenied.Width = 350;
                        break;
                    case 4:
                        deniedDesc.Text = "PS or Approver role only";
                        accessDenied.Width = 350;
                        break;
                    case 1:
                        deniedDesc.Text = "OT or Requester role only";
                        accessDenied.Width = 350;
                        break;
                    default:
                        deniedDesc.Text = "Kindly contact support for assistant";
                        accessDenied.Width = 420;
                        break;
                }

                if (status[0] == "0")
                {
                    accessDeniedMPE.Show();
                }
            }
        }

        protected void ReDirectURL(object s, EventArgs e)
        {
            var btnCat = ((Button)s).ID;
            switch (btnCat)
            {
                case "sideNavSetBtn":
                case "settingBtn":
                    Response.Redirect("~/admin/overview.aspx");
                    break;
                case "accessBtn":
                    Response.Redirect("~/mos/access.aspx");
                    break;
                case "sideNavBtn1":
                case "mainBtn1":
                    Response.Redirect("~/");
                    break;
                case "sideNavBtn2":
                case "mainBtn2":
                    Response.Redirect("~/mos/manage.aspx");
                    break;
                case "sideNavBtn3":
                case "mainBtn3":
                    Response.Redirect("~/monitor.aspx");
                    break;
                case "sideNavBtn4":
                case "mainBtn4":
                    Response.Redirect("~/");
                    break;

                case "sideNavBtn5":
                case "mainBtn5":
                    Response.Redirect("~/Report.aspx");
                    break;
            }
        }

        protected void SignIn(object s, EventArgs e)
        {
            Response.Redirect("~/login.aspx");
        }

        protected void SignOut(object s, EventArgs e)
        {
            String gid = HttpContext.Current.User.Identity.Name;
            Boolean isOut = false;
            try
            {
                Session.Clear();
                FormsAuthentication.SignOut();
                isOut = true;
            }
            catch
            {
                admin.Helper.SendLog("Logout incomplete [UID: " + gid + "]", 0, 1002, "A");
            }

            if (isOut)
            {
                admin.Helper.SendLog("Logout successful [UID: " + gid + "]", 1, 1102, "A");
                Response.Redirect("~/");
            }                
        }

        protected void ResetPassword(object s, EventArgs e)
        {
            Response.Redirect("~/mos/reset.aspx");
        }

        protected void SwitchProfile(object s, EventArgs e)
        {
            String gid = HttpContext.Current.User.Identity.Name;
            Boolean isOut = false;
            try
            {
                Session.Clear();
                FormsAuthentication.SignOut();
                isOut = true;
            }
            catch
            {
                admin.Helper.SendLog("Logout incomplete [UID: " + gid + "]", 0, 1002, "A");
            }

            if (isOut)
            {
                admin.Helper.SendLog("Logout successful [UID: " + gid + "]", 1, 1102, "A");
                Response.Redirect("~/mos/manage.aspx");
            }
            
        }

        // TO BE DETERMINE LATER WHETHER THIS FUNCTION IS REQUIRED OR NOT [23-SEP-2019]
        protected void SetUnlockStatus(object s, EventArgs e)
        {
            var status = unlockReport.CommandName;

            unlockReport.CommandName = (status == "locked") ? "unlock" : "locked";
            unlockReport.Text = (status == "locked") ? "lock_open" : "lock_outline";
            sideNavList1Btn3Icon.Text = (status == "locked") ? "lock_open" : "lock_outline";
            MainContent.DataBind();
        }

    }
}