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

namespace Home_Decor_App.Product_Details.Pillow
{
    public partial class frm_Update_Pillow : Form
    {
        public frm_Update_Pillow()
        {
            InitializeComponent();
        }
        private void Numeric(object sender, KeyPressEventArgs e)
        {
            SharedContent.Only_Numeric(e);
        }
        private void Letter(object sender, KeyPressEventArgs e)
        {
            SharedContent.Only_Text(e);

        }
        void Enable_Controls()
        {
            btn_Search.Enabled = false;
            tb_P_Id.Enabled = false;
            tb_P_Name.Enabled = false;
            tb_P_Company.Enabled = false;
            tb_P_Material.Enabled = false;
            tb_P_Comfort.Enabled = false;
            tb_P_Size.Enabled = false;
            tb_P_Details.Enabled = true;
            tb_P_Purchase_Price.Enabled = true;
            tb_P_Sales_Price.Enabled = true;
        }
        void Disable_Controls()
        {
            btn_Search.Enabled = true;
            tb_P_Id.Focus();
            tb_P_Id.Enabled = true;
            tb_P_Name.Enabled = false;
            tb_P_Company.Enabled = false;
            tb_P_Material.Enabled = false;
            tb_P_Comfort.Enabled = false;
            tb_P_Size.Enabled = false;
            tb_P_Details.Enabled = false;
            tb_P_Purchase_Price.Enabled = false;
            tb_P_Sales_Price.Enabled = false;
        }
        void Clear_Controls()
        {
            tb_P_Id.Clear();
            tb_P_Name.Clear();
            tb_P_Company.Clear();
            tb_P_Material.Clear();
            tb_P_Comfort.Clear();
            tb_P_Size.Clear();
            tb_P_Details.Clear();
            tb_P_Purchase_Price.Clear();
            tb_P_Sales_Price.Clear();
        }
        private void frm_Update_Pillow_Load(object sender, EventArgs e)
        {
            Disable_Controls();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (tb_P_Id.Text != "")
            {
                Connections.Con_Open();

                SqlCommand Cmd = new SqlCommand("Select * from Pillow_Details where P_Id = '" + tb_P_Id.Text + "'", Connections.Con);

                SqlDataReader DR = Cmd.ExecuteReader();

                if (DR.Read())
                {
                    tb_P_Name.Text = DR.GetString(DR.GetOrdinal("P_Name"));
                    tb_P_Company.Text = DR.GetString(DR.GetOrdinal("Company"));
                    tb_P_Material.Text = DR.GetString(DR.GetOrdinal("Material"));
                    tb_P_Comfort.Text = DR.GetString(DR.GetOrdinal("Comfort"));
                    tb_P_Size.Text = DR.GetString(DR.GetOrdinal("Size"));
                    tb_P_Details.Text = DR.GetString(DR.GetOrdinal("Details"));
                    tb_P_Purchase_Price.Text = (DR["Purchase_Price"].ToString());
                    tb_P_Sales_Price.Text = (DR["Sales_Price"].ToString());
                    Enable_Controls();
                }
                else
                {
                    MessageBox.Show("No Details Are Found !!!", "FALURE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tb_P_Id.Clear();
                    Disable_Controls();
                }

                Connections.Con_Close();
            }
            else
            {
                MessageBox.Show("Please Fill The ID !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_P_Id.Focus();
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (tb_P_Id.Text != "" && tb_P_Name.Text != "" && tb_P_Company.Text != "" && tb_P_Material.Text != "" && tb_P_Comfort.Text != "" && tb_P_Size.Text != "" && tb_P_Details.Text != "" && tb_P_Purchase_Price.Text != "" && tb_P_Sales_Price.Text != "")
            {
                Connections.Con_Open();
                SqlCommand Cmd = new SqlCommand();
                Cmd.CommandText = "Update Pillow_Details set P_Name = '" + tb_P_Name.Text + "' , Company = '" + tb_P_Company.Text + "' , Material = '" + tb_P_Material.Text + "' , Comfort = '" + tb_P_Comfort.Text + "' , Size = '" + tb_P_Size.Text + "' , Details = '" + tb_P_Details.Text + "' , Purchase_Price = '" + tb_P_Purchase_Price.Text + "' , Sales_Price = '" + tb_P_Sales_Price.Text + "' where P_Id = '" + tb_P_Id.Text + "'";
                Cmd.Connection = Connections.Con;

                Cmd.ExecuteNonQuery();
                MessageBox.Show("Pillow Updated Successfully.", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear_Controls();
                Disable_Controls();
            }
            else
            {
                MessageBox.Show("Please Fill All Fields !!!", "FAILURE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
