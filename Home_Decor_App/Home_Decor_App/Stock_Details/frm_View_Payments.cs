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
    public partial class frm_View_Payments : Form
    {
        public frm_View_Payments()
        {
            InitializeComponent();
        }

        private void frm_View_Payments_Load(object sender, EventArgs e)
        {
            if(SharedContent.User_Role == "Admin")
            {
                SharedContent.Bind_Grid(dgv_Payment_Details,"Select p.Payment_Id,p.Order_Id,p.Payment_Date,p.Final_Bill,p.Payment_Mode,o.Paid_Amount,p.Note,o.status from Payment_Details p inner join Order_Details o ON p.Order_Id = o.Order_Id");
            }
            else
            {
                SharedContent.Bind_Grid(dgv_Payment_Details, "Select Payment_Id,Order_Id,Payment_Date,Final_Bill,Note,Payment_Mode from Payment_Details");
            }
        }
        int m, y;
        private void cmb_Searchby_Month_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Searchby_Month.Text == "")
            {
                m = cmb_Searchby_Month.SelectedIndex + 1;
            }
            else
            {
                m = cmb_Searchby_Month.SelectedIndex + 1;
            }
            SharedContent.Bind_Grid(dgv_Payment_Details, "select Payment_Id,Order_Id,Payment_Date,Final_Bill,Note,Payment_Mode from Payment_Details where MONTH(Payment_Date) = '" + m + "'");

        }

        private void cmb_Searchby_Year_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Searchby_Year.Text == "")
            {
                y = System.DateTime.Today.Year;
                cmb_Searchby_Year.Text = Convert.ToString(y);
            }
            else
            {
                y = Convert.ToInt32(cmb_Searchby_Year.Text);
            }
            SharedContent.Bind_Grid(dgv_Payment_Details, "select Payment_Id,Order_Id,Payment_Date,Final_Bill,Note,Payment_Mode from Payment_Details where MONTH(Payment_Date) = '" + m + "' and YEAR(Payment_Date) = '" + y + "'");

        }


        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            if (SharedContent.User_Role == "Admin")
            {
                SharedContent.Bind_Grid(dgv_Payment_Details, "Select p.Payment_Id,p.Order_Id,p.Payment_Date,p.Final_Bill,p.Payment_Mode,o.Paid_Amount,p.Note,o.status from Payment_Details p inner join Order_Details o ON p.Order_Id = o.Order_Id");
            }
            else
            {
                SharedContent.Bind_Grid(dgv_Payment_Details, "Select Payment_Id,Order_Id,Payment_Date,Final_Bill,Note,Payment_Mode from Payment_Details");
            }
        }
    }
}
