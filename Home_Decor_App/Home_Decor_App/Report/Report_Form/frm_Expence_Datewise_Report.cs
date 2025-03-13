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
    public partial class frm_Expence_Datewise_Report : Form
    {
        public frm_Expence_Datewise_Report()
        {
            InitializeComponent();
        }

        void Bind_Report(DateTime Start, DateTime End)
        {
            Connections.Con_Open();

            SqlDataAdapter SDA = new SqlDataAdapter("SP_Expence_Datewise_Report", Connections.Con);

            SDA.SelectCommand.CommandType = CommandType.StoredProcedure;
            SDA.SelectCommand.Parameters.AddWithValue("@SDate", Start);
            SDA.SelectCommand.Parameters.AddWithValue("@EDate", End);

            DataTable DT = new DataTable();

            SDA.Fill(DT);

            Connections.Con_Close();

            Report.Crystal_Report.CRPT_Expence_Datewise_Report EDR = new Crystal_Report.CRPT_Expence_Datewise_Report();
            EDR.Database.Tables["SP_Expence_Datewise_Report"].SetDataSource(DT);

            crv_Expence_Datewise_Report.ReportSource = null;

            crv_Expence_Datewise_Report.ReportSource = EDR;
        }
        private void btn_Search_Click(object sender, EventArgs e)
        {
            Bind_Report(dtp_FDate.Value.Date, dtp_Tdate.Value.Date);
        }

        private void frm_Expence_Datewise_Report_Load(object sender, EventArgs e)
        {
            dtp_FDate.Value = new DateTime(System.DateTime.Today.Year, System.DateTime.Today.Month, 1);

            Bind_Report(dtp_FDate.Value.Date, dtp_Tdate.Value.Date);
        }
    }
}
