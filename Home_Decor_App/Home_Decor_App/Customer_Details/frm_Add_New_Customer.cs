using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Home_Decor_App.Customer_Details
{
    public partial class frm_Add_New_Customer : Form
    {
        public frm_Add_New_Customer()
        {
            InitializeComponent();
        }

        int SrNo = 1;

        int New_Stock = 0;
        int Current_Stock = 0;
        private void Numeric(object sender, KeyPressEventArgs e)
        {
            SharedContent.Only_Numeric(e);
        }

        private void Letter(object sender, KeyPressEventArgs e)
        {
            SharedContent.Only_Text(e);
        }
        void Clear_Purchase_Control()
        {
            //tb_Product_Id.Clear();
            cmb_Category.SelectedIndex = -1;
            tb_Product_Name.Clear();
            tb_Quantity.Clear();
            tb_Price.Clear();
            tb_Total.Clear();

        }
        void Clear_Controls()
        {
            tb_C_Id.Text = (Convert.ToString(SharedContent.Auto_Increment("Customer_Details","Customer_Id",101)));
            tb_C_Name.Clear();
            tb_C_Address.Clear();
            dtp_C_Date.Text = "";
            tb_C_Mob_No.Clear();
            cmb_Payment_Mode.SelectedIndex = -1;
            cmb_Category.SelectedIndex = -1;
            tb_Product_Name.Clear();
            tb_Quantity.Clear();
            tb_Price.Clear();
            tb_Total.Clear();
            tb_Bill.Text = "0";
            tb_GST.Text = "0";
            tb_Final_Bill.Text = "0";
            dgv_Product_Details.Rows.Clear();
        }

        private void frm_Add_New_Customer_Load(object sender, EventArgs e)
        {
            tb_C_Id.Text = Convert.ToString(SharedContent.Auto_Increment("Customer_Details", "Customer_Id", 101));
        }

        private void cmb_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cmb_Category.SelectedIndex;

            SharedContent.ProductId = 0;
            SharedContent.ProductName = "";
            SharedContent.ProductPrice = 0.0;

            SharedContent.Flag = 1;

            if (index == 0)
            {
                Popup_Window.frm_Curtain Fcur = new Popup_Window.frm_Curtain() { TopLevel = true, TopMost = true };
                Fcur.FormBorderStyle = FormBorderStyle.None;
                Fcur.WindowState = FormWindowState.Normal;
                
                Fcur.Show();
            }
            else if(index == 1)
            {
                Popup_Window.frm_Cushion Fcus = new Popup_Window.frm_Cushion() { TopLevel = true, TopMost = true };
                Fcus.FormBorderStyle = FormBorderStyle.None;
                Fcus.WindowState = FormWindowState.Normal;
                Fcus.Show();
            }
            else if(index == 2)
            {
                Popup_Window.frm_Mattress fM = new Popup_Window.frm_Mattress() { TopLevel = true, TopMost = true };
                fM.FormBorderStyle = FormBorderStyle.None;
                fM.WindowState = FormWindowState.Normal;
                fM.Show();
            }
            else if(index == 3)
            {
                Popup_Window.frm_Pillow fP = new Popup_Window.frm_Pillow() { TopLevel = true, TopMost = true };
                fP.FormBorderStyle = FormBorderStyle.None;
                fP.WindowState = FormWindowState.Normal;
                fP.Show();
            }
        }

        private void tb_Quantity_TextChanged(object sender, EventArgs e)
        {
            if (tb_Quantity.Text != "" && Convert.ToInt32(tb_Quantity.Text) > 0)
            {
                tb_Price.Enabled = true;
                lbl_CStock.Text = "Available Stock :" + SharedContent.ProductStock;
                lbl_CStock.Visible = true;
                tb_Product_Name.Text = SharedContent.ProductName;
                tb_Price.Text = Convert.ToString(SharedContent.ProductPrice);
                tb_Total.Text = Convert.ToString(Convert.ToDouble(tb_Price.Text) * Convert.ToDouble(tb_Quantity.Text));
            }
            else
            {
                tb_Total.Clear();
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if(cmb_Category.Text != "" && tb_Product_Name.Text != "" && tb_Price.Text != "" && tb_Quantity.Text != "" && tb_Total.Text != "")
            {
                btn_Add.Enabled = true;
                int flag = -1, Qty = Convert.ToInt32(tb_Quantity.Text);

                for(int i = 0; i <= dgv_Product_Details.Rows.Count-1 ; i++)
                {
                    if(cmb_Category.Text == Convert.ToString(dgv_Product_Details.Rows[i].Cells[1].Value) && SharedContent.ProductId == Convert.ToInt32(dgv_Product_Details.Rows[i].Cells[2].Value) && tb_Product_Name.Text == Convert.ToString(dgv_Product_Details.Rows[i].Cells[3].Value))
                    {
                        flag = 0;
                        Qty += Convert.ToInt32(dgv_Product_Details.Rows[i].Cells[4].Value);
                        if(SharedContent.ProductStock >= Qty)
                        {
                            double Total = Convert.ToDouble(dgv_Product_Details.Rows[i].Cells[6].Value) + Convert.ToDouble(tb_Total.Text);
                            dgv_Product_Details.Rows[i].Cells[6].Value = Total;
                            dgv_Product_Details.Rows[i].Cells[4].Value = Qty;

                            tb_Quantity.Clear();
                        }
                        else
                        {
                            flag = 1;
                            MessageBox.Show("Unable to Add More Product !!!", "Not Enough Quantity", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }

                if(flag == -1)
                {
                    if(SharedContent.ProductStock >= Qty)
                    {
                        dgv_Product_Details.Rows.Add(SrNo, cmb_Category.Text, SharedContent.ProductId, tb_Product_Name.Text, tb_Quantity.Text, tb_Price.Text, tb_Total.Text);
                        SrNo++;
                    }
                    else
                    {
                        MessageBox.Show("Not Enough Stock Available", "Not Enough Quantity", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        flag = 1;
                    }
                    cmb_Category.SelectedIndex = -1;
                }

                if(flag < 1)
                {
                    double bill = Convert.ToDouble(tb_Total.Text) + Convert.ToDouble(tb_Bill.Text);

                    tb_Bill.Text = Convert.ToString(bill);
                    tb_Final_Bill.Text = Convert.ToString(bill);
                }
            }
            else
            {
                MessageBox.Show("Please Fill All Purchase Details!!!", "FAILURE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Clear_Purchase_Control();
            lbl_CStock.Visible = false;
            SharedContent.Flag = 0;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (tb_C_Name.Text != "" && tb_C_Address.Text != "" && tb_C_Mob_No.Text != "" && cmb_Payment_Mode.Text != "" && tb_Bill.Text != "" && tb_GST.Text != "" && tb_Discount.Text != "" && tb_Final_Bill.Text != "")
            {
                Connections.Con_Open();
                SqlCommand Cmd = new SqlCommand();
                Cmd.CommandText = "Insert into Customer_Details values (@C_Id , @nm , @add , @date , @mno , @mode , @bill  , @gst , @dis , @fbill , @user)";
                Cmd.Connection = Connections.Con;

                Cmd.Parameters.Add("@C_Id", SqlDbType.Int).Value = tb_C_Id.Text;
                Cmd.Parameters.Add("@nm", SqlDbType.VarChar).Value = tb_C_Name.Text;
                Cmd.Parameters.Add("@add", SqlDbType.NVarChar).Value = tb_C_Address.Text;
                Cmd.Parameters.Add("@date", SqlDbType.Date).Value = dtp_C_Date.Text;
                Cmd.Parameters.Add("@mno", SqlDbType.Decimal).Value = tb_C_Mob_No.Text;
                Cmd.Parameters.Add("@mode", SqlDbType.VarChar).Value = cmb_Payment_Mode.Text;
                Cmd.Parameters.Add("@bill", SqlDbType.Money).Value = tb_Bill.Text;
                Cmd.Parameters.Add("@gst", SqlDbType.Int).Value = tb_GST.Text;
                Cmd.Parameters.Add("@dis", SqlDbType.Int).Value = tb_Discount.Text;
                Cmd.Parameters.Add("@fbill", SqlDbType.Money).Value = tb_Final_Bill.Text;
                Cmd.Parameters.Add("@user", SqlDbType.Int).Value = SharedContent.User_Id;

                Cmd.ExecuteNonQuery();
                Cmd.Dispose();

                for (int i = 0; i < dgv_Product_Details.Rows.Count; i++)
                {
                    Connections.Con_Open();

                    Cmd = new SqlCommand("Insert into Customer_Purchase_Details values(@cat , @pid,@pname,@qty,@price,@total,@cid)", Connections.Con);

                    Cmd.Parameters.Add("@cat", SqlDbType.NVarChar).Value = dgv_Product_Details.Rows[i].Cells[1].Value;
                    Cmd.Parameters.Add("@pid", SqlDbType.Int).Value = dgv_Product_Details.Rows[i].Cells[2].Value;
                    Cmd.Parameters.Add("@pname", SqlDbType.NVarChar).Value = dgv_Product_Details.Rows[i].Cells[3].Value;
                    Cmd.Parameters.Add("@qty", SqlDbType.Int).Value = dgv_Product_Details.Rows[i].Cells[4].Value;
                    Cmd.Parameters.Add("@price", SqlDbType.Money).Value = dgv_Product_Details.Rows[i].Cells[5].Value;
                    Cmd.Parameters.Add("@total", SqlDbType.Money).Value = dgv_Product_Details.Rows[i].Cells[6].Value;
                    Cmd.Parameters.Add("@cid", SqlDbType.NVarChar).Value = tb_C_Id.Text;

                    Cmd.ExecuteNonQuery();
                    Cmd.Dispose();


                    int Saled_Qty = Convert.ToInt32(dgv_Product_Details.Rows[i].Cells[4].Value);

                    if (Convert.ToInt32(dgv_Product_Details.Rows[i].Cells[2].Value) >= 2001 && Convert.ToInt32(dgv_Product_Details.Rows[i].Cells[2].Value) < 3000)
                    {
                        SqlCommand Cmd1 = new SqlCommand("Select Current_Stock from Curtain_Details where Cur_Id = '" + dgv_Product_Details.Rows[i].Cells[2].Value + "'", Connections.Con);
                        Current_Stock = Convert.ToInt32(Cmd1.ExecuteScalar());
                        New_Stock = Current_Stock - Saled_Qty;
                        Cmd1.Dispose();
                        SqlDataAdapter SDA = new SqlDataAdapter("Update Curtain_Details set Current_Stock = '" + New_Stock + "' where Cur_Id = '" + dgv_Product_Details.Rows[i].Cells[2].Value + "'", Connections.Con);
                        DataTable DT = new DataTable();
                        SDA.Fill(DT);
                    }
                    else if (Convert.ToInt32(dgv_Product_Details.Rows[i].Cells[2].Value) >= 3001 && Convert.ToInt32(dgv_Product_Details.Rows[i].Cells[2].Value) < 4000)
                    {
                        SqlCommand Cmd1 = new SqlCommand("Select Current_Stock from Cushion_Details where Cush_Id = '" + dgv_Product_Details.Rows[i].Cells[2].Value + "'", Connections.Con);
                        Current_Stock = Convert.ToInt32(Cmd1.ExecuteScalar());
                        New_Stock = Current_Stock - Saled_Qty;
                        Cmd1.Dispose();
                        SqlDataAdapter SDA = new SqlDataAdapter("Update Cushion_Details set Current_Stock = '" + New_Stock + "' where Cush_Id = '" + dgv_Product_Details.Rows[i].Cells[2].Value + "'", Connections.Con);
                        DataTable DT = new DataTable();
                        SDA.Fill(DT);
                    }
                    else if (Convert.ToInt32(dgv_Product_Details.Rows[i].Cells[2].Value) >= 4001 && Convert.ToInt32(dgv_Product_Details.Rows[i].Cells[2].Value) < 5000)
                    {
                        SqlCommand Cmd1 = new SqlCommand("Select Current_Stock from Mattress_Details where M_Id = '" + dgv_Product_Details.Rows[i].Cells[2].Value + "'", Connections.Con);
                        Current_Stock = Convert.ToInt32(Cmd1.ExecuteScalar());
                        New_Stock = Current_Stock - Saled_Qty;
                        Cmd1.Dispose();
                        SqlDataAdapter SDA = new SqlDataAdapter("Update Mattress_Details set Current_Stock = '" + New_Stock + "' where M_Id = '" + dgv_Product_Details.Rows[i].Cells[2].Value + "'", Connections.Con);
                        DataTable DT = new DataTable();
                        SDA.Fill(DT);
                    }
                    else if (Convert.ToInt32(dgv_Product_Details.Rows[i].Cells[2].Value) >= 5001 && Convert.ToInt32(dgv_Product_Details.Rows[i].Cells[2].Value) < 6000)
                    {
                        SqlCommand Cmd1 = new SqlCommand("Select Current_stock from Pillow_Details where P_Id = '" + dgv_Product_Details.Rows[i].Cells[2].Value + "'", Connections.Con);
                        Current_Stock = Convert.ToInt32(Cmd1.ExecuteScalar());
                        New_Stock = Current_Stock - Saled_Qty;
                        Cmd1.Dispose();
                        SqlDataAdapter SDA = new SqlDataAdapter("Update Pillow_Details set Current_stock = '" + New_Stock + "' where P_Id = '" + dgv_Product_Details.Rows[i].Cells[2].Value + "'", Connections.Con);
                        DataTable DT = new DataTable();
                        SDA.Fill(DT);
                    }
                    Connections.Con_Close();
                }

                MessageBox.Show("Customer Details Saved Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Connections.Con_Close();
                SharedContent.CId = Convert.ToInt32(tb_C_Id.Text);
                Clear_Controls();
                //dgv_Product_Details.Rows.Clear();

                Report.Report_Form.frm_Single_Customer_Bill SCB = new Report.Report_Form.frm_Single_Customer_Bill();
                SCB.Show();
            }
            else
            {
                MessageBox.Show("Fill Customer & Purchase Details Properly.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void tb_GST_Click(object sender, EventArgs e)
        {
                tb_GST.Text = "";
        }
        private void tb_GST_TextChanged(object sender, EventArgs e)
        {
            if (tb_GST.Text != "" && Convert.ToDouble(tb_GST.Text) > 20)
            {
                MessageBox.Show("Invalid Value");
                tb_GST.Text = "0";
            }
            else if(tb_Bill.Text != "" && tb_GST.Text != "")
            {
                double Discount = (Convert.ToDouble(tb_Bill.Text) * Convert.ToDouble(tb_Discount.Text))/100;
                double GST = (Convert.ToDouble(tb_Bill.Text) * Convert.ToDouble(tb_GST.Text)) / 100;

                tb_Final_Bill.Text = Convert.ToString(Convert.ToDouble(tb_Bill.Text) - Discount + GST);
            }
        }

        private void tb_Discount_Click(object sender, EventArgs e)
        {
            tb_Discount.Text = "";
        }

        private void tb_Discount_TextChanged(object sender, EventArgs e)
        {
            if(tb_Discount.Text == "")
            {
                tb_Discount.Text = "0";
            }
            if (tb_GST.Text != "" && Convert.ToInt32(tb_Discount.Text) > 50)
            {
                MessageBox.Show("Invalid Value");
                tb_Discount.Text = "0";
            }
            else if (tb_Bill.Text != "" && tb_GST.Text != "")
            {
                double Discount = (Convert.ToDouble(tb_Bill.Text) * Convert.ToDouble(tb_Discount.Text)) / 100;
                double GST = (Convert.ToDouble(tb_Bill.Text) * Convert.ToDouble(tb_GST.Text)) / 100;

                tb_Final_Bill.Text = Convert.ToString(Convert.ToDouble(tb_Bill.Text) - Discount + GST);
            }
        }

        private void tb_GST_Leave(object sender, EventArgs e)
        {
            if(tb_GST.Text == "")
            {
                tb_GST.Text = "0";
            }
        }

        private void tb_Discount_Leave(object sender, EventArgs e)
        {
            if(tb_Discount.Text == "")
            {
                tb_Discount.Text = "0";
            }
        }
    }
}
