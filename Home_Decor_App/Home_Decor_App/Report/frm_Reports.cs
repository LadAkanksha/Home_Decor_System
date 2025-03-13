using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home_Decor_App.Report
{
    public partial class frm_Reports : Form
    {
        public frm_Reports()
        {
            InitializeComponent();
        }

        private void pb_Customer_Monthly_Report_Click(object sender, EventArgs e)
        {
            Report.Report_Form.frm_Customer_Monthly_Report CMR = new Report_Form.frm_Customer_Monthly_Report();
            CMR.Show();
        }

        private void pb_Expence_Report_Click(object sender, EventArgs e)
        {
            Report.Report_Form.frm_Expence_Datewise_Report EDR = new Report_Form.frm_Expence_Datewise_Report();
            EDR.Show();
        }

        private void pb_Payment_Monthly_Report_Click(object sender, EventArgs e)
        {
            Report.Report_Form.frm_Payment_Monthly_Report PMR = new Report_Form.frm_Payment_Monthly_Report();
            PMR.Show();
        }

        private void pb_Payment_Report_Click(object sender, EventArgs e)
        {
            Report.Report_Form.frm_Receive_Order_Report ROR = new Report_Form.frm_Receive_Order_Report();
            ROR.Show();
        }
    }
}
