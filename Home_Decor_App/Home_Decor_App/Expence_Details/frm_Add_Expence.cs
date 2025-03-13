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

namespace Home_Decor_App.Expence_Details
{
    public partial class frm_Add_Expence : Form
    {
        public frm_Add_Expence()
        {
            InitializeComponent();
        }

        void Clear_Controls()
        {
            tb_E_Id.Text = Convert.ToString(SharedContent.Auto_Increment("Expense_Details", "Id", 1));
            tb_Expence_Details.Clear();
            tb_Amount_Paid.Clear();
            dtp_E_Date.Text = "";
            pb_Bill_Image.Image = null;
            cmb_Paid_By.SelectedIndex = -1;
        }
        private void frm_Add_Expence_Load(object sender, EventArgs e)
        {
            tb_E_Id.Text = Convert.ToString(SharedContent.Auto_Increment("Expense_Details", "Id", 1));
            SharedContent.Bind_ComboBox("Name", cmb_Paid_By, "Select distinct(Name) from Employee_Details");
        }

        private void btn_Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Filter = "Image Files(*.jpg;*.jpeg; *.png; *.gif; *.ico; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.ico; *.bmp";
            if(OFD.ShowDialog() == DialogResult.OK)
            {
                pb_Bill_Image.Image = new Bitmap(OFD.FileName);
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if(tb_Expence_Details.Text != "" && tb_Amount_Paid.Text != "" && pb_Bill_Image.Image != null &&cmb_Paid_By.Text != "")
            {
                Connections.Con_Open();
                SqlCommand Cmd = new SqlCommand();
                Cmd.CommandText = "Insert into Expense_Details values(@id , @detail , @amount , @date , @img , @paidby,@lu)";
                Cmd.Connection = Connections.Con;

                Cmd.Parameters.Add("id", SqlDbType.Int).Value = tb_E_Id.Text;
                Cmd.Parameters.Add("detail", SqlDbType.NVarChar).Value = tb_Expence_Details.Text;
                Cmd.Parameters.Add("amount", SqlDbType.Money).Value = tb_Amount_Paid.Text;
                Cmd.Parameters.Add("date", SqlDbType.Date).Value = dtp_E_Date.Text;
                Cmd.Parameters.Add("paidby", SqlDbType.NVarChar).Value = cmb_Paid_By.Text;
                Cmd.Parameters.Add("lu", SqlDbType.Int).Value = SharedContent.User_Id;

                ImageConverter IC = new ImageConverter();
                byte[] imgArray = (byte[])IC.ConvertTo(pb_Bill_Image.Image, typeof(byte[]));

                Cmd.Parameters.Add("img", SqlDbType.Image).Value = imgArray;

                Cmd.ExecuteNonQuery();
                Connections.Con_Close();
                MessageBox.Show("Expense Details Saved Successfully.", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear_Controls();
            }
            else
            {
                MessageBox.Show("Please Fill All Fields !!!", "FAILURE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }
    }
}
