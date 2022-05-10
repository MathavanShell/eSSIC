using System;
using System.Data;
using System.Web.UI;
using ClosedXML.Excel;
using System.IO;

namespace eSSIC
{
    public partial class Test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Grddata.DataSource = BindGrid();
                Grddata.DataBind();
            }
        }
    
    protected DataTable BindGrid()
    {
        DataTable dt = null;

        dt = new DataTable();
        dt.Columns.Add("StudentID", typeof(int));
        dt.Columns.Add("Name", typeof(string));
        dt.Columns.Add("Marks", typeof(int));

        dt.Rows.Add(1, "Nitin Tyagi", 400);
        dt.Rows.Add(2, "John Smith", 300);
        dt.Rows.Add(3, "James Smith", 200);
        dt.Rows.Add(4, "John Doe", 400);


        return dt;


    }

    protected void Btngenerateexcel_Click(object sender, EventArgs e)
    {
        DataTable dt = null;
        try
        {


            dt = BindGrid();

            using (XLWorkbook wb = new XLWorkbook())
            {
                wb.Worksheets.Add(dt, "Students");

                Response.Clear();
                Response.Buffer = true;
                Response.Charset = "";
                Response.ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                Response.AddHeader("content-disposition", "attachment;filename=Download.xlsx");
                using (MemoryStream MyMemoryStream = new MemoryStream())
                {
                    wb.SaveAs(MyMemoryStream);
                    MyMemoryStream.WriteTo(Response.OutputStream);
                    Response.Flush();
                    Response.End();
                }

            }

        }
        catch (Exception Ex)
        {
        }
        finally
        {
            dt = null;
        }
    }
}
}