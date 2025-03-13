
namespace Home_Decor_App.Product_Details.Mattress
{
    partial class frm_Add_Mattress
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
            this.lbl_M_Comfort = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.tb_M_Sales_Price = new System.Windows.Forms.TextBox();
            this.tb_M_Purchase_Price = new System.Windows.Forms.TextBox();
            this.tb_M_Details = new System.Windows.Forms.TextBox();
            this.tb_M_Id = new System.Windows.Forms.TextBox();
            this.lbl_M_Sales_Price = new System.Windows.Forms.Label();
            this.lbl_M_Purchase_Price = new System.Windows.Forms.Label();
            this.lbl_M_Details = new System.Windows.Forms.Label();
            this.lbl_M_Size = new System.Windows.Forms.Label();
            this.lbl_M_Material = new System.Windows.Forms.Label();
            this.lbl_M_Company = new System.Windows.Forms.Label();
            this.lbl_M_Id = new System.Windows.Forms.Label();
            this.gb_Add_Mattress_Details = new System.Windows.Forms.GroupBox();
            this.cmb_M_Comfort = new System.Windows.Forms.ComboBox();
            this.cmb_M_Material = new System.Windows.Forms.ComboBox();
            this.cmb_M_Company = new System.Windows.Forms.ComboBox();
            this.cmb_Supplier = new System.Windows.Forms.ComboBox();
            this.cmb_M_Size = new System.Windows.Forms.ComboBox();
            this.lbl_M_Supplier = new System.Windows.Forms.Label();
            this.tb_M_Name = new System.Windows.Forms.TextBox();
            this.lbl_M_Name = new System.Windows.Forms.Label();
            this.gb_Add_Mattress_Details.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_M_Comfort
            // 
            this.lbl_M_Comfort.AutoSize = true;
            this.lbl_M_Comfort.Font = new System.Drawing.Font("Palatino Linotype", 16F);
            this.lbl_M_Comfort.ForeColor = System.Drawing.Color.Navy;
            this.lbl_M_Comfort.Location = new System.Drawing.Point(83, 512);
            this.lbl_M_Comfort.Name = "lbl_M_Comfort";
            this.lbl_M_Comfort.Size = new System.Drawing.Size(121, 36);
            this.lbl_M_Comfort.TabIndex = 17;
            this.lbl_M_Comfort.Text = "Firmness";
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.Blue;
            this.btn_Save.Font = new System.Drawing.Font("Times New Roman", 22F);
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(779, 628);
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
            this.btn_Refresh.Location = new System.Drawing.Point(264, 628);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(215, 60);
            this.btn_Refresh.TabIndex = 11;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // tb_M_Sales_Price
            // 
            this.tb_M_Sales_Price.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.tb_M_Sales_Price.Location = new System.Drawing.Point(904, 412);
            this.tb_M_Sales_Price.MaxLength = 5;
            this.tb_M_Sales_Price.Name = "tb_M_Sales_Price";
            this.tb_M_Sales_Price.Size = new System.Drawing.Size(302, 36);
            this.tb_M_Sales_Price.TabIndex = 9;
            this.tb_M_Sales_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numeric);
            // 
            // tb_M_Purchase_Price
            // 
            this.tb_M_Purchase_Price.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.tb_M_Purchase_Price.Location = new System.Drawing.Point(904, 305);
            this.tb_M_Purchase_Price.MaxLength = 5;
            this.tb_M_Purchase_Price.Name = "tb_M_Purchase_Price";
            this.tb_M_Purchase_Price.Size = new System.Drawing.Size(302, 36);
            this.tb_M_Purchase_Price.TabIndex = 8;
            this.tb_M_Purchase_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numeric);
            // 
            // tb_M_Details
            // 
            this.tb_M_Details.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.tb_M_Details.Location = new System.Drawing.Point(904, 156);
            this.tb_M_Details.MaxLength = 200;
            this.tb_M_Details.Multiline = true;
            this.tb_M_Details.Name = "tb_M_Details";
            this.tb_M_Details.Size = new System.Drawing.Size(302, 122);
            this.tb_M_Details.TabIndex = 7;
            // 
            // tb_M_Id
            // 
            this.tb_M_Id.Enabled = false;
            this.tb_M_Id.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.tb_M_Id.Location = new System.Drawing.Point(284, 88);
            this.tb_M_Id.MaxLength = 5;
            this.tb_M_Id.Name = "tb_M_Id";
            this.tb_M_Id.Size = new System.Drawing.Size(299, 36);
            this.tb_M_Id.TabIndex = 1;
            this.tb_M_Id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numeric);
            // 
            // lbl_M_Sales_Price
            // 
            this.lbl_M_Sales_Price.AutoSize = true;
            this.lbl_M_Sales_Price.Font = new System.Drawing.Font("Palatino Linotype", 16F);
            this.lbl_M_Sales_Price.ForeColor = System.Drawing.Color.Navy;
            this.lbl_M_Sales_Price.Location = new System.Drawing.Point(668, 410);
            this.lbl_M_Sales_Price.Name = "lbl_M_Sales_Price";
            this.lbl_M_Sales_Price.Size = new System.Drawing.Size(139, 36);
            this.lbl_M_Sales_Price.TabIndex = 8;
            this.lbl_M_Sales_Price.Text = "Sales Price";
            // 
            // lbl_M_Purchase_Price
            // 
            this.lbl_M_Purchase_Price.AutoSize = true;
            this.lbl_M_Purchase_Price.Font = new System.Drawing.Font("Palatino Linotype", 16F);
            this.lbl_M_Purchase_Price.ForeColor = System.Drawing.Color.Navy;
            this.lbl_M_Purchase_Price.Location = new System.Drawing.Point(668, 301);
            this.lbl_M_Purchase_Price.Name = "lbl_M_Purchase_Price";
            this.lbl_M_Purchase_Price.Size = new System.Drawing.Size(186, 36);
            this.lbl_M_Purchase_Price.TabIndex = 7;
            this.lbl_M_Purchase_Price.Text = "Purchase Price";
            // 
            // lbl_M_Details
            // 
            this.lbl_M_Details.AutoSize = true;
            this.lbl_M_Details.Font = new System.Drawing.Font("Palatino Linotype", 16F);
            this.lbl_M_Details.ForeColor = System.Drawing.Color.Navy;
            this.lbl_M_Details.Location = new System.Drawing.Point(668, 192);
            this.lbl_M_Details.Name = "lbl_M_Details";
            this.lbl_M_Details.Size = new System.Drawing.Size(203, 36);
            this.lbl_M_Details.TabIndex = 6;
            this.lbl_M_Details.Text = "Mattress Details";
            // 
            // lbl_M_Size
            // 
            this.lbl_M_Size.AutoSize = true;
            this.lbl_M_Size.Font = new System.Drawing.Font("Palatino Linotype", 16F);
            this.lbl_M_Size.ForeColor = System.Drawing.Color.Navy;
            this.lbl_M_Size.Location = new System.Drawing.Point(681, 86);
            this.lbl_M_Size.Name = "lbl_M_Size";
            this.lbl_M_Size.Size = new System.Drawing.Size(64, 36);
            this.lbl_M_Size.TabIndex = 3;
            this.lbl_M_Size.Text = "Size";
            // 
            // lbl_M_Material
            // 
            this.lbl_M_Material.AutoSize = true;
            this.lbl_M_Material.Font = new System.Drawing.Font("Palatino Linotype", 16F);
            this.lbl_M_Material.ForeColor = System.Drawing.Color.Navy;
            this.lbl_M_Material.Location = new System.Drawing.Point(83, 412);
            this.lbl_M_Material.Name = "lbl_M_Material";
            this.lbl_M_Material.Size = new System.Drawing.Size(113, 36);
            this.lbl_M_Material.TabIndex = 2;
            this.lbl_M_Material.Text = "Material";
            // 
            // lbl_M_Company
            // 
            this.lbl_M_Company.AutoSize = true;
            this.lbl_M_Company.Font = new System.Drawing.Font("Palatino Linotype", 16F);
            this.lbl_M_Company.ForeColor = System.Drawing.Color.Navy;
            this.lbl_M_Company.Location = new System.Drawing.Point(83, 303);
            this.lbl_M_Company.Name = "lbl_M_Company";
            this.lbl_M_Company.Size = new System.Drawing.Size(128, 36);
            this.lbl_M_Company.TabIndex = 1;
            this.lbl_M_Company.Text = "Company";
            // 
            // lbl_M_Id
            // 
            this.lbl_M_Id.AutoSize = true;
            this.lbl_M_Id.Font = new System.Drawing.Font("Palatino Linotype", 16F);
            this.lbl_M_Id.ForeColor = System.Drawing.Color.Navy;
            this.lbl_M_Id.Location = new System.Drawing.Point(83, 86);
            this.lbl_M_Id.Name = "lbl_M_Id";
            this.lbl_M_Id.Size = new System.Drawing.Size(152, 36);
            this.lbl_M_Id.TabIndex = 0;
            this.lbl_M_Id.Text = "Mattress ID";
            // 
            // gb_Add_Mattress_Details
            // 
            this.gb_Add_Mattress_Details.BackColor = System.Drawing.Color.LightCyan;
            this.gb_Add_Mattress_Details.Controls.Add(this.cmb_M_Comfort);
            this.gb_Add_Mattress_Details.Controls.Add(this.cmb_M_Material);
            this.gb_Add_Mattress_Details.Controls.Add(this.cmb_M_Company);
            this.gb_Add_Mattress_Details.Controls.Add(this.cmb_Supplier);
            this.gb_Add_Mattress_Details.Controls.Add(this.cmb_M_Size);
            this.gb_Add_Mattress_Details.Controls.Add(this.lbl_M_Supplier);
            this.gb_Add_Mattress_Details.Controls.Add(this.tb_M_Name);
            this.gb_Add_Mattress_Details.Controls.Add(this.lbl_M_Name);
            this.gb_Add_Mattress_Details.Controls.Add(this.lbl_M_Comfort);
            this.gb_Add_Mattress_Details.Controls.Add(this.btn_Save);
            this.gb_Add_Mattress_Details.Controls.Add(this.btn_Refresh);
            this.gb_Add_Mattress_Details.Controls.Add(this.tb_M_Sales_Price);
            this.gb_Add_Mattress_Details.Controls.Add(this.tb_M_Purchase_Price);
            this.gb_Add_Mattress_Details.Controls.Add(this.tb_M_Details);
            this.gb_Add_Mattress_Details.Controls.Add(this.tb_M_Id);
            this.gb_Add_Mattress_Details.Controls.Add(this.lbl_M_Sales_Price);
            this.gb_Add_Mattress_Details.Controls.Add(this.lbl_M_Purchase_Price);
            this.gb_Add_Mattress_Details.Controls.Add(this.lbl_M_Details);
            this.gb_Add_Mattress_Details.Controls.Add(this.lbl_M_Size);
            this.gb_Add_Mattress_Details.Controls.Add(this.lbl_M_Material);
            this.gb_Add_Mattress_Details.Controls.Add(this.lbl_M_Company);
            this.gb_Add_Mattress_Details.Controls.Add(this.lbl_M_Id);
            this.gb_Add_Mattress_Details.Font = new System.Drawing.Font("Rockwell", 9F);
            this.gb_Add_Mattress_Details.ForeColor = System.Drawing.Color.Crimson;
            this.gb_Add_Mattress_Details.Location = new System.Drawing.Point(61, 56);
            this.gb_Add_Mattress_Details.Name = "gb_Add_Mattress_Details";
            this.gb_Add_Mattress_Details.Size = new System.Drawing.Size(1280, 737);
            this.gb_Add_Mattress_Details.TabIndex = 0;
            this.gb_Add_Mattress_Details.TabStop = false;
            this.gb_Add_Mattress_Details.Text = "Add Mattress Details";
            // 
            // cmb_M_Comfort
            // 
            this.cmb_M_Comfort.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.cmb_M_Comfort.FormattingEnabled = true;
            this.cmb_M_Comfort.Items.AddRange(new object[] {
            "Dual Comfort",
            "Extra Soft",
            "Soft",
            "Medium",
            "Firm",
            "Extra Firm"});
            this.cmb_M_Comfort.Location = new System.Drawing.Point(284, 514);
            this.cmb_M_Comfort.Name = "cmb_M_Comfort";
            this.cmb_M_Comfort.Size = new System.Drawing.Size(299, 37);
            this.cmb_M_Comfort.TabIndex = 5;
            // 
            // cmb_M_Material
            // 
            this.cmb_M_Material.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.cmb_M_Material.FormattingEnabled = true;
            this.cmb_M_Material.Items.AddRange(new object[] {
            "Coir",
            "Cotton",
            "Feather",
            "Gel Memory foam",
            "High Density Foam",
            "Latex",
            "Memory Foam"});
            this.cmb_M_Material.Location = new System.Drawing.Point(284, 414);
            this.cmb_M_Material.Name = "cmb_M_Material";
            this.cmb_M_Material.Size = new System.Drawing.Size(299, 37);
            this.cmb_M_Material.TabIndex = 4;
            // 
            // cmb_M_Company
            // 
            this.cmb_M_Company.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.cmb_M_Company.FormattingEnabled = true;
            this.cmb_M_Company.Items.AddRange(new object[] {
            "Duroflex",
            "Flo",
            "Peps",
            "Refresh",
            "Sleepwell",
            "SleepyCat",
            "Sunday",
            "Wakefit",
            "Wakeup India"});
            this.cmb_M_Company.Location = new System.Drawing.Point(284, 305);
            this.cmb_M_Company.Name = "cmb_M_Company";
            this.cmb_M_Company.Size = new System.Drawing.Size(299, 37);
            this.cmb_M_Company.TabIndex = 3;
            // 
            // cmb_Supplier
            // 
            this.cmb_Supplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Supplier.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.cmb_Supplier.FormattingEnabled = true;
            this.cmb_Supplier.Location = new System.Drawing.Point(904, 516);
            this.cmb_Supplier.Name = "cmb_Supplier";
            this.cmb_Supplier.Size = new System.Drawing.Size(302, 37);
            this.cmb_Supplier.TabIndex = 10;
            // 
            // cmb_M_Size
            // 
            this.cmb_M_Size.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.cmb_M_Size.FormattingEnabled = true;
            this.cmb_M_Size.Items.AddRange(new object[] {
            "King",
            "Queen",
            "Double",
            "Single",
            "30 * 72 in",
            "30 * 75 in",
            "36 * 75 in",
            "36 * 78 in",
            "42 * 72 in",
            "42 * 75 in",
            "42 * 78 in",
            "48 * 75 in",
            "48 * 78 in",
            "60 * 75 in",
            "60 * 78 in",
            "66 * 72 in",
            "66 * 75 in",
            "66 * 78 in",
            "72 * 78 in"});
            this.cmb_M_Size.Location = new System.Drawing.Point(904, 88);
            this.cmb_M_Size.Name = "cmb_M_Size";
            this.cmb_M_Size.Size = new System.Drawing.Size(302, 37);
            this.cmb_M_Size.TabIndex = 6;
            // 
            // lbl_M_Supplier
            // 
            this.lbl_M_Supplier.AutoSize = true;
            this.lbl_M_Supplier.Font = new System.Drawing.Font("Palatino Linotype", 16F);
            this.lbl_M_Supplier.ForeColor = System.Drawing.Color.Navy;
            this.lbl_M_Supplier.Location = new System.Drawing.Point(668, 514);
            this.lbl_M_Supplier.Name = "lbl_M_Supplier";
            this.lbl_M_Supplier.Size = new System.Drawing.Size(113, 36);
            this.lbl_M_Supplier.TabIndex = 21;
            this.lbl_M_Supplier.Text = "Supplier";
            // 
            // tb_M_Name
            // 
            this.tb_M_Name.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.tb_M_Name.Location = new System.Drawing.Point(284, 194);
            this.tb_M_Name.MaxLength = 50;
            this.tb_M_Name.Name = "tb_M_Name";
            this.tb_M_Name.Size = new System.Drawing.Size(299, 36);
            this.tb_M_Name.TabIndex = 2;
            this.tb_M_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Letter);
            // 
            // lbl_M_Name
            // 
            this.lbl_M_Name.AutoSize = true;
            this.lbl_M_Name.Font = new System.Drawing.Font("Palatino Linotype", 16F);
            this.lbl_M_Name.ForeColor = System.Drawing.Color.Navy;
            this.lbl_M_Name.Location = new System.Drawing.Point(83, 192);
            this.lbl_M_Name.Name = "lbl_M_Name";
            this.lbl_M_Name.Size = new System.Drawing.Size(86, 36);
            this.lbl_M_Name.TabIndex = 19;
            this.lbl_M_Name.Text = "Name";
            // 
            // frm_Add_Mattress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1400, 860);
            this.ControlBox = false;
            this.Controls.Add(this.gb_Add_Mattress_Details);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Add_Mattress";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add New Mattress";
            this.Load += new System.EventHandler(this.frm_Add_Mattress_Load);
            this.gb_Add_Mattress_Details.ResumeLayout(false);
            this.gb_Add_Mattress_Details.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbl_M_Comfort;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.TextBox tb_M_Sales_Price;
        private System.Windows.Forms.TextBox tb_M_Purchase_Price;
        private System.Windows.Forms.TextBox tb_M_Details;
        private System.Windows.Forms.TextBox tb_M_Id;
        private System.Windows.Forms.Label lbl_M_Sales_Price;
        private System.Windows.Forms.Label lbl_M_Purchase_Price;
        private System.Windows.Forms.Label lbl_M_Details;
        private System.Windows.Forms.Label lbl_M_Size;
        private System.Windows.Forms.Label lbl_M_Material;
        private System.Windows.Forms.Label lbl_M_Company;
        private System.Windows.Forms.Label lbl_M_Id;
        private System.Windows.Forms.GroupBox gb_Add_Mattress_Details;
        private System.Windows.Forms.Label lbl_M_Supplier;
        private System.Windows.Forms.TextBox tb_M_Name;
        private System.Windows.Forms.Label lbl_M_Name;
        private System.Windows.Forms.ComboBox cmb_Supplier;
        private System.Windows.Forms.ComboBox cmb_M_Size;
        private System.Windows.Forms.ComboBox cmb_M_Comfort;
        private System.Windows.Forms.ComboBox cmb_M_Material;
        private System.Windows.Forms.ComboBox cmb_M_Company;
    }
}