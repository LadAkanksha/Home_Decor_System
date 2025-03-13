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

namespace Home_Decor_App.Stock_Details
{
    public partial class frm_Payment_Details : Form
    {
        public frm_Payment_Details()
        {
            InitializeComponent();
        }
        public frm_Payment_Details(int id , string dt,double bill)
        {
            InitializeComponent();
            tb_RO_Id.Text = Convert.ToString(id);
            dtp_RO_Date.Text = dt;
            tb_Final_Bill.Text = Convert.ToString(bill);
            tb_Paid_Amount.Clear();
            tb_Balanced_Amount.Clear();
            tb_Paying_Amount.Clear();
            tb_Note.Clear();
            cmb_Mode.SelectedIndex = -1;
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
            tb_RO_Id.Clear();
            dtp_RO_Date.ResetText();
            tb_Payment_Id.Text = Convert.ToString(SharedContent.Auto_Increment("Payment_Details","Payment_Id",9001));
            dtp_P_Date.ResetText();
            tb_Final_Bill.Clear();
            tb_Paid_Amount.Clear();
            tb_Balanced_Amount.Clear();
            tb_Paying_Amount.Clear();
            tb_Note.Clear();
            cmb_Mode.SelectedIndex = -1;
        }
        void Disable_Controls()
        {
            tb_RO_Id.Enabled = true;
            dtp_RO_Date.Enabled = false;
            dtp_P_Date.Enabled = false;
            tb_Final_Bill.Enabled = false;
            tb_Paying_Amount.Enabled = false;
            tb_Note.Enabled = false;
            cmb_Mode.Enabled = false;
            btn_Save.Enabled = false;
        }

        void Enable_Controls()
        {
            tb_RO_Id.Enabled = false;
            dtp_P_Date.Enabled = true;
            tb_Paying_Amount.Enabled = true;
            tb_Note.Enabled = true;
            cmb_Mode.Enabled = true;
            btn_Save.Enabled = true;
        }
        private void frm_Payment_Details_Load(object sender, EventArgs e)
        {
            //tb_RO_Id.Focus();
            tb_Payment_Id.Text = Convert.ToString(SharedContent.Auto_Increment("Payment_Details", "Payment_Id", 9001));
            if (SharedContent.Flag == 3)
            {
                btn_Search.Visible = false;
                Connections.Con_Open();
                SqlCommand cmd = new SqlCommand("select Paid_Amount from Order_Details where Order_Id = '" + tb_RO_Id.Text + "'", Connections.Con);

                tb_Paid_Amount.Text = Convert.ToString(cmd.ExecuteScalar());

                Connections.Con_Close();
                tb_Balanced_Amount.Text = Convert.ToString(Convert.ToDouble(tb_Final_Bill.Text) - Convert.ToDouble(tb_Paid_Amount.Text));
            }
            else
            {
                btn_Search.Visible = true;
                Disable_Controls();
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if(tb_RO_Id.Text != "")
            {
                Connections.Con_Open();

                SqlCommand cmd = new SqlCommand("Select Final_Bill, Paid_Amount,Date from Order_Details where Order_Id = '" + tb_RO_Id.Text + "'", Connections.Con);

                SqlDataReader DR = cmd.ExecuteReader();
                if (DR.Read())
                {
                    double fbill = Convert.ToDouble(DR["Final_Bill"].ToString());
                    double paidAmount = Convert.ToDouble(DR["Paid_Amount"].ToString());
                    string Date = DR["Date"].ToString();                                       
                    if(fbill == paidAmount)
                    {
                        MessageBox.Show("Payment of This Order Is Already Complete.", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Disable_Controls();
                        btn_Save.Enabled = false;
                    }
                    else
                    {
                        dtp_RO_Date.Text = Convert.ToString(Date);
                        tb_Final_Bill.Text = fbill.ToString();
                        tb_Paid_Amount.Text = paidAmount.ToString();
                        tb_Balanced_Amount.Text = Convert.ToString(fbill - paidAmount);
                        Enable_Controls();
                    }
                }
                else
                {
                    MessageBox.Show("Data Not Found !!!", "FAILURE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb_RO_Id.Clear();
                    tb_RO_Id.Focus();
                    Clear_Controls();
                    Disable_Controls();
                }
                Connections.Con_Close();
            }
            else
            {
                MessageBox.Show("Please Fill The Received Id !!!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Disable_Controls();
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if(tb_RO_Id.Text != "" && tb_Paying_Amount.Text != "" && cmb_Mode.Text != "")
            {
                Connections.Con_Open();
                SqlCommand cmd = new SqlCommand("Insert into Payment_Details values(@id,@oid,@pdate,@fbill,@curramt,@note,@mode,@luser)", Connections.Con);

                cmd.Parameters.Add("@id", SqlDbType.Int).Value = tb_Payment_Id.Text;
                cmd.Parameters.Add("@oid", SqlDbType.Int).Value = tb_RO_Id.Text;
                cmd.Parameters.Add("@pdate", SqlDbType.Date).Value = dtp_P_Date.Text;
                cmd.Parameters.Add("@fbill", SqlDbType.Money).Value = tb_Final_Bill.Text;
                cmd.Parameters.Add("@curramt", SqlDbType.Money).Value = tb_Paying_Amount.Text;
                cmd.Parameters.Add("@note", SqlDbType.NVarChar).Value = tb_Note.Text;
                cmd.Parameters.Add("@mode", SqlDbType.NVarChar).Value = cmb_Mode.Text;
                cmd.Parameters.Add("@luser", SqlDbType.Int).Value = SharedContent.User_Id;

                cmd.ExecuteNonQuery();
                cmd.Dispose();

                double PaidAmount = Convert.ToDouble(tb_Paid_Amount.Text) + Convert.ToDouble(tb_Paying_Amount.Text);
                SqlCommand cmd1 = new SqlCommand("Update Order_Details Set Paid_Amount = '" + PaidAmount + "', Status = "+0+" where Order_Id = '" + tb_RO_Id.Text + "'", Connections.Con);

                cmd1.ExecuteNonQuery();

                Connections.Con_Close();

                MessageBox.Show("Payment Details Saved Successfully !!!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear_Controls();
            }
            else
            {
                MessageBox.Show("Something Went Wrong !!! Please Fill All Fields !!!", "FAILURE", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            Clear_Controls();
            Disable_Controls();
            btn_Search.Visible = true;

        }

        private void tb_Paying_Amount_TextChanged(object sender, EventArgs e)
        {
            if(tb_Paying_Amount.Text != "" && Convert.ToDouble(tb_Paying_Amount.Text) > Convert.ToDouble(tb_Balanced_Amount.Text))
            {
                tb_Paying_Amount.Text = "0";
                tb_Paying_Amount.Focus();
            }
        }

        private void tb_Paying_Amount_Click(object sender, EventArgs e)
        {
            tb_Paying_Amount.Text = "";
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
            Disable_Controls();
        }
    }
}
