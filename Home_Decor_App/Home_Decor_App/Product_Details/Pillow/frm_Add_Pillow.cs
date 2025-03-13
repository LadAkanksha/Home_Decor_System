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

namespace Home_Decor_App.Product_Details.Pillow
{
    public partial class frm_Add_Pillow : Form
    {
        public frm_Add_Pillow()
        {
            InitializeComponent();
        }

        public static int Curr_Stock = 0;
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
            tb_P_ID.Text = Convert.ToString(SharedContent.Auto_Increment("Pillow_Details", "P_Id", 5001));
            tb_P_Name.Clear();
            cmb_P_Company.SelectedIndex = -1;
            cmb_P_Material.SelectedIndex = -1;
            cmb_P_Comfort.SelectedIndex = -1;
            cmb_P_Size.SelectedIndex = -1;
            tb_P_Details.Clear();
            tb_P_Purchase_Price.Clear();
            tb_P_Sales_Price.Clear();
            cmb_Supplier.SelectedIndex = -1;
        }
        private void frm_Add_Pillow_Load(object sender, EventArgs e)
        {
            tb_P_ID.Text = Convert.ToString(SharedContent.Auto_Increment("Pillow_Details", "P_Id", 5001));
            SharedContent.Bind_ComboBox("Name", cmb_Supplier, "select distinct(Name) from Supplier_Details");
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Connections.Con_Open();

            if (tb_P_ID.Text != "" && tb_P_Name.Text != "" && cmb_P_Company.Text != "" && cmb_P_Material.Text != "" && cmb_P_Comfort.Text != "" && cmb_P_Size.Text != "" && tb_P_Details.Text != "" && tb_P_Purchase_Price.Text != "" && tb_P_Sales_Price.Text != "" && cmb_Supplier.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();
                Cmd.CommandText = "Insert into Pillow_Details values(@id , @name , @cmp , @mat , @comfort , @size , @dtl , @pprice , @sprice , @sup , @cstock , @cuser , @status)";
                Cmd.Connection = Connections.Con;

                Cmd.Parameters.Add("id", SqlDbType.Int).Value = tb_P_ID.Text;
                Cmd.Parameters.Add("name", SqlDbType.NVarChar).Value = tb_P_Name.Text;
                Cmd.Parameters.Add("cmp", SqlDbType.NVarChar).Value = cmb_P_Company.Text;
                Cmd.Parameters.Add("mat", SqlDbType.VarChar).Value = cmb_P_Material.Text;
                Cmd.Parameters.Add("comfort", SqlDbType.VarChar).Value = cmb_P_Comfort.Text;
                Cmd.Parameters.Add("size", SqlDbType.NVarChar).Value = cmb_P_Size.Text;
                Cmd.Parameters.Add("dtl", SqlDbType.NVarChar).Value = tb_P_Details.Text;
                Cmd.Parameters.Add("pprice", SqlDbType.Money).Value = tb_P_Purchase_Price.Text;
                Cmd.Parameters.Add("sprice", SqlDbType.Money).Value = tb_P_Sales_Price.Text;
                Cmd.Parameters.Add("sup", SqlDbType.NVarChar).Value = cmb_Supplier.Text;
                Cmd.Parameters.Add("cstock", SqlDbType.Int).Value = Curr_Stock;
                Cmd.Parameters.Add("cuser", SqlDbType.Int).Value = SharedContent.User_Id;
                Cmd.Parameters.Add("status", SqlDbType.Int).Value = 1;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Data Successfully Saved", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear_Controls();
            }
            else
            {
                MessageBox.Show("Please Fill All Fields", "FAILURE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Connections.Con_Close();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }
    }
}
