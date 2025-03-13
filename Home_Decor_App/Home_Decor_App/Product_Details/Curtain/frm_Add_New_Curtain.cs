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
    public partial class frm_Add_New_Curtain : Form
    {
        public frm_Add_New_Curtain()
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
            tb_Cur_ID.Text = Convert.ToString(SharedContent.Auto_Increment("Curtain_Details", "Cur_Id", 2001));
            tb_Cur_Name.Clear();
            cmb_Cur_Company.SelectedIndex = -1;
            cmb_Cur_Material.SelectedIndex = -1;
            cmb_Cur_Style.SelectedIndex = -1;
            cmb_Size.SelectedIndex = -1;
            tb_Cur_Details.Clear();
            tb_Cur_Purchase_Price.Clear();
            tb_Cur_Sales_Price.Clear();
            cmb_Supplier.SelectedIndex = -1;
        }
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Connections.Con_Open();

            if(tb_Cur_ID.Text != "" && tb_Cur_Name.Text != "" && cmb_Cur_Company.Text != "" && cmb_Cur_Material.Text != "" && cmb_Cur_Style.Text != "" && cmb_Size.Text != "" && tb_Cur_Details.Text != "" && tb_Cur_Purchase_Price.Text != "" && tb_Cur_Sales_Price.Text != "" && cmb_Supplier.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();
                Cmd.CommandText = "Insert into Curtain_Details values(@id , @name , @cmp , @mat , @style , @size , @dtl , @pprice , @sprice , @sup , @cstock , @cuser , @status)";
                Cmd.Connection = Connections.Con;

                Cmd.Parameters.Add("id", SqlDbType.Int).Value = tb_Cur_ID.Text;
                Cmd.Parameters.Add("name", SqlDbType.NVarChar).Value = tb_Cur_Name.Text;
                Cmd.Parameters.Add("cmp", SqlDbType.NVarChar).Value = cmb_Cur_Company.Text;
                Cmd.Parameters.Add("mat", SqlDbType.VarChar).Value = cmb_Cur_Material.Text;
                Cmd.Parameters.Add("style", SqlDbType.VarChar).Value = cmb_Cur_Style.Text;
                Cmd.Parameters.Add("size", SqlDbType.NVarChar).Value = cmb_Size.Text;
                Cmd.Parameters.Add("dtl", SqlDbType.NVarChar).Value = tb_Cur_Details.Text;
                Cmd.Parameters.Add("pprice", SqlDbType.Money).Value = tb_Cur_Purchase_Price.Text;
                Cmd.Parameters.Add("sprice", SqlDbType.Money).Value = tb_Cur_Sales_Price.Text;
                Cmd.Parameters.Add("sup", SqlDbType.NVarChar).Value = cmb_Supplier.Text;
                Cmd.Parameters.Add("cstock", SqlDbType.Int).Value = 0;
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

        private void frm_Add_New_Curtain_Details_Load(object sender, EventArgs e)
        {
            tb_Cur_ID.Text = Convert.ToString(SharedContent.Auto_Increment("Curtain_Details", "Cur_Id", 2001));
            SharedContent.Bind_ComboBox("Name", cmb_Supplier, "select distinct(Name) from Supplier_Details");
        }
    }
}
