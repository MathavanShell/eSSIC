using eSSIC.admin;
using AjaxControlToolkit;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Numerics;

namespace eSSIC.MOS
{
    public partial class Request : BasePage
    {
        private DataTable function = new DataTable();
        private DataTable title = new DataTable();

        protected void Page_Load(object s, EventArgs e)
        {
            Page.Title = Master.appNameTitle + "Request";
            ((Button)Master.FindControl("mainBtn2")).CssClass = "mainNavBarMenuBtnActive";

            ScriptManager.RegisterStartupScript(Page, GetType(), "SetMandatoryChecker", "checkMandatoryField('REQ');", true);

            if (!IsPostBack)
            {
                reqFormId.Value = Int32.TryParse(GetParameter("id"), out int result) ? result.ToString() : "0";
                HttpContext.Current.Session["insertMode"] = Request.QueryString.Count > 0 ? false : true;

                if (!String.IsNullOrEmpty(reqFormId.Value))
                {
                    SetHiddenFields(s, e);
                }

                SetFormMode();
                SetFunctionAccess();
                ValidateRequester();
            }
        }

        //Validate Requester
        protected void ValidateRequester()
        {
            Boolean isNew = Boolean.TryParse(GetSessionVar("insertMode"), out bool result) ? result : false;
            if (isNew)
            {
                AuthorizeAccess(1);
            }
        }

        //Set hidden fields values
        protected void SetHiddenFields(object s, EventArgs e)
        {            
            using (DataView dv = (DataView)requestDS.Select(DataSourceSelectArguments.Empty))
            {
                if (dv.Count > 0)
                {
                    ((TextBox)Master.FindControl("search")).Text = "MOS No.   " + dv[0].Row["hub"].ToString() + "-" + Convert.ToInt32(dv[0].Row["mosId"]).ToString("D5");
                    ((TextBox)Master.FindControl("mobileSearch")).Text = "MOS No.   " + dv[0].Row["hub"].ToString() + "-" + Convert.ToInt32(dv[0].Row["mosId"]).ToString("D5");
                }

                reqFormHub.Value = dv.Count > 0 ? dv[0].Row["hub"].ToString() : "";
                reqFormField.Value = dv.Count > 0 ? dv[0].Row["field"].ToString() : "";
                reqTime.Value = dv.Count > 0 ? dv[0].Row["reqTimestamp"].ToString() : "";
                reqId.Value = dv.Count > 0 ? dv[0].Row["reqId"].ToString() : "";

                reqCurRole.Value = dv.Count > 0 ? dv[0].Row["nextRole"].ToString() : "0";
                reqCurState.Value = dv.Count > 0 ? dv[0].Row["curState"].ToString() : "0";
                reqCurMode.Value = dv.Count > 0 ? dv[0].Row["curMode"].ToString() : "0";                
                reqExtCount.Value = dv.Count > 0 ? dv[0].Row["extCount"].ToString() : "0";
            }

            function.Clear();
            //function.Columns.AddRange(new DataColumn[2] { new DataColumn("fnDesc"), new DataColumn("fnCode") });
            using (DataView fnDv = (DataView)fnListDS.Select(DataSourceSelectArguments.Empty))
            {
                function = fnDv.ToTable();
            }

            title.Clear();
            //title.Columns.AddRange(new DataColumn[2] { new DataColumn("roleDesc"), new DataColumn("roleCode") });
            using (DataView roleDv = (DataView)roleListDS.Select(DataSourceSelectArguments.Empty))
            {
                title = roleDv.ToTable();
            }
        }

        //Disable non-related function or button
        protected void SetFunctionAccess()
        {
            ((TextBox)Master.FindControl("search")).Enabled = false;
            ((TextBox)Master.FindControl("search")).ToolTip = "Request ID";
            ((Button)Master.FindControl("searchBtn")).Enabled = false;            
            ((Button)Master.FindControl("searchBtn")).Text = "subject";
            ((Button)Master.FindControl("searchBtn")).ToolTip = "";

            ((TextBox)Master.FindControl("mobileSearch")).Enabled = false;
            ((TextBox)Master.FindControl("mobileSearch")).ToolTip = "Request ID";
            ((Button)Master.FindControl("mobileSearchBtn")).Enabled = false;            
            ((Button)Master.FindControl("mobileSearchBtn")).Text = "subject";
            ((Button)Master.FindControl("mobileSearchBtn")).ToolTip = "";

            //Navigation validation overide
            String overide = "$('#basePrimary').attr('novalidate', 'novalidate');";
            ((Button)Master.FindControl("mainBtn1")).OnClientClick = overide;
            ((Button)Master.FindControl("mainBtn2")).OnClientClick = overide;
            ((Button)Master.FindControl("mainBtn3")).OnClientClick = overide;
            ((Button)Master.FindControl("settingBtn")).OnClientClick = overide;
            ((Button)Master.FindControl("searchBtn")).OnClientClick += overide;
        }

        //Enable request form sections according to process phase
        protected void SetFormMode()
        {
            Boolean insertMode = Boolean.TryParse(GetSessionVar("insertMode"), out bool result) ? result : false ;
            Int32 currentRole = Int32.TryParse(GetSessionVar("domainRole"), out int role) ? role : 0;

            Int32 lastRole = Int32.TryParse(reqCurRole.Value, out int r) ? r : 0;
            Int32 currentState = Int32.TryParse(reqCurState.Value, out int status) ? status : 1; // <== Minimum [1] - Submitted
            Int32 currentMode = Int32.TryParse(reqCurMode.Value, out int mode) ? mode : 1; // <== Minimum [1] - New
            Int32 extendCount = Int32.TryParse(reqExtCount.Value, out int count) ? count : 0;

            Int32 formId = Int32.TryParse(reqFormId.Value, out int form) ? form : 0;

            FormView fv = mosRequestFV;

            if (insertMode)
            {
                fv.ChangeMode(FormViewMode.Insert);
            }
            else
            {
                String userHub = GetSessionVar("domainHub");
                String reqHub = reqFormHub.Value;

                if (userHub.ToLower() != reqHub.ToLower())
                {
                    fv.ChangeMode(FormViewMode.ReadOnly);
                }
                else
                {
                    //[0-nextRole][1-nextState][2-nextFunction][3-isEditMode][4-isNeedAction][5-nextCount]
                    String[] flowState = new Helper().GetWorkFlowState(formId, currentMode, currentRole, currentState, extendCount);

                    Int32 nextRole = Int32.TryParse(flowState[0], out int rl) ? rl : 0;
                    Int32 nextState = Int32.TryParse(flowState[1], out int st) ? st : 1;
                    Int32 nextFn = Int32.TryParse(flowState[2], out int fn) ? fn : 1;
                    Boolean isEditMode = Boolean.TryParse(flowState[3], out bool ed) ? ed : false;
                    Boolean isNeedAction = Boolean.TryParse(flowState[4], out bool ac) ? ac : false;
                    Int32 nextCount = Int32.TryParse(flowState[5], out int ct) ? ct : 0;

                    //Set Function label datatable
                    DataRow[] functionLabel = function.Select("fnCode = '" + nextFn + "'");
                    DataRow[] titleLabel = title.Select("roleCode = '" + currentRole + "'");

                    reqNextRole.Value = nextRole.ToString();
                    reqExtCount.Value = nextCount.ToString();

                    if (isEditMode)
                    {
                        fv.ChangeMode(FormViewMode.Edit);

                        //Set drop down list selection
                        if (!IsPostBack)
                        {
                            (fv.FindControl("hub") as DropDownList).SelectedValue = reqFormHub.Value;
                            (fv.FindControl("field") as DropDownList).SelectedValue = reqFormField.Value;
                        }

                        //Set Extension display
                        if (extendCount != 0)
                        {
                            (fv.FindControl("mosExtension") as CheckBoxList).Items[0].Selected = (extendCount > 0) ? true : false;
                            (fv.FindControl("mosExtension") as CheckBoxList).Items[1].Selected = (extendCount > 1) ? true : false;
                        }

                        //Set main button function
                        (fv.FindControl("editFn1Btn") as Button).Text = functionLabel[0][0].ToString();
                        fnBtnArgs1.Value = nextState.ToString();

                        //Set reject button
                        (fv.FindControl("editFn2Btn") as Button).Text = "Reject";
                        reqNextRoleAlt.Value = currentRole.ToString();
                        fnBtnArgs2.Value = "10";
                        reqCurModeAlt.Value = "4";

                        //Set remark section title
                        (fv.FindControl("flowTitle") as Label).Text = titleLabel[0][0].ToString();
                        switch (currentRole)
                        {
                            case 1:
                                if (currentMode == 3)
                                {
                                    (fv.FindControl("agrRemarks") as TextBox).Visible = true;
                                }
                                break;
                            case 2:
                                (fv.FindControl("edsRemarks") as TextBox).Visible = true;
                                break;
                            case 3:
                                (fv.FindControl("autRemarks") as TextBox).Visible = true;

                                // OIM specific options
                                (fv.FindControl("activatePanel") as Table).Enabled = true;
                                (fv.FindControl("activateChecklist") as Table).Enabled = true;
                                (fv.FindControl("planStartDateCE") as CalendarExtender).Enabled = true;
                                (fv.FindControl("planEndDateCE") as CalendarExtender).Enabled = true;
                                break;
                            case 4:
                                (fv.FindControl("apvRemarks") as TextBox).Visible = true;
                                break;
                        }
                    }
                    else
                    {
                        fv.ChangeMode(FormViewMode.ReadOnly);

                        //Set Extension display
                        if (extendCount != 0)
                        {
                            (fv.FindControl("mosExtension") as CheckBoxList).Items[0].Selected = (extendCount > 0) ? true : false;
                            (fv.FindControl("mosExtension") as CheckBoxList).Items[1].Selected = (extendCount > 1) ? true : false;
                        }

                        if (isNeedAction)
                        {
                            Button readFn1Btn = fv.FindControl("readFn1Btn") as Button;
                            Button readFn2Btn = fv.FindControl("readFn2Btn") as Button;
                            CheckBox readConfirm1Chk = fv.FindControl("readConfirm1Chk") as CheckBox;
                            CheckBox readConfirm2Chk = fv.FindControl("readConfirm2Chk") as CheckBox;

                            readConfirm1Chk.Visible = true;
                            readConfirm2Chk.Visible = false;

                            //Set main button function
                            readFn1Btn.Visible = true;
                            readFn1Btn.Text = (currentRole == 5 && nextFn == 5 ? "Execute-MOS " : "") + functionLabel[0][0].ToString();
                            fnBtnArgs1.Value = nextState.ToString();

                            //Set reject button function
                            readFn2Btn.Visible = true;
                            readFn2Btn.Text = "Reject";
                            fnBtnArgs2.Value = "10";
                            reqCurModeAlt.Value = "4";

                            //Set DUAL function - when needed
                            if (currentRole == 5)
                            {
                                if (nextFn == 12)
                                {
                                    readFn1Btn.Visible = true;
                                    readFn1Btn.Width = 260;
                                    readFn1Btn.Text = "Execute-MOS Deactivate (EXTEND)";
                                    fnBtnArgs1.Value = "8";
                                    reqNextRole.Value = "1";
                                    reqCurMode.Value = "2";

                                    readFn2Btn.Visible = true;
                                    readFn2Btn.Width = 260;
                                    readFn2Btn.Text = "Execute-MOS Deactivate (COMPLETE)";
                                    fnBtnArgs2.Value = "9";
                                    reqNextRoleAlt.Value = "2";
                                    reqCurModeAlt.Value = "3";

                                    readConfirm1Chk.Visible = true;
                                    readConfirm2Chk.Visible = false;
                                }
                                else
                                {
                                    readFn2Btn.Visible = false;
                                    readConfirm1Chk.Visible = false;
                                    readConfirm2Chk.Visible = true;

                                    if (nextFn == 9)
                                    {
                                        reqCurMode.Value = "3";
                                    }
                                }
                            }
                            if (currentRole == 3 && nextFn == 11)
                            {
                                readFn2Btn.Visible = false;
                                readConfirm1Chk.Visible = false;
                                readConfirm2Chk.Visible = true;
                            }

                            (fv.FindControl("closeBtn") as Button).Visible = false;
                        }

                    }
                }
            }            
        }
                
        protected void MosTagInsert(Int32 formId) // <== REVIEW REQUIRED IN FUTURE!!!
        {            
            SqlConnection sqlConn = null;
            SqlCommand sqlCmd = null;
            String sqlStr = null;

            String tagList = null;
            String[][] tagListArray = new String[][] { };

            FormView fv = mosRequestFV;
            String maxLength = Master.maxText.ToString();
            
            tagList = (fv.FindControl("tagCombo") as HiddenField).Value;

            if (!String.IsNullOrEmpty(tagList))
            {
                try
                {
                    tagListArray = (tagList.IndexOf('|') != -1) ? tagList.Split('|').Select(x => x.Split('^')).ToArray() : new String[1][] { tagList.Split('^').ToArray() };
                    
                    sqlStr = "INSERT INTO form_mos_tag (formId,tagName,manual) VALUES (@formId,LEFT(@tagName,@MaxLength),@manual)";
                    var connStr = ConfigurationManager.ConnectionStrings["dataWriteStr"].ConnectionString;
                    sqlConn = new SqlConnection(connStr);
                    sqlConn.Open();
                    sqlCmd = new SqlCommand(sqlStr, sqlConn);

                    for (int i = 0; i < tagListArray.Length; i++)
                    {
                        try
                        {
                            sqlCmd.Parameters.Clear();
                            sqlCmd.Parameters.AddWithValue("@formId", formId);
                            sqlCmd.Parameters.AddWithValue("@tagName", tagListArray[i][0]);
                            sqlCmd.Parameters.AddWithValue("@MaxLength", maxLength);
                            sqlCmd.Parameters.AddWithValue("@manual", tagListArray[i][1]);
                            sqlCmd.ExecuteNonQuery();

                            Helper.SendLog("New MOS tag list inserted successfully [FormID: " + formId + "][Tag: " + tagListArray[i][0] + " ]", 1, 3102, "A");
                        }
                        catch
                        {
                            Helper.SendLog("Insert new MOS tag list error - unable to insert entry into database [FormID: " + formId + "][Tag: " + tagListArray[i][0] + " ]", 0, 3002, "A");
                        }
                    }
                }
                catch
                {
                    Helper.SendLog("Insert new MOS tag list error - unable to insert entry into database [FormID: " + formId + "][Tags: " + tagList + " ]", 0, 3002, "A");
                }
                finally
                {
                    sqlConn.Close();
                }
            }
        }

        protected void MosTagAdd(object s, EventArgs e) // <== REVIEW REQUIRED IN FUTURE!!!
        {
            SqlConnection sqlConn = null;
            SqlCommand sqlCmd = null;
            String sqlStr = null;

            String tagList = null;
            String[][] tagListArray = new String[][] { };
            Boolean[] tagDuplicate = new Boolean[] { };

            FormView fv = mosRequestFV;
            String formId = reqFormId.Value;
            String uid = HttpContext.Current.User.Identity.Name;
            String maxLength = Master.maxText.ToString();

            tagList = (fv.FindControl("tagCombo") as HiddenField).Value;

            if (!String.IsNullOrEmpty(tagList))
            {
                try
                {
                    tagListArray = (tagList.IndexOf('|') != -1) ? tagList.Split('|').Select(x => x.Split('^')).ToArray() : new String[1][] { tagList.Split('^').ToArray() };
                    tagDuplicate = MosTagCheck(tagListArray, formId);

                    sqlStr = "INSERT INTO form_mos_tag (formId,tagName,manual) VALUES (@formId,LEFT(@tagName,@MaxLength),@manual)";                    
                    var connStr = ConfigurationManager.ConnectionStrings["dataWriteStr"].ConnectionString;
                    sqlConn = new SqlConnection(connStr);
                    sqlConn.Open();
                    sqlCmd = new SqlCommand(sqlStr, sqlConn);

                    for (int x = 0; x < tagDuplicate.Length; x++)
                    {
                        if (!tagDuplicate[x])
                        {
                            try
                            {
                                sqlCmd.Parameters.Clear();
                                sqlCmd.Parameters.AddWithValue("@formId", formId);
                                sqlCmd.Parameters.AddWithValue("@tagName", tagListArray[x][0]);
                                sqlCmd.Parameters.AddWithValue("@MaxLength", maxLength);
                                sqlCmd.Parameters.AddWithValue("@manual", tagListArray[x][1]);
                                sqlCmd.ExecuteNonQuery();

                                Helper.SendLog("MOS tag added successfully [UID: " + uid + "][FormID: " + formId + "][Tag: " + tagListArray[x][0] + "]", 1, 3105, "A");
                            }
                            catch
                            {
                                Helper.SendLog("Add MOS tag error - unable to insert entry into database [UID: " + uid + "][FormID: " + formId + "][Tag: " + tagListArray[x][0] + "]", 0, 3005, "A");
                            }
                        }
                    }
                }
                catch
                {
                    Helper.SendLog("Add MOS tag error - unable to insert entry into database [UID: " + uid + "][FormID: " + formId + "][Tags: " + tagList + "]", 0, 3005, "A");
                }
                finally
                {
                    sqlConn.Close();
                }
            }
            (fv.FindControl("newTag") as TextBox).Text = "";
            (fv.FindControl("mosTagGV") as GridView).DataBind();
        }

        protected bool[] MosTagCheck(String[][] tags, String formId) // <== REVIEW REQUIRED IN FUTURE!!!
        {
            Boolean[] duplicateStatus = new Boolean[tags.Length];
            
            SqlConnection sqlConn = null;
            SqlCommand sqlCmd = null;
            String sqlStr = null;
            Object contentData = null;

            try
            {
                sqlStr = "SELECT status from form_mos_tag WHERE formId=@formId AND tagName=@tagName AND status=@status";
                var connStr = ConfigurationManager.ConnectionStrings["dataReadStr"].ConnectionString;
                sqlConn = new SqlConnection(connStr);
                sqlConn.Open();
                sqlCmd = new SqlCommand(sqlStr, sqlConn);

                for (int i = 0; i < tags.Length; i++)
                {
                    try
                    {
                        sqlCmd.Parameters.Clear();
                        sqlCmd.Parameters.AddWithValue("@formId", formId);
                        sqlCmd.Parameters.AddWithValue("@tagName", tags[i][0]);
                        sqlCmd.Parameters.AddWithValue("@status", true);
                        contentData = sqlCmd.ExecuteScalar();

                        duplicateStatus[i] = Boolean.TryParse(contentData.ToString(), out bool state) ? state : false;
                    }
                    catch
                    {
                        duplicateStatus[i] = false;
                    }
                }
            }
            catch { }
            finally
            {
                sqlConn.Close();
            }

            return duplicateStatus;
        }

        protected void MosTagDeleted(object s, GridViewDeletedEventArgs e)
        {
            String tag = null;
            String formId = reqFormId.Value;
            String uid = HttpContext.Current.User.Identity.Name;

            tag = e.Values[0].ToString();
            
            if (e.Exception == null)
            {
                Helper.SendLog("MOS tag deleted successfully [UID: " + uid + "][FormID: " + formId + "][Tag: " + tag + "]", 1, 3106, "A");
            }
            else 
            {
                Helper.SendLog("Delete MOS tag error - unable to remove entry from database  [UID: " + uid + "][FormID: " + formId + "][Tag: " + tag + "]", 0, 3006, "A");
                e.ExceptionHandled = true;
            }
        }

        protected void MosTagUpdate(object s, EventArgs e)
        {
            String sqlStr = null;
            Boolean result = false;

            FormView fv = mosRequestFV;
            GridView tagGv = (fv.FindControl("mosTagGV") as GridView);

            String formId = reqFormId.Value;
            String uid = HttpContext.Current.User.Identity.Name;

            String ori = null;
            String name = null;
            String id = null;

            sqlStr = "UPDATE form_mos_tag SET tagName=@tagName WHERE tagId=@tagId;";
            foreach (GridViewRow rw in tagGv.Rows)
            {
                name = (rw.FindControl("tagName") as TextBox).Text;
                ori = rw.Cells[0].Text;// (rw.FindControl("tagNameHid") as HiddenField).Value;
                id = rw.Cells[1].Text;// (rw.FindControl("tagIdHid") as HiddenField).Value;

                if (name != ori)
                {
                    result = new Helper().UpdateDatabase(sqlStr, new string[] { "tagId", "tagName" }, new String[] { id, name.ToUpper() });

                    if (result)
                    {
                        Helper.SendLog("MOS tag list updated successfully [UID: " + uid + "][FormID: " + formId + "]", 1, 3104, "A");
                    }
                    else
                    {
                        Helper.SendLog("Update MOS tag list error - unable to save changes into database [UID: " + uid + "][FormID: " + formId + "]", 0, 3004, "A");
                    }
                }
            }
        }

        protected void UpdateSelection(object s, EventArgs e)
        {
            Boolean insertMode = (mosRequestFV.CurrentMode == FormViewMode.Insert) ? true : false;
            Boolean editMode = (mosRequestFV.CurrentMode == FormViewMode.Edit) ? true : false;
            Boolean readMode = (mosRequestFV.CurrentMode == FormViewMode.ReadOnly) ? true : false;
            String fnSet = fnBtnArgs3.Value;

            if (!String.IsNullOrEmpty(fnSet))
            {
                switch (fnSet)
                {
                    case "1":
                        if (insertMode) { CreateNew(s, e); }
                        if (editMode) { FlowUpdate(s, e); }
                        if (readMode) { StatusUpdate(s, e); }
                        break;
                    case "2":
                        if (editMode || readMode) { StatusUpdate(s, e); }                        
                        break;
                }
            }
        }

        // ============================================= //

        private void CreateNew(object s, EventArgs e)
        {
            Helper helper = new Helper();

            String[] paraCol = new String[] { };
            String[] value = new String[] { };
            String passcode = null;
            Int32 newRecordId = 0;

            String sqlStr = null;
            Boolean result = false;

            FormView fv = mosRequestFV;
            String ptw = (fv.FindControl("newPtwId") as TextBox).Text;
            String hub = (fv.FindControl("newHubList") as DropDownList).SelectedValue;

            // Get latest MOS ID by Hub
            sqlStr = "INSERT INTO iden_hub_" + hub.ToLower() + " (creationTime) VALUES (@creationTime)";
            paraCol = new String[] { "creationTime" };
            value = new String[] { DateTime.Now.ToString() };
            Int32 mosId = helper.UpdateDatabase(sqlStr,paraCol,value,true);

            if (mosId > 0)
            {
                Boolean longTerm = Boolean.TryParse((fv.FindControl("newLongTerm") as RadioButtonList).SelectedValue, out Boolean type) ? type : false;
                String moc = longTerm ? (fv.FindControl("newMocId") as TextBox).Text : "";

                sqlStr = "INSERT INTO form_mos (mosId,hub,field,ptwId,mocId,longTerm,processSystem,controlSystem,isolateFunction,isolateMethod,isolatePurpose,isolateEffect,altSafetySystem,riskRemarks,riskRating,mitigateMethod,verifyCode,reqId,reqTimestamp) VALUES (@mosId,@hub,@field,@ptwId,@mocId,@longTerm,LEFT(@processSystem,@MaxLength),LEFT(@controlSystem,@MaxLength),LEFT(@isolateFunction,@MaxLength),LEFT(@isolateMethod,@MaxLength),LEFT(@isolatePurpose,@MaxLength),LEFT(@isolateEffect,@MaxLength),LEFT(@altSafetySystem,@MaxLength),@riskRemarks,@riskRating,@mitigateMethod,@verifyCode,@reqId,@reqTimestamp)";
                passcode = new Crypter().GenerateCode(1, 12);
                paraCol = new String[] { "mosId", "hub", "field", "ptwId", "mocId", "longTerm", "processSystem", "controlSystem", "isolateFunction", "isolateMethod", "isolatePurpose", "isolateEffect", "altSafetySystem", "riskRemarks", "riskRating", "mitigateMethod", "verifyCode", "reqId", "reqTimestamp", "MaxLength" };
                value = new String[] { mosId.ToString(), hub, (fv.FindControl("newFieldList") as DropDownList).SelectedValue, ptw, moc, longTerm.ToString(), (fv.FindControl("newProcessSystem") as TextBox).Text, (fv.FindControl("newControlSystem") as TextBox).Text, (fv.FindControl("newIsolateFunction") as TextBox).Text, (fv.FindControl("newIsolateMethod") as TextBox).Text, (fv.FindControl("newIsolatePurpose") as TextBox).Text, (fv.FindControl("newIsolateEffect") as TextBox).Text, (fv.FindControl("newAltSafetySystem") as TextBox).Text, (fv.FindControl("newRiskRemarks") as TextBox).Text, (fv.FindControl("newRiskRating") as TextBox).Text, (fv.FindControl("newMitigateMethod") as TextBox).Text, passcode, HttpContext.Current.User.Identity.Name, DateTime.Now.ToString(), Master.maxText.ToString() }; //Page.User.Identity.Name

                newRecordId = helper.UpdateDatabase(sqlStr, paraCol, value, true);
                result = (newRecordId != 0) ? true : false;

                if (result)
                {
                    Helper.SendLog("New MOS request created successfully [FormID: " + newRecordId + "]", 1, 3101, "A");
                    MosTagInsert(newRecordId);
                }
                else
                {
                    Helper.SendLog("Insert new MOS request error - unable to insert entry into database [PTW: " + ptw + "]", 0, 3001, "A");
                }

                Response.Redirect("manage.aspx");
            }
            else
            {
                Helper.SendLog("Insert new MOS request error - unable to generate a valid MOS ID [PTW: " + ptw + "]", 0, 3001, "A");
            }
        }
        
        private void FlowUpdate(object s, EventArgs e)
        {
            String sqlStr = null;
            Boolean result = false;
            
            String[] colBase = new String[] { };
            String[] colAddOn = new String[] { };
            String[] colCombo = new String[] { };
            String[] valUpdate = new String[] { };
            String[] valAddOn = new String[] { };
            String[] valCombo = new String[] { };
            String[] valOrigin = new String[] { };

            String activationStart = "";
            String activationEnd = "";
            Int32 extendCount = 0;

            FormView fv = mosRequestFV;

            String formId = reqFormId.Value;
            String uid = HttpContext.Current.User.Identity.Name;
            Int32 curUserRole = Int32.TryParse(GetSessionVar("domainRole"), out int role) ? role : 0;
            Int32 currentState = Int32.TryParse(reqCurState.Value, out int status) ? status : 1;
            Boolean longTerm = Boolean.TryParse((fv.FindControl("longTerm") as RadioButtonList).SelectedValue, out Boolean type) ? type : false;
            String moc = longTerm ? (fv.FindControl("mocId") as TextBox).Text : "";

            String agrRmkField = (fv.FindControl("agrRemarksHid") as HiddenField).Value;
            String edsRmkField = (fv.FindControl("edsRemarksHid") as HiddenField).Value;
            String autRmkField = (fv.FindControl("autRemarksHid") as HiddenField).Value;
            String apvRmkField = (fv.FindControl("apvRemarksHid") as HiddenField).Value;

            switch (curUserRole)
            {
                case 1:
                    agrRmkField = Server.HtmlEncode((fv.FindControl("agrRemarks") as TextBox).Text);
                    break;
                case 2:
                    edsRmkField = Server.HtmlEncode((fv.FindControl("edsRemarks") as TextBox).Text);
                    break;
                case 3:
                    autRmkField = Server.HtmlEncode((fv.FindControl("autRemarks") as TextBox).Text);                    
                    activationStart = (fv.FindControl("planStartDate") as TextBox).Text + " " + (fv.FindControl("planStartTime") as DropDownList).SelectedValue + " " + (fv.FindControl("planStartTimeInd") as DropDownList).SelectedValue;
                    activationEnd = (fv.FindControl("planEndDate") as TextBox).Text + " " + (fv.FindControl("planEndTime") as DropDownList).SelectedValue + " " + (fv.FindControl("planEndTimeInd") as DropDownList).SelectedValue;
                    extendCount = Int32.TryParse(reqExtCount.Value, out int cnt) ? cnt : 0; 
                    break;
                case 4:
                    apvRmkField = Server.HtmlEncode((fv.FindControl("apvRemarks") as TextBox).Text);
                    break;
            }

            sqlStr = "UPDATE form_mos SET hub=@hub,field=@field,ptwId=@ptwId,mocId=@mocId,longTerm=@longTerm,processSystem=LEFT(@processSystem,@MaxLength),controlSystem=LEFT(@controlSystem,@MaxLength),isolateFunction=LEFT(@isolateFunction,@MaxLength),isolateMethod=LEFT(@isolateMethod,@MaxLength),isolatePurpose=LEFT(@isolatePurpose,@MaxLength),isolateEffect=LEFT(@isolateEffect,@MaxLength),altSafetySystem=LEFT(@altSafetySystem,@MaxLength),riskRemarks=@riskRemarks,riskRating=@riskRating,mitigateMethod=@mitigateMethod,agrRemarks=@agrRemarks,edsRemarks=@edsRemarks,autRemarks=@autRemarks,apvRemarks=@apvRemarks WHERE formId=@formId";

            colBase = new String[] { "hub", "field", "ptwId", "mocId", "longTerm", "processSystem", "controlSystem", "isolateFunction", "isolateMethod", "isolatePurpose", "isolateEffect", "altSafetySystem", "riskRemarks", "riskRating", "mitigateMethod" };
            valUpdate = new String[] { (fv.FindControl("hub") as DropDownList).SelectedValue, (fv.FindControl("field") as DropDownList).SelectedValue, (fv.FindControl("ptwId") as TextBox).Text, moc, longTerm.ToString(), (fv.FindControl("processSystem") as TextBox).Text, (fv.FindControl("controlSystem") as TextBox).Text, (fv.FindControl("isolateFunction") as TextBox).Text, (fv.FindControl("isolateMethod") as TextBox).Text, (fv.FindControl("isolatePurpose") as TextBox).Text, (fv.FindControl("isolateEffect") as TextBox).Text, (fv.FindControl("altSafetySystem") as TextBox).Text, (fv.FindControl("riskRemarks") as TextBox).Text, (fv.FindControl("riskRating") as TextBox).Text, (fv.FindControl("mitigateMethod") as TextBox).Text };
            valOrigin = new String[] { (fv.FindControl("hubHid") as HiddenField).Value, (fv.FindControl("fieldHid") as HiddenField).Value, (fv.FindControl("ptwIdHid") as HiddenField).Value, (fv.FindControl("mocIdHid") as HiddenField).Value, (fv.FindControl("longTermHid") as HiddenField).Value, (fv.FindControl("processSystemHid") as HiddenField).Value, (fv.FindControl("controlSystemHid") as HiddenField).Value, (fv.FindControl("isolateFunctionHid") as HiddenField).Value, (fv.FindControl("isolateMethodHid") as HiddenField).Value, (fv.FindControl("isolatePurposeHid") as HiddenField).Value, (fv.FindControl("isolateEffectHid") as HiddenField).Value, (fv.FindControl("altSafetySystemHid") as HiddenField).Value, (fv.FindControl("riskRemarksHid") as HiddenField).Value, (fv.FindControl("riskRatingHid") as HiddenField).Value, (fv.FindControl("mitigateMethodHid") as HiddenField).Value };

            colAddOn = new String[] { "agrRemarks", "edsRemarks", "autRemarks", "apvRemarks", "MaxLength", "formId" };
            valAddOn = new String[] { agrRmkField, edsRmkField, autRmkField, apvRmkField, Master.maxText.ToString(), formId };
            
            colCombo = colBase.Concat(colAddOn).ToArray();
            valCombo = valUpdate.Concat(valAddOn).ToArray();
            
            //Update main request into database
            result = new Helper().UpdateDatabase(sqlStr, colCombo, valCombo);

            //Update MOS Activation Date/Time into database - OIM ONLY ACCESS!
            if (curUserRole == 3)
            {
                TimeUpdate(uid, formId, activationStart, activationEnd, extendCount);
                ChecklistUpdate(uid, formId);
            }

            if (result)
                {
                Helper.SendLog("MOS request updated successfully [UID: " + uid + "][FormID: " + formId + "]", 1, 3103, "A"); 

                MosTagUpdate(s, e);
                ChangeLog(colBase, valOrigin, valUpdate, formId, uid, curUserRole);
                StatusUpdate(s, e);

                

            }
            else
            {
                Helper.SendLog("Update MOS request error - unable to save changes into database [UID: " + uid + "][FormID: " + formId + "]", 0, 3003, "A"); 
            }

            Response.Redirect("manage.aspx");
        }

        private void StatusUpdate(object s, EventArgs e)
        {
            String sqlStr = null;
            Boolean result = false;
            Int32 role = 0;
            Int32 status = 0;
            Int32 mode = 0;
            Int32 count = 0;

            String formId = reqFormId.Value;
            String fnSet = fnBtnArgs3.Value;
            String uid = HttpContext.Current.User.Identity.Name;
            
            
            status = (fnSet == "1") ? (Int32.TryParse(fnBtnArgs1.Value, out int arg1) ? arg1 : 1) : (Int32.TryParse(fnBtnArgs2.Value, out int arg2) ? arg2 : 1);
            role = (fnSet == "1") ? (Int32.TryParse(reqNextRole.Value, out int rl1) ? rl1 : 0) : (Int32.TryParse(reqNextRoleAlt.Value, out int rl2) ? rl2 : 0);
            
            mode = (fnSet == "1") ? (Int32.TryParse(reqCurMode.Value, out int md1) ? md1 : 1) : (Int32.TryParse(reqCurModeAlt.Value, out int md2) ? md2 : 1);
            count = Int32.TryParse(reqExtCount.Value, out int ct) ? ct : 0;

            //Update workflow status into database
            sqlStr = "UPDATE form_mos SET nextRole=@nextRole,curState=@curState,curMode=@curMode,extCount=@extCount WHERE formId=@formId AND reqStatus=1";
            result = new Helper().UpdateDatabase(sqlStr, new String[] { "formId", "nextRole", "curState", "curMode", "extCount" }, new String[] { formId, role.ToString(), status.ToString(), mode.ToString(), count.ToString() });
           
            if (result)
            {
                AuditTrails(uid,formId,role,status);
                Helper.SendLog("MOS request progress status updated successfully [UID: " + uid + "][FormID: " + formId + "][State: " + status + "][Mode: " + mode + "][Ext: " + count + "]", 1, 4101, "A");
                 
            }
            else
            {
                Helper.SendLog("Update MOS request progress status error - unable to save changes into database [UID: " + uid + "][FormID: " + formId + "][State: " + status + "][Mode: " + mode + "][Ext: " + count + "]", 0, 4001, "A");
            }

            Response.Redirect("manage.aspx");
        }
        private void AuditTrails(String uid, String formId, Int32 curRole, Int32 curState)
        {
            //BigInteger formID = BigInteger.Parse(formId);
            SqlCommand sqlCmd = null;
            SqlConnection sqlConn = null;
            string result= null; 
            try
            {
                var connStr = ConfigurationManager.ConnectionStrings["dataWriteStr"].ConnectionString;
                String sqlStr ="sp_insert_audit_trails";
                sqlConn = new SqlConnection(connStr);
                sqlCmd = new SqlCommand(sqlStr, sqlConn);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.Clear();
                sqlCmd.Parameters.AddWithValue("@updatedBy", SqlDbType.NVarChar).Value = uid;
                sqlCmd.Parameters.AddWithValue("@formId", SqlDbType.BigInt).Value = formId;
                sqlCmd.Parameters.AddWithValue("@curRole", SqlDbType.Int).Value = curRole;
                sqlCmd.Parameters.AddWithValue("@curState", SqlDbType.Int).Value = curState;
                sqlConn.Open();
               result=  sqlCmd.ExecuteNonQuery().ToString();
              

            }
            catch (Exception ex)
            {
                Helper.SendLog("MOS Audit Trails [UID: " + uid + "][FormID: " + formId + "][State: " + curRole + "][Mode: " + curState + "] " + ex, 1, 4101, "A");

            }

            finally
            {
                sqlConn.Close();
               
            }



        }
        private void TimeUpdate(String uid, String formId, String planStart, String planEnd, Int32 extCount)
        {
            String sqlStr = null;
            Boolean result = false;
            String exist = "";

            //Validate if entry is already inserted
            sqlStr = "SELECT extId FROM form_mos_ext WHERE formId=@formId AND extCount=@extCount";
            exist = new Helper().SearchDatabase(sqlStr, new String[] { "formId", "extCount" }, new String[] { formId, extCount.ToString() });

            if (String.IsNullOrEmpty(exist))
            {
                sqlStr = "INSERT INTO form_mos_ext (formId,planStart,planEnd,extCount) VALUES (@formId,@planStart,@planEnd,@extCount);";
            }
            else
            {
                sqlStr = "UPDATE form_mos_ext SET planStart=@planStart,planEnd=@planEnd WHERE formId=@formId AND extCount=@extCount";
            }

            //Update new activation time into database
            result = new Helper().UpdateDatabase(sqlStr, new string[] { "formId", "planStart", "planEnd", "extCount" }, new String[] { formId, planStart, planEnd, extCount.ToString() });

            if (result)
            {
                Helper.SendLog("MOS activation date updated successfully [UID: " + uid + "][FormID: " + formId + "][Ext: " + extCount.ToString() + "]", 1, 3108, "A");
            }
            else
            {
                Helper.SendLog("Update MOS activation date error - unable to save changes into database [UID: " + uid + "][FormID: " + formId + "][Ext: " + extCount.ToString() + "]", 0, 3008, "A");
            }
        }

        private void ChecklistUpdate(String uid, String formId)
        {
            String sqlStr = null;
            Boolean result = false;

            String[] colBase = new String[] { };
            String[] valUpdate = new String[] { };

            FormView fv = mosRequestFV;

            //Update checklist status into database
            sqlStr = "UPDATE form_mos SET allTagIdentify=@allTagIdentify,allKeyNotify=@allKeyNotify,logBookEntry=@logBookEntry,isolateCertDisplay=@isolateCertDisplay WHERE formId=@formId";

            colBase = new String[] { "allTagIdentify", "allKeyNotify", "logBookEntry", "isolateCertDisplay", "formId" };
            valUpdate = new String[] { (fv.FindControl("allTagIdentify") as CheckBox).Checked.ToString(), (fv.FindControl("allKeyNotify") as CheckBox).Checked.ToString(), (fv.FindControl("logBookEntry") as CheckBox).Checked.ToString(), (fv.FindControl("isolateCertDisplay") as CheckBox).Checked.ToString(), formId };

            //Update checklist status into database
            result = new Helper().UpdateDatabase(sqlStr, colBase, valUpdate);

            if (result)
            {
                Helper.SendLog("MOS activation checklist updated successfully [UID: " + uid + "][FormID: " + formId + "]", 1, 3109, "A");
            }
            else
            {
                Helper.SendLog("Update MOS activation checklist error - unable to save checklist status into database [UID: " + uid + "][FormID: " + formId + "]", 0, 3009, "A");
            }
        }
        
        private void ChangeLog(String[] field, String[] origin, String[] entry, String formId, String uid, Int32 curUserRole)
        {   
            String sqlStr = null;
            Boolean result = false;

            String[][] chgArray = new String[][] { };

            String chgComboStr = "";
            String exist = "";

            String oriTime = reqTime.Value;
            String oriUser = reqId.Value;
            String curTime = DateTime.Now.ToString();
            String curUser = String.IsNullOrEmpty(HttpContext.Current.User.Identity.Name) ? "Guest" : HttpContext.Current.User.Identity.Name;

            //Detect and compile change value strings
            sqlStr = "SELECT rec FROM form_mos_chg WHERE formId=@formId AND field=@field AND role=1";

            for (int x = 0; x < origin.Length; x++)
            {
                if (entry[x].ToLower() != origin[x].ToLower())
                {
                    //Validate if origin entry is logged
                    exist = new Helper().SearchDatabase(sqlStr, new String[] { "formId", "field" }, new String[] { formId, field[x] });

                    if (String.IsNullOrEmpty(exist) || exist == "error")
                    {
                        chgComboStr += formId + ";" + "1" + ";" + oriUser + ";" + oriTime + ";" + field[x] + ";" + origin[x] + "|";
                    }

                    //Change String - [formId][role][uid][timestamp][field][value]
                    chgComboStr += formId + ";" + curUserRole + ";" + curUser + ";" + curTime + ";" + field[x] + ";" + entry[x] + "|";
                }
            }

            //Prepare combo string and insert change log
            sqlStr = "INSERT INTO form_mos_chg (formId,role,uid,timestamp,field,value) VALUES (@formId,@role,@uid,@timestamp,@field,@value)";

            if (!String.IsNullOrEmpty(chgComboStr))
            {
                chgComboStr = chgComboStr.Substring(0, chgComboStr.Length - 1);
                chgArray = chgComboStr.IndexOf('|') != -1 ? chgComboStr.Split('|').Select(x => x.Split(';')).ToArray() : new String[1][] { chgComboStr.Split(';').ToArray() };
                
                //Update new changes into log
                result = new Helper().UpdateDatabase(sqlStr, new string[] { "formId", "role", "uid", "timestamp", "field", "value" }, chgArray);

                if (result)
                {
                    Helper.SendLog("MOS request data revision logged successfully [UID: " + uid + "][FormID: " + formId + "]", 1, 3107, "A"); 
                }
                else
                {
                    Helper.SendLog("Log MOS request data revision error - unable to insert entry into database [UID: " + uid + "][FormID: " + formId + "]", 0, 3007, "A"); 
                }
            }
        }

    }
}