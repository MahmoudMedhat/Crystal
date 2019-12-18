using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Web;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CrystalRep
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CrystalReport1 rprt = new CrystalReport1();
            rprt.Load(Server.MapPath("~/CrystalReport1.rpt"));
            SqlConnection con = new SqlConnection(@"Data Source =.; initial catalog = Northwind; integrated security = true;");
            SqlCommand cmd = new SqlCommand("Proc_Product", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            rprt.SetDataSource(dt);
            //rprt.SetParameterValue(0, Name);
            CrystalReportViewer1.ReportSource = rprt;
            CrystalReportViewer1.DataBind();


        }






    }
}