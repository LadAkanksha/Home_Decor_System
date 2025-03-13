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

namespace Home_Decor_App.Product_Details.Curtain
{
    public partial class frm_Update_Curtain : Form
    {
        public frm_Update_Curtain()
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
            tb_Cur_Id.Enabled = false;
            tb_Cur_Name.Enabled = false ;
            tb_Cur_Company.Enabled = false;
            tb_Cur_Material.Enabled = false;
            tb_Cur_Style.Enabled = false;
            tb_Cur_Size.Enabled = false;
            tb_Cur_Details.Enabled = true;
            tb_Cur_Purchase_Price.Enabled = true;
            tb_Cur_Sales_Price.Enabled = true;
        }
        void Disable_Controls()
        {
            btn_Search.Enabled = true;
            tb_Cur_Id.Focus();
            tb_Cur_Id.Enabled = true;
            tb_Cur_Name.Enabled = false;
            tb_Cur_Company.Enabled = false;
            tb_Cur_Material.Enabled = false;
            tb_Cur_Style.Enabled = false;
            tb_Cur_Size.Enabled = false;
            tb_Cur_Details.Enabled = false;
            tb_Cur_Purchase_Price.Enabled = false;
            tb_Cur_Sales_Price.Enabled = false;
        }
        void Clear_Controls()
        {
            tb_Cur_Id.Clear();
            tb_Cur_Name.Clear();
            tb_Cur_Company.Clear();
            tb_Cur_Material.Clear();
            tb_Cur_Style.Clear();
            tb_Cur_Size.Clear();
            tb_Cur_Details.Clear();
            tb_Cur_Purchase_Price.Clear();
            tb_Cur_Sales_Price.Clear();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if(tb_Cur_Id.Text != "")
            {
                Connections.Con_Open();
                SqlCommand Cmd = new SqlCommand("Select * from Curtain_Details where Cur_Id = '"+tb_Cur_Id.Text+"'",Connections.Con);

                SqlDataReader DR = Cmd.ExecuteReader();

                if(DR.Read())
                {
                    tb_Cur_Name.Text = DR.GetString(DR.GetOrdinal("Cur_name"));
                    tb_Cur_Company.Text = DR.GetString(DR.GetOrdinal("Company"));
                    tb_Cur_Material.Text = DR.GetString(DR.GetOrdinal("Material"));
                    tb_Cur_Style.Text = DR.GetString(DR.GetOrdinal("Style"));
                    tb_Cur_Size.Text = DR.GetString(DR.GetOrdinal("Size"));
                    tb_Cur_Details.Text = DR.GetString(DR.GetOrdinal("Details"));
                    tb_Cur_Purchase_Price.Text = (DR["Purchase_Price"].ToString());
                    tb_Cur_Sales_Price.Text = (DR["Sales_Price"].ToString());
                    Enable_Controls();
                }
                else
                {
                    MessageBox.Show("No Details Are Found !!!", "FAILURE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tb_Cur_Id.Clear();
                    Disable_Controls();
                }
                Connections.Con_Close();
            }
            else
            {
                MessageBox.Show("Please Fill The ID !!!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Disable_Controls();
            }
        }
        private void frm_Update_Curtain_Details_Load(object sender, EventArgs e)
        {
            Disable_Controls();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (tb_Cur_Id.Text != "" && tb_Cur_Name.Text != "" && tb_Cur_Company.Text != "" && tb_Cur_Material.Text != "" && tb_Cur_Style.Text != "" && tb_Cur_Size.Text != "" && tb_Cur_Details.Text != "" && tb_Cur_Purchase_Price.Text != "" && tb_Cur_Sales_Price.Text != "")
            {
                Connections.Con_Open();
                SqlCommand Cmd = new SqlCommand();
                Cmd.CommandText = "Update Curtain_Details set Cur_Name = '"+tb_Cur_Name.Text+"' , Company = '"+tb_Cur_Company.Text+"' , Material = '"+tb_Cur_Material.Text+"' , Style = '"+tb_Cur_Style.Text+"' , Size = '"+tb_Cur_Size.Text+"' , Details = '"+tb_Cur_Details.Text+"' , Purchase_Price = '"+tb_Cur_Purchase_Price.Text+"' , Sales_Price = '"+tb_Cur_Sales_Price.Text+"' where Cur_Id = '"+tb_Cur_Id.Text+"'";
                Cmd.Connection = Connections.Con;

                Cmd.ExecuteNonQuery();
                MessageBox.Show("Curtain Updated Successfully.", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear_Controls();
                Disable_Controls();
                Connections.Con_Close();
            }
            else
            {
                MessageBox.Show("Please Fill All Fields !!!", "FAILURE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

       /* private void tb_Cur_Sales_Price_TextChanged(object sender, EventArgs e)
        {
            if(Convert.ToDouble(tb_Cur_Purchase_Price.Text) < Convert.ToDouble(tb_Cur_Sales_Price.Text))
            {
                MessageBox.Show("Purchase Price Must Be Less Than Purchase Price", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }*/
    }
}
