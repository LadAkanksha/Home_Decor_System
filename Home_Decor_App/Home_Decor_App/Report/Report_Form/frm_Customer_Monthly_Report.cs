using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home_Decor_App.Report.Report_Form
{
    public partial class frm_Customer_Monthly_Report : Form
    {
        public frm_Customer_Monthly_Report()
        {
            InitializeComponent();
        }

        void Bind_Report(int Month, int Year)
        {
            Connections.Con_Open();

            SqlDataAdapter SDA = new SqlDataAdapter("SP_Customer_Monthly_Report", Connections.Con);

            SDA.SelectCommand.CommandType = CommandType.StoredProcedure;
            SDA.SelectCommand.Parameters.AddWithValue("@Month", Month);
            SDA.SelectCommand.Parameters.AddWithValue("@Year", Year);

            DataTable DT = new DataTable();

            SDA.Fill(DT);

            Connections.Con_Close();

            Crystal_Report.CRPT_Customer_Monthly_Report CMR = new Crystal_Report.CRPT_Customer_Monthly_Report();
            CMR.Database.Tables["SP_Customer_Monthly_Report"].SetDataSource(DT);

            crv_Customer_Monthly_Report.ReportSource = null;
            crv_Customer_Monthly_Report.ReportSource = CMR;
        }
        private void btn_Search_Click(object sender, EventArgs e)
        {

            int C_Month = System.DateTime.Today.Month;
            int C_Year = System.DateTime.Today.Year;

            cmb_Year.Text = Convert.ToString(C_Year);
            cmb_Month.SelectedIndex = C_Month - 1;

            Bind_Report(C_Month, C_Year);
        }

        private void cmb_Month_SelectedIndexChanged(object sender, EventArgs e)
        {
            int C_Month = cmb_Month.SelectedIndex + 1;
            int C_Year;
            if (cmb_Year.Text == "")
            {
                 C_Year = System.DateTime.Today.Year;
            }
            else
            {
                 C_Year = Convert.ToInt32(cmb_Year.Text);
            }
            Bind_Report(C_Month, C_Year);
        }

        private void cmb_Year_SelectedIndexChanged(object sender, EventArgs e)
        {
            int C_Month = cmb_Month.SelectedIndex + 1;
            int C_Year = Convert.ToInt32(cmb_Year.Text);

            Bind_Report(C_Month, C_Year);
        }

        private void frm_Customer_Monthly_Report_Load(object sender, EventArgs e)
        {

        }
    }
}
