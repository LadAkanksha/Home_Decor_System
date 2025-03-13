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

namespace Home_Decor_App.Product_Details.Mattress
{
    public partial class frm_Update_Mattress : Form
    {
        public frm_Update_Mattress()
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
            tb_M_Id.Enabled = false;
            tb_M_Name.Enabled = false;
            tb_M_Company.Enabled = false;
            tb_M_Material.Enabled = false;
            tb_M_Comfort.Enabled = false;
            tb_M_Size.Enabled = false;
            tb_M_Details.Enabled = true;
            tb_M_Purchase_Price.Enabled = true;
            tb_M_Sales_Price.Enabled = true;
        }
        void Disable_Controls()
        {
            btn_Search.Enabled = true;
            tb_M_Id.Focus();
            tb_M_Id.Enabled = true;
            tb_M_Name.Enabled = false;
            tb_M_Company.Enabled = false;
            tb_M_Material.Enabled = false;
            tb_M_Comfort.Enabled = false;
            tb_M_Size.Enabled = false;
            tb_M_Details.Enabled = false;
            tb_M_Purchase_Price.Enabled = false;
            tb_M_Sales_Price.Enabled = false;
        }
        void Clear_Controls()
        {
            tb_M_Id.Clear();
            tb_M_Name.Clear();
            tb_M_Company.Clear();
            tb_M_Material.Clear();
            tb_M_Comfort.Clear();
            tb_M_Size.Clear();
            tb_M_Details.Clear();
            tb_M_Purchase_Price.Clear();
            tb_M_Sales_Price.Clear();
        }
        private void frm_Update_Mattress_Load(object sender, EventArgs e)
        {
            Disable_Controls();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if(tb_M_Id.Text != "")
            {
                Connections.Con_Open();

                SqlCommand Cmd = new SqlCommand("Select * from Mattress_Details where M_Id = '" + tb_M_Id.Text + "'", Connections.Con);

                SqlDataReader DR = Cmd.ExecuteReader();

                if(DR.Read())
                {
                    tb_M_Name.Text = DR.GetString(DR.GetOrdinal("M_Name"));
                    tb_M_Company.Text = DR.GetString(DR.GetOrdinal("Company"));
                    tb_M_Material.Text = DR.GetString(DR.GetOrdinal("Material"));
                    tb_M_Comfort.Text = DR.GetString(DR.GetOrdinal("Comfort"));
                    tb_M_Size.Text = DR.GetString(DR.GetOrdinal("Size"));
                    tb_M_Details.Text = DR.GetString(DR.GetOrdinal("Details"));
                    tb_M_Purchase_Price.Text = (DR["Purchase_Price"].ToString());
                    tb_M_Sales_Price.Text = (DR["Sales_Price"].ToString());
                    Enable_Controls();
                }
                else
                {
                    MessageBox.Show("No Details Are Found !!!", "FALURE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tb_M_Id.Clear();
                }    

                Connections.Con_Close();
            }
            else
            {
                MessageBox.Show("Please Fill The ID !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_M_Details.Focus();
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (tb_M_Id.Text != "" && tb_M_Name.Text != "" && tb_M_Company.Text != "" && tb_M_Material.Text != "" && tb_M_Comfort.Text != "" && tb_M_Size.Text != "" && tb_M_Details.Text != "" && tb_M_Purchase_Price.Text != "" && tb_M_Sales_Price.Text != "")
            {
                Connections.Con_Open();
                SqlCommand Cmd = new SqlCommand();
                Cmd.CommandText = "Update Mattress_Details set M_Name = '" + tb_M_Name.Text + "' , Company = '" + tb_M_Company.Text + "' , Material = '" + tb_M_Material.Text + "' , Comfort = '" + tb_M_Comfort.Text + "' , Size = '" + tb_M_Size.Text + "' , Details = '" + tb_M_Details.Text + "' , Purchase_Price = '" + tb_M_Purchase_Price.Text + "' , Sales_Price = '" + tb_M_Sales_Price.Text + "' where M_Id = '" + tb_M_Id.Text + "'";
                Cmd.Connection = Connections.Con;

                Cmd.ExecuteNonQuery();
                MessageBox.Show("Mattress Updated Successfully.", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
