using System;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eSSIC
{
    public partial class Default : BasePage
    {
        protected void Page_Load(object s, EventArgs e)
        {
            Page.Title = Master.appNameTitle + "Dashboard";
            ((Button)Master.FindControl("mainBtn1")).CssClass = "mainNavBarMenuBtnActive";
            
            if (!IsPostBack)
            {
                updateTime.Text = DateTime.Now.ToString("dd-MMM-yyyy hh:mm:ss tt");
                ScriptManager.RegisterStartupScript(Page, GetType(), "AutoRefreshTable", "autoRefreshTable();", true);
            }

            SetStatistic(s, e);
        }

        //Set Count displays
        protected void SetStatistic(object s, EventArgs e)
        {
            DataTable hubStatistic = new DataTable();
            hubStatistic.Columns.AddRange(new DataColumn[9] { new DataColumn("hub"), new DataColumn("total"), new DataColumn("submitted"), new DataColumn("endorsed"), new DataColumn("authorized"), new DataColumn("approved"), new DataColumn("executed"), new DataColumn("closed"), new DataColumn("rejected") });

            using (DataView dv = (DataView)hubListDS.Select(DataSourceSelectArguments.Empty))
            {
                int i = 0;
                foreach (DataRowView drv in dv)
                {
                    hubStatistic.Rows.Add();
                    i = hubStatistic.Rows.Count - 1;
                    hubStatistic.Rows[i][0] = drv["hubCode"].ToString().Trim();
                }               
            }

            //[0-hub][1-Total][2-Submitted][3-Endorsed][4-Authorized][5-Approved][6-Executed][7-Closed][8-Rejected]
            using (DataView dv = (DataView)todayMosDS.Select(DataSourceSelectArguments.Empty))
            {
                for (int i = 0; i < hubStatistic.Rows.Count; i++)
                {
                    var hubCode = hubStatistic.Rows[i][0].ToString();

                    dv.RowFilter = "hub='" + hubCode + "'";
                    hubStatistic.Rows[i][1] = (dv is null) ? "0" : dv.Count.ToString();

                    dv.RowFilter = "curState=1 AND hub='" + hubCode + "'";
                    hubStatistic.Rows[i][2] = (dv is null) ? "0" : dv.Count.ToString();

                    dv.RowFilter = "curState=2 AND hub='" + hubCode + "'";
                    hubStatistic.Rows[i][3] = (dv is null) ? "0" : dv.Count.ToString();

                    dv.RowFilter = "curState=3 AND hub='" + hubCode + "'";
                    hubStatistic.Rows[i][4] = (dv is null) ? "0" : dv.Count.ToString();

                    dv.RowFilter = "curState=4 AND hub='" + hubCode + "'";
                    hubStatistic.Rows[i][5] = (dv is null) ? "0" : dv.Count.ToString();
                    
                    dv.RowFilter = "curState=5 AND hub='" + hubCode + "'";
                    hubStatistic.Rows[i][6] = (dv is null) ? "0" : dv.Count.ToString();

                    dv.RowFilter = "curState=11 AND hub='" + hubCode + "'";
                    hubStatistic.Rows[i][7] = (dv is null) ? "0" : dv.Count.ToString();

                    dv.RowFilter = "curState=10 AND hub='" + hubCode + "'";
                    hubStatistic.Rows[i][8] = (dv is null) ? "0" : dv.Count.ToString();

                    dv.RowFilter = null;
                }

                //DataView dvSort = new DataView(hubStatistic);
                //dvSort.Sort = "total DESC";

                todayGV.DataSource = hubStatistic;
                todayGV.DataBind();
            }
        }
        
        //Set table page sizeuserRole
        protected void SetPagerSize(object s, EventArgs e)
        {
            mosGV.PageSize = Convert.ToInt32(((DropDownList)s).SelectedValue);
        }

        protected void RefreshTable(object s, EventArgs e)
        {
            mosDS.DataBind();
            mosGV.DataBind();
            updateTime.Text = DateTime.Now.ToString("dd-MMM-yyyy hh:mm:ss tt");
        }

    }
}