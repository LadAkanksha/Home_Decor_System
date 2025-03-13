using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home_Decor_App
{
    public partial class frm_MDI : Form
    {
        public frm_MDI()
        {
            InitializeComponent();
        }

        private void addNewCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer_Details.frm_Add_New_Customer ANC = new Customer_Details.frm_Add_New_Customer();
            ANC.MdiParent = this;
            ANC.WindowState = FormWindowState.Maximized;
            ANC.Show();
        }
    }
}
