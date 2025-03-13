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

namespace Home_Decor_App.User_Management
{
    public partial class frm_Add_User : Form
    {
        public frm_Add_User()
        {
            InitializeComponent();
        }

        void Clear_Controls()
        {
            cmb_User_Role.SelectedIndex = -1;
            tb_Username.Text = "";
            tb_Password.Text = "";
            tb_Confirm_Password.Text = "";
        }

        private void frm_Add_User_Load(object sender, EventArgs e)
        {
            SharedContent.Bind_ComboBox("Role", cmb_User_Role, "select distinct(Role) from Employee_Details");
        }

        int Check_Password()
        {
            if (tb_Password.Text != tb_Confirm_Password.Text)
            {
                MessageBox.Show("Mismatch Password!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_Confirm_Password.Text = "";
                tb_Confirm_Password.Focus();
                return 0;
            }
            return 1;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            int check = Check_Password();

            if (cmb_User_Role.Text != "" && tb_Username.Text != "" && tb_Password.Text != "" && check == 1)
            {
                Connections.Con_Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "insert into Login_Details values(@role , @unm , @pwd,@sts)";
                cmd.Connection = Connections.Con;

                cmd.Parameters.Add("role", SqlDbType.VarChar).Value = cmb_User_Role.Text;
                cmd.Parameters.Add("unm", SqlDbType.NVarChar).Value = tb_Username.Text;
                cmd.Parameters.Add("pwd", SqlDbType.NVarChar).Value = tb_Password.Text;
                cmd.Parameters.Add("sts", SqlDbType.Bit).Value = true;

                cmd.ExecuteNonQuery();
                cmd.Dispose();

                MessageBox.Show("User Saved Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear_Controls();
                Connections.Con_Close();
            }
            else
            {
                MessageBox.Show("Please Fill All Fields !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tb_Password_TextChanged(object sender, EventArgs e)
        {
            Connections.Con_Open();
            SqlCommand cmd = new SqlCommand("select count(*) from Login_Details where Username = '" + tb_Username.Text + "'", Connections.Con);

            int cnt = Convert.ToInt32(cmd.ExecuteScalar());

            if (cnt > 0)
            {
                MessageBox.Show("This Username is already exist !!!\nPlease Change Username.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_Username.Clear();
                tb_Password.Clear();
                tb_Username.Focus();
            }
            Connections.Con_Close();
        }
    }
}
