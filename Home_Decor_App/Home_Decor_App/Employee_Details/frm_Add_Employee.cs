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
    public partial class frm_Add_Employee : Form
    {
        public frm_Add_Employee()
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
            tb_E_ID.Text = Convert.ToString(SharedContent.Auto_Increment("Employee_Details", "E_Id", 8001));
            tb_E_Name.Clear();
            tb_E_Mob_No.Clear();
            tb_E_AMob_No.Clear();
            cmb_E_Designation.SelectedIndex = -1;
            tb_E_Address.Clear();
            dtp_E_Date.Text = "";
            tb_E_Aadhar_No.Clear();
            tb_E_PAN_No.Clear();
            tb_E_Email.Clear();
            tb_E_Acc_No.Clear();
            tb_E_Bank_Details.Clear();
        }

        private void frm_Add_Employee_Load(object sender, EventArgs e)
        {
            tb_E_ID.Text = Convert.ToString(SharedContent.Auto_Increment("Employee_Details", "E_Id", 8001));
            SharedContent.Bind_ComboBox("Role", cmb_E_Designation, "select distinct(Role) from Employee_Details");
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Connections.Con_Open();

            if (tb_E_ID.Text != "" && tb_E_Name.Text != "" && tb_E_Mob_No.Text != "" && cmb_E_Designation.Text != "" && tb_E_Address.Text != "" && dtp_E_Date.Text != "" && tb_E_Aadhar_No.Text != "" && tb_E_PAN_No.Text != "" && tb_E_Email.Text != "" && tb_E_Acc_No.Text != "" && tb_E_Bank_Details.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();
                Cmd.CommandText = "insert into Employee_Details values(@id,@nm,@mno,@amno,@post,@adress,@date,@Adhar,@pan,@email,@accno,@bdetail,@lu,@status)";
                Cmd.Connection = Connections.Con;

                Cmd.Parameters.Add("id", SqlDbType.Int).Value = tb_E_ID.Text;
                Cmd.Parameters.Add("nm", SqlDbType.NVarChar).Value = tb_E_Name.Text;
                Cmd.Parameters.Add("mno", SqlDbType.Decimal).Value = tb_E_Mob_No.Text;
                Cmd.Parameters.Add("amno", SqlDbType.Decimal).Value = tb_E_AMob_No.Text;
                Cmd.Parameters.Add("post", SqlDbType.VarChar).Value = cmb_E_Designation.Text;
                Cmd.Parameters.Add("adress", SqlDbType.NVarChar).Value = tb_E_Address.Text;
                Cmd.Parameters.Add("date", SqlDbType.Date).Value = dtp_E_Date.Text;
                Cmd.Parameters.Add("adhar", SqlDbType.Decimal).Value = tb_E_Aadhar_No.Text;
                Cmd.Parameters.Add("pan", SqlDbType.NVarChar).Value = tb_E_PAN_No.Text;
                Cmd.Parameters.Add("email", SqlDbType.NVarChar).Value = tb_E_Email.Text;
                Cmd.Parameters.Add("accno", SqlDbType.Decimal).Value = tb_E_Acc_No.Text;
                Cmd.Parameters.Add("bdetail", SqlDbType.NVarChar).Value = tb_E_Bank_Details.Text;
                Cmd.Parameters.Add("lu", SqlDbType.Int).Value = SharedContent.User_Id;
                Cmd.Parameters.Add("status", SqlDbType.Int).Value = 1;

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
