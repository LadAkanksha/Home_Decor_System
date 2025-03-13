using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home_Decor_App.Product_Details.Mattress
{
    public partial class frm_View_Mattress : Form
    {
        public frm_View_Mattress()
        {
            InitializeComponent();
        }

        private void frm_View_Mattress_Load(object sender, EventArgs e)
        {
            SharedContent.Bind_ComboBox("Company", cmb_M_Company, "Select distinct(Company) from Mattress_Details");
            if (SharedContent.User_Role == "Admin")
            {
                SharedContent.Bind_Grid(dgv_Mattress_Details, "select M_Id as ID , M_Name as Mattress , Company , Material , Comfort , Size , Details , Purchase_Price , Sales_Price , Supplier , Current_Stock as Stock from Mattress_Details");
            }
            else
            {
                SharedContent.Bind_Grid(dgv_Mattress_Details, "select M_Id as ID , M_Name as Mattress , Company , Material , Comfort , Size , Details ,  Sales_Price , Supplier , Current_Stock as Stock from Mattress_Details");
            }
        }

        private void cmb_M_Company_SelectedIndexChanged(object sender, EventArgs e)
        {
            SharedContent.Bind_ComboBox("Material", cmb_M_Material, "Select distinct(Material) from Mattress_Details where Company = '" + cmb_M_Company.Text + "'");
            SharedContent.Bind_Grid(dgv_Mattress_Details, "select M_Id as ID , M_Name as Mattress , Company , Material , Comfort , Size , Details ,  Sales_Price , Supplier , Current_Stock as Stock from Mattress_Details where Company = '" + cmb_M_Company.Text + "'");
        }

        private void cmb_M_Material_SelectedIndexChanged(object sender, EventArgs e)
        {
            SharedContent.Bind_ComboBox("Comfort", cmb_M_Comfort, "Select distinct(Comfort) from Mattress_Details where Company = '" + cmb_M_Company.Text + "' and Material = '" + cmb_M_Material.Text + "'");
            SharedContent.Bind_Grid(dgv_Mattress_Details, "select M_Id as ID , M_Name as Mattress , Company , Material , Comfort , Size , Details ,  Sales_Price , Supplier , Current_Stock as Stock from Mattress_Details where Company = '" + cmb_M_Company.Text + "'and Material = '" + cmb_M_Material.Text + "'");
        }

        private void cmb_M_Comfort_SelectedIndexChanged(object sender, EventArgs e)
        {
            SharedContent.Bind_Grid(dgv_Mattress_Details, "select M_Id as ID , M_Name as Mattress , Company , Material , Comfort , Size , Details ,  Sales_Price , Supplier , Current_Stock as Stock from Mattress_Details where Company = '" + cmb_M_Company.Text + "'and Material = '" + cmb_M_Material.Text + "' and Comfort = '"+cmb_M_Comfort.Text+"'");
        }
    }
}
