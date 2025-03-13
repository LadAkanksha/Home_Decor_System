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
    public partial class frm_Update_User : Form
    {
        public frm_Update_User()
        {
            InitializeComponent();
        }

        void Clear_Controls()
        {
            cmb_User_Role.SelectedIndex = -1;
            cmb_Username.SelectedIndex = -1;
            tb_Password.Clear();
            tb_Confirm_Password.Clear();
        }

        private void frm_Update_User_Load(object sender, EventArgs e)
        {
            SharedContent.Bind_ComboBox("Role", cmb_User_Role, "select distinct(Role) from Employee_Details");
        }

        private void cmb_User_Role_SelectedIndexChanged(object sender, EventArgs e)
        {
            SharedContent.Bind_ComboBox("Username", cmb_Username, "select distinct(Username) from Login_Details where Role = '" + cmb_User_Role.Text + "'");
        }
        int CheckPassword()
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

        private void btn_Update_Click(object sender, EventArgs e)
        {
            int check = CheckPassword();
            if(cmb_User_Role.Text != "" && cmb_Username.Text != "" && tb_Password.Text != "" && check == 1)
            {
                Connections.Con_Open();
                SqlCommand cmd = new SqlCommand("update Login_Details set Password = '" + tb_Password.Text + "' where Role = '" + cmb_User_Role.Text + "' and Username = '" + cmb_Username.Text + "'", Connections.Con);

                cmd.ExecuteNonQuery();
                MessageBox.Show("User Update Successfully", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear_Controls();
                Connections.Con_Close();
            }
            else
            {
                MessageBox.Show("Please Fill All Fields !!!", "FAILURE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
