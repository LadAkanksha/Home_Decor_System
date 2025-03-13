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
    public partial class frm_Mattress : Form
    {
        public frm_Mattress()
        {
            InitializeComponent();
        }

        private void frm_Mattress_Load(object sender, EventArgs e)
        {
            SharedContent.Bind_ComboBox("Company",cmb_MCompany,"select distinct(Company) from Mattress_Details");
        }

        private void cmb_MCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            SharedContent.Bind_ComboBox("Material",cmb_MMaterial, "select distinct(Material) from Mattress_Details where Company = '"+cmb_MCompany.Text+"'");
        }

        private void cmb_MMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            SharedContent.Bind_ComboBox("Comfort", cmb_MComfort, "select distinct(Comfort) from Mattress_Details where Company = '" + cmb_MCompany.Text + "' and Material = '"+cmb_MMaterial.Text+"'");
        }

        private void cmb_MComfort_SelectedIndexChanged(object sender, EventArgs e)
        {
            SharedContent.Bind_ComboBox("Size", cmb_MSize, "select distinct(Size) from Mattress_Details where Company = '" + cmb_MCompany.Text + "' and Material = '" + cmb_MMaterial.Text + "' and Comfort = '" + cmb_MComfort.Text + "'");
        }

        private void cmb_MSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            Connections.Con_Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select M_Id , M_Name , Sales_Price ,Purchase_Price , Current_Stock from Mattress_Details where Company = '" + cmb_MCompany.Text + "' and Material = '" + cmb_MMaterial.Text + "' and Comfort = '" + cmb_MComfort.Text + "' and Size = '"+cmb_MSize.Text+"'";
            cmd.Connection = Connections.Con;
            SqlDataReader DR = cmd.ExecuteReader();
            if(DR.Read())
            {
                SharedContent.ProductId = (int)DR["M_Id"];
                SharedContent.ProductName = DR.GetString(DR.GetOrdinal("M_Name"));
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
            tb_MPrice.Text = Convert.ToString(SharedContent.ProductPrice);

            Connections.Con_Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            if (cmb_MCompany.Text != "" && cmb_MMaterial.Text != "" && cmb_MComfort.Text != "" && cmb_MSize.Text != "" && tb_MPrice.Text != "" && SharedContent.ProductId != 0)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Something Went Wrong!!!\nTry Again");
            }
        }
    }
}
