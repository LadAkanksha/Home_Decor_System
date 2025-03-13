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

namespace Home_Decor_App.Product_Details.Cushion
{
    public partial class frm_Update_Cushion : Form
    {
        public frm_Update_Cushion()
        {
            InitializeComponent();
        }
        void Enable_Controls()
        {
            btn_Search.Enabled = false;
            tb_Cus_Id.Enabled = false;
            tb_Cus_Name.Enabled = false;
            tb_Cus_Company.Enabled = false;
            tb_Cus_Material.Enabled = false;
            tb_Cus_Comfort.Enabled = false;
            tb_Cus_Size.Enabled = false;
            tb_Cus_Details.Enabled = true;
            tb_Cus_Purchase_Price.Enabled = true;
            tb_Cus_Sales_Price.Enabled = true;
        }
        void Disable_Controls()
        {
            btn_Search.Enabled = true;
            tb_Cus_Id.Focus();
            tb_Cus_Id.Enabled = true;
            tb_Cus_Name.Enabled = false;
            tb_Cus_Company.Enabled = false;
            tb_Cus_Material.Enabled = false;
            tb_Cus_Comfort.Enabled = false;
            tb_Cus_Size.Enabled = false;
            tb_Cus_Details.Enabled = false;
            tb_Cus_Purchase_Price.Enabled = false;
            tb_Cus_Sales_Price.Enabled = false;
        }
        void Clear_Controls()
        {
            tb_Cus_Id.Clear();
            tb_Cus_Name.Clear();
            tb_Cus_Company.Clear();
            tb_Cus_Material.Clear();
            tb_Cus_Comfort.Clear();
            tb_Cus_Size.Clear();
            tb_Cus_Details.Clear();
            tb_Cus_Purchase_Price.Clear();
            tb_Cus_Sales_Price.Clear();
        }
        private void frm_Update_Cushion_Load(object sender, EventArgs e)
        {
            Disable_Controls();
        }
        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (tb_Cus_Id.Text != "")
            {
                Connections.Con_Open();
                SqlCommand Cmd = new SqlCommand("select * from Cushion_Details where Cush_Id = '" + tb_Cus_Id.Text + "'", Connections.Con);

                SqlDataReader DR = Cmd.ExecuteReader();

                if (DR.Read())
                {
                    tb_Cus_Name.Text = DR.GetString(DR.GetOrdinal("Cush_Name"));
                    tb_Cus_Company.Text = DR.GetString(DR.GetOrdinal("Company"));
                    tb_Cus_Material.Text = DR.GetString(DR.GetOrdinal("Material"));
                    tb_Cus_Comfort.Text = DR.GetString(DR.GetOrdinal("Comfort"));
                    tb_Cus_Size.Text = DR.GetString(DR.GetOrdinal("Size"));
                    tb_Cus_Details.Text = DR.GetString(DR.GetOrdinal("Details"));
                    tb_Cus_Purchase_Price.Text = (DR["Purchase_Price"].ToString());
                    tb_Cus_Sales_Price.Text = (DR["Sales_Price"].ToString());
                    Enable_Controls();
                }
                else
                {
                    MessageBox.Show("No Details Are Found !!!", "FAILURE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tb_Cus_Id.Clear();
                    Disable_Controls();
                }
                Connections.Con_Close();
            }
            else
            {
                MessageBox.Show("Please Fill The ID !!!", "FAILURE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (tb_Cus_Id.Text != "" && tb_Cus_Name.Text != "" && tb_Cus_Company.Text != "" && tb_Cus_Material.Text != "" && tb_Cus_Comfort.Text != "" && tb_Cus_Size.Text != "" && tb_Cus_Details.Text != "" && tb_Cus_Purchase_Price.Text != "" && tb_Cus_Sales_Price.Text != "")
            {
                Connections.Con_Open();
                SqlCommand Cmd = new SqlCommand();
                Cmd.CommandText = "Update Cushion_Details set Cush_Name = '" + tb_Cus_Name.Text + "' , Company = '" + tb_Cus_Company.Text + "' , Material = '" + tb_Cus_Material.Text + "' , Comfort = '" + tb_Cus_Comfort.Text + "' , Size = '" + tb_Cus_Size.Text + "' , Details = '" + tb_Cus_Details.Text + "' , Purchase_Price = '" + tb_Cus_Purchase_Price.Text + "' , Sales_Price = '" + tb_Cus_Sales_Price.Text + "' where Cush_Id = '" + tb_Cus_Id.Text + "'";
                Cmd.Connection = Connections.Con;

                Cmd.ExecuteNonQuery();
                MessageBox.Show("Cushion Updated Successfully.", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear_Controls();
                Disable_Controls();
                Connections.Con_Close();
            }
            else
            {
                MessageBox.Show("Please Fill All Fields !!!", "FAILURE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Numeric(object sender, KeyPressEventArgs e)
        {
            SharedContent.Only_Numeric(e);
        }
    }
}
