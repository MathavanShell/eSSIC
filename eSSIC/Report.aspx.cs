using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using ClosedXML.Excel;
using System.Web.UI.WebControls;

namespace eSSIC
{
    public partial class Report : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = Master.appNameTitle + "Monitor";
            ((Button)Master.FindControl("mainBtn5")).CssClass = "mainNavBarMenuBtnActive";
            if (!IsPostBack)
            {
                Task.Run(() => StartMosThread());


            }
        }

        private void StartMosThread()
        {
            if (Global.mosWorker.IsBusy != true)
            {
                Global.mosWorker.RunWorkerAsync();
            }
        }

        protected void SetColumnView(object s, EventArgs e)
        {
            reportGV.Visible = true;
            landing.Visible = true;

            //String selection = formSelect.SelectedValue;
            Int32[] hide = new Int32[] { 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            Int32[] show = new Int32[] { };

            //Enable filters
            if (!dataFilter.Enabled)
            {
                dataFilter.Enabled = true;
                dateFilter.Enabled = true;
                searchStartDateCE.Enabled = true;
                searchEndDateCE.Enabled = true;
            }

        }
        protected void GetRecordCount(object s, EventArgs e)
        {
            landing.Visible = false;
            using (DataView dv = (DataView)reportDS.Select(DataSourceSelectArguments.Empty))
            {
                DataTable dt = dv.ToTable();

                if (dt != null)
                {
                    DataView revDv = dt.AsDataView();
                    reportGV.Visible = true;

                    //reportGV.DataSource = revDv;
                    reportGV.DataBind();
                    resetBtn.Enabled = true;
                    exportBtn.Enabled = true;
                    

                }


            }
        }

        protected void ResetField(object s, EventArgs e)
        {
            //Text field
            ((TextBox)Master.FindControl("search")).Text = "";
            ((TextBox)Master.FindControl("mobileSearch")).Text = "";
            searchStartDate.Text = "";
            searchEndDate.Text = "";
            mocId.Text = "";
            tagsId.Text = "";
            mosreqidtxt.Text = "";
            //termididtxt.Text = "";

            //Drop List
            //fieldList.SelectedIndex = 0;
            hubList.SelectedIndex = 0;
            ptwlist.SelectedIndex = 0;
            reqList.SelectedIndex = 0;
            statusList.SelectedIndex = 0;
            termList.SelectedIndex = 0;
            //formSelect.ClearSelection();

            //Table
            reportGV.PageIndex = 0;
            reportGV.PageSize = 10;
            reportGV.Sort("", SortDirection.Ascending);
            SetColumnView(s, e);

            //Disable filterOptions
            //dataFilter.Enabled = false;
            //dateFilter.Enabled = false;
            //searchStartDateCE.Enabled = false;
            //searchEndDateCE.Enabled = false;

            reportGV.Visible = false;
            resetBtn.Enabled = false;
            exportBtn.Enabled = false;
            landing.Visible = true;
        }


        public override void VerifyRenderingInServerForm(Control control)
        {

            return;
        }
        protected void BtnExport_Click(object s, EventArgs e)
        {
            ExportGridToExcel();
        }
        public void ExportGridToExcel()
        {
            
            
            DataTable dt = new DataTable("Report");
            try
            {
                reportGV.AllowPaging = false;
                reportGV.DataBind();

                foreach (System.Web.UI.WebControls.TableCell cell in reportGV.HeaderRow.Cells)
                {
                    dt.Columns.Add(cell.Text);
                }
                foreach (GridViewRow row in reportGV.Rows)
                {
                    dt.Rows.Add();
                    for (int j = 0; j < row.Cells.Count; j++)
                    {
                        if (row.Cells[j].Text.Equals(null) || row.Cells[j].Text == "&nbsp;")
                        {
                            dt.Rows[dt.Rows.Count - 1][j] = "";


                        }
                        else
                        {

                            dt.Rows[dt.Rows.Count - 1][j] = row.Cells[j].Text;
                        }

                    }
                }
                using (XLWorkbook wb = new XLWorkbook())
                {


                    wb.Worksheets.Add(dt);
                    Response.Clear();
                    Response.Buffer = true;
                    Response.Charset = "";
                    Response.ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                    Response.AddHeader("content-disposition", "attachment;filename=Report.xlsx");
                    using (MemoryStream MyMemoryStream = new MemoryStream())
                    {
                        wb.SaveAs(MyMemoryStream);
                        MyMemoryStream.WriteTo(Response.OutputStream);
                        Response.Flush();

                    }
                }
            }
            catch (Exception Ex)
            {
                Response.Write(Ex.Message);
                throw Ex;
            }

            finally
            {

                dt = null;
            }

            Response.End();
        }





        protected DataTable BindGrid()
        {
            DataTable dt = new DataTable("Report");
            reportGV.AllowPaging = false;


            foreach (System.Web.UI.WebControls.TableCell cell in reportGV.HeaderRow.Cells)
            {
                dt.Columns.Add(cell.Text);
            }
            foreach (GridViewRow row in reportGV.Rows)
            {
                dt.Rows.Add();
                for (int j = 0; j < row.Cells.Count; j++)
                {
                    if (row.Cells[j].Text.Equals(null) || row.Cells[j].Text == "&nbsp;")
                    {
                        dt.Rows[dt.Rows.Count - 1][j] = "";
                    }
                    else
                    {
                        dt.Rows[dt.Rows.Count - 1][j] = row.Cells[j].Text;
                    }
                    }
            }

            return dt;

        }


        protected void SetPagerSize(object s, EventArgs e)
        {
            reportGV.PageSize = Convert.ToInt32(((DropDownList)s).SelectedValue);
        }

        //Refresh table data - Manual sync + Table refresh
        protected void RefreshTable(object s, EventArgs e)
        {
            //Initiate manual sync process - Old Implementation: [ new admin.Helper().StartTransfer(); ]
            ServiceController svc = new ServiceController();

            svc.ExecuteCommand(141);

            reportGV.DataBind();
        }
        //protected void GvPostProcess(object s, EventArgs e)
        //{
        //    //GetRecordCount(s, e); // <-- CURRENTLY NOT REQUIRED UNTIL THE NEED TO SHOW INDICATOR

        //}
        //protected void SetStatusIndicator(object s, GridViewRowEventArgs e)
        //{

        //}
    }
}