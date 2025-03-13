using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home_Decor_App.Product_Details.Pillow
{
    public partial class frm_View_Pillow_List : Form
    {
        public frm_View_Pillow_List()
        {
            InitializeComponent();
        }

        private void frm_View_Pillow_List_Load(object sender, EventArgs e)
        {
            SharedContent.Bind_ComboBox("Company", cmb_P_Company, "Select distinct(Company) from Pillow_Details");
            if (SharedContent.User_Role == "Admin")
            {
                SharedContent.Bind_Grid(dgv_Pillow_Details, "select P_Id as ID , P_Name as Pillow , Company , Material , Comfort , Size , Details , Purchase_Price , Sales_Price , Supplier , Current_Stock as Stock from Pillow_Details");
            }
            else
            {
                SharedContent.Bind_Grid(dgv_Pillow_Details, "select P_Id as ID , P_Name as Pillow , Company , Material , Comfort , Size , Details ,  Sales_Price , Supplier , Current_Stock as Stock from Pillow_Details");
            }
        }

        private void cmb_P_Company_SelectedIndexChanged(object sender, EventArgs e)
        {

            SharedContent.Bind_ComboBox("Material", cmb_P_Material, "Select distinct(Material) from Pillow_Details where Company = '" + cmb_P_Company.Text + "'");
            SharedContent.Bind_Grid(dgv_Pillow_Details, "select P_Id as ID , P_Name as Pillow , Company , Material , Comfort , Size , Details ,  Sales_Price , Supplier , Current_Stock as Stock from Pillow_Details where Company = '" + cmb_P_Company.Text + "'");

        }

        private void cmb_P_Material_SelectedIndexChanged(object sender, EventArgs e)
        {

            SharedContent.Bind_ComboBox("Comfort", cmb_P_Comfort, "Select distinct(Comfort) from Pillow_Details where Company = '" + cmb_P_Company.Text + "'and Material = '" + cmb_P_Material.Text + "'");
            SharedContent.Bind_Grid(dgv_Pillow_Details, "select P_Id as ID , P_Name as Pillow , Company , Material , Comfort , Size , Details ,  Sales_Price , Supplier , Current_Stock as Stock from Pillow_Details where Company = '" + cmb_P_Company.Text + "' and Material = '"+cmb_P_Material.Text+"'");

        }

        private void cmb_P_Comfort_SelectedIndexChanged(object sender, EventArgs e)
        {
            SharedContent.Bind_Grid(dgv_Pillow_Details, "select P_Id as ID , P_Name as Pillow , Company , Material , Comfort , Size , Details ,  Sales_Price , Supplier , Current_Stock as Stock from Pillow_Details where Company = '" + cmb_P_Company.Text + "' and Material = '" + cmb_P_Material.Text + "' and Comfort = '"+cmb_P_Comfort.Text+"'");
        }
    }
}
