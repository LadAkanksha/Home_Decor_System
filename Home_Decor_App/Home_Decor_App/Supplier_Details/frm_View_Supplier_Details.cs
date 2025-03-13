using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home_Decor_App.Supplier_Details
{
    public partial class frm_View_Supplier_Details : Form
    {
        public frm_View_Supplier_Details()
        {
            InitializeComponent();
        }

        private void frm_View_Supplier_Details_Load(object sender, EventArgs e)
        {
            if(SharedContent.User_Role == "Admin")
            {
                SharedContent.Bind_Grid(dgv_Supplier_Details, "select * from Supplier_Details");
            }
            else
            {
                SharedContent.Bind_Grid(dgv_Supplier_Details, "select S_Id , Name , Mob_No , AMob_No , Office_Address , Date , Aadhar_No from Supplier_Details");
            }
        }
    }
}
