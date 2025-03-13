using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home_Decor_App.Stock_Details
{
    public partial class frm_View_Orders : Form
    {
        public frm_View_Orders()
        {
            InitializeComponent();
        }

        private void frm_View_Orders_Load(object sender, EventArgs e)
        {
            if (SharedContent.User_Role == "Admin")
            {
                SharedContent.Bind_Grid(dgv_Order_Details, "select * from Order_Details");
            }
            else
            {
                SharedContent.Bind_Grid(dgv_Order_Details, "select Order_Id,Supplier,Mob_No,Bill,GST,Final_Bill,Paid_Amount,Status from Order_Details");
            }
        }
    }
}
