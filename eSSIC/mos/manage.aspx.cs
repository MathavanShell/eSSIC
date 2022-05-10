using System;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eSSIC.MOS
{
    public partial class Manage : BasePage
    {
        protected void Page_Load(object s, EventArgs e)
        {
            Page.Title = Master.appNameTitle + "Manage";
            ((Button)Master.FindControl("mainBtn2")).CssClass = "mainNavBarMenuBtnActive";

            if (!IsPostBack)
            {
                SetHiddenFields(s, e);
            }

            SearchRefresh(s, e);
            SetStatistic(s, e);
        }

        //Set hidden fields values
        protected void SetHiddenFields(object s, EventArgs e)
        {
            Int32 role = Int32.TryParse(GetSessionVar("domainRole"), out int r) ? r : 0;
            String hub = GetSessionVar("domainHub");

            userRole.Value = role.ToString();
            userHub.Value = hub.ToString();
            newMosRequest.Enabled = (role == 1) ? true : false; // ONLY OT-[Role=1] can submit request
        }

        //Set Count displays
        protected void SetStatistic(object s, EventArgs e)
        {
            using (DataView dv = (DataView)mosPassDS.Select(DataSourceSelectArguments.Empty))
            {
                mosPassCnt.Text = "[" + (dv is null ? "0" : dv.Count.ToString()) + "]";
            }
            using (DataView dv = (DataView)mosArchiveDS.Select(DataSourceSelectArguments.Empty))
            {
                mosArchiveCnt.Text = "[" + (dv is null ? "0" : dv.Count.ToString()) + "]";
            }
        }

        //Refresh table on search
        protected void SearchRefresh(object s, EventArgs e)
        {
            mosPendingGV.DataSourceID = "mosPendingDS";
            mosProgressGV.DataSourceID = "mosPassDS";
            mosArchiveGV.DataSourceID = "mosArchiveDS";
        }

        //Set table page sizeuserRole
        protected void SetPagerSize(object s, EventArgs e)
        {
            Int32 target = Convert.ToInt32(((DropDownList)s).AccessKey);

            switch (target)
            {
                case 1:
                    mosPendingGV.PageSize = Convert.ToInt32(((DropDownList)s).SelectedValue);
                    break;
                case 2:
                    mosProgressGV.PageSize = Convert.ToInt32(((DropDownList)s).SelectedValue);
                    break;
                case 3:
                    mosArchiveGV.PageSize = Convert.ToInt32(((DropDownList)s).SelectedValue);
                    break;
            }            
        }

        //Refresh table data
        protected void RefreshTable(object s, EventArgs e)
        {
            Int32 target = Convert.ToInt32(((LinkButton)s).CommandArgument);

            switch (target)
            {
                case 1:
                    mosPendingGV.DataBind();
                    break;
                case 2:
                    mosProgressGV.DataBind();
                    break;
            }
        }
                        
    }
}