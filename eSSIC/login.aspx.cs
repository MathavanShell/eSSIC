using eSSIC.admin;
using System;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eSSIC
{
    public partial class Login : BasePage
    {
        protected void Page_Init(object s, EventArgs e)
        {
            ScriptReferenceCollection scripts = ScriptManager.GetCurrent(this.Page).Scripts;
            ScriptReference rsa = new ScriptReference("~/Scripts/jsRSA.min.js");
            scripts.Add(rsa);
        }

        protected void Page_Load(object s, EventArgs e)
        {
            Page.Title = "SSIC | Sign In";


            if (!IsPostBack)
            {
                SetPublicKeys(s, e);
            }
        }

        protected internal void ValidateSSO() // <== TO BE UPDATED LATER FOR FUTURE USE
        {
            Int32 group = new Helper().GetUserGroup(); 

            HttpContext.Current.Session["domainGroup"] = (group == 4) ? 4 : 0;
            mosSSO.Visible = (group == 4) ? true : false;
        }

        protected internal void RequestValidate(object s, EventArgs e) // <== TO BE UPDATED LATER FOR FUTURE USE
        {
            String email = acsEmail.Text;
            String uid = null;
            Boolean exist = false;

            uid = (email.IndexOf("@")) != -1 ? email.Substring(0, email.IndexOf("@")) : "";
            exist = new Finder().ValidateUser(uid);

            //exist = true;
            //System.Threading.Thread.Sleep(3000); // <== For TEST Purpose!

            if (exist)
            {
                validated.Visible = true;
                acsContinue.Visible = true;

                acsEmail.Enabled = false;
                acsValidate.Visible = false;
                acsMsg.Text = "";

                acsRole.Visible = true;
            }
            else
            {
                acsMsg.Text = "Is your email address correct?";
            }
            accessMPE.Show();

        }

        protected internal void RequestSubmit(object s, EventArgs e) // <== TO BE UPDATED LATER FOR FUTURE USE
        {
            String email = acsEmail.Text;
            String role = acsRole.SelectedValue + " / " + acsRole.SelectedItem.Text;
            Int32 mode = 1;
            String value = ""; // <== FUTURE USE

            email = String.IsNullOrEmpty(email) ? "" : email;
            role = String.IsNullOrEmpty(role) ? "" : role;

            if (email != "" && role != "")
            {
                String[] manualArray = new Helper().StartEmail(mode, value, email, role);
                ResetReqField(s, e);
                accessMPE.Hide();
            }
        }

        protected internal void ResetReqField(object s, EventArgs e)
        {
            acsEmail.Text = "";
            acsMsg.Text = "";
            acsRole.SelectedValue = "";

            acsEmail.Enabled = true;
            acsValidate.Visible = true;
            acsContinue.Visible = false;
            acsRole.Visible = false;
            validated.Visible = false;
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

        protected internal void SignIn(object s, EventArgs e)
        {
            String method = (s as Button).CommandArgument;

            if (method == "SSO") // <== TO BE UPDATED LATER FOR FUTURE USE
            {
                /*
                Int32 FGR = Int32.TryParse(HttpContext.Current.Session["domainGroup"].ToString(), out int group) ? group : 0;
                String uid = new Helper().GetUserId(); // <== TO BE UPDATED LATER FOR FUTURE USE

                HttpContext.Current.Session["domainRole"] = (FGR == 4) ? 9 : 0; // Only IT Admin can use SSO
                FormsAuthentication.RedirectFromLoginPage(uid, false);
                */
            }
            else
            {
                String gid = null;
                String email = uid.Text;
                Boolean persist = mosPersist.Checked;

                Boolean validated = ValidateCredential(email, new Crypter().RetreiveDecoded(ud.Value, cp.Value));
                
                if (validated)
                {
                    gid = (email.IndexOf("@")) != -1 ? email.Substring(0, email.IndexOf("@")) : "";
                    FormsAuthentication.RedirectFromLoginPage((gid.ToUpper()), persist); // Alt: FormsAuthentication.SetAuthCookie(ID, true)

                    Helper.SendLog("Login successful [UID: " + gid + "]", 1, 1101, "A");
                }
                else
                {
                    SetPublicKeys(s, e);
                    mosMsg.Text = "Is your email address or password correct?";

                    Helper.SendLog("Unauthorized login attempt [UID: " + gid + "]", 2, 1201, "A");
                }
            }
        }
        
        private bool ValidateCredential(String email, String pass)
        {
            Boolean isAuthenticated = false;
            String[] column = new String[] { };
            String[] value = new String[] { };
            String[] select = new String[] { };
            String[] hashed = new String[] { };
            String sqlStr = null;

            select = new String[] { "pc", "na", "role", "hub" };
            hashed = new String[select.Length];

            column = new String[] { "email" };
            value = new String[] { email };            

            try
            {
                sqlStr = "SELECT pc,na,role,hub FROM adm_sys_user WHERE email=@email AND status=1";
                hashed = new Helper().SearchDatabase(select, sqlStr, column, value);

                if (!String.IsNullOrEmpty(hashed[0]) && hashed[0] != "error" && hashed[2] != "0")
                {
                    String[] userHashed = new Crypter().RetreiveHashed(hashed[1], pass);
                    pass = null;

                    if (hashed[0] == userHashed[0])
                    {
                        HttpContext.Current.Session["domainRole"] = hashed[2];
                        HttpContext.Current.Session["domainHub"] = hashed[3];
                        isAuthenticated = true;
                    }
                }
            }
            catch
            {
                Helper.SendLog("Login validation failure [Email: " + email + "]", 0, 1001, "A");
            }
            
            return isAuthenticated;
        }       

    }
}