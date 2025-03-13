using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home_Decor_App.Employee_Details
{
    public partial class frm_View_Employee_Details : Form
    {
        public frm_View_Employee_Details()
        {
            InitializeComponent();
        }

        private void frm_View_Employee_Details_Load(object sender, EventArgs e)
        {

            SharedContent.Bind_ComboBox("Role", cmb_Post, "select distinct(Role) from Employee_Details");

            if (SharedContent.User_Role == "Admin")
            {
                SharedContent.Bind_Grid(dgv_Employee_Details, "select * from Employee_Details");
            }
            else
            {
                SharedContent.Bind_Grid(dgv_Employee_Details, "select E_Id as ID, Name , Mob_No as 'Mobile No', Role , Address , Email_Id from Employee_Details");
                dgv_Employee_Details.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void cmb_Post_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmb_Post.Text == "Admin")
            {
                SharedContent.Bind_Grid(dgv_Employee_Details, "select * from Employee_Details where Role = '" + cmb_Post.Text + "'");
            }
            else
            {
                string qry = "select E_Id as ID, Name , Mob_No as 'Mobile No', Role , Address , Email_Id as Email from Employee_Details where Role = '" + cmb_Post.Text + "'";
                SharedContent.Bind_Grid(dgv_Employee_Details, qry);
                dgv_Employee_Details.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }
    }
}
