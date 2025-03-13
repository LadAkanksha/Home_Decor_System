using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home_Decor_App.Customer_Details
{
    public partial class frm_View_Customer_Details : Form
    {
        public frm_View_Customer_Details()
        {
            InitializeComponent();
        }

        private void frm_View_Customer_Details_Load(object sender, EventArgs e)
        {
            if(SharedContent.User_Role == "Admin")
            {
                SharedContent.Bind_Grid(dgv_Customer_Details, "Select * from Customer_Details");
            }
            else
            {
                SharedContent.Bind_Grid(dgv_Customer_Details, "Select Customer_Id , Name , Address , Mob_No , Pay_Mode , Bill , GST , Discount , Final_Bill from Customer_Details");
            }
        }

        private void cmb_Searchby_Month_SelectedIndexChanged(object sender, EventArgs e)
        {
            SharedContent.Bind_Grid(dgv_Customer_Details, "Select Customer_Id , Name , Address , Mob_No , Pay_Mode , Bill , GST , Discount , Final_Bill from Customer_Details where MONTH(Date) ='"+Convert.ToInt32((cmb_Searchby_Month.SelectedIndex)+1)+"'");
        }

        private void cmb_Searchby_Year_SelectedIndexChanged(object sender, EventArgs e)
        {
            SharedContent.Bind_Grid(dgv_Customer_Details, "Select Customer_Id , Name , Address , Mob_No , Pay_Mode , Bill , GST , Discount , Final_Bill from Customer_Details where MONTH(Date) ='" + Convert.ToInt32((cmb_Searchby_Month.SelectedIndex) + 1) + "' and Year(Date) = '"+Convert.ToInt32(cmb_Searchby_Year.Text) +"'");
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            if (SharedContent.User_Role == "Admin")
            {
                SharedContent.Bind_Grid(dgv_Customer_Details, "Select * from Customer_Details");
            }
            else
            {
                SharedContent.Bind_Grid(dgv_Customer_Details, "Select Customer_Id , Name , Address , Mob_No , Pay_Mode , Bill , GST , Discount , Final_Bill from Customer_Details");
            }
        }

        private void dgv_Customer_Details_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SharedContent.CId = Convert.ToInt32(dgv_Customer_Details.CurrentRow.Cells[0].Value);

            Report.Report_Form.frm_Single_Customer_Bill SCB = new Report.Report_Form.frm_Single_Customer_Bill();
            SCB.Show();
        }
    }
}
