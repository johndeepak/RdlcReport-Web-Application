using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace RdlcReport_Web_Application
{
    public partial class Report : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string conString = ConfigurationManager.ConnectionStrings["TimeTrackerConnectionString"].ConnectionString;

                ReportViewer1.ProcessingMode = ProcessingMode.Local;
                ReportViewer1.LocalReport.ReportPath = Server.MapPath("~/NewFolder1/Report1.rdlc");
                Customers dsUsersInfo = new Customers();
                DataTable ds = new DataTable();
                using (SqlConnection con = new SqlConnection(conString))
                {
                    con.Open();
                    SqlCommand cmd = null;
                    if (Name.Text != string.Empty)
                    {
                        cmd = new SqlCommand("select * from Sales where name='" + Name.Text + "'", con);
                    }
                    else
                    {
                        cmd = new SqlCommand("select * from Sales", con);
                    }
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    ds = new DataTable("Sales");
                    da.Fill(ds);
                    con.Close();
                }
                ReportDataSource datasource = new ReportDataSource("Sales", ds);
                ReportViewer1.LocalReport.DataSources.Clear();
                ReportViewer1.LocalReport.DataSources.Add(datasource);
            }
        }

        protected void Save_Click(object sender, EventArgs e)
        {
            string conString = ConfigurationManager.ConnectionStrings["TimeTrackerConnectionString"].ConnectionString;

            ReportViewer1.ProcessingMode = ProcessingMode.Local;
            ReportViewer1.LocalReport.ReportPath = Server.MapPath("~/NewFolder1/Report1.rdlc");
            Customers dsUsersInfo = new Customers();
            DataTable ds = new DataTable();
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                SqlCommand cmd = null;
                if (Name.Text != string.Empty)
                {
                    cmd = new SqlCommand("select * from Sales where name='" + Name.Text + "'", con);
                }
                else
                {
                    cmd = new SqlCommand("select * from Sales", con);
                }
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                ds = new DataTable("Sales");
                da.Fill(ds);
                con.Close();
            }
            ReportDataSource datasource = new ReportDataSource("Sales", ds);
            ReportViewer1.LocalReport.DataSources.Clear();
            ReportViewer1.LocalReport.DataSources.Add(datasource);
        }

    }
}


