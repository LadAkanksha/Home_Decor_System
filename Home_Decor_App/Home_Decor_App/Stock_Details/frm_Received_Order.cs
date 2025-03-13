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
    public partial class frm_Received_Order : Form
    {
        public frm_Received_Order()
        {
            InitializeComponent();
        }

        int SrNo = 1 , Current_Stock = 0, New_Stock = 0;
        void Clear_Control()
        {
            tb_R_O_Id.Text = Convert.ToString(SharedContent.Auto_Increment("Order_Details", "Order_Id", 6001));
            cmb_Supplier.SelectedIndex = -1;
            dtp_R_O_Date.Text = "";
            tb_S_Mob_No.Clear();
            cmb_Category.SelectedIndex = -1;
            tb_Price.Clear();
            tb_Quantity.Clear();
            tb_Total.Clear();
            tb_Bill.Text = "0";
            tb_GST.Text = "0";
            tb_Final_Bill.Text = "0";
        }

        void Clear_Product_Control()
        {
            cmb_Category.SelectedIndex = -1;
            tb_Product_Name.Clear();
            tb_Price.Clear();
            tb_Quantity.Clear();
            tb_Total.Clear();
        }
        private void Numeric(object sender, KeyPressEventArgs e)
        {
            SharedContent.Only_Numeric(e);
        }
        private void Letter(object sender, KeyPressEventArgs e)
        {
            SharedContent.Only_Text(e);

        }
        private void frm_Received_Order_Load(object sender, EventArgs e)
        {
            tb_R_O_Id.Text = Convert.ToString(SharedContent.Auto_Increment("Order_Details", "Order_Id", 6001));
            SharedContent.Bind_ComboBox("Name", cmb_Supplier, "Select Distinct(Name) from Supplier_Details");
        }

        private void cmb_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cmb_Category.SelectedIndex;

            SharedContent.ProductId = 0;
            SharedContent.ProductName = "";
            SharedContent.ProductPrice = 0.0;
            
            SharedContent.Flag = 2;

            if (index == 0)
            {
                Popup_Window.frm_Curtain Fcur = new Popup_Window.frm_Curtain() { TopLevel = true, TopMost = true };
                Fcur.FormBorderStyle = FormBorderStyle.None;
                Fcur.WindowState = FormWindowState.Normal;
                Fcur.Show();
            }
            else if (index == 1)
            {
                Popup_Window.frm_Cushion Fcus = new Popup_Window.frm_Cushion() { TopLevel = true, TopMost = true };
                Fcus.FormBorderStyle = FormBorderStyle.None;
                Fcus.WindowState = FormWindowState.Normal;
                Fcus.Show();
            }
            else if (index == 2)
            {
                Popup_Window.frm_Mattress fM = new Popup_Window.frm_Mattress() { TopLevel = true, TopMost = true };
                fM.FormBorderStyle = FormBorderStyle.None;
                fM.WindowState = FormWindowState.Normal;
                fM.Show();
            }
            else if (index == 3)
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
                int Qty = Convert.ToInt32(tb_Quantity.Text) , flag = 1;

                for(int i = 0; i < dgv_Product_Details.Rows.Count; i++)
                {
                    if(cmb_Category.Text == Convert.ToString(dgv_Product_Details.Rows[i].Cells[1].Value) && SharedContent.ProductId == Convert.ToInt32(dgv_Product_Details.Rows[i].Cells[2].Value) && tb_Product_Name.Text == Convert.ToString(dgv_Product_Details.Rows[i].Cells[3].Value))
                    {
                        flag = 0;
                        Qty += Convert.ToInt32(dgv_Product_Details.Rows[i].Cells[4].Value);

                        double Total = Convert.ToDouble(dgv_Product_Details.Rows[i].Cells[6].Value) + Convert.ToDouble(tb_Total.Text);
                        dgv_Product_Details.Rows[i].Cells[4].Value = Qty;
                        dgv_Product_Details.Rows[i].Cells[6].Value = Total;
                    }
                }

                if(flag == 1)
                {
                    dgv_Product_Details.Rows.Add(SrNo, cmb_Category.Text, SharedContent.ProductId, tb_Product_Name.Text, tb_Quantity.Text, tb_Price.Text, tb_Total.Text);
                    SrNo++;
                }

                double bill = Convert.ToDouble(tb_Total.Text) + Convert.ToDouble(tb_Bill.Text);

                tb_Bill.Text = Convert.ToString(bill);
                tb_Final_Bill.Text = Convert.ToString(bill);
            }
            else
            {
                MessageBox.Show("Please Fill Received Product Details !!!", "FAILURE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Clear_Product_Control();
            SharedContent.Flag = 0;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (cmb_Supplier.Text != "" && dtp_R_O_Date.Text != "" && tb_S_Mob_No.Text != "" && tb_Bill.Text != "" && tb_GST.Text != "" && tb_Final_Bill.Text != "")
            {
                Connections.Con_Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Insert Into Order_Details values(@id,@sup,@date,@mno,@bill,@gst,@fbill,@pamt,@lu,@status)";
                cmd.Connection = Connections.Con;

                cmd.Parameters.Add("@id", SqlDbType.Int).Value = tb_R_O_Id.Text;
                cmd.Parameters.Add("@sup", SqlDbType.NVarChar).Value = cmb_Supplier.Text;
                cmd.Parameters.Add("@date", SqlDbType.Date).Value = dtp_R_O_Date.Text;
                cmd.Parameters.Add("@mno", SqlDbType.Decimal).Value = tb_S_Mob_No.Text;
                cmd.Parameters.Add("@bill", SqlDbType.Money).Value = tb_Bill.Text;
                cmd.Parameters.Add("@gst", SqlDbType.Float).Value = tb_GST.Text;
                cmd.Parameters.Add("@fbill", SqlDbType.Money).Value = tb_Final_Bill.Text;
                cmd.Parameters.Add("@pamt", SqlDbType.Money).Value = 0;
                cmd.Parameters.Add("@lu", SqlDbType.Int).Value = SharedContent.User_Id;
                cmd.Parameters.Add("@status", SqlDbType.Bit).Value = true;

                cmd.ExecuteNonQuery();
                cmd.Dispose();

                for (int i = 0; i < dgv_Product_Details.Rows.Count; i++)
                {
                    Connections.Con_Open();
                    cmd = new SqlCommand("Insert into Received_Order_Details(Category,Product_Id,Product_Name,Quantity,Price,Total_Price,Order_Id) values (@cat,@pid,@pnm,@qty,@price,@tprice,@oid)", Connections.Con);

                    cmd.Parameters.Add("@cat", SqlDbType.NVarChar).Value = dgv_Product_Details.Rows[i].Cells[1].Value;
                    cmd.Parameters.Add("@pid", SqlDbType.Int).Value = dgv_Product_Details.Rows[i].Cells[2].Value;
                    cmd.Parameters.Add("@pnm", SqlDbType.NVarChar).Value = dgv_Product_Details.Rows[i].Cells[3].Value;
                    cmd.Parameters.Add("@qty", SqlDbType.Int).Value = dgv_Product_Details.Rows[i].Cells[4].Value;
                    cmd.Parameters.Add("@price", SqlDbType.Money).Value = dgv_Product_Details.Rows[i].Cells[5].Value;
                    cmd.Parameters.Add("@tprice", SqlDbType.Money).Value = dgv_Product_Details.Rows[i].Cells[6].Value;
                    cmd.Parameters.Add("@oid", SqlDbType.Int).Value = tb_R_O_Id.Text;

                    cmd.ExecuteNonQuery();
                    cmd.Dispose();

                    int addQty = Convert.ToInt32(dgv_Product_Details.Rows[i].Cells[4].Value);

                    if (Convert.ToInt32(dgv_Product_Details.Rows[i].Cells[2].Value) >= 2001 && Convert.ToInt32(dgv_Product_Details.Rows[i].Cells[2].Value) <= 3000)
                    {
                        SqlCommand Cmd1 = new SqlCommand("Select Current_Stock from Curtain_Details where Cur_Id = '" + dgv_Product_Details.Rows[i].Cells[2].Value + "'", Connections.Con);
                        Current_Stock = Convert.ToInt32(Cmd1.ExecuteScalar());
                        New_Stock = Current_Stock + addQty;
                        Cmd1.Dispose();
                        SqlDataAdapter SDA = new SqlDataAdapter("Update Curtain_Details set Current_Stock = '" + New_Stock + "' where Cur_Id = '" + dgv_Product_Details.Rows[i].Cells[2].Value + "'", Connections.Con);
                        DataTable DT = new DataTable();
                        SDA.Fill(DT);
                        
                    }
                    else if (Convert.ToInt32(dgv_Product_Details.Rows[i].Cells[2].Value) >= 3001 && Convert.ToInt32(dgv_Product_Details.Rows[i].Cells[2].Value) <= 4000)
                    {
                        SqlCommand Cmd2 = new SqlCommand("Select Current_Stock from Cushion_Details where Cush_Id = '" + dgv_Product_Details.Rows[i].Cells[2].Value + "'", Connections.Con);
                        Current_Stock = Convert.ToInt32(Cmd2.ExecuteScalar());
                        New_Stock = Current_Stock + addQty;
                        Cmd2.Dispose();
                        SqlDataAdapter SDA = new SqlDataAdapter("Update Cushion_Details set Current_Stock = '" + New_Stock + "' where Cush_Id = '" + dgv_Product_Details.Rows[i].Cells[2].Value + "'", Connections.Con);
                        DataTable DT = new DataTable();
                        SDA.Fill(DT);
                    }
                    else if (Convert.ToInt32(dgv_Product_Details.Rows[i].Cells[2].Value) >= 4001 && Convert.ToInt32(dgv_Product_Details.Rows[i].Cells[2].Value) <= 5000)
                    {
                        SqlCommand Cmd3 = new SqlCommand("Select Current_Stock from Mattress_Details where M_Id = '" + dgv_Product_Details.Rows[i].Cells[2].Value + "'", Connections.Con);
                        Current_Stock = Convert.ToInt32(Cmd3.ExecuteScalar());
                        New_Stock = Current_Stock + addQty;
                        Cmd3.Dispose();
                        SqlDataAdapter SDA = new SqlDataAdapter("Update Mattress_Details set Current_Stock = '" + New_Stock + "' where M_Id = '" + dgv_Product_Details.Rows[i].Cells[2].Value + "'", Connections.Con);
                        DataTable DT = new DataTable();
                        SDA.Fill(DT);
                    }
                    else if (Convert.ToInt32(dgv_Product_Details.Rows[i].Cells[2].Value) >= 5001 && Convert.ToInt32(dgv_Product_Details.Rows[i].Cells[2].Value) <= 6000)
                    {
                        SqlCommand Cmd4 = new SqlCommand("Select Current_stock from Pillow_Details where P_Id = '" + dgv_Product_Details.Rows[i].Cells[2].Value + "'", Connections.Con);
                        Current_Stock = Convert.ToInt32(Cmd4.ExecuteScalar());
                        New_Stock = Current_Stock + addQty;
                        Cmd4.Dispose();
                        SqlDataAdapter SDA = new SqlDataAdapter("Update Pillow_Details set Current_stock = '" + New_Stock + "' where P_Id = '" + dgv_Product_Details.Rows[i].Cells[2].Value + "'", Connections.Con);
                        DataTable DT = new DataTable();
                        SDA.Fill(DT);
                    }
                    Connections.Con_Close();
                }
                DialogResult DR = MessageBox.Show("Stock Details Saves Successfully.", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if(DR == DialogResult.OK)
                {
                    SharedContent.Flag = 3;
                    int id = Convert.ToInt32(tb_R_O_Id.Text);
                    string date = Convert.ToString(dtp_R_O_Date.Text);
                    double bill = Convert.ToDouble(tb_Final_Bill.Text);
                    frm_Payment_Details PD = new frm_Payment_Details(id,date,bill);

                    PD.MdiParent = this.ParentForm;
                    PD.Show();
                    this.Hide();
                    SharedContent.Flag = 0;
                }
                
                Clear_Control();
                Connections.Con_Close();
            }
            else
            {
                MessageBox.Show("Please Fill All Fields Properly!!!", "FAILURE", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void tb_Price_TextChanged(object sender, EventArgs e)
        {
            if(tb_Price.Text != "" || tb_Price.Text != "0")
            {

            }
        }

        private void tb_GST_Leave(object sender, EventArgs e)
        {
            if(tb_GST.Text == "")
            {
                tb_GST.Text = "0";
            }
        }

        private void tb_GST_Click(object sender, EventArgs e)
        {
            tb_GST.Text = "";
        }

        private void cmb_Supplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            Connections.Con_Open();

            SqlCommand cmd = new SqlCommand("select Mob_No from Supplier_Details where Name = '"+cmb_Supplier.Text+"'",Connections.Con);
            double mn = Convert.ToDouble(cmd.ExecuteScalar());
            tb_S_Mob_No.Text = Convert.ToString(mn);

            Connections.Con_Close();
        }

        private void tb_GST_TextChanged(object sender, EventArgs e)
        {
            if (tb_GST.Text != "" && Convert.ToDouble(tb_GST.Text) > 20)
            {
                MessageBox.Show("Invalid Value");
                tb_GST.Text = "0";
            }
            else if (tb_Bill.Text != "" && tb_GST.Text != "")
            {
                double GST = (Convert.ToDouble(tb_Bill.Text) * Convert.ToDouble(tb_GST.Text)) / 100;

                tb_Final_Bill.Text = Convert.ToString(Convert.ToDouble(tb_Bill.Text) + GST);
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Control();
        }
    }
}
