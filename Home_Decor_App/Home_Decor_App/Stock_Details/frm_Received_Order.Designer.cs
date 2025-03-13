
namespace Home_Decor_App.Stock_Details
{
    partial class frm_Received_Order
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
            this.dtp_R_O_Date = new System.Windows.Forms.DateTimePicker();
            this.tb_Quantity = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.tb_Total = new System.Windows.Forms.TextBox();
            this.tb_Price = new System.Windows.Forms.TextBox();
            this.tb_R_O_Id = new System.Windows.Forms.TextBox();
            this.lbl_S_Mob_No = new System.Windows.Forms.Label();
            this.lbl_R_O_Date = new System.Windows.Forms.Label();
            this.lbl_Total_Price = new System.Windows.Forms.Label();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.lbl_Quantity = new System.Windows.Forms.Label();
            this.tb_S_Mob_No = new System.Windows.Forms.TextBox();
            this.lbl_R_O_Id = new System.Windows.Forms.Label();
            this.cmb_Category = new System.Windows.Forms.ComboBox();
            this.dgv_Product_Details = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Purchase_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_Category = new System.Windows.Forms.Label();
            this.lbl_Supplier = new System.Windows.Forms.Label();
            this.gb_Product_Details = new System.Windows.Forms.GroupBox();
            this.tb_Product_Name = new System.Windows.Forms.TextBox();
            this.lbl_Pro_name = new System.Windows.Forms.Label();
            this.tb_Final_Bill = new System.Windows.Forms.TextBox();
            this.lbl_FInal_Bill = new System.Windows.Forms.Label();
            this.tb_GST = new System.Windows.Forms.TextBox();
            this.lbl_GST = new System.Windows.Forms.Label();
            this.tb_Bill = new System.Windows.Forms.TextBox();
            this.lbl_Bill = new System.Windows.Forms.Label();
            this.gb_Supplier_Details = new System.Windows.Forms.GroupBox();
            this.cmb_Supplier = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Product_Details)).BeginInit();
            this.gb_Product_Details.SuspendLayout();
            this.gb_Supplier_Details.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtp_R_O_Date
            // 
            this.dtp_R_O_Date.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.dtp_R_O_Date.Location = new System.Drawing.Point(857, 33);
            this.dtp_R_O_Date.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dtp_R_O_Date.Name = "dtp_R_O_Date";
            this.dtp_R_O_Date.Size = new System.Drawing.Size(266, 34);
            this.dtp_R_O_Date.TabIndex = 3;
            // 
            // tb_Quantity
            // 
            this.tb_Quantity.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.tb_Quantity.Location = new System.Drawing.Point(177, 91);
            this.tb_Quantity.MaxLength = 5;
            this.tb_Quantity.Name = "tb_Quantity";
            this.tb_Quantity.Size = new System.Drawing.Size(176, 34);
            this.tb_Quantity.TabIndex = 6;
            this.tb_Quantity.TextChanged += new System.EventHandler(this.tb_Quantity_TextChanged);
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.LightPink;
            this.btn_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Add.Font = new System.Drawing.Font("Times New Roman", 22F);
            this.btn_Add.ForeColor = System.Drawing.Color.DarkGreen;
            this.btn_Add.Location = new System.Drawing.Point(906, 77);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(302, 59);
            this.btn_Add.TabIndex = 7;
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
            this.btn_Save.Location = new System.Drawing.Point(755, 549);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(174, 53);
            this.btn_Save.TabIndex = 14;
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
            this.btn_Refresh.Location = new System.Drawing.Point(307, 549);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(174, 53);
            this.btn_Refresh.TabIndex = 15;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // tb_Total
            // 
            this.tb_Total.Enabled = false;
            this.tb_Total.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.tb_Total.Location = new System.Drawing.Point(591, 95);
            this.tb_Total.MaxLength = 6;
            this.tb_Total.Name = "tb_Total";
            this.tb_Total.Size = new System.Drawing.Size(228, 34);
            this.tb_Total.TabIndex = 0;
            // 
            // tb_Price
            // 
            this.tb_Price.Enabled = false;
            this.tb_Price.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.tb_Price.Location = new System.Drawing.Point(1049, 21);
            this.tb_Price.MaxLength = 5;
            this.tb_Price.Name = "tb_Price";
            this.tb_Price.Size = new System.Drawing.Size(207, 34);
            this.tb_Price.TabIndex = 0;
            this.tb_Price.TextChanged += new System.EventHandler(this.tb_Price_TextChanged);
            // 
            // tb_R_O_Id
            // 
            this.tb_R_O_Id.Enabled = false;
            this.tb_R_O_Id.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.tb_R_O_Id.Location = new System.Drawing.Point(303, 36);
            this.tb_R_O_Id.MaxLength = 5;
            this.tb_R_O_Id.Name = "tb_R_O_Id";
            this.tb_R_O_Id.Size = new System.Drawing.Size(232, 34);
            this.tb_R_O_Id.TabIndex = 1;
            this.tb_R_O_Id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numeric);
            // 
            // lbl_S_Mob_No
            // 
            this.lbl_S_Mob_No.AutoSize = true;
            this.lbl_S_Mob_No.Font = new System.Drawing.Font("Palatino Linotype", 15F);
            this.lbl_S_Mob_No.ForeColor = System.Drawing.Color.Navy;
            this.lbl_S_Mob_No.Location = new System.Drawing.Point(693, 90);
            this.lbl_S_Mob_No.Name = "lbl_S_Mob_No";
            this.lbl_S_Mob_No.Size = new System.Drawing.Size(142, 33);
            this.lbl_S_Mob_No.TabIndex = 4;
            this.lbl_S_Mob_No.Text = "Mobile No.";
            // 
            // lbl_R_O_Date
            // 
            this.lbl_R_O_Date.AutoSize = true;
            this.lbl_R_O_Date.Font = new System.Drawing.Font("Palatino Linotype", 15F);
            this.lbl_R_O_Date.ForeColor = System.Drawing.Color.Navy;
            this.lbl_R_O_Date.Location = new System.Drawing.Point(693, 33);
            this.lbl_R_O_Date.Name = "lbl_R_O_Date";
            this.lbl_R_O_Date.Size = new System.Drawing.Size(67, 33);
            this.lbl_R_O_Date.TabIndex = 3;
            this.lbl_R_O_Date.Text = "Date";
            // 
            // lbl_Total_Price
            // 
            this.lbl_Total_Price.AutoSize = true;
            this.lbl_Total_Price.Font = new System.Drawing.Font("Palatino Linotype", 15F);
            this.lbl_Total_Price.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Total_Price.Location = new System.Drawing.Point(396, 92);
            this.lbl_Total_Price.Name = "lbl_Total_Price";
            this.lbl_Total_Price.Size = new System.Drawing.Size(137, 33);
            this.lbl_Total_Price.TabIndex = 9;
            this.lbl_Total_Price.Text = "Total Price";
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.Font = new System.Drawing.Font("Palatino Linotype", 15F);
            this.lbl_Price.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Price.Location = new System.Drawing.Point(857, 20);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(179, 33);
            this.lbl_Price.TabIndex = 8;
            this.lbl_Price.Text = "Purchase Price";
            // 
            // lbl_Quantity
            // 
            this.lbl_Quantity.AutoSize = true;
            this.lbl_Quantity.Font = new System.Drawing.Font("Palatino Linotype", 15F);
            this.lbl_Quantity.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Quantity.Location = new System.Drawing.Point(37, 88);
            this.lbl_Quantity.Name = "lbl_Quantity";
            this.lbl_Quantity.Size = new System.Drawing.Size(114, 33);
            this.lbl_Quantity.TabIndex = 7;
            this.lbl_Quantity.Text = "Quantity";
            // 
            // tb_S_Mob_No
            // 
            this.tb_S_Mob_No.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.tb_S_Mob_No.Location = new System.Drawing.Point(857, 93);
            this.tb_S_Mob_No.MaxLength = 10;
            this.tb_S_Mob_No.Name = "tb_S_Mob_No";
            this.tb_S_Mob_No.Size = new System.Drawing.Size(266, 34);
            this.tb_S_Mob_No.TabIndex = 4;
            this.tb_S_Mob_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numeric);
            // 
            // lbl_R_O_Id
            // 
            this.lbl_R_O_Id.AutoSize = true;
            this.lbl_R_O_Id.Font = new System.Drawing.Font("Palatino Linotype", 15F);
            this.lbl_R_O_Id.ForeColor = System.Drawing.Color.Navy;
            this.lbl_R_O_Id.Location = new System.Drawing.Point(74, 33);
            this.lbl_R_O_Id.Name = "lbl_R_O_Id";
            this.lbl_R_O_Id.Size = new System.Drawing.Size(200, 33);
            this.lbl_R_O_Id.TabIndex = 0;
            this.lbl_R_O_Id.Text = "Receive Order Id";
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
            this.cmb_Category.Location = new System.Drawing.Point(177, 23);
            this.cmb_Category.MaxLength = 10;
            this.cmb_Category.Name = "cmb_Category";
            this.cmb_Category.Size = new System.Drawing.Size(176, 34);
            this.cmb_Category.TabIndex = 5;
            this.cmb_Category.SelectedIndexChanged += new System.EventHandler(this.cmb_Category_SelectedIndexChanged);
            // 
            // dgv_Product_Details
            // 
            this.dgv_Product_Details.AllowUserToAddRows = false;
            this.dgv_Product_Details.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Product_Details.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Rockwell", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Product_Details.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Product_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Product_Details.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Category,
            this.Product_Id,
            this.Name,
            this.Quantity,
            this.Purchase_Price,
            this.Total});
            this.dgv_Product_Details.Location = new System.Drawing.Point(18, 148);
            this.dgv_Product_Details.Name = "dgv_Product_Details";
            this.dgv_Product_Details.RowHeadersWidth = 51;
            this.dgv_Product_Details.RowTemplate.Height = 24;
            this.dgv_Product_Details.Size = new System.Drawing.Size(1238, 312);
            this.dgv_Product_Details.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Id.HeaderText = "Sr No.";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Width = 71;
            // 
            // Category
            // 
            this.Category.HeaderText = "Category";
            this.Category.MinimumWidth = 6;
            this.Category.Name = "Category";
            // 
            // Product_Id
            // 
            this.Product_Id.HeaderText = "Product Id";
            this.Product_Id.MinimumWidth = 6;
            this.Product_Id.Name = "Product_Id";
            this.Product_Id.Visible = false;
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            // 
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 91;
            // 
            // Purchase_Price
            // 
            this.Purchase_Price.HeaderText = "Purchase Price";
            this.Purchase_Price.MinimumWidth = 6;
            this.Purchase_Price.Name = "Purchase_Price";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            // 
            // lbl_Category
            // 
            this.lbl_Category.AutoSize = true;
            this.lbl_Category.Font = new System.Drawing.Font("Palatino Linotype", 15F);
            this.lbl_Category.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Category.Location = new System.Drawing.Point(37, 23);
            this.lbl_Category.Name = "lbl_Category";
            this.lbl_Category.Size = new System.Drawing.Size(117, 33);
            this.lbl_Category.TabIndex = 0;
            this.lbl_Category.Text = "Category";
            // 
            // lbl_Supplier
            // 
            this.lbl_Supplier.AutoSize = true;
            this.lbl_Supplier.Font = new System.Drawing.Font("Palatino Linotype", 15F);
            this.lbl_Supplier.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Supplier.Location = new System.Drawing.Point(74, 90);
            this.lbl_Supplier.Name = "lbl_Supplier";
            this.lbl_Supplier.Size = new System.Drawing.Size(108, 33);
            this.lbl_Supplier.TabIndex = 1;
            this.lbl_Supplier.Text = "Supplier";
            // 
            // gb_Product_Details
            // 
            this.gb_Product_Details.BackColor = System.Drawing.Color.LightCyan;
            this.gb_Product_Details.Controls.Add(this.tb_Product_Name);
            this.gb_Product_Details.Controls.Add(this.lbl_Pro_name);
            this.gb_Product_Details.Controls.Add(this.tb_Final_Bill);
            this.gb_Product_Details.Controls.Add(this.lbl_FInal_Bill);
            this.gb_Product_Details.Controls.Add(this.tb_GST);
            this.gb_Product_Details.Controls.Add(this.lbl_GST);
            this.gb_Product_Details.Controls.Add(this.tb_Bill);
            this.gb_Product_Details.Controls.Add(this.lbl_Bill);
            this.gb_Product_Details.Controls.Add(this.tb_Quantity);
            this.gb_Product_Details.Controls.Add(this.btn_Add);
            this.gb_Product_Details.Controls.Add(this.btn_Save);
            this.gb_Product_Details.Controls.Add(this.btn_Refresh);
            this.gb_Product_Details.Controls.Add(this.tb_Total);
            this.gb_Product_Details.Controls.Add(this.tb_Price);
            this.gb_Product_Details.Controls.Add(this.lbl_Total_Price);
            this.gb_Product_Details.Controls.Add(this.lbl_Price);
            this.gb_Product_Details.Controls.Add(this.lbl_Quantity);
            this.gb_Product_Details.Controls.Add(this.cmb_Category);
            this.gb_Product_Details.Controls.Add(this.dgv_Product_Details);
            this.gb_Product_Details.Controls.Add(this.lbl_Category);
            this.gb_Product_Details.Font = new System.Drawing.Font("Rockwell", 8F);
            this.gb_Product_Details.ForeColor = System.Drawing.Color.Crimson;
            this.gb_Product_Details.Location = new System.Drawing.Point(61, 205);
            this.gb_Product_Details.Name = "gb_Product_Details";
            this.gb_Product_Details.Size = new System.Drawing.Size(1280, 613);
            this.gb_Product_Details.TabIndex = 0;
            this.gb_Product_Details.TabStop = false;
            this.gb_Product_Details.Text = "Product Details";
            // 
            // tb_Product_Name
            // 
            this.tb_Product_Name.Enabled = false;
            this.tb_Product_Name.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.tb_Product_Name.Location = new System.Drawing.Point(591, 26);
            this.tb_Product_Name.MaxLength = 6;
            this.tb_Product_Name.Name = "tb_Product_Name";
            this.tb_Product_Name.Size = new System.Drawing.Size(228, 34);
            this.tb_Product_Name.TabIndex = 0;
            // 
            // lbl_Pro_name
            // 
            this.lbl_Pro_name.AutoSize = true;
            this.lbl_Pro_name.Font = new System.Drawing.Font("Palatino Linotype", 15F);
            this.lbl_Pro_name.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Pro_name.Location = new System.Drawing.Point(396, 23);
            this.lbl_Pro_name.Name = "lbl_Pro_name";
            this.lbl_Pro_name.Size = new System.Drawing.Size(176, 33);
            this.lbl_Pro_name.TabIndex = 41;
            this.lbl_Pro_name.Text = "Product Name";
            // 
            // tb_Final_Bill
            // 
            this.tb_Final_Bill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Final_Bill.Enabled = false;
            this.tb_Final_Bill.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.tb_Final_Bill.Location = new System.Drawing.Point(968, 483);
            this.tb_Final_Bill.MaxLength = 6;
            this.tb_Final_Bill.Name = "tb_Final_Bill";
            this.tb_Final_Bill.Size = new System.Drawing.Size(223, 34);
            this.tb_Final_Bill.TabIndex = 10;
            this.tb_Final_Bill.Text = "0";
            // 
            // lbl_FInal_Bill
            // 
            this.lbl_FInal_Bill.AutoSize = true;
            this.lbl_FInal_Bill.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_FInal_Bill.ForeColor = System.Drawing.Color.DeepPink;
            this.lbl_FInal_Bill.Location = new System.Drawing.Point(822, 481);
            this.lbl_FInal_Bill.Name = "lbl_FInal_Bill";
            this.lbl_FInal_Bill.Size = new System.Drawing.Size(140, 37);
            this.lbl_FInal_Bill.TabIndex = 27;
            this.lbl_FInal_Bill.Text = " Final Bill";
            // 
            // tb_GST
            // 
            this.tb_GST.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_GST.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.tb_GST.Location = new System.Drawing.Point(566, 483);
            this.tb_GST.MaxLength = 2;
            this.tb_GST.Name = "tb_GST";
            this.tb_GST.Size = new System.Drawing.Size(174, 34);
            this.tb_GST.TabIndex = 9;
            this.tb_GST.Text = "0";
            this.tb_GST.Click += new System.EventHandler(this.tb_GST_Click);
            this.tb_GST.TextChanged += new System.EventHandler(this.tb_GST_TextChanged);
            this.tb_GST.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numeric);
            this.tb_GST.Leave += new System.EventHandler(this.tb_GST_Leave);
            // 
            // lbl_GST
            // 
            this.lbl_GST.AutoSize = true;
            this.lbl_GST.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_GST.ForeColor = System.Drawing.Color.DeepPink;
            this.lbl_GST.Location = new System.Drawing.Point(435, 478);
            this.lbl_GST.Name = "lbl_GST";
            this.lbl_GST.Size = new System.Drawing.Size(74, 37);
            this.lbl_GST.TabIndex = 23;
            this.lbl_GST.Text = "GST";
            // 
            // tb_Bill
            // 
            this.tb_Bill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Bill.Enabled = false;
            this.tb_Bill.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.tb_Bill.Location = new System.Drawing.Point(141, 484);
            this.tb_Bill.MaxLength = 6;
            this.tb_Bill.Name = "tb_Bill";
            this.tb_Bill.Size = new System.Drawing.Size(223, 36);
            this.tb_Bill.TabIndex = 8;
            this.tb_Bill.Text = "0";
            // 
            // lbl_Bill
            // 
            this.lbl_Bill.AutoSize = true;
            this.lbl_Bill.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_Bill.ForeColor = System.Drawing.Color.DeepPink;
            this.lbl_Bill.Location = new System.Drawing.Point(73, 477);
            this.lbl_Bill.Name = "lbl_Bill";
            this.lbl_Bill.Size = new System.Drawing.Size(62, 37);
            this.lbl_Bill.TabIndex = 20;
            this.lbl_Bill.Text = "Bill";
            // 
            // gb_Supplier_Details
            // 
            this.gb_Supplier_Details.BackColor = System.Drawing.Color.LightCyan;
            this.gb_Supplier_Details.Controls.Add(this.cmb_Supplier);
            this.gb_Supplier_Details.Controls.Add(this.dtp_R_O_Date);
            this.gb_Supplier_Details.Controls.Add(this.tb_S_Mob_No);
            this.gb_Supplier_Details.Controls.Add(this.tb_R_O_Id);
            this.gb_Supplier_Details.Controls.Add(this.lbl_S_Mob_No);
            this.gb_Supplier_Details.Controls.Add(this.lbl_R_O_Date);
            this.gb_Supplier_Details.Controls.Add(this.lbl_Supplier);
            this.gb_Supplier_Details.Controls.Add(this.lbl_R_O_Id);
            this.gb_Supplier_Details.Font = new System.Drawing.Font("Rockwell", 8F);
            this.gb_Supplier_Details.ForeColor = System.Drawing.Color.Crimson;
            this.gb_Supplier_Details.Location = new System.Drawing.Point(61, 56);
            this.gb_Supplier_Details.Name = "gb_Supplier_Details";
            this.gb_Supplier_Details.Size = new System.Drawing.Size(1280, 143);
            this.gb_Supplier_Details.TabIndex = 0;
            this.gb_Supplier_Details.TabStop = false;
            this.gb_Supplier_Details.Text = " Supplier Details";
            // 
            // cmb_Supplier
            // 
            this.cmb_Supplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Supplier.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.cmb_Supplier.FormattingEnabled = true;
            this.cmb_Supplier.Location = new System.Drawing.Point(303, 93);
            this.cmb_Supplier.MaxLength = 10;
            this.cmb_Supplier.Name = "cmb_Supplier";
            this.cmb_Supplier.Size = new System.Drawing.Size(232, 34);
            this.cmb_Supplier.TabIndex = 2;
            this.cmb_Supplier.SelectedIndexChanged += new System.EventHandler(this.cmb_Supplier_SelectedIndexChanged);
            // 
            // frm_Received_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1400, 860);
            this.ControlBox = false;
            this.Controls.Add(this.gb_Product_Details);
            this.Controls.Add(this.gb_Supplier_Details);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Received Order Details";
            this.Load += new System.EventHandler(this.frm_Received_Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Product_Details)).EndInit();
            this.gb_Product_Details.ResumeLayout(false);
            this.gb_Product_Details.PerformLayout();
            this.gb_Supplier_Details.ResumeLayout(false);
            this.gb_Supplier_Details.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_R_O_Date;
        private System.Windows.Forms.TextBox tb_Quantity;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.TextBox tb_Total;
        private System.Windows.Forms.TextBox tb_Price;
        private System.Windows.Forms.TextBox tb_R_O_Id;
        private System.Windows.Forms.Label lbl_S_Mob_No;
        private System.Windows.Forms.Label lbl_R_O_Date;
        private System.Windows.Forms.Label lbl_Total_Price;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.Label lbl_Quantity;
        private System.Windows.Forms.TextBox tb_S_Mob_No;
        private System.Windows.Forms.Label lbl_R_O_Id;
        private System.Windows.Forms.ComboBox cmb_Category;
        private System.Windows.Forms.DataGridView dgv_Product_Details;
        private System.Windows.Forms.Label lbl_Category;
        private System.Windows.Forms.Label lbl_Supplier;
        private System.Windows.Forms.GroupBox gb_Product_Details;
        private System.Windows.Forms.GroupBox gb_Supplier_Details;
        private System.Windows.Forms.TextBox tb_Final_Bill;
        private System.Windows.Forms.Label lbl_FInal_Bill;
        private System.Windows.Forms.TextBox tb_GST;
        private System.Windows.Forms.Label lbl_GST;
        private System.Windows.Forms.TextBox tb_Bill;
        private System.Windows.Forms.Label lbl_Bill;
        private System.Windows.Forms.Label lbl_Pro_name;
        private System.Windows.Forms.ComboBox cmb_Supplier;
        private System.Windows.Forms.TextBox tb_Product_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Purchase_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}