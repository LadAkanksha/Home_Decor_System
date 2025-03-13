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

namespace Home_Decor_App.Supplier_Details
{
    public partial class frm_Update_Supplier_Details : Form
    {
        public frm_Update_Supplier_Details()
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
        void Clear_Controls()
        {
            tb_S_ID.Clear();
            tb_S_Name.Clear();
            tb_S_Mob_No.Clear();
            tb_S_AMob_No.Clear();
            tb_S_Address.Clear();
            tb_S_Email.Clear();
            tb_S_Aadhar_No.Clear();
            tb_S_PAN_No.Clear();
            tb_S_Acc_No.Clear();
            tb_S_Bank_Details.Clear();
        }
        void Enable_Controls()
        {
            btn_Search.Enabled = false;
            tb_S_ID.Enabled = false;
            tb_S_Name.Enabled = true;
            tb_S_Mob_No.Enabled = true;
            tb_S_AMob_No.Enabled = true;
            tb_S_Address.Enabled = true;
            tb_S_Email.Enabled = true;
            tb_S_Aadhar_No.Enabled = false;
            tb_S_PAN_No.Enabled = false;
            tb_S_Acc_No.Enabled = true;
            tb_S_Bank_Details.Enabled = true;
        }
        void Disable_Controls()
        {
            btn_Search.Enabled = true;
            tb_S_ID.Focus();
            tb_S_ID.Enabled = true;
            tb_S_Name.Enabled = false;
            tb_S_Mob_No.Enabled = false;
            tb_S_AMob_No.Enabled = false;
            tb_S_Address.Enabled = false;
            tb_S_Email.Enabled = false;
            tb_S_Aadhar_No.Enabled = false;
            tb_S_PAN_No.Enabled = false;
            tb_S_Acc_No.Enabled = false;
            tb_S_Bank_Details.Enabled = false;
        }
        private void btn_Search_Click(object sender, EventArgs e)
        {
            if(tb_S_ID.Text != "")
            {
                Connections.Con_Open();
                SqlCommand cmd = new SqlCommand("select * from Supplier_Details where S_Id = '" + tb_S_ID.Text + "'", Connections.Con);

                SqlDataReader DR = cmd.ExecuteReader();

                if (DR.Read())
                {
                    tb_S_Name.Text = DR.GetString(DR.GetOrdinal("Name"));
                    tb_S_Mob_No.Text = (DR["Mob_No"].ToString());
                    tb_S_AMob_No.Text = (DR["AMob_No"].ToString());
                    tb_S_Address.Text = DR.GetString(DR.GetOrdinal("Office_Address"));
                    tb_S_Email.Text = DR.GetString(DR.GetOrdinal("Email_Id"));
                    tb_S_Aadhar_No.Text = (DR["Aadhar_No"].ToString());
                    tb_S_PAN_No.Text = DR.GetString(DR.GetOrdinal("PAN_No"));
                    tb_S_Acc_No.Text = (DR["Account_No"].ToString());
                    tb_S_Bank_Details.Text = DR.GetString(DR.GetOrdinal("Bank_Details"));
                    Enable_Controls();
                }
                else
                {
                    MessageBox.Show("Data Not Found !!!", "FAILURE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb_S_ID.Clear();
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

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if(tb_S_Name.Text != "" && tb_S_Mob_No.Text != "" && tb_S_AMob_No.Text != "" && tb_S_Address.Text != "" && tb_S_Email.Text != "" && tb_S_Aadhar_No.Text != "" && tb_S_PAN_No.Text != "" && tb_S_Acc_No.Text != "" && tb_S_Bank_Details.Text != "")
            {
                Connections.Con_Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "update Supplier_Details set Name = '" + tb_S_Name.Text + "' , Mob_No = '" + tb_S_Mob_No.Text + "' , AMob_No = '" + tb_S_AMob_No.Text + "' , Office_Address = '" + tb_S_Address.Text + "' , Aadhar_No = '" + tb_S_Aadhar_No.Text + "' , PAN_No = '" + tb_S_PAN_No.Text + "' , Email_Id = '" + tb_S_Email.Text + "' , Account_No = '" + tb_S_Acc_No.Text + "' , Bank_Details = '" + tb_S_Bank_Details.Text + "' where S_Id = '"+tb_S_ID.Text+"'";
                cmd.Connection = Connections.Con;

                cmd.ExecuteNonQuery();
                MessageBox.Show("Supplier Updated Successfully.", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear_Controls();
                Disable_Controls();
                Connections.Con_Close();
            }
            else
            {
                MessageBox.Show("Please Fill All Fields", "FAILURE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
            Disable_Controls();
        }

        private void frm_Update_Supplier_Details_Load(object sender, EventArgs e)
        {
            Clear_Controls();
            Disable_Controls();
        }
    }
}
