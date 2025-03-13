
namespace Home_Decor_App.Product_Details.Cushion
{
    partial class frm_Add_Cushion
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
            this.lbl_Cus_Comfort = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.tb_Cus_Sales_Price = new System.Windows.Forms.TextBox();
            this.tb_Cus_Purchase_Price = new System.Windows.Forms.TextBox();
            this.tb_Cus_Details = new System.Windows.Forms.TextBox();
            this.tb_Cus_ID = new System.Windows.Forms.TextBox();
            this.lbl_Cus_Sales_Price = new System.Windows.Forms.Label();
            this.lbl_Cus_Purchase_Price = new System.Windows.Forms.Label();
            this.lbl_Cus_Details = new System.Windows.Forms.Label();
            this.lbl_Cus_Size = new System.Windows.Forms.Label();
            this.lbl_Cus_Material = new System.Windows.Forms.Label();
            this.lbl_Cus_Company = new System.Windows.Forms.Label();
            this.lbl_Cus_Id = new System.Windows.Forms.Label();
            this.gb_Add_Cushion_Details = new System.Windows.Forms.GroupBox();
            this.cmb_Cus_Comfort = new System.Windows.Forms.ComboBox();
            this.cmb_Cus_Material = new System.Windows.Forms.ComboBox();
            this.cmb_Cus_Company = new System.Windows.Forms.ComboBox();
            this.cmb_Supplier = new System.Windows.Forms.ComboBox();
            this.cmb_Cus_Size = new System.Windows.Forms.ComboBox();
            this.lbl_Cus_Supplier = new System.Windows.Forms.Label();
            this.tb_Cus_Name = new System.Windows.Forms.TextBox();
            this.lbl_Cus_Name = new System.Windows.Forms.Label();
            this.gb_Add_Cushion_Details.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Cus_Comfort
            // 
            this.lbl_Cus_Comfort.AutoSize = true;
            this.lbl_Cus_Comfort.Font = new System.Drawing.Font("Palatino Linotype", 16F);
            this.lbl_Cus_Comfort.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Cus_Comfort.Location = new System.Drawing.Point(113, 516);
            this.lbl_Cus_Comfort.Name = "lbl_Cus_Comfort";
            this.lbl_Cus_Comfort.Size = new System.Drawing.Size(121, 36);
            this.lbl_Cus_Comfort.TabIndex = 17;
            this.lbl_Cus_Comfort.Text = "Firmness";
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.Blue;
            this.btn_Save.Font = new System.Drawing.Font("Times New Roman", 22F);
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(808, 629);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(215, 60);
            this.btn_Save.TabIndex = 12;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.Blue;
            this.btn_Refresh.Font = new System.Drawing.Font("Times New Roman", 22F);
            this.btn_Refresh.ForeColor = System.Drawing.Color.White;
            this.btn_Refresh.Location = new System.Drawing.Point(297, 629);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(215, 60);
            this.btn_Refresh.TabIndex = 11;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // tb_Cus_Sales_Price
            // 
            this.tb_Cus_Sales_Price.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.tb_Cus_Sales_Price.Location = new System.Drawing.Point(921, 409);
            this.tb_Cus_Sales_Price.MaxLength = 5;
            this.tb_Cus_Sales_Price.Name = "tb_Cus_Sales_Price";
            this.tb_Cus_Sales_Price.Size = new System.Drawing.Size(265, 36);
            this.tb_Cus_Sales_Price.TabIndex = 9;
            this.tb_Cus_Sales_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numeric);
            // 
            // tb_Cus_Purchase_Price
            // 
            this.tb_Cus_Purchase_Price.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.tb_Cus_Purchase_Price.Location = new System.Drawing.Point(921, 297);
            this.tb_Cus_Purchase_Price.MaxLength = 5;
            this.tb_Cus_Purchase_Price.Name = "tb_Cus_Purchase_Price";
            this.tb_Cus_Purchase_Price.Size = new System.Drawing.Size(265, 36);
            this.tb_Cus_Purchase_Price.TabIndex = 8;
            this.tb_Cus_Purchase_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numeric);
            // 
            // tb_Cus_Details
            // 
            this.tb_Cus_Details.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.tb_Cus_Details.Location = new System.Drawing.Point(921, 142);
            this.tb_Cus_Details.MaxLength = 200;
            this.tb_Cus_Details.Multiline = true;
            this.tb_Cus_Details.Name = "tb_Cus_Details";
            this.tb_Cus_Details.Size = new System.Drawing.Size(265, 126);
            this.tb_Cus_Details.TabIndex = 7;
            // 
            // tb_Cus_ID
            // 
            this.tb_Cus_ID.Enabled = false;
            this.tb_Cus_ID.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.tb_Cus_ID.Location = new System.Drawing.Point(314, 72);
            this.tb_Cus_ID.MaxLength = 5;
            this.tb_Cus_ID.Name = "tb_Cus_ID";
            this.tb_Cus_ID.Size = new System.Drawing.Size(277, 36);
            this.tb_Cus_ID.TabIndex = 1;
            this.tb_Cus_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numeric);
            // 
            // lbl_Cus_Sales_Price
            // 
            this.lbl_Cus_Sales_Price.AutoSize = true;
            this.lbl_Cus_Sales_Price.Font = new System.Drawing.Font("Palatino Linotype", 16F);
            this.lbl_Cus_Sales_Price.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Cus_Sales_Price.Location = new System.Drawing.Point(705, 407);
            this.lbl_Cus_Sales_Price.Name = "lbl_Cus_Sales_Price";
            this.lbl_Cus_Sales_Price.Size = new System.Drawing.Size(139, 36);
            this.lbl_Cus_Sales_Price.TabIndex = 8;
            this.lbl_Cus_Sales_Price.Text = "Sales Price";
            // 
            // lbl_Cus_Purchase_Price
            // 
            this.lbl_Cus_Purchase_Price.AutoSize = true;
            this.lbl_Cus_Purchase_Price.Font = new System.Drawing.Font("Palatino Linotype", 16F);
            this.lbl_Cus_Purchase_Price.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Cus_Purchase_Price.Location = new System.Drawing.Point(705, 295);
            this.lbl_Cus_Purchase_Price.Name = "lbl_Cus_Purchase_Price";
            this.lbl_Cus_Purchase_Price.Size = new System.Drawing.Size(186, 36);
            this.lbl_Cus_Purchase_Price.TabIndex = 7;
            this.lbl_Cus_Purchase_Price.Text = "Purchase Price";
            // 
            // lbl_Cus_Details
            // 
            this.lbl_Cus_Details.AutoSize = true;
            this.lbl_Cus_Details.Font = new System.Drawing.Font("Palatino Linotype", 16F);
            this.lbl_Cus_Details.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Cus_Details.Location = new System.Drawing.Point(705, 179);
            this.lbl_Cus_Details.Name = "lbl_Cus_Details";
            this.lbl_Cus_Details.Size = new System.Drawing.Size(203, 36);
            this.lbl_Cus_Details.TabIndex = 6;
            this.lbl_Cus_Details.Text = "Cushion Details";
            // 
            // lbl_Cus_Size
            // 
            this.lbl_Cus_Size.AutoSize = true;
            this.lbl_Cus_Size.Font = new System.Drawing.Font("Palatino Linotype", 16F);
            this.lbl_Cus_Size.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Cus_Size.Location = new System.Drawing.Point(705, 70);
            this.lbl_Cus_Size.Name = "lbl_Cus_Size";
            this.lbl_Cus_Size.Size = new System.Drawing.Size(64, 36);
            this.lbl_Cus_Size.TabIndex = 3;
            this.lbl_Cus_Size.Text = "Size";
            // 
            // lbl_Cus_Material
            // 
            this.lbl_Cus_Material.AutoSize = true;
            this.lbl_Cus_Material.Font = new System.Drawing.Font("Palatino Linotype", 16F);
            this.lbl_Cus_Material.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Cus_Material.Location = new System.Drawing.Point(114, 407);
            this.lbl_Cus_Material.Name = "lbl_Cus_Material";
            this.lbl_Cus_Material.Size = new System.Drawing.Size(113, 36);
            this.lbl_Cus_Material.TabIndex = 2;
            this.lbl_Cus_Material.Text = "Material";
            // 
            // lbl_Cus_Company
            // 
            this.lbl_Cus_Company.AutoSize = true;
            this.lbl_Cus_Company.Font = new System.Drawing.Font("Palatino Linotype", 16F);
            this.lbl_Cus_Company.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Cus_Company.Location = new System.Drawing.Point(113, 295);
            this.lbl_Cus_Company.Name = "lbl_Cus_Company";
            this.lbl_Cus_Company.Size = new System.Drawing.Size(128, 36);
            this.lbl_Cus_Company.TabIndex = 1;
            this.lbl_Cus_Company.Text = "Company";
            // 
            // lbl_Cus_Id
            // 
            this.lbl_Cus_Id.AutoSize = true;
            this.lbl_Cus_Id.Font = new System.Drawing.Font("Palatino Linotype", 16F);
            this.lbl_Cus_Id.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Cus_Id.Location = new System.Drawing.Point(113, 70);
            this.lbl_Cus_Id.Name = "lbl_Cus_Id";
            this.lbl_Cus_Id.Size = new System.Drawing.Size(152, 36);
            this.lbl_Cus_Id.TabIndex = 0;
            this.lbl_Cus_Id.Text = "Cushion ID";
            // 
            // gb_Add_Cushion_Details
            // 
            this.gb_Add_Cushion_Details.BackColor = System.Drawing.Color.LightCyan;
            this.gb_Add_Cushion_Details.Controls.Add(this.cmb_Cus_Comfort);
            this.gb_Add_Cushion_Details.Controls.Add(this.cmb_Cus_Material);
            this.gb_Add_Cushion_Details.Controls.Add(this.cmb_Cus_Company);
            this.gb_Add_Cushion_Details.Controls.Add(this.cmb_Supplier);
            this.gb_Add_Cushion_Details.Controls.Add(this.cmb_Cus_Size);
            this.gb_Add_Cushion_Details.Controls.Add(this.lbl_Cus_Supplier);
            this.gb_Add_Cushion_Details.Controls.Add(this.tb_Cus_Name);
            this.gb_Add_Cushion_Details.Controls.Add(this.lbl_Cus_Name);
            this.gb_Add_Cushion_Details.Controls.Add(this.lbl_Cus_Comfort);
            this.gb_Add_Cushion_Details.Controls.Add(this.btn_Save);
            this.gb_Add_Cushion_Details.Controls.Add(this.btn_Refresh);
            this.gb_Add_Cushion_Details.Controls.Add(this.tb_Cus_Sales_Price);
            this.gb_Add_Cushion_Details.Controls.Add(this.tb_Cus_Purchase_Price);
            this.gb_Add_Cushion_Details.Controls.Add(this.tb_Cus_Details);
            this.gb_Add_Cushion_Details.Controls.Add(this.tb_Cus_ID);
            this.gb_Add_Cushion_Details.Controls.Add(this.lbl_Cus_Sales_Price);
            this.gb_Add_Cushion_Details.Controls.Add(this.lbl_Cus_Purchase_Price);
            this.gb_Add_Cushion_Details.Controls.Add(this.lbl_Cus_Details);
            this.gb_Add_Cushion_Details.Controls.Add(this.lbl_Cus_Size);
            this.gb_Add_Cushion_Details.Controls.Add(this.lbl_Cus_Material);
            this.gb_Add_Cushion_Details.Controls.Add(this.lbl_Cus_Company);
            this.gb_Add_Cushion_Details.Controls.Add(this.lbl_Cus_Id);
            this.gb_Add_Cushion_Details.Font = new System.Drawing.Font("Rockwell", 9F);
            this.gb_Add_Cushion_Details.ForeColor = System.Drawing.Color.Crimson;
            this.gb_Add_Cushion_Details.Location = new System.Drawing.Point(61, 56);
            this.gb_Add_Cushion_Details.Name = "gb_Add_Cushion_Details";
            this.gb_Add_Cushion_Details.Size = new System.Drawing.Size(1280, 737);
            this.gb_Add_Cushion_Details.TabIndex = 5;
            this.gb_Add_Cushion_Details.TabStop = false;
            this.gb_Add_Cushion_Details.Text = "Add Cushion Details";
            // 
            // cmb_Cus_Comfort
            // 
            this.cmb_Cus_Comfort.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.cmb_Cus_Comfort.FormattingEnabled = true;
            this.cmb_Cus_Comfort.Items.AddRange(new object[] {
            "Ultra Firm",
            "Extra Firm",
            "Firm",
            "Medium",
            "Soft",
            "Extra Soft",
            "Ultra Soft",
            "Plush"});
            this.cmb_Cus_Comfort.Location = new System.Drawing.Point(314, 520);
            this.cmb_Cus_Comfort.Name = "cmb_Cus_Comfort";
            this.cmb_Cus_Comfort.Size = new System.Drawing.Size(277, 37);
            this.cmb_Cus_Comfort.TabIndex = 5;
            // 
            // cmb_Cus_Material
            // 
            this.cmb_Cus_Material.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.cmb_Cus_Material.FormattingEnabled = true;
            this.cmb_Cus_Material.Items.AddRange(new object[] {
            "Buckwheat",
            "Cotton",
            "Down",
            "Feather",
            "Foam",
            "Gel Memory Foam",
            "Memory Foam",
            "Polyester",
            "Polypropylene",
            "Wool"});
            this.cmb_Cus_Material.Location = new System.Drawing.Point(315, 409);
            this.cmb_Cus_Material.Name = "cmb_Cus_Material";
            this.cmb_Cus_Material.Size = new System.Drawing.Size(277, 37);
            this.cmb_Cus_Material.TabIndex = 4;
            // 
            // cmb_Cus_Company
            // 
            this.cmb_Cus_Company.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.cmb_Cus_Company.FormattingEnabled = true;
            this.cmb_Cus_Company.Items.AddRange(new object[] {
            "AeroHaven",
            "Duroflex",
            "Kurlon",
            "Refresh",
            "Sleepwell",
            "Springfit",
            "SleepyCat",
            "Wakefit"});
            this.cmb_Cus_Company.Location = new System.Drawing.Point(315, 297);
            this.cmb_Cus_Company.Name = "cmb_Cus_Company";
            this.cmb_Cus_Company.Size = new System.Drawing.Size(277, 37);
            this.cmb_Cus_Company.TabIndex = 3;
            // 
            // cmb_Supplier
            // 
            this.cmb_Supplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Supplier.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.cmb_Supplier.FormattingEnabled = true;
            this.cmb_Supplier.Location = new System.Drawing.Point(921, 518);
            this.cmb_Supplier.Name = "cmb_Supplier";
            this.cmb_Supplier.Size = new System.Drawing.Size(265, 37);
            this.cmb_Supplier.TabIndex = 10;
            // 
            // cmb_Cus_Size
            // 
            this.cmb_Cus_Size.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.cmb_Cus_Size.FormattingEnabled = true;
            this.cmb_Cus_Size.Items.AddRange(new object[] {
            "15 * 15 cm",
            "30 * 30 cm",
            "35 * 35 cm",
            "40 * 40 cm",
            "45 * 45 cm",
            "50 * 50 cm",
            "55 * 55 cm",
            "60 * 60 cm",
            "70 * 70 cm"});
            this.cmb_Cus_Size.Location = new System.Drawing.Point(921, 72);
            this.cmb_Cus_Size.Name = "cmb_Cus_Size";
            this.cmb_Cus_Size.Size = new System.Drawing.Size(265, 37);
            this.cmb_Cus_Size.TabIndex = 6;
            // 
            // lbl_Cus_Supplier
            // 
            this.lbl_Cus_Supplier.AutoSize = true;
            this.lbl_Cus_Supplier.Font = new System.Drawing.Font("Palatino Linotype", 16F);
            this.lbl_Cus_Supplier.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Cus_Supplier.Location = new System.Drawing.Point(705, 518);
            this.lbl_Cus_Supplier.Name = "lbl_Cus_Supplier";
            this.lbl_Cus_Supplier.Size = new System.Drawing.Size(113, 36);
            this.lbl_Cus_Supplier.TabIndex = 21;
            this.lbl_Cus_Supplier.Text = "Supplier";
            // 
            // tb_Cus_Name
            // 
            this.tb_Cus_Name.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.tb_Cus_Name.Location = new System.Drawing.Point(315, 182);
            this.tb_Cus_Name.MaxLength = 50;
            this.tb_Cus_Name.Name = "tb_Cus_Name";
            this.tb_Cus_Name.Size = new System.Drawing.Size(277, 36);
            this.tb_Cus_Name.TabIndex = 2;
            this.tb_Cus_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Letter);
            // 
            // lbl_Cus_Name
            // 
            this.lbl_Cus_Name.AutoSize = true;
            this.lbl_Cus_Name.Font = new System.Drawing.Font("Palatino Linotype", 16F);
            this.lbl_Cus_Name.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Cus_Name.Location = new System.Drawing.Point(113, 180);
            this.lbl_Cus_Name.Name = "lbl_Cus_Name";
            this.lbl_Cus_Name.Size = new System.Drawing.Size(86, 36);
            this.lbl_Cus_Name.TabIndex = 19;
            this.lbl_Cus_Name.Text = "Name";
            // 
            // frm_Add_Cushion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1400, 860);
            this.ControlBox = false;
            this.Controls.Add(this.gb_Add_Cushion_Details);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Add_Cushion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add New Cushion";
            this.Load += new System.EventHandler(this.frm_Add_Cushion_Load);
            this.gb_Add_Cushion_Details.ResumeLayout(false);
            this.gb_Add_Cushion_Details.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbl_Cus_Comfort;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.TextBox tb_Cus_Sales_Price;
        private System.Windows.Forms.TextBox tb_Cus_Purchase_Price;
        private System.Windows.Forms.TextBox tb_Cus_Details;
        private System.Windows.Forms.TextBox tb_Cus_ID;
        private System.Windows.Forms.Label lbl_Cus_Sales_Price;
        private System.Windows.Forms.Label lbl_Cus_Purchase_Price;
        private System.Windows.Forms.Label lbl_Cus_Details;
        private System.Windows.Forms.Label lbl_Cus_Size;
        private System.Windows.Forms.Label lbl_Cus_Material;
        private System.Windows.Forms.Label lbl_Cus_Company;
        private System.Windows.Forms.Label lbl_Cus_Id;
        private System.Windows.Forms.GroupBox gb_Add_Cushion_Details;
        private System.Windows.Forms.Label lbl_Cus_Supplier;
        private System.Windows.Forms.TextBox tb_Cus_Name;
        private System.Windows.Forms.Label lbl_Cus_Name;
        private System.Windows.Forms.ComboBox cmb_Supplier;
        private System.Windows.Forms.ComboBox cmb_Cus_Size;
        private System.Windows.Forms.ComboBox cmb_Cus_Comfort;
        private System.Windows.Forms.ComboBox cmb_Cus_Material;
        private System.Windows.Forms.ComboBox cmb_Cus_Company;
    }
}