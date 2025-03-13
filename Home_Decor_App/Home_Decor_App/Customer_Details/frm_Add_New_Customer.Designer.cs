
namespace Home_Decor_App.Customer_Details
{
    partial class frm_Add_New_Customer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.tb_Final_Bill = new System.Windows.Forms.TextBox();
            this.lbl_FInal_Bill = new System.Windows.Forms.Label();
            this.tb_Discount = new System.Windows.Forms.TextBox();
            this.lbl_Discount = new System.Windows.Forms.Label();
            this.tb_GST = new System.Windows.Forms.TextBox();
            this.lbl_GST = new System.Windows.Forms.Label();
            this.tb_Bill = new System.Windows.Forms.TextBox();
            this.lbl_Bill = new System.Windows.Forms.Label();
            this.tb_Total = new System.Windows.Forms.TextBox();
            this.tb_Price = new System.Windows.Forms.TextBox();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.lbl_Quantity = new System.Windows.Forms.Label();
            this.tb_Product_Name = new System.Windows.Forms.TextBox();
            this.lbl_Product_Name = new System.Windows.Forms.Label();
            this.cmb_Category = new System.Windows.Forms.ComboBox();
            this.dgv_Product_Details = new System.Windows.Forms.DataGridView();
            this.Sr_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_Category = new System.Windows.Forms.Label();
            this.dtp_C_Date = new System.Windows.Forms.DateTimePicker();
            this.tb_C_Mob_No = new System.Windows.Forms.TextBox();
            this.tb_C_Address = new System.Windows.Forms.TextBox();
            this.tb_C_Name = new System.Windows.Forms.TextBox();
            this.tb_C_Id = new System.Windows.Forms.TextBox();
            this.lbl_C_Mob_No = new System.Windows.Forms.Label();
            this.lbl_C_Date = new System.Windows.Forms.Label();
            this.lbl_C_Address = new System.Windows.Forms.Label();
            this.lbl_C_Name = new System.Windows.Forms.Label();
            this.lbl_C_Id = new System.Windows.Forms.Label();
            this.gb_Product_Details = new System.Windows.Forms.GroupBox();
            this.lbl_CStock = new System.Windows.Forms.Label();
            this.tb_Quantity = new System.Windows.Forms.TextBox();
            this.gb_Customer_Details = new System.Windows.Forms.GroupBox();
            this.cmb_Payment_Mode = new System.Windows.Forms.ComboBox();
            this.lbl_Payment_Mode = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Product_Details)).BeginInit();
            this.gb_Product_Details.SuspendLayout();
            this.gb_Customer_Details.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.LightPink;
            this.btn_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Add.Font = new System.Drawing.Font("Times New Roman", 22F);
            this.btn_Add.ForeColor = System.Drawing.Color.DarkGreen;
            this.btn_Add.Location = new System.Drawing.Point(910, 89);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(295, 54);
            this.btn_Add.TabIndex = 9;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.Blue;
            this.btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Save.Font = new System.Drawing.Font("Times New Roman", 22F);
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(748, 468);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(174, 53);
            this.btn_Save.TabIndex = 12;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.Blue;
            this.btn_Refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Refresh.Font = new System.Drawing.Font("Times New Roman", 22F);
            this.btn_Refresh.ForeColor = System.Drawing.Color.White;
            this.btn_Refresh.Location = new System.Drawing.Point(310, 465);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(174, 53);
            this.btn_Refresh.TabIndex = 13;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // tb_Final_Bill
            // 
            this.tb_Final_Bill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Final_Bill.Enabled = false;
            this.tb_Final_Bill.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.tb_Final_Bill.Location = new System.Drawing.Point(1041, 410);
            this.tb_Final_Bill.MaxLength = 7;
            this.tb_Final_Bill.Name = "tb_Final_Bill";
            this.tb_Final_Bill.Size = new System.Drawing.Size(184, 34);
            this.tb_Final_Bill.TabIndex = 0;
            this.tb_Final_Bill.Text = "0";
            // 
            // lbl_FInal_Bill
            // 
            this.lbl_FInal_Bill.AutoSize = true;
            this.lbl_FInal_Bill.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_FInal_Bill.ForeColor = System.Drawing.Color.DeepPink;
            this.lbl_FInal_Bill.Location = new System.Drawing.Point(885, 409);
            this.lbl_FInal_Bill.Name = "lbl_FInal_Bill";
            this.lbl_FInal_Bill.Size = new System.Drawing.Size(140, 37);
            this.lbl_FInal_Bill.TabIndex = 19;
            this.lbl_FInal_Bill.Text = " Final Bill";
            // 
            // tb_Discount
            // 
            this.tb_Discount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Discount.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.tb_Discount.Location = new System.Drawing.Point(728, 410);
            this.tb_Discount.MaxLength = 2;
            this.tb_Discount.Name = "tb_Discount";
            this.tb_Discount.Size = new System.Drawing.Size(119, 34);
            this.tb_Discount.TabIndex = 11;
            this.tb_Discount.Text = "0";
            this.tb_Discount.Click += new System.EventHandler(this.tb_Discount_Click);
            this.tb_Discount.TextChanged += new System.EventHandler(this.tb_Discount_TextChanged);
            this.tb_Discount.Leave += new System.EventHandler(this.tb_Discount_Leave);
            // 
            // lbl_Discount
            // 
            this.lbl_Discount.AutoSize = true;
            this.lbl_Discount.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_Discount.ForeColor = System.Drawing.Color.DeepPink;
            this.lbl_Discount.Location = new System.Drawing.Point(591, 409);
            this.lbl_Discount.Name = "lbl_Discount";
            this.lbl_Discount.Size = new System.Drawing.Size(131, 37);
            this.lbl_Discount.TabIndex = 17;
            this.lbl_Discount.Text = "Discount";
            // 
            // tb_GST
            // 
            this.tb_GST.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_GST.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.tb_GST.Location = new System.Drawing.Point(413, 412);
            this.tb_GST.MaxLength = 2;
            this.tb_GST.Name = "tb_GST";
            this.tb_GST.Size = new System.Drawing.Size(112, 34);
            this.tb_GST.TabIndex = 10;
            this.tb_GST.Text = "0";
            this.tb_GST.Click += new System.EventHandler(this.tb_GST_Click);
            this.tb_GST.TextChanged += new System.EventHandler(this.tb_GST_TextChanged);
            this.tb_GST.Leave += new System.EventHandler(this.tb_GST_Leave);
            // 
            // lbl_GST
            // 
            this.lbl_GST.AutoSize = true;
            this.lbl_GST.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_GST.ForeColor = System.Drawing.Color.DeepPink;
            this.lbl_GST.Location = new System.Drawing.Point(333, 409);
            this.lbl_GST.Name = "lbl_GST";
            this.lbl_GST.Size = new System.Drawing.Size(74, 37);
            this.lbl_GST.TabIndex = 15;
            this.lbl_GST.Text = "GST";
            // 
            // tb_Bill
            // 
            this.tb_Bill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Bill.Enabled = false;
            this.tb_Bill.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.tb_Bill.Location = new System.Drawing.Point(92, 411);
            this.tb_Bill.MaxLength = 7;
            this.tb_Bill.Name = "tb_Bill";
            this.tb_Bill.Size = new System.Drawing.Size(189, 36);
            this.tb_Bill.TabIndex = 0;
            this.tb_Bill.Text = "0";
            // 
            // lbl_Bill
            // 
            this.lbl_Bill.AutoSize = true;
            this.lbl_Bill.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_Bill.ForeColor = System.Drawing.Color.DeepPink;
            this.lbl_Bill.Location = new System.Drawing.Point(24, 409);
            this.lbl_Bill.Name = "lbl_Bill";
            this.lbl_Bill.Size = new System.Drawing.Size(62, 37);
            this.lbl_Bill.TabIndex = 13;
            this.lbl_Bill.Text = "Bill";
            // 
            // tb_Total
            // 
            this.tb_Total.Enabled = false;
            this.tb_Total.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.tb_Total.Location = new System.Drawing.Point(575, 88);
            this.tb_Total.MaxLength = 6;
            this.tb_Total.Name = "tb_Total";
            this.tb_Total.Size = new System.Drawing.Size(289, 34);
            this.tb_Total.TabIndex = 0;
            // 
            // tb_Price
            // 
            this.tb_Price.Enabled = false;
            this.tb_Price.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.tb_Price.Location = new System.Drawing.Point(1006, 35);
            this.tb_Price.MaxLength = 7;
            this.tb_Price.Name = "tb_Price";
            this.tb_Price.Size = new System.Drawing.Size(199, 34);
            this.tb_Price.TabIndex = 0;
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Font = new System.Drawing.Font("Palatino Linotype", 15F);
            this.lbl_Total.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Total.Location = new System.Drawing.Point(421, 89);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(74, 33);
            this.lbl_Total.TabIndex = 9;
            this.lbl_Total.Text = "Total";
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.Font = new System.Drawing.Font("Palatino Linotype", 15F);
            this.lbl_Price.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Price.Location = new System.Drawing.Point(904, 36);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(72, 33);
            this.lbl_Price.TabIndex = 8;
            this.lbl_Price.Text = "Price";
            // 
            // lbl_Quantity
            // 
            this.lbl_Quantity.AutoSize = true;
            this.lbl_Quantity.Font = new System.Drawing.Font("Palatino Linotype", 15F);
            this.lbl_Quantity.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Quantity.Location = new System.Drawing.Point(54, 89);
            this.lbl_Quantity.Name = "lbl_Quantity";
            this.lbl_Quantity.Size = new System.Drawing.Size(114, 33);
            this.lbl_Quantity.TabIndex = 7;
            this.lbl_Quantity.Text = "Quantity";
            // 
            // tb_Product_Name
            // 
            this.tb_Product_Name.Enabled = false;
            this.tb_Product_Name.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.tb_Product_Name.Location = new System.Drawing.Point(575, 35);
            this.tb_Product_Name.MaxLength = 40;
            this.tb_Product_Name.Name = "tb_Product_Name";
            this.tb_Product_Name.Size = new System.Drawing.Size(289, 34);
            this.tb_Product_Name.TabIndex = 0;
            // 
            // lbl_Product_Name
            // 
            this.lbl_Product_Name.AutoSize = true;
            this.lbl_Product_Name.Font = new System.Drawing.Font("Palatino Linotype", 15F);
            this.lbl_Product_Name.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Product_Name.Location = new System.Drawing.Point(384, 32);
            this.lbl_Product_Name.Name = "lbl_Product_Name";
            this.lbl_Product_Name.Size = new System.Drawing.Size(176, 33);
            this.lbl_Product_Name.TabIndex = 5;
            this.lbl_Product_Name.Text = "Product Name";
            // 
            // cmb_Category
            // 
            this.cmb_Category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Category.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.cmb_Category.FormattingEnabled = true;
            this.cmb_Category.Items.AddRange(new object[] {
            "Curtain",
            "Cushion",
            "Mattress",
            "Pillow"});
            this.cmb_Category.Location = new System.Drawing.Point(177, 30);
            this.cmb_Category.MaxLength = 10;
            this.cmb_Category.Name = "cmb_Category";
            this.cmb_Category.Size = new System.Drawing.Size(173, 34);
            this.cmb_Category.TabIndex = 7;
            this.cmb_Category.SelectedIndexChanged += new System.EventHandler(this.cmb_Category_SelectedIndexChanged);
            // 
            // dgv_Product_Details
            // 
            this.dgv_Product_Details.AllowUserToAddRows = false;
            this.dgv_Product_Details.AllowUserToDeleteRows = false;
            this.dgv_Product_Details.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Product_Details.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Rockwell", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Product_Details.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Product_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Product_Details.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sr_No,
            this.Category,
            this.PID,
            this.PName,
            this.Qty,
            this.Price,
            this.Total});
            this.dgv_Product_Details.Location = new System.Drawing.Point(6, 149);
            this.dgv_Product_Details.Name = "dgv_Product_Details";
            this.dgv_Product_Details.ReadOnly = true;
            this.dgv_Product_Details.RowHeadersWidth = 51;
            this.dgv_Product_Details.RowTemplate.Height = 24;
            this.dgv_Product_Details.Size = new System.Drawing.Size(1268, 231);
            this.dgv_Product_Details.TabIndex = 0;
            // 
            // Sr_No
            // 
            this.Sr_No.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Sr_No.HeaderText = "Sr.No.";
            this.Sr_No.MinimumWidth = 6;
            this.Sr_No.Name = "Sr_No";
            this.Sr_No.ReadOnly = true;
            this.Sr_No.Width = 79;
            // 
            // Category
            // 
            this.Category.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Category.HeaderText = "Category";
            this.Category.MinimumWidth = 6;
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            this.Category.Width = 102;
            // 
            // PID
            // 
            this.PID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.PID.HeaderText = "Product ID";
            this.PID.MinimumWidth = 6;
            this.PID.Name = "PID";
            this.PID.ReadOnly = true;
            this.PID.Visible = false;
            this.PID.Width = 125;
            // 
            // PName
            // 
            this.PName.HeaderText = "Product Name";
            this.PName.MinimumWidth = 6;
            this.PName.Name = "PName";
            this.PName.ReadOnly = true;
            // 
            // Qty
            // 
            this.Qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Qty.HeaderText = "Quantity";
            this.Qty.MinimumWidth = 6;
            this.Qty.Name = "Qty";
            this.Qty.ReadOnly = true;
            this.Qty.Width = 98;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // lbl_Category
            // 
            this.lbl_Category.AutoSize = true;
            this.lbl_Category.Font = new System.Drawing.Font("Palatino Linotype", 15F);
            this.lbl_Category.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Category.Location = new System.Drawing.Point(54, 32);
            this.lbl_Category.Name = "lbl_Category";
            this.lbl_Category.Size = new System.Drawing.Size(117, 33);
            this.lbl_Category.TabIndex = 0;
            this.lbl_Category.Text = "Category";
            // 
            // dtp_C_Date
            // 
            this.dtp_C_Date.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.dtp_C_Date.Location = new System.Drawing.Point(898, 33);
            this.dtp_C_Date.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dtp_C_Date.Name = "dtp_C_Date";
            this.dtp_C_Date.Size = new System.Drawing.Size(245, 34);
            this.dtp_C_Date.TabIndex = 4;
            // 
            // tb_C_Mob_No
            // 
            this.tb_C_Mob_No.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.tb_C_Mob_No.Location = new System.Drawing.Point(898, 88);
            this.tb_C_Mob_No.MaxLength = 10;
            this.tb_C_Mob_No.Name = "tb_C_Mob_No";
            this.tb_C_Mob_No.Size = new System.Drawing.Size(245, 34);
            this.tb_C_Mob_No.TabIndex = 5;
            this.tb_C_Mob_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numeric);
            // 
            // tb_C_Address
            // 
            this.tb_C_Address.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.tb_C_Address.Location = new System.Drawing.Point(266, 141);
            this.tb_C_Address.MaxLength = 100;
            this.tb_C_Address.Multiline = true;
            this.tb_C_Address.Name = "tb_C_Address";
            this.tb_C_Address.Size = new System.Drawing.Size(334, 48);
            this.tb_C_Address.TabIndex = 3;
            // 
            // tb_C_Name
            // 
            this.tb_C_Name.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.tb_C_Name.Location = new System.Drawing.Point(266, 88);
            this.tb_C_Name.MaxLength = 50;
            this.tb_C_Name.Name = "tb_C_Name";
            this.tb_C_Name.Size = new System.Drawing.Size(334, 34);
            this.tb_C_Name.TabIndex = 2;
            this.tb_C_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Letter);
            // 
            // tb_C_Id
            // 
            this.tb_C_Id.Enabled = false;
            this.tb_C_Id.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.tb_C_Id.Location = new System.Drawing.Point(266, 36);
            this.tb_C_Id.MaxLength = 5;
            this.tb_C_Id.Name = "tb_C_Id";
            this.tb_C_Id.Size = new System.Drawing.Size(218, 34);
            this.tb_C_Id.TabIndex = 1;
            this.tb_C_Id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numeric);
            // 
            // lbl_C_Mob_No
            // 
            this.lbl_C_Mob_No.AutoSize = true;
            this.lbl_C_Mob_No.Font = new System.Drawing.Font("Palatino Linotype", 15F);
            this.lbl_C_Mob_No.ForeColor = System.Drawing.Color.Navy;
            this.lbl_C_Mob_No.Location = new System.Drawing.Point(693, 89);
            this.lbl_C_Mob_No.Name = "lbl_C_Mob_No";
            this.lbl_C_Mob_No.Size = new System.Drawing.Size(142, 33);
            this.lbl_C_Mob_No.TabIndex = 4;
            this.lbl_C_Mob_No.Text = "Mobile No.";
            // 
            // lbl_C_Date
            // 
            this.lbl_C_Date.AutoSize = true;
            this.lbl_C_Date.Font = new System.Drawing.Font("Palatino Linotype", 15F);
            this.lbl_C_Date.ForeColor = System.Drawing.Color.Navy;
            this.lbl_C_Date.Location = new System.Drawing.Point(693, 37);
            this.lbl_C_Date.Name = "lbl_C_Date";
            this.lbl_C_Date.Size = new System.Drawing.Size(67, 33);
            this.lbl_C_Date.TabIndex = 3;
            this.lbl_C_Date.Text = "Date";
            // 
            // lbl_C_Address
            // 
            this.lbl_C_Address.AutoSize = true;
            this.lbl_C_Address.Font = new System.Drawing.Font("Palatino Linotype", 15F);
            this.lbl_C_Address.ForeColor = System.Drawing.Color.Navy;
            this.lbl_C_Address.Location = new System.Drawing.Point(65, 148);
            this.lbl_C_Address.Name = "lbl_C_Address";
            this.lbl_C_Address.Size = new System.Drawing.Size(106, 33);
            this.lbl_C_Address.TabIndex = 2;
            this.lbl_C_Address.Text = "Address";
            // 
            // lbl_C_Name
            // 
            this.lbl_C_Name.AutoSize = true;
            this.lbl_C_Name.Font = new System.Drawing.Font("Palatino Linotype", 15F);
            this.lbl_C_Name.ForeColor = System.Drawing.Color.Navy;
            this.lbl_C_Name.Location = new System.Drawing.Point(65, 85);
            this.lbl_C_Name.Name = "lbl_C_Name";
            this.lbl_C_Name.Size = new System.Drawing.Size(83, 33);
            this.lbl_C_Name.TabIndex = 1;
            this.lbl_C_Name.Text = "Name";
            // 
            // lbl_C_Id
            // 
            this.lbl_C_Id.AutoSize = true;
            this.lbl_C_Id.Font = new System.Drawing.Font("Palatino Linotype", 15F);
            this.lbl_C_Id.ForeColor = System.Drawing.Color.Navy;
            this.lbl_C_Id.Location = new System.Drawing.Point(65, 33);
            this.lbl_C_Id.Name = "lbl_C_Id";
            this.lbl_C_Id.Size = new System.Drawing.Size(151, 33);
            this.lbl_C_Id.TabIndex = 0;
            this.lbl_C_Id.Text = "Customer Id";
            // 
            // gb_Product_Details
            // 
            this.gb_Product_Details.BackColor = System.Drawing.Color.LightCyan;
            this.gb_Product_Details.Controls.Add(this.lbl_CStock);
            this.gb_Product_Details.Controls.Add(this.tb_Quantity);
            this.gb_Product_Details.Controls.Add(this.btn_Add);
            this.gb_Product_Details.Controls.Add(this.btn_Save);
            this.gb_Product_Details.Controls.Add(this.btn_Refresh);
            this.gb_Product_Details.Controls.Add(this.lbl_Quantity);
            this.gb_Product_Details.Controls.Add(this.tb_Final_Bill);
            this.gb_Product_Details.Controls.Add(this.lbl_FInal_Bill);
            this.gb_Product_Details.Controls.Add(this.tb_Discount);
            this.gb_Product_Details.Controls.Add(this.lbl_Discount);
            this.gb_Product_Details.Controls.Add(this.tb_GST);
            this.gb_Product_Details.Controls.Add(this.lbl_GST);
            this.gb_Product_Details.Controls.Add(this.tb_Bill);
            this.gb_Product_Details.Controls.Add(this.lbl_Bill);
            this.gb_Product_Details.Controls.Add(this.tb_Total);
            this.gb_Product_Details.Controls.Add(this.tb_Price);
            this.gb_Product_Details.Controls.Add(this.lbl_Total);
            this.gb_Product_Details.Controls.Add(this.lbl_Price);
            this.gb_Product_Details.Controls.Add(this.tb_Product_Name);
            this.gb_Product_Details.Controls.Add(this.lbl_Product_Name);
            this.gb_Product_Details.Controls.Add(this.cmb_Category);
            this.gb_Product_Details.Controls.Add(this.dgv_Product_Details);
            this.gb_Product_Details.Controls.Add(this.lbl_Category);
            this.gb_Product_Details.Font = new System.Drawing.Font("Rockwell", 9F);
            this.gb_Product_Details.ForeColor = System.Drawing.Color.Crimson;
            this.gb_Product_Details.Location = new System.Drawing.Point(61, 283);
            this.gb_Product_Details.Name = "gb_Product_Details";
            this.gb_Product_Details.Size = new System.Drawing.Size(1280, 536);
            this.gb_Product_Details.TabIndex = 0;
            this.gb_Product_Details.TabStop = false;
            this.gb_Product_Details.Text = "Purchase Details";
            // 
            // lbl_CStock
            // 
            this.lbl_CStock.AutoSize = true;
            this.lbl_CStock.Font = new System.Drawing.Font("Rockwell", 7F);
            this.lbl_CStock.Location = new System.Drawing.Point(246, 127);
            this.lbl_CStock.Name = "lbl_CStock";
            this.lbl_CStock.Size = new System.Drawing.Size(101, 14);
            this.lbl_CStock.TabIndex = 20;
            this.lbl_CStock.Text = "Available Stock : ";
            this.lbl_CStock.Visible = false;
            // 
            // tb_Quantity
            // 
            this.tb_Quantity.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.tb_Quantity.Location = new System.Drawing.Point(177, 92);
            this.tb_Quantity.MaxLength = 3;
            this.tb_Quantity.Name = "tb_Quantity";
            this.tb_Quantity.Size = new System.Drawing.Size(176, 34);
            this.tb_Quantity.TabIndex = 8;
            this.tb_Quantity.TextChanged += new System.EventHandler(this.tb_Quantity_TextChanged);
            this.tb_Quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numeric);
            // 
            // gb_Customer_Details
            // 
            this.gb_Customer_Details.BackColor = System.Drawing.Color.LightCyan;
            this.gb_Customer_Details.Controls.Add(this.cmb_Payment_Mode);
            this.gb_Customer_Details.Controls.Add(this.lbl_Payment_Mode);
            this.gb_Customer_Details.Controls.Add(this.dtp_C_Date);
            this.gb_Customer_Details.Controls.Add(this.tb_C_Mob_No);
            this.gb_Customer_Details.Controls.Add(this.tb_C_Address);
            this.gb_Customer_Details.Controls.Add(this.tb_C_Name);
            this.gb_Customer_Details.Controls.Add(this.tb_C_Id);
            this.gb_Customer_Details.Controls.Add(this.lbl_C_Mob_No);
            this.gb_Customer_Details.Controls.Add(this.lbl_C_Date);
            this.gb_Customer_Details.Controls.Add(this.lbl_C_Address);
            this.gb_Customer_Details.Controls.Add(this.lbl_C_Name);
            this.gb_Customer_Details.Controls.Add(this.lbl_C_Id);
            this.gb_Customer_Details.Font = new System.Drawing.Font("Rockwell", 9F);
            this.gb_Customer_Details.ForeColor = System.Drawing.Color.Crimson;
            this.gb_Customer_Details.Location = new System.Drawing.Point(61, 56);
            this.gb_Customer_Details.Name = "gb_Customer_Details";
            this.gb_Customer_Details.Size = new System.Drawing.Size(1280, 221);
            this.gb_Customer_Details.TabIndex = 0;
            this.gb_Customer_Details.TabStop = false;
            this.gb_Customer_Details.Text = "Customer Details";
            // 
            // cmb_Payment_Mode
            // 
            this.cmb_Payment_Mode.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.cmb_Payment_Mode.FormattingEnabled = true;
            this.cmb_Payment_Mode.Items.AddRange(new object[] {
            "Cash",
            "Credit Card",
            "UPI"});
            this.cmb_Payment_Mode.Location = new System.Drawing.Point(898, 159);
            this.cmb_Payment_Mode.MaxLength = 20;
            this.cmb_Payment_Mode.Name = "cmb_Payment_Mode";
            this.cmb_Payment_Mode.Size = new System.Drawing.Size(245, 34);
            this.cmb_Payment_Mode.TabIndex = 6;
            // 
            // lbl_Payment_Mode
            // 
            this.lbl_Payment_Mode.AutoSize = true;
            this.lbl_Payment_Mode.Font = new System.Drawing.Font("Palatino Linotype", 15F);
            this.lbl_Payment_Mode.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Payment_Mode.Location = new System.Drawing.Point(693, 156);
            this.lbl_Payment_Mode.Name = "lbl_Payment_Mode";
            this.lbl_Payment_Mode.Size = new System.Drawing.Size(182, 33);
            this.lbl_Payment_Mode.TabIndex = 7;
            this.lbl_Payment_Mode.Text = "Payment Mode";
            // 
            // frm_Add_New_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1400, 860);
            this.ControlBox = false;
            this.Controls.Add(this.gb_Product_Details);
            this.Controls.Add(this.gb_Customer_Details);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Add_New_Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frm_Add_New_Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Product_Details)).EndInit();
            this.gb_Product_Details.ResumeLayout(false);
            this.gb_Product_Details.PerformLayout();
            this.gb_Customer_Details.ResumeLayout(false);
            this.gb_Customer_Details.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.TextBox tb_Final_Bill;
        private System.Windows.Forms.Label lbl_FInal_Bill;
        private System.Windows.Forms.TextBox tb_Discount;
        private System.Windows.Forms.Label lbl_Discount;
        private System.Windows.Forms.TextBox tb_GST;
        private System.Windows.Forms.Label lbl_GST;
        private System.Windows.Forms.TextBox tb_Bill;
        private System.Windows.Forms.Label lbl_Bill;
        private System.Windows.Forms.TextBox tb_Total;
        private System.Windows.Forms.TextBox tb_Price;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.Label lbl_Quantity;
        private System.Windows.Forms.TextBox tb_Product_Name;
        private System.Windows.Forms.Label lbl_Product_Name;
        private System.Windows.Forms.ComboBox cmb_Category;
        private System.Windows.Forms.DataGridView dgv_Product_Details;
        private System.Windows.Forms.Label lbl_Category;
        private System.Windows.Forms.DateTimePicker dtp_C_Date;
        private System.Windows.Forms.TextBox tb_C_Mob_No;
        private System.Windows.Forms.TextBox tb_C_Address;
        private System.Windows.Forms.TextBox tb_C_Name;
        private System.Windows.Forms.TextBox tb_C_Id;
        private System.Windows.Forms.Label lbl_C_Mob_No;
        private System.Windows.Forms.Label lbl_C_Date;
        private System.Windows.Forms.Label lbl_C_Address;
        private System.Windows.Forms.Label lbl_C_Name;
        private System.Windows.Forms.Label lbl_C_Id;
        private System.Windows.Forms.GroupBox gb_Product_Details;
        private System.Windows.Forms.GroupBox gb_Customer_Details;
        private System.Windows.Forms.TextBox tb_Quantity;
        private System.Windows.Forms.ComboBox cmb_Payment_Mode;
        private System.Windows.Forms.Label lbl_Payment_Mode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sr_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn PID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Label lbl_CStock;
    }
}