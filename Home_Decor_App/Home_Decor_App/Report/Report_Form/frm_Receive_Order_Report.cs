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
    public partial class frm_Receive_Order_Report : Form
    {
        public frm_Receive_Order_Report()
        {
            InitializeComponent();
        }

        private void frm_Receive_Order_Report_Load(object sender, EventArgs e)
        {
            Connections.Con_Open();

            SqlDataAdapter sqlDa = new SqlDataAdapter("SP_Receive_Order_Report", Connections.Con);

            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataTable dtbl = new DataTable();

            sqlDa.Fill(dtbl);

            Connections.Con_Close();

            Report.Crystal_Report.CRPT_Receive_Order_Report ROR = new Crystal_Report.CRPT_Receive_Order_Report();
            ROR.Database.Tables["SP_Receive_Order_Report"].SetDataSource(dtbl);

            crv_Receive_Order_Report.ReportSource = null;

            crv_Receive_Order_Report.ReportSource = ROR;
        }
    }
}
