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

namespace Home_Decor_App.Employee_Details
{
    public partial class frm_Update_Employee_Details : Form
    {
        public frm_Update_Employee_Details()
        {
            InitializeComponent();
        }

        private void Numeric(object sender, KeyPressEventArgs e)
        {
            SharedContent.Only_Numeric(e);
        }

        void Clear_Controls()
        {
            tb_E_ID.Clear();
            tb_E_Name.Clear();
            tb_E_Mob_No.Clear();
            tb_E_AMob_No.Clear();
            tb_E_Address.Clear();
            tb_E_Aadhar_No.Clear();
            tb_E_PAN_No.Clear();
            tb_E_Email.Clear();
            tb_E_Acc_No.Clear();
            tb_E_Bank_Details.Clear();
        }
        void Enable_Controls()
        {
            btn_Search.Enabled = false;
            tb_E_ID.Enabled = false;
            tb_E_Name.Enabled = true;
            tb_E_Mob_No.Enabled = true;
            tb_E_AMob_No.Enabled = true;
            tb_E_Address.Enabled = true;
            tb_E_Email.Enabled = true;
            tb_E_Aadhar_No.Enabled = false;
            tb_E_PAN_No.Enabled = false;
            tb_E_Acc_No.Enabled = true;
            tb_E_Bank_Details.Enabled = true;
        }
        void Disable_Controls()
        {
            btn_Search.Enabled = true;
            tb_E_ID.Focus();
            tb_E_ID.Enabled = true;
            tb_E_Name.Enabled = false;
            tb_E_Mob_No.Enabled = false;
            tb_E_AMob_No.Enabled = false;
            tb_E_Address.Enabled = false;
            tb_E_Email.Enabled = false;
            tb_E_Aadhar_No.Enabled = false;
            tb_E_PAN_No.Enabled = false;
            tb_E_Acc_No.Enabled = false;
            tb_E_Bank_Details.Enabled = false;
        }
        private void frm_Update_Employee_Details_Load(object sender, EventArgs e)
        {
            Disable_Controls();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Connections.Con_Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from Employee_Details where E_Id = '" + tb_E_ID.Text + "'";
            cmd.Connection = Connections.Con;

            SqlDataReader DR = cmd.ExecuteReader();

            if(DR.Read())
            {
                tb_E_Name.Text = DR.GetString(DR.GetOrdinal("Name"));
                tb_E_Mob_No.Text = (DR["Mob_No"].ToString());
                tb_E_AMob_No.Text = (DR["AMob_No"].ToString());
                tb_E_Address.Text = DR.GetString(DR.GetOrdinal("Address"));
                tb_E_Email.Text = DR.GetString(DR.GetOrdinal("Email_Id"));
                tb_E_Aadhar_No.Text = (DR["Aadhar_No"].ToString());
                tb_E_PAN_No.Text = DR.GetString(DR.GetOrdinal("PAN_No"));
                tb_E_Acc_No.Text = (DR["Account_No"].ToString());
                tb_E_Bank_Details.Text = DR.GetString(DR.GetOrdinal("Bank_Details"));

                Enable_Controls();
            }
            else
            {
                MessageBox.Show("No Details Found !!!", "FAILURE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_E_ID.Clear();
            }
            Connections.Con_Close();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if(tb_E_Name.Text != "" && tb_E_Mob_No.Text != "" && tb_E_AMob_No.Text != "" && tb_E_Address.Text != "" && tb_E_Email.Text != "" && tb_E_Aadhar_No.Text != "" && tb_E_PAN_No.Text != "" && tb_E_Acc_No.Text != "" && tb_E_Bank_Details.Text != "")
            {
                Connections.Con_Open();
                SqlCommand cmd = new SqlCommand("update Employee_Details set Name = @nm , Mob_No = @mn , AMob_No = @amn , Address = @ad , Email_Id = @ei , Aadhar_No = @an , PAN_No = @pn , Account_No = @accn , Bank_Details = @bd where E_Id = @id", Connections.Con);

                cmd.Parameters.Add("id", SqlDbType.Int).Value = tb_E_ID.Text;
                cmd.Parameters.Add("nm", SqlDbType.VarChar).Value = tb_E_Name.Text;
                cmd.Parameters.Add("mn",SqlDbType.Decimal).Value = tb_E_Mob_No.Text;
                cmd.Parameters.Add("amn", SqlDbType.Decimal).Value = tb_E_AMob_No.Text;
                cmd.Parameters.Add("ad",SqlDbType.NVarChar).Value = tb_E_Address.Text;
                cmd.Parameters.Add("ei",SqlDbType.NVarChar).Value = tb_E_Email.Text;
                cmd.Parameters.Add("an",SqlDbType.Decimal).Value = tb_E_Aadhar_No.Text;
                cmd.Parameters.Add("pn",SqlDbType.NVarChar).Value = tb_E_PAN_No.Text;
                cmd.Parameters.Add("accn",SqlDbType.Decimal).Value = tb_E_Acc_No.Text;
                cmd.Parameters.Add("bd",SqlDbType.NVarChar).Value = tb_E_Bank_Details.Text;

                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee Updated Successfully.", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Disable_Controls();
                Clear_Controls();
                Connections.Con_Close();
            }
            else
            {
                MessageBox.Show("Please Fill All Fields !!!", "FAILURE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
            Disable_Controls();
        }
    }
}
