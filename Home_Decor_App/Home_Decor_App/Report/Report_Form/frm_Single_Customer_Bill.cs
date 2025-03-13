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
    public partial class frm_Single_Customer_Bill : Form
    {
        public frm_Single_Customer_Bill()
        {
            InitializeComponent();
        }

        private void frm_Single_Customer_Bill_Load(object sender, EventArgs e)
        {
            Connections.Con_Open();
            SqlDataAdapter SDA = new SqlDataAdapter("SP_Single_Customer_Bill", Connections.Con);
            SDA.SelectCommand.CommandType = CommandType.StoredProcedure;
            SDA.SelectCommand.Parameters.AddWithValue("@C_Id", SharedContent.CId);

            DataTable DT = new DataTable();
            SDA.Fill(DT);

            Connections.Con_Close();

            Report.Crystal_Report.CRPT_Single_Customer_Bill Obj = new Crystal_Report.CRPT_Single_Customer_Bill();
            Obj.Database.Tables["SP_Single_Customer_Bill"].SetDataSource(DT);

            crv_Single_Customer_Bill.ReportSource = null;
            crv_Single_Customer_Bill.ReportSource = Obj;
        }
    }
}
