using System;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eSSIC
{
    public partial class Monitor : BasePage
    {
        protected void Page_Load(object s, EventArgs e)
        {
            Page.Title = Master.appNameTitle + "Monitor";
            ((Button)Master.FindControl("mainBtn3")).CssClass = "mainNavBarMenuBtnActive";

            if (!IsPostBack)
            {
                Task.Run(() => StartMosThread());
                updateTime.Text = DateTime.Now.ToString("dd-MMM-yyyy hh:mm:ss tt");
                SetHiddenFields(s, e);

                ScriptManager.RegisterStartupScript(Page, GetType(), "InitiateMosCheck", "mosOverrideCheck();", true);
                ScriptManager.RegisterStartupScript(Page, GetType(), "AutoRefreshTable", "autoRefreshTable();", true);
            }
        }

        private void StartMosThread()
        {
            if (Global.mosWorker.IsBusy != true)
            {
                Global.mosWorker.RunWorkerAsync();
            }
        }
                
        protected void SetHiddenFields(object s, EventArgs e)
        {
            using (DataView dv = (DataView)mosTagsDS.Select(DataSourceSelectArguments.Empty))
            {
                totalRows.Value = dv.Count > 0 ? dv[0].Row["cnt"].ToString() : "0";
            }
        }

        protected void SetTagTable(object s, GridViewRowEventArgs e)
        {
            String tagListStr;
            String[][] tagArray;

            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                tagListStr = (e.Row.FindControl("tagList") as HiddenField).Value;

                if (!String.IsNullOrEmpty(tagListStr))
                {
                    tagArray = (tagListStr.IndexOf('|') != -1) ? tagListStr.Split('|').Select(x => x.Split('^')).ToArray() : new String[1][] { tagListStr.Split('^').ToArray() };

                    Table table = (e.Row.FindControl("tagTable") as Table);

                    for (int x = 0; x < tagArray.Length; x++)
                    {
                        TableRow row = new TableRow();
                        TableCell leftCell = new TableCell();
                        TableCell rightCell = new TableCell();
                        Label holder = new Label();

                        holder.Text = tagArray[x][1] == "0" ? "blur_on" : "help";
                        holder.CssClass = "material-icons statusIndIconDisable mosTagRowIcon";

                        leftCell.Controls.Add(holder);

                        leftCell.CssClass = "mosTagRowLeft";
                        rightCell.CssClass = "mosTagRowRight";
                        rightCell.Wrap = false;
                        rightCell.Text = tagArray[x][0];

                        row.Cells.Add(leftCell);
                        row.Cells.Add(rightCell);
                        table.Rows.Add(row);
                    }
                }              
            }
        }

        protected void RefreshTagStatus(object s, EventArgs e)
        {
            if (IsPostBack)
            {
                using (DataView dv = (DataView)activeMosDS.Select(DataSourceSelectArguments.Empty))
                {
                    filterRows.Value = dv is null ? "0" : dv.Count.ToString();
                }
                ScriptManager.RegisterStartupScript(Page, GetType(), "RefreshMosTable", "mosTableRefresh();", true);
            }            
        }

        protected void RefreshTagTable(object s, EventArgs e)
        {
            //For override tags
            StartMosThread();

            //For request view
            activeMosGV.DataBind();

            //For non-authorized view
            mosTagsDS.DataBind();

            showHub.SelectedIndex = 0;
            ((TextBox)Master.FindControl("search")).Text = "";

            ScriptManager.RegisterStartupScript(Page, GetType(), "RefreshMosCheck", "mosOverrideCheck();", true);
        }

    }
}