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
    public partial class frm_Add_Supplier : Form
    {
        public frm_Add_Supplier()
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
        public void Clear_Controls()
        {
            tb_S_ID.Text = Convert.ToString(SharedContent.Auto_Increment("Supplier_Details", "S_Id", 7001));
            tb_S_Name.Clear();
            tb_S_Mob_No.Clear();
            tb_S_AMob_No.Clear();
            tb_S_Address.Clear();
            dtp_S_Date.Text="";
            tb_S_Aadhar_No.Clear();
            tb_S_PAN_No.Clear();
            tb_S_Email.Clear();
            tb_S_Acc_No.Clear();
            tb_S_Bank_Details.Clear();
        }
        private void frm_Add_Supplier_Load(object sender, EventArgs e)
        {
            tb_S_ID.Text = Convert.ToString(SharedContent.Auto_Increment("Supplier_Details", "S_Id", 7001));
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            Connections.Con_Open();

            if(tb_S_ID.Text != "" && tb_S_Name.Text != "" && tb_S_Mob_No.Text != "" && tb_S_Address.Text != "" && dtp_S_Date.Text != "" && tb_S_Aadhar_No.Text != "" && tb_S_PAN_No.Text != "" && tb_S_Email.Text != "" && tb_S_Acc_No.Text != "" && tb_S_Bank_Details.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();
                Cmd.CommandText = "insert into Supplier_Details values(@id,@nm,@mno,@amno,@adress,@date,@Adhar,@pan,@email,@accno,@bdetail,@lu)";
                Cmd.Connection = Connections.Con;

                Cmd.Parameters.Add("id", SqlDbType.Int).Value = tb_S_ID.Text;
                Cmd.Parameters.Add("nm", SqlDbType.NVarChar).Value = tb_S_Name.Text;
                Cmd.Parameters.Add("mno", SqlDbType.Decimal).Value = tb_S_Mob_No.Text;
                Cmd.Parameters.Add("amno", SqlDbType.Decimal).Value = tb_S_AMob_No.Text;
                Cmd.Parameters.Add("adress", SqlDbType.NVarChar).Value = tb_S_Address.Text;
                Cmd.Parameters.Add("date", SqlDbType.Date).Value = dtp_S_Date.Text;
                Cmd.Parameters.Add("adhar", SqlDbType.Decimal).Value = tb_S_Aadhar_No.Text;
                Cmd.Parameters.Add("pan", SqlDbType.NVarChar).Value = tb_S_PAN_No.Text;
                Cmd.Parameters.Add("email", SqlDbType.NVarChar).Value = tb_S_Email.Text;
                Cmd.Parameters.Add("accno", SqlDbType.Decimal).Value = tb_S_Acc_No.Text;
                Cmd.Parameters.Add("bdetail", SqlDbType.NVarChar).Value = tb_S_Bank_Details.Text;
                Cmd.Parameters.Add("lu", SqlDbType.Int).Value = SharedContent.User_Id;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Data Successfully Saved", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear_Controls();
            }
            else
            {
                MessageBox.Show("Something went Wrong !!! \nData not Saved", "FAILURE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
                Connections.Con_Close();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void Alphanumeric(object sender, KeyPressEventArgs e)
        {
            SharedContent.Only_AlphaNumeric(e);
        }
    }
}
