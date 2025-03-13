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
    public partial class frm_Pillow : Form
    {
        public frm_Pillow()
        {
            InitializeComponent();
        }

        private void frm_Pillow_Load(object sender, EventArgs e)
        {
            SharedContent.Bind_ComboBox("Company",cmb_PCompany,"select distinct(Company) from Pillow_Details");
        }

        private void cmb_PCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            SharedContent.Bind_ComboBox("Material", cmb_PMaterial, "select distinct(Material) from Pillow_Details where Company = '" + cmb_PCompany.Text + "'");
        }

        private void cmb_PMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            SharedContent.Bind_ComboBox("Comfort", cmb_PComfort, "select distinct(Comfort) from Pillow_Details where Company = '" + cmb_PCompany.Text + "' and Material = '" + cmb_PMaterial.Text + "'");
        }

        private void cmb_PComfort_SelectedIndexChanged(object sender, EventArgs e)
        {
            SharedContent.Bind_ComboBox("Size", cmb_PSize, "select distinct(Size) from Pillow_Details where Company = '" + cmb_PCompany.Text + "' and Material = '" + cmb_PMaterial.Text + "' and Comfort = '" + cmb_PComfort.Text + "'");
        }

        private void cmb_PSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            Connections.Con_Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select P_Id , P_Name , Sales_Price ,Purchase_Price,Current_stock from Pillow_Details where Company = '" + cmb_PCompany.Text + "' and Material = '" + cmb_PMaterial.Text + "' and Comfort = '" + cmb_PComfort.Text + "' and Size = '"+cmb_PSize.Text+"'";
            cmd.Connection = Connections.Con;
            SqlDataReader DR = cmd.ExecuteReader();
            if(DR.Read())
            {
                SharedContent.ProductId = (int)DR["P_Id"];
                SharedContent.ProductName = DR.GetString(DR.GetOrdinal("P_Name"));
                if (SharedContent.Flag == 1)
                {
                    SharedContent.ProductPrice = Convert.ToDouble(DR["Sales_Price"]);
                }
                else
                {
                    SharedContent.ProductPrice = Convert.ToDouble(DR["Purchase_Price"]);
                }
                SharedContent.ProductStock = (int)DR["Current_stock"];
            }
            tb_PPrice.Text = Convert.ToString(SharedContent.ProductPrice);

            Connections.Con_Close();
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            if (cmb_PCompany.Text != "" && cmb_PMaterial.Text != "" && cmb_PComfort.Text != "" && cmb_PSize.Text != "" && tb_PPrice.Text != "" && SharedContent.ProductId != 0)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Something Went Wrong!!!\nTry Again");
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
