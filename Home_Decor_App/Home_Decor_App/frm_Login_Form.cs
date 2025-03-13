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

namespace Home_Decor_App
{
    public partial class frm_Login_Form : Form
    {
        public frm_Login_Form()
        {
            InitializeComponent();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            Connections.Con_Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select count(*) from Login_Details where Role = @role and Username = @unm and Password = @pwd";
            cmd.Connection = Connections.Con;

            cmd.Parameters.Add("role", SqlDbType.VarChar).Value = cmb_User_Role.Text;
            cmd.Parameters.Add("unm", SqlDbType.NVarChar).Value = cmb_Username.Text;
            cmd.Parameters.Add("pwd", SqlDbType.NVarChar).Value = tb_Password.Text;

            int cnt = Convert.ToInt32(cmd.ExecuteScalar());

            if(cnt > 0)
            {
                SharedContent.Login_User = cmb_Username.Text;
                SharedContent.User_Role = cmb_User_Role.Text;
                SharedContent.Generate_Id();
                MessageBox.Show("Login Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frm_MDI main = new frm_MDI();
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Username / Password", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            cmb_User_Role.SelectedIndex = -1;
            cmb_Username.SelectedIndex = -1;
            tb_Password.Clear();
            cmb_Username.Focus();
        }

        private void frm_Login_Form_Load(object sender, EventArgs e)
        {
            SharedContent.Bind_ComboBox("Role",cmb_User_Role,"select distinct(Role) from Employee_Details");
            cmb_User_Role.SelectedIndex = 0;
            cmb_Username.SelectedIndex = 0;
            cmb_User_Role.Focus();
        }

        private void cmb_User_Role_SelectedIndexChanged(object sender, EventArgs e)
        {
            SharedContent.Bind_ComboBox("Username", cmb_Username, "select distinct(Username) from Login_Details where Role = '" + cmb_User_Role.Text + "' and status = 'true'");
        }
    }
}
