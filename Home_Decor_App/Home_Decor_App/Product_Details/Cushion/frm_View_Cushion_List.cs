using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home_Decor_App.Product_Details.Cushion
{
    public partial class frm_View_Cushion_List : Form
    {
        public frm_View_Cushion_List()
        {
            InitializeComponent();
        }

        private void frm_View_Cushion_List_Load(object sender, EventArgs e)
        {
            SharedContent.Bind_ComboBox("Company", cmb_Cus_Company, "Select distinct(Company) from Cushion_Details");
            if (SharedContent.User_Role == "Admin")
            {
                SharedContent.Bind_Grid(dgv_Cushion_Details, "select Cush_Id as ID , Cush_Name as Cushion , Company , Material , Comfort , Size , Details , Purchase_Price , Sales_Price , Supplier , Current_Stock as Stock from Cushion_Details");
            }
            else
            {
                SharedContent.Bind_Grid(dgv_Cushion_Details, "select Cush_Id as ID , Cush_Name as Cushion , Company , Material , Comfort , Size , Details ,  Sales_Price , Supplier , Current_Stock as Stock from Cushion_Details");
            }
        }

        private void cmb_Cus_Company_SelectedIndexChanged(object sender, EventArgs e)
        {
            SharedContent.Bind_ComboBox("Material", cmb_Cus_Material, "Select distinct(Material) from Cushion_Details where Company = '"+cmb_Cus_Company.Text+"'");
            SharedContent.Bind_Grid(dgv_Cushion_Details, "select Cush_Id as ID , Cush_Name as Cushion , Company , Material , Comfort , Size , Details ,  Sales_Price , Supplier , Current_Stock as Stock from Cushion_Details where Company = '"+cmb_Cus_Company.Text+"'");
        }

        private void cmb_Cus_Material_SelectedIndexChanged(object sender, EventArgs e)
        {
            SharedContent.Bind_ComboBox("Comfort", cmb_Cus_Comfort, "Select distinct(Comfort) from Cushion_Details where Company = '" + cmb_Cus_Company.Text + "' and Material = '"+cmb_Cus_Material.Text+"'");
            SharedContent.Bind_Grid(dgv_Cushion_Details, "select Cush_Id as ID , Cush_Name as Cushion , Company , Material , Comfort , Size , Details ,  Sales_Price , Supplier , Current_Stock as Stock from Cushion_Details where Company = '" + cmb_Cus_Company.Text + "'and Material = '" + cmb_Cus_Material.Text + "'");
        }

        private void cmb_Cus_Comfort_SelectedIndexChanged(object sender, EventArgs e)
        {
            SharedContent.Bind_Grid(dgv_Cushion_Details, "select Cush_Id as ID , Cush_Name as Cushion , Company , Material , Comfort , Size , Details ,  Sales_Price , Supplier , Current_Stock as Stock from Cushion_Details where Company = '" + cmb_Cus_Company.Text + "'and Material = '" + cmb_Cus_Material.Text + "'and Comfort = '" + cmb_Cus_Comfort.Text + "'");
        }
    }
}
