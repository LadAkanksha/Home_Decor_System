using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home_Decor_App.Popup_Window
{
    public partial class frm_Curtain : Form
    {
        public frm_Curtain()
        {
            InitializeComponent();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            if(cmb_CurCompany.Text != "" && cmb_CurMaterial.Text!= "" && cmb_CurStyle.Text != "" && cmb_CurSize.Text != "" && tb_CurPrice.Text != "" && SharedContent.ProductId != 0)  // (tb_CurPrice.Text != "" && SharedContent.ProductId != 0)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Something Went Wrong!!!\nTry Again");
            }
        }

        private void frm_Curtain_Load(object sender, EventArgs e)
        {
            SharedContent.Bind_ComboBox("Company", cmb_CurCompany, "select distinct(Company) from Curtain_Details");
        }


        private void cmb_CurCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            SharedContent.Bind_ComboBox("Material", cmb_CurMaterial, "select distinct(Material) from Curtain_Details where Company = '" + cmb_CurCompany.Text + "'");
        }

        private void cmb_CurMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            SharedContent.Bind_ComboBox("Style", cmb_CurStyle, "select distinct(Style) from Curtain_Details where Company = '" + cmb_CurCompany.Text + "' and Material = '" + cmb_CurMaterial.Text + "'");
        }

        private void cmb_CurStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            SharedContent.Bind_ComboBox("Size", cmb_CurSize, "select distinct(Size) from Curtain_Details where Company = '" + cmb_CurCompany.Text + "' and Material = '"+cmb_CurMaterial.Text+"' and Style = '"+cmb_CurStyle.Text+"'");
        }

        private void cmb_CurSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            Connections.Con_Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select Cur_Id , Cur_Name , Purchase_Price, Sales_Price, Current_Stock from Curtain_Details where Company = '" + cmb_CurCompany.Text+"' and Material = '"+cmb_CurMaterial.Text+"' and Style = '"+cmb_CurStyle.Text+"' and Size = '"+cmb_CurSize.Text+"'";
            cmd.Connection = Connections.Con;

            SqlDataReader DR = cmd.ExecuteReader();
            if(DR.Read())
            {
                SharedContent.ProductId = (int)DR["Cur_Id"];
                SharedContent.ProductName = DR.GetString(DR.GetOrdinal("Cur_Name"));

                if (SharedContent.Flag == 1)
                {
                    SharedContent.ProductPrice = Convert.ToDouble(DR["Sales_Price"]);
                }
                else
                {
                    SharedContent.ProductPrice = Convert.ToDouble(DR["Purchase_Price"]);
                }
                SharedContent.ProductStock = (int)DR["Current_Stock"];
                
            }
            tb_CurPrice.Text = Convert.ToString(SharedContent.ProductPrice);

            Connections.Con_Close();
        }
    }
}
