
namespace Home_Decor_App.Stock_Details
{
    partial class frm_Payment_Details
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gb_Order_Details = new System.Windows.Forms.GroupBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.dtp_RO_Date = new System.Windows.Forms.DateTimePicker();
            this.tb_RO_Id = new System.Windows.Forms.TextBox();
            this.lbl_RO_Date = new System.Windows.Forms.Label();
            this.lbl_RO_Id = new System.Windows.Forms.Label();
            this.gb_Payment_Details = new System.Windows.Forms.GroupBox();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.tb_Payment_Id = new System.Windows.Forms.TextBox();
            this.lbl_Payment_Id = new System.Windows.Forms.Label();
            this.cmb_Mode = new System.Windows.Forms.ComboBox();
            this.dtp_P_Date = new System.Windows.Forms.DateTimePicker();
            this.btn_Save = new System.Windows.Forms.Button();
            this.tb_Note = new System.Windows.Forms.TextBox();
            this.lbl_Note = new System.Windows.Forms.Label();
            this.tb_Paying_Amount = new System.Windows.Forms.TextBox();
            this.lbl_Paying_Amount = new System.Windows.Forms.Label();
            this.tb_Balanced_Amount = new System.Windows.Forms.TextBox();
            this.lbl_Balanced_Amount = new System.Windows.Forms.Label();
            this.tb_Paid_Amount = new System.Windows.Forms.TextBox();
            this.lbl_Paid_Amount = new System.Windows.Forms.Label();
            this.tb_Final_Bill = new System.Windows.Forms.TextBox();
            this.lbl_Final_Bill = new System.Windows.Forms.Label();
            this.lbl_P_Media = new System.Windows.Forms.Label();
            this.lbl_P_Date = new System.Windows.Forms.Label();
            this.gb_Order_Details.SuspendLayout();
            this.gb_Payment_Details.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Order_Details
            // 
            this.gb_Order_Details.BackColor = System.Drawing.Color.LightCyan;
            this.gb_Order_Details.Controls.Add(this.btn_Search);
            this.gb_Order_Details.Controls.Add(this.dtp_RO_Date);
            this.gb_Order_Details.Controls.Add(this.tb_RO_Id);
            this.gb_Order_Details.Controls.Add(this.lbl_RO_Date);
            this.gb_Order_Details.Controls.Add(this.lbl_RO_Id);
            this.gb_Order_Details.Font = new System.Drawing.Font("Rockwell", 9F);
            this.gb_Order_Details.ForeColor = System.Drawing.Color.Crimson;
            this.gb_Order_Details.Location = new System.Drawing.Point(61, 61);
            this.gb_Order_Details.Name = "gb_Order_Details";
            this.gb_Order_Details.Size = new System.Drawing.Size(1280, 115);
            this.gb_Order_Details.TabIndex = 0;
            this.gb_Order_Details.TabStop = false;
            this.gb_Order_Details.Text = "Order Details";
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.LightPink;
            this.btn_Search.Font = new System.Drawing.Font("Times New Roman", 20F);
            this.btn_Search.ForeColor = System.Drawing.Color.DarkGreen;
            this.btn_Search.Location = new System.Drawing.Point(477, 34);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(136, 54);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // dtp_RO_Date
            // 
            this.dtp_RO_Date.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.dtp_RO_Date.Location = new System.Drawing.Point(954, 43);
            this.dtp_RO_Date.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dtp_RO_Date.Name = "dtp_RO_Date";
            this.dtp_RO_Date.Size = new System.Drawing.Size(245, 34);
            this.dtp_RO_Date.TabIndex = 3;
            // 
            // tb_RO_Id
            // 
            this.tb_RO_Id.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.tb_RO_Id.Location = new System.Drawing.Point(294, 46);
            this.tb_RO_Id.MaxLength = 5;
            this.tb_RO_Id.Name = "tb_RO_Id";
            this.tb_RO_Id.Size = new System.Drawing.Size(177, 34);
            this.tb_RO_Id.TabIndex = 1;
            this.tb_RO_Id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numeric);
            // 
            // lbl_RO_Date
            // 
            this.lbl_RO_Date.AutoSize = true;
            this.lbl_RO_Date.Font = new System.Drawing.Font("Palatino Linotype", 15F);
            this.lbl_RO_Date.ForeColor = System.Drawing.Color.Navy;
            this.lbl_RO_Date.Location = new System.Drawing.Point(671, 43);
            this.lbl_RO_Date.Name = "lbl_RO_Date";
            this.lbl_RO_Date.Size = new System.Drawing.Size(244, 33);
            this.lbl_RO_Date.TabIndex = 1;
            this.lbl_RO_Date.Text = "Received Order Date";
            // 
            // lbl_RO_Id
            // 
            this.lbl_RO_Id.AutoSize = true;
            this.lbl_RO_Id.Font = new System.Drawing.Font("Palatino Linotype", 15F);
            this.lbl_RO_Id.ForeColor = System.Drawing.Color.Navy;
            this.lbl_RO_Id.Location = new System.Drawing.Point(49, 43);
            this.lbl_RO_Id.Name = "lbl_RO_Id";
            this.lbl_RO_Id.Size = new System.Drawing.Size(214, 33);
            this.lbl_RO_Id.TabIndex = 0;
            this.lbl_RO_Id.Text = "Received Order Id";
            // 
            // gb_Payment_Details
            // 
            this.gb_Payment_Details.BackColor = System.Drawing.Color.LightCyan;
            this.gb_Payment_Details.Controls.Add(this.btn_Refresh);
            this.gb_Payment_Details.Controls.Add(this.tb_Payment_Id);
            this.gb_Payment_Details.Controls.Add(this.lbl_Payment_Id);
            this.gb_Payment_Details.Controls.Add(this.cmb_Mode);
            this.gb_Payment_Details.Controls.Add(this.dtp_P_Date);
            this.gb_Payment_Details.Controls.Add(this.btn_Save);
            this.gb_Payment_Details.Controls.Add(this.tb_Note);
            this.gb_Payment_Details.Controls.Add(this.lbl_Note);
            this.gb_Payment_Details.Controls.Add(this.tb_Paying_Amount);
            this.gb_Payment_Details.Controls.Add(this.lbl_Paying_Amount);
            this.gb_Payment_Details.Controls.Add(this.tb_Balanced_Amount);
            this.gb_Payment_Details.Controls.Add(this.lbl_Balanced_Amount);
            this.gb_Payment_Details.Controls.Add(this.tb_Paid_Amount);
            this.gb_Payment_Details.Controls.Add(this.lbl_Paid_Amount);
            this.gb_Payment_Details.Controls.Add(this.tb_Final_Bill);
            this.gb_Payment_Details.Controls.Add(this.lbl_Final_Bill);
            this.gb_Payment_Details.Controls.Add(this.lbl_P_Media);
            this.gb_Payment_Details.Controls.Add(this.lbl_P_Date);
            this.gb_Payment_Details.Font = new System.Drawing.Font("Rockwell", 9F);
            this.gb_Payment_Details.ForeColor = System.Drawing.Color.Crimson;
            this.gb_Payment_Details.Location = new System.Drawing.Point(61, 182);
            this.gb_Payment_Details.Name = "gb_Payment_Details";
            this.gb_Payment_Details.Size = new System.Drawing.Size(1280, 623);
            this.gb_Payment_Details.TabIndex = 0;
            this.gb_Payment_Details.TabStop = false;
            this.gb_Payment_Details.Text = "Payment Details";
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.Blue;
            this.btn_Refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Refresh.Font = new System.Drawing.Font("Times New Roman", 22F);
            this.btn_Refresh.ForeColor = System.Drawing.Color.White;
            this.btn_Refresh.Location = new System.Drawing.Point(319, 529);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(174, 53);
            this.btn_Refresh.TabIndex = 17;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // tb_Payment_Id
            // 
            this.tb_Payment_Id.Enabled = false;
            this.tb_Payment_Id.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.tb_Payment_Id.Location = new System.Drawing.Point(346, 70);
            this.tb_Payment_Id.MaxLength = 3;
            this.tb_Payment_Id.Name = "tb_Payment_Id";
            this.tb_Payment_Id.Size = new System.Drawing.Size(262, 34);
            this.tb_Payment_Id.TabIndex = 4;
            // 
            // lbl_Payment_Id
            // 
            this.lbl_Payment_Id.AutoSize = true;
            this.lbl_Payment_Id.Font = new System.Drawing.Font("Palatino Linotype", 15F);
            this.lbl_Payment_Id.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Payment_Id.Location = new System.Drawing.Point(101, 67);
            this.lbl_Payment_Id.Name = "lbl_Payment_Id";
            this.lbl_Payment_Id.Size = new System.Drawing.Size(140, 33);
            this.lbl_Payment_Id.TabIndex = 16;
            this.lbl_Payment_Id.Text = "Payment Id";
            // 
            // cmb_Mode
            // 
            this.cmb_Mode.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.cmb_Mode.FormattingEnabled = true;
            this.cmb_Mode.Items.AddRange(new object[] {
            "Net Banking",
            "UPI",
            "Cash",
            "Credit Card"});
            this.cmb_Mode.Location = new System.Drawing.Point(933, 429);
            this.cmb_Mode.MaxLength = 10;
            this.cmb_Mode.Name = "cmb_Mode";
            this.cmb_Mode.Size = new System.Drawing.Size(262, 34);
            this.cmb_Mode.TabIndex = 8;
            // 
            // dtp_P_Date
            // 
            this.dtp_P_Date.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.dtp_P_Date.Location = new System.Drawing.Point(933, 69);
            this.dtp_P_Date.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dtp_P_Date.Name = "dtp_P_Date";
            this.dtp_P_Date.Size = new System.Drawing.Size(262, 34);
            this.dtp_P_Date.TabIndex = 5;
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.Blue;
            this.btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Save.Font = new System.Drawing.Font("Times New Roman", 22F);
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(750, 529);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(174, 53);
            this.btn_Save.TabIndex = 9;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // tb_Note
            // 
            this.tb_Note.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.tb_Note.Location = new System.Drawing.Point(286, 395);
            this.tb_Note.MaxLength = 100;
            this.tb_Note.Multiline = true;
            this.tb_Note.Name = "tb_Note";
            this.tb_Note.Size = new System.Drawing.Size(322, 97);
            this.tb_Note.TabIndex = 7;
            // 
            // lbl_Note
            // 
            this.lbl_Note.AutoSize = true;
            this.lbl_Note.Font = new System.Drawing.Font("Palatino Linotype", 15F);
            this.lbl_Note.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Note.Location = new System.Drawing.Point(101, 414);
            this.lbl_Note.Name = "lbl_Note";
            this.lbl_Note.Size = new System.Drawing.Size(70, 33);
            this.lbl_Note.TabIndex = 15;
            this.lbl_Note.Text = "Note";
            // 
            // tb_Paying_Amount
            // 
            this.tb_Paying_Amount.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.tb_Paying_Amount.Location = new System.Drawing.Point(933, 302);
            this.tb_Paying_Amount.MaxLength = 7;
            this.tb_Paying_Amount.Name = "tb_Paying_Amount";
            this.tb_Paying_Amount.Size = new System.Drawing.Size(262, 34);
            this.tb_Paying_Amount.TabIndex = 6;
            this.tb_Paying_Amount.Text = "0";
            this.tb_Paying_Amount.Click += new System.EventHandler(this.tb_Paying_Amount_Click);
            this.tb_Paying_Amount.TextChanged += new System.EventHandler(this.tb_Paying_Amount_TextChanged);
            // 
            // lbl_Paying_Amount
            // 
            this.lbl_Paying_Amount.AutoSize = true;
            this.lbl_Paying_Amount.Font = new System.Drawing.Font("Palatino Linotype", 15F);
            this.lbl_Paying_Amount.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Paying_Amount.Location = new System.Drawing.Point(688, 299);
            this.lbl_Paying_Amount.Name = "lbl_Paying_Amount";
            this.lbl_Paying_Amount.Size = new System.Drawing.Size(208, 33);
            this.lbl_Paying_Amount.TabIndex = 13;
            this.lbl_Paying_Amount.Text = "Payment Amount";
            // 
            // tb_Balanced_Amount
            // 
            this.tb_Balanced_Amount.Enabled = false;
            this.tb_Balanced_Amount.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.tb_Balanced_Amount.Location = new System.Drawing.Point(346, 302);
            this.tb_Balanced_Amount.MaxLength = 7;
            this.tb_Balanced_Amount.Name = "tb_Balanced_Amount";
            this.tb_Balanced_Amount.Size = new System.Drawing.Size(262, 34);
            this.tb_Balanced_Amount.TabIndex = 0;
            this.tb_Balanced_Amount.Text = "0";
            // 
            // lbl_Balanced_Amount
            // 
            this.lbl_Balanced_Amount.AutoSize = true;
            this.lbl_Balanced_Amount.Font = new System.Drawing.Font("Palatino Linotype", 15F);
            this.lbl_Balanced_Amount.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Balanced_Amount.Location = new System.Drawing.Point(101, 299);
            this.lbl_Balanced_Amount.Name = "lbl_Balanced_Amount";
            this.lbl_Balanced_Amount.Size = new System.Drawing.Size(212, 33);
            this.lbl_Balanced_Amount.TabIndex = 11;
            this.lbl_Balanced_Amount.Text = "Balanced Amount";
            // 
            // tb_Paid_Amount
            // 
            this.tb_Paid_Amount.Enabled = false;
            this.tb_Paid_Amount.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.tb_Paid_Amount.Location = new System.Drawing.Point(933, 182);
            this.tb_Paid_Amount.MaxLength = 7;
            this.tb_Paid_Amount.Name = "tb_Paid_Amount";
            this.tb_Paid_Amount.Size = new System.Drawing.Size(262, 34);
            this.tb_Paid_Amount.TabIndex = 0;
            this.tb_Paid_Amount.Text = "0";
            // 
            // lbl_Paid_Amount
            // 
            this.lbl_Paid_Amount.AutoSize = true;
            this.lbl_Paid_Amount.Font = new System.Drawing.Font("Palatino Linotype", 15F);
            this.lbl_Paid_Amount.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Paid_Amount.Location = new System.Drawing.Point(688, 179);
            this.lbl_Paid_Amount.Name = "lbl_Paid_Amount";
            this.lbl_Paid_Amount.Size = new System.Drawing.Size(160, 33);
            this.lbl_Paid_Amount.TabIndex = 9;
            this.lbl_Paid_Amount.Text = "Paid Amount";
            // 
            // tb_Final_Bill
            // 
            this.tb_Final_Bill.Enabled = false;
            this.tb_Final_Bill.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.tb_Final_Bill.Location = new System.Drawing.Point(346, 182);
            this.tb_Final_Bill.MaxLength = 7;
            this.tb_Final_Bill.Name = "tb_Final_Bill";
            this.tb_Final_Bill.Size = new System.Drawing.Size(262, 34);
            this.tb_Final_Bill.TabIndex = 0;
            // 
            // lbl_Final_Bill
            // 
            this.lbl_Final_Bill.AutoSize = true;
            this.lbl_Final_Bill.Font = new System.Drawing.Font("Palatino Linotype", 15F);
            this.lbl_Final_Bill.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Final_Bill.Location = new System.Drawing.Point(101, 179);
            this.lbl_Final_Bill.Name = "lbl_Final_Bill";
            this.lbl_Final_Bill.Size = new System.Drawing.Size(117, 33);
            this.lbl_Final_Bill.TabIndex = 7;
            this.lbl_Final_Bill.Text = "Final Bill";
            // 
            // lbl_P_Media
            // 
            this.lbl_P_Media.AutoSize = true;
            this.lbl_P_Media.Font = new System.Drawing.Font("Palatino Linotype", 15F);
            this.lbl_P_Media.ForeColor = System.Drawing.Color.Navy;
            this.lbl_P_Media.Location = new System.Drawing.Point(688, 426);
            this.lbl_P_Media.Name = "lbl_P_Media";
            this.lbl_P_Media.Size = new System.Drawing.Size(189, 33);
            this.lbl_P_Media.TabIndex = 5;
            this.lbl_P_Media.Text = "Payment Media";
            // 
            // lbl_P_Date
            // 
            this.lbl_P_Date.AutoSize = true;
            this.lbl_P_Date.Font = new System.Drawing.Font("Palatino Linotype", 15F);
            this.lbl_P_Date.ForeColor = System.Drawing.Color.Navy;
            this.lbl_P_Date.Location = new System.Drawing.Point(688, 67);
            this.lbl_P_Date.Name = "lbl_P_Date";
            this.lbl_P_Date.Size = new System.Drawing.Size(170, 33);
            this.lbl_P_Date.TabIndex = 3;
            this.lbl_P_Date.Text = "Payment Date";
            // 
            // frm_Payment_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1400, 860);
            this.ControlBox = false;
            this.Controls.Add(this.gb_Payment_Details);
            this.Controls.Add(this.gb_Order_Details);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Payment_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Payment Details";
            this.Load += new System.EventHandler(this.frm_Payment_Details_Load);
            this.gb_Order_Details.ResumeLayout(false);
            this.gb_Order_Details.PerformLayout();
            this.gb_Payment_Details.ResumeLayout(false);
            this.gb_Payment_Details.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Order_Details;
        private System.Windows.Forms.Label lbl_RO_Id;
        private System.Windows.Forms.Label lbl_RO_Date;
        private System.Windows.Forms.TextBox tb_RO_Id;
        private System.Windows.Forms.DateTimePicker dtp_RO_Date;
        private System.Windows.Forms.GroupBox gb_Payment_Details;
        private System.Windows.Forms.TextBox tb_Note;
        private System.Windows.Forms.Label lbl_Note;
        private System.Windows.Forms.TextBox tb_Paying_Amount;
        private System.Windows.Forms.Label lbl_Paying_Amount;
        private System.Windows.Forms.TextBox tb_Balanced_Amount;
        private System.Windows.Forms.Label lbl_Balanced_Amount;
        private System.Windows.Forms.TextBox tb_Paid_Amount;
        private System.Windows.Forms.Label lbl_Paid_Amount;
        private System.Windows.Forms.TextBox tb_Final_Bill;
        private System.Windows.Forms.Label lbl_Final_Bill;
        private System.Windows.Forms.Label lbl_P_Media;
        private System.Windows.Forms.Label lbl_P_Date;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.DateTimePicker dtp_P_Date;
        private System.Windows.Forms.ComboBox cmb_Mode;
        private System.Windows.Forms.TextBox tb_Payment_Id;
        private System.Windows.Forms.Label lbl_Payment_Id;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Refresh;
    }
}