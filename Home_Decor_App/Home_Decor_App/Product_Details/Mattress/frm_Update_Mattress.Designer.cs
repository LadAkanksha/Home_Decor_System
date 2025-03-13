
namespace Home_Decor_App.Product_Details.Mattress
{
    partial class frm_Update_Mattress
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
            this.lbl_M_Sales_Price = new System.Windows.Forms.Label();
            this.btn_Update = new System.Windows.Forms.Button();
            this.tb_M_Sales_Price = new System.Windows.Forms.TextBox();
            this.tb_M_Purchase_Price = new System.Windows.Forms.TextBox();
            this.gb_Update_Mattress_Details = new System.Windows.Forms.GroupBox();
            this.tb_M_Details = new System.Windows.Forms.TextBox();
            this.lbl_M_Details = new System.Windows.Forms.Label();
            this.lbl_M_Purchase_Price = new System.Windows.Forms.Label();
            this.gb_Mattress_Details = new System.Windows.Forms.GroupBox();
            this.tb_M_Name = new System.Windows.Forms.TextBox();
            this.lbl_M_Name = new System.Windows.Forms.Label();
            this.lbl_M_Comfort = new System.Windows.Forms.Label();
            this.tb_M_Comfort = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.tb_M_Size = new System.Windows.Forms.TextBox();
            this.tb_M_Material = new System.Windows.Forms.TextBox();
            this.lbl_M_Size = new System.Windows.Forms.Label();
            this.lbl_M_Material = new System.Windows.Forms.Label();
            this.tb_M_Company = new System.Windows.Forms.TextBox();
            this.tb_M_Id = new System.Windows.Forms.TextBox();
            this.lbl_M_Company = new System.Windows.Forms.Label();
            this.lbl_M_Id = new System.Windows.Forms.Label();
            this.gb_Update_Mattress_Details.SuspendLayout();
            this.gb_Mattress_Details.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_M_Sales_Price
            // 
            this.lbl_M_Sales_Price.AutoSize = true;
            this.lbl_M_Sales_Price.Font = new System.Drawing.Font("Palatino Linotype", 16F);
            this.lbl_M_Sales_Price.ForeColor = System.Drawing.Color.Navy;
            this.lbl_M_Sales_Price.Location = new System.Drawing.Point(714, 207);
            this.lbl_M_Sales_Price.Name = "lbl_M_Sales_Price";
            this.lbl_M_Sales_Price.Size = new System.Drawing.Size(139, 36);
            this.lbl_M_Sales_Price.TabIndex = 8;
            this.lbl_M_Sales_Price.Text = "Sales Price";
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.Blue;
            this.btn_Update.Font = new System.Drawing.Font("Times New Roman", 22F);
            this.btn_Update.ForeColor = System.Drawing.Color.White;
            this.btn_Update.Location = new System.Drawing.Point(500, 317);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(203, 53);
            this.btn_Update.TabIndex = 6;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // tb_M_Sales_Price
            // 
            this.tb_M_Sales_Price.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.tb_M_Sales_Price.Location = new System.Drawing.Point(916, 209);
            this.tb_M_Sales_Price.MaxLength = 5;
            this.tb_M_Sales_Price.Name = "tb_M_Sales_Price";
            this.tb_M_Sales_Price.Size = new System.Drawing.Size(243, 36);
            this.tb_M_Sales_Price.TabIndex = 5;
            this.tb_M_Sales_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numeric);
            // 
            // tb_M_Purchase_Price
            // 
            this.tb_M_Purchase_Price.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.tb_M_Purchase_Price.Location = new System.Drawing.Point(350, 209);
            this.tb_M_Purchase_Price.MaxLength = 5;
            this.tb_M_Purchase_Price.Name = "tb_M_Purchase_Price";
            this.tb_M_Purchase_Price.Size = new System.Drawing.Size(220, 36);
            this.tb_M_Purchase_Price.TabIndex = 4;
            this.tb_M_Purchase_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numeric);
            // 
            // gb_Update_Mattress_Details
            // 
            this.gb_Update_Mattress_Details.BackColor = System.Drawing.Color.LightCyan;
            this.gb_Update_Mattress_Details.Controls.Add(this.tb_M_Details);
            this.gb_Update_Mattress_Details.Controls.Add(this.lbl_M_Details);
            this.gb_Update_Mattress_Details.Controls.Add(this.btn_Update);
            this.gb_Update_Mattress_Details.Controls.Add(this.tb_M_Sales_Price);
            this.gb_Update_Mattress_Details.Controls.Add(this.tb_M_Purchase_Price);
            this.gb_Update_Mattress_Details.Controls.Add(this.lbl_M_Purchase_Price);
            this.gb_Update_Mattress_Details.Controls.Add(this.lbl_M_Sales_Price);
            this.gb_Update_Mattress_Details.Font = new System.Drawing.Font("Rockwell", 9F);
            this.gb_Update_Mattress_Details.ForeColor = System.Drawing.Color.Crimson;
            this.gb_Update_Mattress_Details.Location = new System.Drawing.Point(61, 370);
            this.gb_Update_Mattress_Details.Name = "gb_Update_Mattress_Details";
            this.gb_Update_Mattress_Details.Size = new System.Drawing.Size(1280, 409);
            this.gb_Update_Mattress_Details.TabIndex = 0;
            this.gb_Update_Mattress_Details.TabStop = false;
            this.gb_Update_Mattress_Details.Text = "Update Details";
            // 
            // tb_M_Details
            // 
            this.tb_M_Details.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.tb_M_Details.Location = new System.Drawing.Point(584, 33);
            this.tb_M_Details.MaxLength = 50;
            this.tb_M_Details.Multiline = true;
            this.tb_M_Details.Name = "tb_M_Details";
            this.tb_M_Details.Size = new System.Drawing.Size(345, 115);
            this.tb_M_Details.TabIndex = 3;
            // 
            // lbl_M_Details
            // 
            this.lbl_M_Details.AutoSize = true;
            this.lbl_M_Details.Font = new System.Drawing.Font("Palatino Linotype", 16F);
            this.lbl_M_Details.ForeColor = System.Drawing.Color.Navy;
            this.lbl_M_Details.Location = new System.Drawing.Point(361, 69);
            this.lbl_M_Details.Name = "lbl_M_Details";
            this.lbl_M_Details.Size = new System.Drawing.Size(203, 36);
            this.lbl_M_Details.TabIndex = 11;
            this.lbl_M_Details.Text = "Mattress Details";
            // 
            // lbl_M_Purchase_Price
            // 
            this.lbl_M_Purchase_Price.AutoSize = true;
            this.lbl_M_Purchase_Price.Font = new System.Drawing.Font("Palatino Linotype", 16F);
            this.lbl_M_Purchase_Price.ForeColor = System.Drawing.Color.Navy;
            this.lbl_M_Purchase_Price.Location = new System.Drawing.Point(122, 207);
            this.lbl_M_Purchase_Price.Name = "lbl_M_Purchase_Price";
            this.lbl_M_Purchase_Price.Size = new System.Drawing.Size(186, 36);
            this.lbl_M_Purchase_Price.TabIndex = 7;
            this.lbl_M_Purchase_Price.Text = "Purchase Price";
            // 
            // gb_Mattress_Details
            // 
            this.gb_Mattress_Details.BackColor = System.Drawing.Color.LightCyan;
            this.gb_Mattress_Details.Controls.Add(this.tb_M_Name);
            this.gb_Mattress_Details.Controls.Add(this.lbl_M_Name);
            this.gb_Mattress_Details.Controls.Add(this.lbl_M_Comfort);
            this.gb_Mattress_Details.Controls.Add(this.tb_M_Comfort);
            this.gb_Mattress_Details.Controls.Add(this.btn_Search);
            this.gb_Mattress_Details.Controls.Add(this.tb_M_Size);
            this.gb_Mattress_Details.Controls.Add(this.tb_M_Material);
            this.gb_Mattress_Details.Controls.Add(this.lbl_M_Size);
            this.gb_Mattress_Details.Controls.Add(this.lbl_M_Material);
            this.gb_Mattress_Details.Controls.Add(this.tb_M_Company);
            this.gb_Mattress_Details.Controls.Add(this.tb_M_Id);
            this.gb_Mattress_Details.Controls.Add(this.lbl_M_Company);
            this.gb_Mattress_Details.Controls.Add(this.lbl_M_Id);
            this.gb_Mattress_Details.Font = new System.Drawing.Font("Rockwell", 9F);
            this.gb_Mattress_Details.ForeColor = System.Drawing.Color.Crimson;
            this.gb_Mattress_Details.Location = new System.Drawing.Point(61, 56);
            this.gb_Mattress_Details.Name = "gb_Mattress_Details";
            this.gb_Mattress_Details.Size = new System.Drawing.Size(1280, 308);
            this.gb_Mattress_Details.TabIndex = 0;
            this.gb_Mattress_Details.TabStop = false;
            this.gb_Mattress_Details.Text = "Mattress Details";
            // 
            // tb_M_Name
            // 
            this.tb_M_Name.Enabled = false;
            this.tb_M_Name.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.tb_M_Name.Location = new System.Drawing.Point(290, 131);
            this.tb_M_Name.MaxLength = 40;
            this.tb_M_Name.Name = "tb_M_Name";
            this.tb_M_Name.Size = new System.Drawing.Size(277, 36);
            this.tb_M_Name.TabIndex = 0;
            this.tb_M_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Letter);
            // 
            // lbl_M_Name
            // 
            this.lbl_M_Name.AutoSize = true;
            this.lbl_M_Name.Font = new System.Drawing.Font("Palatino Linotype", 16F);
            this.lbl_M_Name.ForeColor = System.Drawing.Color.Navy;
            this.lbl_M_Name.Location = new System.Drawing.Point(89, 129);
            this.lbl_M_Name.Name = "lbl_M_Name";
            this.lbl_M_Name.Size = new System.Drawing.Size(86, 36);
            this.lbl_M_Name.TabIndex = 33;
            this.lbl_M_Name.Text = "Name";
            // 
            // lbl_M_Comfort
            // 
            this.lbl_M_Comfort.AutoSize = true;
            this.lbl_M_Comfort.Font = new System.Drawing.Font("Palatino Linotype", 16F);
            this.lbl_M_Comfort.ForeColor = System.Drawing.Color.Navy;
            this.lbl_M_Comfort.Location = new System.Drawing.Point(709, 41);
            this.lbl_M_Comfort.Name = "lbl_M_Comfort";
            this.lbl_M_Comfort.Size = new System.Drawing.Size(114, 36);
            this.lbl_M_Comfort.TabIndex = 31;
            this.lbl_M_Comfort.Text = "Comfort";
            // 
            // tb_M_Comfort
            // 
            this.tb_M_Comfort.Enabled = false;
            this.tb_M_Comfort.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.tb_M_Comfort.Location = new System.Drawing.Point(910, 43);
            this.tb_M_Comfort.MaxLength = 20;
            this.tb_M_Comfort.Name = "tb_M_Comfort";
            this.tb_M_Comfort.Size = new System.Drawing.Size(277, 36);
            this.tb_M_Comfort.TabIndex = 0;
            this.tb_M_Comfort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Letter);
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.LightPink;
            this.btn_Search.Font = new System.Drawing.Font("Times New Roman", 20F);
            this.btn_Search.ForeColor = System.Drawing.Color.DarkGreen;
            this.btn_Search.Location = new System.Drawing.Point(447, 36);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(131, 45);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // tb_M_Size
            // 
            this.tb_M_Size.Enabled = false;
            this.tb_M_Size.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.tb_M_Size.Location = new System.Drawing.Point(910, 228);
            this.tb_M_Size.MaxLength = 20;
            this.tb_M_Size.Name = "tb_M_Size";
            this.tb_M_Size.Size = new System.Drawing.Size(277, 36);
            this.tb_M_Size.TabIndex = 0;
            // 
            // tb_M_Material
            // 
            this.tb_M_Material.Enabled = false;
            this.tb_M_Material.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.tb_M_Material.Location = new System.Drawing.Point(915, 131);
            this.tb_M_Material.MaxLength = 20;
            this.tb_M_Material.Name = "tb_M_Material";
            this.tb_M_Material.Size = new System.Drawing.Size(277, 36);
            this.tb_M_Material.TabIndex = 0;
            // 
            // lbl_M_Size
            // 
            this.lbl_M_Size.AutoSize = true;
            this.lbl_M_Size.Font = new System.Drawing.Font("Palatino Linotype", 16F);
            this.lbl_M_Size.ForeColor = System.Drawing.Color.Navy;
            this.lbl_M_Size.Location = new System.Drawing.Point(709, 221);
            this.lbl_M_Size.Name = "lbl_M_Size";
            this.lbl_M_Size.Size = new System.Drawing.Size(64, 36);
            this.lbl_M_Size.TabIndex = 28;
            this.lbl_M_Size.Text = "Size";
            // 
            // lbl_M_Material
            // 
            this.lbl_M_Material.AutoSize = true;
            this.lbl_M_Material.Font = new System.Drawing.Font("Palatino Linotype", 16F);
            this.lbl_M_Material.ForeColor = System.Drawing.Color.Navy;
            this.lbl_M_Material.Location = new System.Drawing.Point(709, 129);
            this.lbl_M_Material.Name = "lbl_M_Material";
            this.lbl_M_Material.Size = new System.Drawing.Size(113, 36);
            this.lbl_M_Material.TabIndex = 26;
            this.lbl_M_Material.Text = "Material";
            // 
            // tb_M_Company
            // 
            this.tb_M_Company.Enabled = false;
            this.tb_M_Company.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.tb_M_Company.Location = new System.Drawing.Point(290, 225);
            this.tb_M_Company.MaxLength = 20;
            this.tb_M_Company.Name = "tb_M_Company";
            this.tb_M_Company.Size = new System.Drawing.Size(277, 36);
            this.tb_M_Company.TabIndex = 0;
            // 
            // tb_M_Id
            // 
            this.tb_M_Id.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.tb_M_Id.Location = new System.Drawing.Point(290, 40);
            this.tb_M_Id.MaxLength = 5;
            this.tb_M_Id.Name = "tb_M_Id";
            this.tb_M_Id.Size = new System.Drawing.Size(142, 36);
            this.tb_M_Id.TabIndex = 1;
            this.tb_M_Id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numeric);
            // 
            // lbl_M_Company
            // 
            this.lbl_M_Company.AutoSize = true;
            this.lbl_M_Company.Font = new System.Drawing.Font("Palatino Linotype", 16F);
            this.lbl_M_Company.ForeColor = System.Drawing.Color.Navy;
            this.lbl_M_Company.Location = new System.Drawing.Point(89, 221);
            this.lbl_M_Company.Name = "lbl_M_Company";
            this.lbl_M_Company.Size = new System.Drawing.Size(128, 36);
            this.lbl_M_Company.TabIndex = 24;
            this.lbl_M_Company.Text = "Company";
            // 
            // lbl_M_Id
            // 
            this.lbl_M_Id.AutoSize = true;
            this.lbl_M_Id.Font = new System.Drawing.Font("Palatino Linotype", 16F);
            this.lbl_M_Id.ForeColor = System.Drawing.Color.Navy;
            this.lbl_M_Id.Location = new System.Drawing.Point(89, 38);
            this.lbl_M_Id.Name = "lbl_M_Id";
            this.lbl_M_Id.Size = new System.Drawing.Size(152, 36);
            this.lbl_M_Id.TabIndex = 22;
            this.lbl_M_Id.Text = "Mattress ID";
            // 
            // frm_Update_Mattress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1400, 860);
            this.ControlBox = false;
            this.Controls.Add(this.gb_Update_Mattress_Details);
            this.Controls.Add(this.gb_Mattress_Details);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Update_Mattress";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Update Mattress Details";
            this.Load += new System.EventHandler(this.frm_Update_Mattress_Load);
            this.gb_Update_Mattress_Details.ResumeLayout(false);
            this.gb_Update_Mattress_Details.PerformLayout();
            this.gb_Mattress_Details.ResumeLayout(false);
            this.gb_Mattress_Details.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_M_Sales_Price;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.TextBox tb_M_Sales_Price;
        private System.Windows.Forms.TextBox tb_M_Purchase_Price;
        private System.Windows.Forms.GroupBox gb_Update_Mattress_Details;
        private System.Windows.Forms.Label lbl_M_Purchase_Price;
        private System.Windows.Forms.GroupBox gb_Mattress_Details;
        private System.Windows.Forms.TextBox tb_M_Company;
        private System.Windows.Forms.TextBox tb_M_Id;
        private System.Windows.Forms.Label lbl_M_Company;
        private System.Windows.Forms.Label lbl_M_Id;
        private System.Windows.Forms.TextBox tb_M_Size;
        private System.Windows.Forms.TextBox tb_M_Comfort;
        private System.Windows.Forms.Label lbl_M_Comfort;
        private System.Windows.Forms.TextBox tb_M_Material;
        private System.Windows.Forms.Label lbl_M_Size;
        private System.Windows.Forms.Label lbl_M_Material;
        private System.Windows.Forms.TextBox tb_M_Details;
        private System.Windows.Forms.Label lbl_M_Details;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox tb_M_Name;
        private System.Windows.Forms.Label lbl_M_Name;
    }
}