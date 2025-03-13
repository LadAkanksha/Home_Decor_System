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
    public partial class frm_Cushion : Form
    {
        public frm_Cushion()
        {
            InitializeComponent();
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            if (cmb_CusCompany.Text != "" && cmb_CusMaterial.Text != "" && cmb_CusComfort.Text != "" && cmb_CusSize.Text != "" && tb_CusPrice.Text != "" && SharedContent.ProductId != 0)
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

        private void frm_Cushion_Load(object sender, EventArgs e)
        {
            SharedContent.Bind_ComboBox("Company", cmb_CusCompany, "select distinct(Company) from Cushion_Details");
        }

        private void cmb_CusCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            SharedContent.Bind_ComboBox("Material", cmb_CusMaterial, "select distinct(Material) from Cushion_Details where Company = '" + cmb_CusCompany.Text + "'");
        }

        private void cmb_CusMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            SharedContent.Bind_ComboBox("Comfort", cmb_CusComfort, "select distinct(Comfort) from Cushion_Details where Company = '" + cmb_CusCompany.Text + "' and Material = '" + cmb_CusMaterial.Text + "'");

        }

        private void cmb_CusComfort_SelectedIndexChanged(object sender, EventArgs e)
        {
            SharedContent.Bind_ComboBox("Size", cmb_CusSize, "select distinct(Size) from Cushion_Details where Company = '" + cmb_CusCompany.Text + "' and Material = '" + cmb_CusMaterial.Text + "' and Comfort = '" + cmb_CusComfort.Text + "'");

        }

        private void cmb_CusSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            Connections.Con_Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select Cush_Id , Cush_Name , Sales_Price , Purchase_Price,Current_Stock from Cushion_Details where Company = '"+cmb_CusCompany.Text+"' and Material = '"+cmb_CusMaterial.Text+"' and Comfort = '"+cmb_CusComfort.Text+"' and Size = '"+cmb_CusSize.Text+"'";
            cmd.Connection = Connections.Con;
            SqlDataReader DR = cmd.ExecuteReader();

            if(DR.Read())
            {
                SharedContent.ProductId = (int)DR["Cush_Id"];
                SharedContent.ProductName = DR.GetString(DR.GetOrdinal("Cush_Name"));
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
            tb_CusPrice.Text = Convert.ToString(SharedContent.ProductPrice);

            Connections.Con_Close();
        }
    }
}
