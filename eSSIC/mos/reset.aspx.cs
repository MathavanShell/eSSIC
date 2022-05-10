using eSSIC.admin;
using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eSSIC.MOS
{
    public partial class Reset : BasePage
    {
        protected void Page_Init(object s, EventArgs e)
        {
            ScriptReferenceCollection scripts = ScriptManager.GetCurrent(this.Page).Scripts;
            ScriptReference rsa = new ScriptReference("~/Scripts/jsRSA.min.js");
            scripts.Add(rsa);
        }

        protected void Page_Load(object s, EventArgs e)
        {
            Page.Title = Master.appNameTitle + "Reset";
            

            if (!IsPostBack)
            {
                SetFunctionAccess(s, e);
                SetPublicKeys(s, e);
            }
        }

        //Disable non-related function or button
        protected void SetFunctionAccess(object s, EventArgs e)
        {
            ((Button)Master.FindControl("searchBtn")).Enabled = false;
            ((TextBox)Master.FindControl("search")).Enabled = false;
            ((Button)Master.FindControl("mobileSearchBtn")).Enabled = false;
            ((TextBox)Master.FindControl("mobileSearch")).Enabled = false;
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

        protected internal void ChangePass(object s, EventArgs e)
        {
            Boolean isChanged = ValidateAndUpdate(HttpContext.Current.User.Identity.Name, new Crypter().RetreiveDecoded(ud.Value, cp.Value));

            if (isChanged)
            {
                resetMsg.CssClass = "msgGreen";
                resetMsg.Text = "Password updated successfully";
            }
            else
            {
                SetPublicKeys(s, e);
                resetMsg.Text = "Is your current password correct?";
            }
        }

        private bool ValidateAndUpdate(String uid, String pcStr)
        {
            Boolean isCompleted = false;
            Boolean proceedUpdate = false;

            String[] column = new String[] { };
            String[] value = new String[] { };
            String[] select = new String[] { };
            String[] hashed = new String[] { };
            String[] userHashed = new String[] { };
            String[] newHashed = new String[] { };

            String[] pcList = String.IsNullOrEmpty(pcStr) ? new String[] { } : pcStr.Split('|');

            if (pcList.Length > 0)
            {
                select = new String[] { "pc", "na" };
                hashed = new String[select.Length];

                column = new String[] { "uid" };
                value = new String[] { uid };

                String sqlStr = null;
                try
                {
                    sqlStr = "SELECT pc,na FROM adm_sys_user WHERE uid=@uid AND status=1";
                    hashed = new Helper().SearchDatabase(select, sqlStr, column, value);

                    //Hash Code Validate
                    if (!String.IsNullOrEmpty(hashed[0]) && !String.IsNullOrEmpty(hashed[1]) && hashed[0] != "error")
                    {
                        userHashed = new Crypter().RetreiveHashed(hashed[1], pcList[0]);

                        if (hashed[0] == userHashed[0])
                        {
                            proceedUpdate = true;
                        }
                        else
                        {
                            Helper.SendLog("User profile passcode hash does not match [UID: " + uid + "]", 0, 2006, "A");
                        }
                        Array.Clear(hashed, 0, hashed.Length);
                        Array.Clear(userHashed, 0, userHashed.Length);
                        Array.Clear(column, 0, column.Length);
                        Array.Clear(value, 0, value.Length);
                        Array.Clear(select, 0, select.Length);
                    }
                                        
                    // Hash Code Update
                    if (proceedUpdate && (pcList[1] == pcList[2]))
                    {
                        newHashed = new Crypter().RetreiveHashed("", pcList[1]);
                        if (newHashed.Length > 0)
                        {
                            column = new String[] { "pc", "na", "uid" };
                            value = new String[] { newHashed[0], newHashed[1], uid };

                            sqlStr = "UPDATE adm_sys_user SET pc=@pc,na=@na WHERE uid=@uid";
                            isCompleted = new Helper().UpdateDatabase(sqlStr, column, value);

                            if (isCompleted)
                            {
                                Helper.SendLog("User profile passcode updated successfully [UID: " + uid + "]", 1, 2107, "A");
                            }
                            else
                            {
                                Helper.SendLog("Update user profile passcode error - unable to save status into database [UID: " + uid + "]", 0, 2007, "A");
                            }
                        }
                        Array.Clear(newHashed, 0, newHashed.Length);
                        Array.Clear(column, 0, column.Length);
                        Array.Clear(value, 0, value.Length);                        
                    }                    
                }
                catch
                {
                    Helper.SendLog("Update user profile passcode error - unable to save status into database [UID: " + uid + "]", 0, 2007, "A");
                }
            }
            return isCompleted;
        }


    }
}