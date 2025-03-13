using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home_Decor_App.Product_Details.Curtain
{
    public partial class frm_View_Curtain : Form
    {
        public frm_View_Curtain()
        {
            InitializeComponent();
        }

        private void frm_View_Curtain_Load(object sender, EventArgs e)
        {
            SharedContent.Bind_ComboBox("Company", cmb_Cur_Company, "Select distinct(Company) from Curtain_Details");
            if(SharedContent.User_Role == "Admin")
            {
                SharedContent.Bind_Grid(dgv_Curtain_Details, "select Cur_Id as ID , Cur_Name as Curtain , Company , Material , Style , Size , Details , Purchase_Price , Sales_Price , Supplier , Current_Stock as Stock from Curtain_Details");
            }
            else
            {
                SharedContent.Bind_Grid(dgv_Curtain_Details, "select Cur_Id as ID , Cur_Name as Curtain , Company , Material , Style , Size , Details ,  Sales_Price , Supplier , Current_Stock as Stock from Curtain_Details");
            }
        }

        private void cmb_Cur_Company_SelectedIndexChanged(object sender, EventArgs e)
        {
            SharedContent.Bind_ComboBox("Material", cmb_Cur_Material, "Select distinct(Material) from Curtain_Details where Company = '"+cmb_Cur_Company.Text+"'");
            SharedContent.Bind_Grid(dgv_Curtain_Details, "select Cur_Id as ID , Cur_Name as Curtain , Company , Material , Style , Size , Details ,  Sales_Price , Supplier , Current_Stock as Stock from Curtain_Details where Company = '"+cmb_Cur_Company.Text+"'");
        }

        private void cmb_Cur_Material_SelectedIndexChanged(object sender, EventArgs e)
        {
            SharedContent.Bind_ComboBox("Style", cmb_Cur_Style, "Select distinct(Style) from Curtain_Details where Company = '"+cmb_Cur_Company.Text+"' and Material = '"+cmb_Cur_Material.Text+"'");
            SharedContent.Bind_Grid(dgv_Curtain_Details, "select Cur_Id as ID , Cur_Name as Curtain , Company , Material , Style , Size , Details ,  Sales_Price , Supplier , Current_Stock as Stock from Curtain_Details where Company = '" + cmb_Cur_Company.Text + "' and Material = '"+cmb_Cur_Material.Text+"'");
        }

        private void cmb_Cur_Style_SelectedIndexChanged(object sender, EventArgs e)
        {
            SharedContent.Bind_Grid(dgv_Curtain_Details, "select Cur_Id as ID , Cur_Name as Curtain , Company , Material , Style , Size , Details ,  Sales_Price , Supplier , Current_Stock as Stock from Curtain_Details where Company = '" + cmb_Cur_Company.Text + "' and Material = '"+cmb_Cur_Material.Text+"' and Style = '"+cmb_Cur_Style.Text+"'");
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            dgv_Curtain_Details.Rows.Clear();
        }
    }
}
