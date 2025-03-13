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
    public partial class frm_Payment_Monthly_Report : Form
    {
        public frm_Payment_Monthly_Report()
        {
            InitializeComponent();
        }

        void Bind_Report(int Month, int Year)
        {
            Connections.Con_Open();

            SqlDataAdapter SDA = new SqlDataAdapter("SP_Payment_Monthly_Report", Connections.Con);

            SDA.SelectCommand.CommandType = CommandType.StoredProcedure;
            SDA.SelectCommand.Parameters.AddWithValue("@Month", Month);
            SDA.SelectCommand.Parameters.AddWithValue("@Year", Year);

            DataTable DT = new DataTable();

            SDA.Fill(DT);

            Connections.Con_Close();

            Crystal_Report.CRPT_Payment_Monthly_Report PMR = new Crystal_Report.CRPT_Payment_Monthly_Report();
            PMR.Database.Tables["SP_Payment_Monthly_Report"].SetDataSource(DT);

            crv_Payment_Monthly_Report.ReportSource = null;
            crv_Payment_Monthly_Report.ReportSource = PMR;
        }
        private void btn_Search_Click(object sender, EventArgs e)
        {
            int C_Year , C_Month = cmb_Month.SelectedIndex + 1;
            if (cmb_Year.Text == "")
            {
                C_Year = System.DateTime.Today.Year;
            }
            else
            {

                C_Year = Convert.ToInt32(cmb_Year.Text);
            }
            if (cmb_Month.Text == "" && cmb_Year.Text == "")
            {

                 C_Month = System.DateTime.Today.Month;
                 C_Year = System.DateTime.Today.Year;

                cmb_Year.Text = Convert.ToString(C_Year);
                cmb_Month.SelectedIndex = C_Month - 1;
            }

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
        }

        private void cmb_Year_SelectedIndexChanged(object sender, EventArgs e)
        {
            int C_Month = cmb_Month.SelectedIndex + 1;
            int C_Year = Convert.ToInt32(cmb_Year.Text);
        }

        private void frm_Payment_Monthly_Report_Load(object sender, EventArgs e)
        {

        }
    }
}
