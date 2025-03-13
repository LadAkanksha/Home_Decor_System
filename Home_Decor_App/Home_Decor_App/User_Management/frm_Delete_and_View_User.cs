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
    public partial class frm_Delete_and_View_User : Form
    {
        public frm_Delete_and_View_User()
        {
            InitializeComponent();
        }
        void Clear_Controls()
        {
            tb_User_Role.Clear();
            tb_Username.Clear();
            tb_Confirm_Password.Clear();
            btn_Delete.Enabled = false;
        }

        private void frm_Delete_and_View_User_Load(object sender, EventArgs e)
        {
            SharedContent.Bind_Grid(dgv_User_Details, "Select Role , Username from Login_Details where Status = 'true'");
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if(tb_User_Role.Text != "" && tb_Username.Text != "")
            {
                btn_Delete.Enabled = true;
                DialogResult DR = MessageBox.Show("Are You Sure To Delete This User !!!", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if(DR == DialogResult.Yes)
                {
                    Connections.Con_Open();
                    SqlCommand cmd = new SqlCommand("update Login_Details set Status = 0 where Role = '" + tb_User_Role.Text + "' and Username = '" + tb_Username.Text + "'", Connections.Con);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Deleted Successfully !!!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SharedContent.Bind_Grid(dgv_User_Details,"Select Role , Username from Login_Details where status = 'true'");
                    
                    Clear_Controls();
                }
                else
                {
                    MessageBox.Show("Please Fill Required Data!!!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Clear_Controls();
                }
            }
        }

        private void tb_Confirm_Password_TextChanged(object sender, EventArgs e)
        {
            Connections.Con_Open();
            SqlCommand cmd = new SqlCommand("Select count(*) from Login_Details where Password = '"+tb_Confirm_Password.Text+"'",Connections.Con);

            int cnt = Convert.ToInt32(cmd.ExecuteScalar());

            if(cnt > 0)
            {
                btn_Delete.Enabled = true;
            }
            else
            {
                btn_Delete.Enabled = false;
            }
            /*if (tb_User_Role.Text != "" && tb_Username.Text != "" && tb_Confirm_Password.Text == "1234")
            {
                btn_Delete.Enabled = true;
            }*/
        }

        private void dgv_User_Details_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int SelectedRowCount = dgv_User_Details.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (SelectedRowCount == 1)
            {
                int Row_Index = dgv_User_Details.SelectedCells[0].RowIndex;
                string Role = Convert.ToString(dgv_User_Details.Rows[Row_Index].Cells[0].Value);
                string Username = Convert.ToString(dgv_User_Details.Rows[Row_Index].Cells[1].Value);

                tb_User_Role.Text = Role;
                tb_Username.Text = Username;
            }
        }
    }
}
