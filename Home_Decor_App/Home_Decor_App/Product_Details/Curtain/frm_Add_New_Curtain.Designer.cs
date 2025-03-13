
namespace Home_Decor_App.Product_Details.Curtain
{
    partial class frm_Add_New_Curtain
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
            this.cmb_Size = new System.Windows.Forms.ComboBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.tb_Cur_Sales_Price = new System.Windows.Forms.TextBox();
            this.tb_Cur_Purchase_Price = new System.Windows.Forms.TextBox();
            this.tb_Cur_Details = new System.Windows.Forms.TextBox();
            this.tb_Cur_ID = new System.Windows.Forms.TextBox();
            this.lbl_Cur_Sales_Price = new System.Windows.Forms.Label();
            this.lbl_Cur_Purchase_Price = new System.Windows.Forms.Label();
            this.lbl_Cur_Details = new System.Windows.Forms.Label();
            this.lbl_Cur_Size = new System.Windows.Forms.Label();
            this.lbl_Cur_Material = new System.Windows.Forms.Label();
            this.lbl_Cur_Company = new System.Windows.Forms.Label();
            this.lbl_Cur_Id = new System.Windows.Forms.Label();
            this.gb_Add_Curtain_Details = new System.Windows.Forms.GroupBox();
            this.cmb_Cur_Style = new System.Windows.Forms.ComboBox();
            this.cmb_Cur_Material = new System.Windows.Forms.ComboBox();
            this.cmb_Cur_Company = new System.Windows.Forms.ComboBox();
            this.cmb_Supplier = new System.Windows.Forms.ComboBox();
            this.lbl_Cur_Supplier = new System.Windows.Forms.Label();
            this.tb_Cur_Name = new System.Windows.Forms.TextBox();
            this.lbl_Cur_Name = new System.Windows.Forms.Label();
            this.lbl_Style = new System.Windows.Forms.Label();
            this.gb_Add_Curtain_Details.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_Size
            // 
            this.cmb_Size.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.cmb_Size.FormattingEnabled = true;
            this.cmb_Size.Items.AddRange(new object[] {
            "2.15L * 1.50W Meters",
            "1.50L * 1.15W Meters"});
            this.cmb_Size.Location = new System.Drawing.Point(914, 88);
            this.cmb_Size.Name = "cmb_Size";
            this.cmb_Size.Size = new System.Drawing.Size(286, 37);
            this.cmb_Size.TabIndex = 6;
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.Blue;
            this.btn_Save.Font = new System.Drawing.Font("Times New Roman", 22F);
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(825, 644);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(215, 60);
            this.btn_Save.TabIndex = 11;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.Blue;
            this.btn_Refresh.Font = new System.Drawing.Font("Times New Roman", 22F);
            this.btn_Refresh.ForeColor = System.Drawing.Color.White;
            this.btn_Refresh.Location = new System.Drawing.Point(314, 644);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(215, 60);
            this.btn_Refresh.TabIndex = 12;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // tb_Cur_Sales_Price
            // 
            this.tb_Cur_Sales_Price.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.tb_Cur_Sales_Price.Location = new System.Drawing.Point(914, 428);
            this.tb_Cur_Sales_Price.MaxLength = 5;
            this.tb_Cur_Sales_Price.Name = "tb_Cur_Sales_Price";
            this.tb_Cur_Sales_Price.Size = new System.Drawing.Size(286, 36);
            this.tb_Cur_Sales_Price.TabIndex = 9;
            this.tb_Cur_Sales_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numeric);
            // 
            // tb_Cur_Purchase_Price
            // 
            this.tb_Cur_Purchase_Price.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.tb_Cur_Purchase_Price.Location = new System.Drawing.Point(914, 314);
            this.tb_Cur_Purchase_Price.MaxLength = 5;
            this.tb_Cur_Purchase_Price.Name = "tb_Cur_Purchase_Price";
            this.tb_Cur_Purchase_Price.Size = new System.Drawing.Size(286, 36);
            this.tb_Cur_Purchase_Price.TabIndex = 8;
            this.tb_Cur_Purchase_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numeric);
            // 
            // tb_Cur_Details
            // 
            this.tb_Cur_Details.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.tb_Cur_Details.Location = new System.Drawing.Point(914, 169);
            this.tb_Cur_Details.MaxLength = 200;
            this.tb_Cur_Details.Multiline = true;
            this.tb_Cur_Details.Name = "tb_Cur_Details";
            this.tb_Cur_Details.Size = new System.Drawing.Size(286, 110);
            this.tb_Cur_Details.TabIndex = 7;
            // 
            // tb_Cur_ID
            // 
            this.tb_Cur_ID.Enabled = false;
            this.tb_Cur_ID.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.tb_Cur_ID.Location = new System.Drawing.Point(294, 88);
            this.tb_Cur_ID.MaxLength = 5;
            this.tb_Cur_ID.Name = "tb_Cur_ID";
            this.tb_Cur_ID.Size = new System.Drawing.Size(296, 36);
            this.tb_Cur_ID.TabIndex = 1;
            this.tb_Cur_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numeric);
            // 
            // lbl_Cur_Sales_Price
            // 
            this.lbl_Cur_Sales_Price.AutoSize = true;
            this.lbl_Cur_Sales_Price.Font = new System.Drawing.Font("Palatino Linotype", 16F);
            this.lbl_Cur_Sales_Price.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Cur_Sales_Price.Location = new System.Drawing.Point(686, 426);
            this.lbl_Cur_Sales_Price.Name = "lbl_Cur_Sales_Price";
            this.lbl_Cur_Sales_Price.Size = new System.Drawing.Size(139, 36);
            this.lbl_Cur_Sales_Price.TabIndex = 8;
            this.lbl_Cur_Sales_Price.Text = "Sales Price";
            // 
            // lbl_Cur_Purchase_Price
            // 
            this.lbl_Cur_Purchase_Price.AutoSize = true;
            this.lbl_Cur_Purchase_Price.Font = new System.Drawing.Font("Palatino Linotype", 16F);
            this.lbl_Cur_Purchase_Price.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Cur_Purchase_Price.Location = new System.Drawing.Point(686, 312);
            this.lbl_Cur_Purchase_Price.Name = "lbl_Cur_Purchase_Price";
            this.lbl_Cur_Purchase_Price.Size = new System.Drawing.Size(186, 36);
            this.lbl_Cur_Purchase_Price.TabIndex = 7;
            this.lbl_Cur_Purchase_Price.Text = "Purchase Price";
            // 
            // lbl_Cur_Details
            // 
            this.lbl_Cur_Details.AutoSize = true;
            this.lbl_Cur_Details.Font = new System.Drawing.Font("Palatino Linotype", 16F);
            this.lbl_Cur_Details.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Cur_Details.Location = new System.Drawing.Point(686, 192);
            this.lbl_Cur_Details.Name = "lbl_Cur_Details";
            this.lbl_Cur_Details.Size = new System.Drawing.Size(195, 36);
            this.lbl_Cur_Details.TabIndex = 6;
            this.lbl_Cur_Details.Text = "Curtain Details";
            // 
            // lbl_Cur_Size
            // 
            this.lbl_Cur_Size.AutoSize = true;
            this.lbl_Cur_Size.Font = new System.Drawing.Font("Palatino Linotype", 16F);
            this.lbl_Cur_Size.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Cur_Size.Location = new System.Drawing.Point(702, 86);
            this.lbl_Cur_Size.Name = "lbl_Cur_Size";
            this.lbl_Cur_Size.Size = new System.Drawing.Size(64, 36);
            this.lbl_Cur_Size.TabIndex = 3;
            this.lbl_Cur_Size.Text = "Size";
            // 
            // lbl_Cur_Material
            // 
            this.lbl_Cur_Material.AutoSize = true;
            this.lbl_Cur_Material.Font = new System.Drawing.Font("Palatino Linotype", 16F);
            this.lbl_Cur_Material.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Cur_Material.Location = new System.Drawing.Point(99, 426);
            this.lbl_Cur_Material.Name = "lbl_Cur_Material";
            this.lbl_Cur_Material.Size = new System.Drawing.Size(113, 36);
            this.lbl_Cur_Material.TabIndex = 2;
            this.lbl_Cur_Material.Text = "Material";
            // 
            // lbl_Cur_Company
            // 
            this.lbl_Cur_Company.AutoSize = true;
            this.lbl_Cur_Company.Font = new System.Drawing.Font("Palatino Linotype", 16F);
            this.lbl_Cur_Company.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Cur_Company.Location = new System.Drawing.Point(99, 312);
            this.lbl_Cur_Company.Name = "lbl_Cur_Company";
            this.lbl_Cur_Company.Size = new System.Drawing.Size(128, 36);
            this.lbl_Cur_Company.TabIndex = 1;
            this.lbl_Cur_Company.Text = "Company";
            // 
            // lbl_Cur_Id
            // 
            this.lbl_Cur_Id.AutoSize = true;
            this.lbl_Cur_Id.Font = new System.Drawing.Font("Palatino Linotype", 16F);
            this.lbl_Cur_Id.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Cur_Id.Location = new System.Drawing.Point(99, 86);
            this.lbl_Cur_Id.Name = "lbl_Cur_Id";
            this.lbl_Cur_Id.Size = new System.Drawing.Size(144, 36);
            this.lbl_Cur_Id.TabIndex = 0;
            this.lbl_Cur_Id.Text = "Curtain ID";
            // 
            // gb_Add_Curtain_Details
            // 
            this.gb_Add_Curtain_Details.BackColor = System.Drawing.Color.LightCyan;
            this.gb_Add_Curtain_Details.Controls.Add(this.cmb_Cur_Style);
            this.gb_Add_Curtain_Details.Controls.Add(this.cmb_Cur_Material);
            this.gb_Add_Curtain_Details.Controls.Add(this.cmb_Cur_Company);
            this.gb_Add_Curtain_Details.Controls.Add(this.cmb_Supplier);
            this.gb_Add_Curtain_Details.Controls.Add(this.lbl_Cur_Supplier);
            this.gb_Add_Curtain_Details.Controls.Add(this.tb_Cur_Name);
            this.gb_Add_Curtain_Details.Controls.Add(this.lbl_Cur_Name);
            this.gb_Add_Curtain_Details.Controls.Add(this.lbl_Style);
            this.gb_Add_Curtain_Details.Controls.Add(this.cmb_Size);
            this.gb_Add_Curtain_Details.Controls.Add(this.btn_Save);
            this.gb_Add_Curtain_Details.Controls.Add(this.btn_Refresh);
            this.gb_Add_Curtain_Details.Controls.Add(this.tb_Cur_Sales_Price);
            this.gb_Add_Curtain_Details.Controls.Add(this.tb_Cur_Purchase_Price);
            this.gb_Add_Curtain_Details.Controls.Add(this.tb_Cur_Details);
            this.gb_Add_Curtain_Details.Controls.Add(this.tb_Cur_ID);
            this.gb_Add_Curtain_Details.Controls.Add(this.lbl_Cur_Sales_Price);
            this.gb_Add_Curtain_Details.Controls.Add(this.lbl_Cur_Purchase_Price);
            this.gb_Add_Curtain_Details.Controls.Add(this.lbl_Cur_Details);
            this.gb_Add_Curtain_Details.Controls.Add(this.lbl_Cur_Size);
            this.gb_Add_Curtain_Details.Controls.Add(this.lbl_Cur_Material);
            this.gb_Add_Curtain_Details.Controls.Add(this.lbl_Cur_Company);
            this.gb_Add_Curtain_Details.Controls.Add(this.lbl_Cur_Id);
            this.gb_Add_Curtain_Details.Font = new System.Drawing.Font("Rockwell", 9F);
            this.gb_Add_Curtain_Details.ForeColor = System.Drawing.Color.Crimson;
            this.gb_Add_Curtain_Details.Location = new System.Drawing.Point(61, 56);
            this.gb_Add_Curtain_Details.Name = "gb_Add_Curtain_Details";
            this.gb_Add_Curtain_Details.Size = new System.Drawing.Size(1280, 740);
            this.gb_Add_Curtain_Details.TabIndex = 0;
            this.gb_Add_Curtain_Details.TabStop = false;
            this.gb_Add_Curtain_Details.Text = "Add Curtain Details";
            // 
            // cmb_Cur_Style
            // 
            this.cmb_Cur_Style.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.cmb_Cur_Style.FormattingEnabled = true;
            this.cmb_Cur_Style.Items.AddRange(new object[] {
            "Box Pleat",
            "Duo Pleat",
            "Eyelet",
            "Goblet",
            "Goblet with Buttons",
            "Inverted Pleat",
            "Pencil Pleat",
            "Pinch Pleat",
            "Rod Pocket",
            "Slot Top",
            "Tab Top",
            "Tailored Pleat",
            "Tempo Wave",
            "Tie Top"});
            this.cmb_Cur_Style.Location = new System.Drawing.Point(294, 533);
            this.cmb_Cur_Style.Name = "cmb_Cur_Style";
            this.cmb_Cur_Style.Size = new System.Drawing.Size(296, 37);
            this.cmb_Cur_Style.TabIndex = 5;
            // 
            // cmb_Cur_Material
            // 
            this.cmb_Cur_Material.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.cmb_Cur_Material.FormattingEnabled = true;
            this.cmb_Cur_Material.Items.AddRange(new object[] {
            "Acrylic",
            "Cotton",
            "Linen",
            "Nylon",
            "Polycotton",
            "Polyester",
            "Silk",
            "Velvet"});
            this.cmb_Cur_Material.Location = new System.Drawing.Point(294, 428);
            this.cmb_Cur_Material.Name = "cmb_Cur_Material";
            this.cmb_Cur_Material.Size = new System.Drawing.Size(296, 37);
            this.cmb_Cur_Material.TabIndex = 4;
            // 
            // cmb_Cur_Company
            // 
            this.cmb_Cur_Company.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.cmb_Cur_Company.FormattingEnabled = true;
            this.cmb_Cur_Company.Items.AddRange(new object[] {
            "Airwill",
            "Cortina",
            "Wakefit",
            "Sleepwell",
            "Refresh",
            "Dekor World"});
            this.cmb_Cur_Company.Location = new System.Drawing.Point(294, 314);
            this.cmb_Cur_Company.Name = "cmb_Cur_Company";
            this.cmb_Cur_Company.Size = new System.Drawing.Size(296, 37);
            this.cmb_Cur_Company.TabIndex = 3;
            // 
            // cmb_Supplier
            // 
            this.cmb_Supplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Supplier.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.cmb_Supplier.FormattingEnabled = true;
            this.cmb_Supplier.Location = new System.Drawing.Point(914, 533);
            this.cmb_Supplier.Name = "cmb_Supplier";
            this.cmb_Supplier.Size = new System.Drawing.Size(286, 37);
            this.cmb_Supplier.TabIndex = 10;
            // 
            // lbl_Cur_Supplier
            // 
            this.lbl_Cur_Supplier.AutoSize = true;
            this.lbl_Cur_Supplier.Font = new System.Drawing.Font("Palatino Linotype", 16F);
            this.lbl_Cur_Supplier.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Cur_Supplier.Location = new System.Drawing.Point(686, 531);
            this.lbl_Cur_Supplier.Name = "lbl_Cur_Supplier";
            this.lbl_Cur_Supplier.Size = new System.Drawing.Size(113, 36);
            this.lbl_Cur_Supplier.TabIndex = 20;
            this.lbl_Cur_Supplier.Text = "Supplier";
            // 
            // tb_Cur_Name
            // 
            this.tb_Cur_Name.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.tb_Cur_Name.Location = new System.Drawing.Point(294, 194);
            this.tb_Cur_Name.MaxLength = 50;
            this.tb_Cur_Name.Name = "tb_Cur_Name";
            this.tb_Cur_Name.Size = new System.Drawing.Size(296, 36);
            this.tb_Cur_Name.TabIndex = 2;
            this.tb_Cur_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Letter);
            // 
            // lbl_Cur_Name
            // 
            this.lbl_Cur_Name.AutoSize = true;
            this.lbl_Cur_Name.Font = new System.Drawing.Font("Palatino Linotype", 16F);
            this.lbl_Cur_Name.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Cur_Name.Location = new System.Drawing.Point(99, 192);
            this.lbl_Cur_Name.Name = "lbl_Cur_Name";
            this.lbl_Cur_Name.Size = new System.Drawing.Size(86, 36);
            this.lbl_Cur_Name.TabIndex = 2;
            this.lbl_Cur_Name.Text = "Name";
            // 
            // lbl_Style
            // 
            this.lbl_Style.AutoSize = true;
            this.lbl_Style.Font = new System.Drawing.Font("Palatino Linotype", 16F);
            this.lbl_Style.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Style.Location = new System.Drawing.Point(99, 531);
            this.lbl_Style.Name = "lbl_Style";
            this.lbl_Style.Size = new System.Drawing.Size(73, 36);
            this.lbl_Style.TabIndex = 17;
            this.lbl_Style.Text = "Style";
            // 
            // frm_Add_New_Curtain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1400, 860);
            this.ControlBox = false;
            this.Controls.Add(this.gb_Add_Curtain_Details);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Add_New_Curtain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add New Curtain";
            this.Load += new System.EventHandler(this.frm_Add_New_Curtain_Details_Load);
            this.gb_Add_Curtain_Details.ResumeLayout(false);
            this.gb_Add_Curtain_Details.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cmb_Size;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.TextBox tb_Cur_Sales_Price;
        private System.Windows.Forms.TextBox tb_Cur_Purchase_Price;
        private System.Windows.Forms.TextBox tb_Cur_Details;
        private System.Windows.Forms.TextBox tb_Cur_ID;
        private System.Windows.Forms.Label lbl_Cur_Sales_Price;
        private System.Windows.Forms.Label lbl_Cur_Purchase_Price;
        private System.Windows.Forms.Label lbl_Cur_Details;
        private System.Windows.Forms.Label lbl_Cur_Size;
        private System.Windows.Forms.Label lbl_Cur_Material;
        private System.Windows.Forms.Label lbl_Cur_Company;
        private System.Windows.Forms.Label lbl_Cur_Id;
        private System.Windows.Forms.GroupBox gb_Add_Curtain_Details;
        private System.Windows.Forms.Label lbl_Style;
        private System.Windows.Forms.Label lbl_Cur_Supplier;
        private System.Windows.Forms.TextBox tb_Cur_Name;
        private System.Windows.Forms.Label lbl_Cur_Name;
        private System.Windows.Forms.ComboBox cmb_Supplier;
        private System.Windows.Forms.ComboBox cmb_Cur_Style;
        private System.Windows.Forms.ComboBox cmb_Cur_Material;
        private System.Windows.Forms.ComboBox cmb_Cur_Company;
    }
}