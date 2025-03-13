using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home_Decor_App.Expence_Details
{
    public partial class frm_View_Expence_Details : Form
    {
        public frm_View_Expence_Details()
        {
            InitializeComponent();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
          //  dgv_Expence_Details.Rows.Clear();
        }

        private void frm_View_Expence_Details_Load(object sender, EventArgs e)
        {
            SharedContent.Bind_Grid(dgv_Expence_Details, "Select Id, Details, Paid_Amout as 'Amount', Expense_Date, Paid_By, Login_User_Id from Expense_Details");
        }
        int m, y;

        private void cmb_Searchby_Month_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmb_Searchby_Month.Text == "")
            {
                m = cmb_Searchby_Month.SelectedIndex + 1;
            }
            else
            {
                m = cmb_Searchby_Month.SelectedIndex+1;
            }
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
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            SharedContent.Bind_Grid(dgv_Expence_Details, "Select Id, Details, Paid_Amout as 'Amount', Expense_Date, Paid_By, Login_User_Id from Expense_Details where MONTH(Expense_Date) = '" + m + "' and YEAR(Expense_Date) = '" + y + "'");
        }
    }
}
