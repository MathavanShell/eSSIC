using eSSIC.admin;
using System;
using System.Collections.Specialized;
using System.Globalization;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eSSIC.MOS
{
    public partial class Access : BasePage
    {
        protected void Page_Load(object s, EventArgs e)
        {
            AuthorizeAccess(4);

            Page.Title = Master.appNameTitle + "Access";
            
            if (!IsPostBack)
            { }
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
                Helper.SendLog("User profile passcode reset successfully [UID: "+ uid + "][Profile: " + email + "]", 1, 2108, "A");

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

    }

}