
namespace Home_Decor_App.Product_Details.Pillow
{
    partial class frm_Update_Pillow
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
            this.gb_Pillow_Details = new System.Windows.Forms.GroupBox();
            this.tb_P_Name = new System.Windows.Forms.TextBox();
            this.lbl_P_Name = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.tb_P_Size = new System.Windows.Forms.TextBox();
            this.tb_P_Comfort = new System.Windows.Forms.TextBox();
            this.lbl_P_Comfort = new System.Windows.Forms.Label();
            this.tb_P_Material = new System.Windows.Forms.TextBox();
            this.lbl_P_Size = new System.Windows.Forms.Label();
            this.lbl_P_Material = new System.Windows.Forms.Label();
            this.tb_P_Company = new System.Windows.Forms.TextBox();
            this.tb_P_Id = new System.Windows.Forms.TextBox();
            this.lbl_P_Company = new System.Windows.Forms.Label();
            this.lbl_P_Id = new System.Windows.Forms.Label();
            this.gb_Update_Pillow_Details = new System.Windows.Forms.GroupBox();
            this.tb_P_Sales_Price = new System.Windows.Forms.TextBox();
            this.tb_P_Purchase_Price = new System.Windows.Forms.TextBox();
            this.lbl_P_Sales_Price = new System.Windows.Forms.Label();
            this.lbl_P_Purchase_Price = new System.Windows.Forms.Label();
            this.tb_P_Details = new System.Windows.Forms.TextBox();
            this.lbl_P_Details = new System.Windows.Forms.Label();
            this.btn_Update = new System.Windows.Forms.Button();
            this.gb_Pillow_Details.SuspendLayout();
            this.gb_Update_Pillow_Details.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Pillow_Details
            // 
            this.gb_Pillow_Details.BackColor = System.Drawing.Color.LightCyan;
            this.gb_Pillow_Details.Controls.Add(this.tb_P_Name);
            this.gb_Pillow_Details.Controls.Add(this.lbl_P_Name);
            this.gb_Pillow_Details.Controls.Add(this.btn_Search);
            this.gb_Pillow_Details.Controls.Add(this.tb_P_Size);
            this.gb_Pillow_Details.Controls.Add(this.tb_P_Comfort);
            this.gb_Pillow_Details.Controls.Add(this.lbl_P_Comfort);
            this.gb_Pillow_Details.Controls.Add(this.tb_P_Material);
            this.gb_Pillow_Details.Controls.Add(this.lbl_P_Size);
            this.gb_Pillow_Details.Controls.Add(this.lbl_P_Material);
            this.gb_Pillow_Details.Controls.Add(this.tb_P_Company);
            this.gb_Pillow_Details.Controls.Add(this.tb_P_Id);
            this.gb_Pillow_Details.Controls.Add(this.lbl_P_Company);
            this.gb_Pillow_Details.Controls.Add(this.lbl_P_Id);
            this.gb_Pillow_Details.Font = new System.Drawing.Font("Rockwell", 9F);
            this.gb_Pillow_Details.ForeColor = System.Drawing.Color.Crimson;
            this.gb_Pillow_Details.Location = new System.Drawing.Point(61, 56);
            this.gb_Pillow_Details.Name = "gb_Pillow_Details";
            this.gb_Pillow_Details.Size = new System.Drawing.Size(1280, 308);
            this.gb_Pillow_Details.TabIndex = 0;
            this.gb_Pillow_Details.TabStop = false;
            this.gb_Pillow_Details.Text = "Pillow Details";
            // 
            // tb_P_Name
            // 
            this.tb_P_Name.Enabled = false;
            this.tb_P_Name.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.tb_P_Name.Location = new System.Drawing.Point(300, 138);
            this.tb_P_Name.MaxLength = 40;
            this.tb_P_Name.Name = "tb_P_Name";
            this.tb_P_Name.Size = new System.Drawing.Size(277, 36);
            this.tb_P_Name.TabIndex = 0;
            this.tb_P_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Letter);
            // 
            // lbl_P_Name
            // 
            this.lbl_P_Name.AutoSize = true;
            this.lbl_P_Name.Font = new System.Drawing.Font("Palatino Linotype", 16F);
            this.lbl_P_Name.ForeColor = System.Drawing.Color.Navy;
            this.lbl_P_Name.Location = new System.Drawing.Point(112, 136);
            this.lbl_P_Name.Name = "lbl_P_Name";
            this.lbl_P_Name.Size = new System.Drawing.Size(86, 36);
            this.lbl_P_Name.TabIndex = 33;
            this.lbl_P_Name.Text = "Name";
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.LightPink;
            this.btn_Search.Font = new System.Drawing.Font("Times New Roman", 20F);
            this.btn_Search.ForeColor = System.Drawing.Color.DarkGreen;
            this.btn_Search.Location = new System.Drawing.Point(461, 44);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(135, 47);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // tb_P_Size
            // 
            this.tb_P_Size.Enabled = false;
            this.tb_P_Size.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.tb_P_Size.Location = new System.Drawing.Point(875, 227);
            this.tb_P_Size.MaxLength = 20;
            this.tb_P_Size.Name = "tb_P_Size";
            this.tb_P_Size.Size = new System.Drawing.Size(277, 36);
            this.tb_P_Size.TabIndex = 0;
            // 
            // tb_P_Comfort
            // 
            this.tb_P_Comfort.Enabled = false;
            this.tb_P_Comfort.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.tb_P_Comfort.Location = new System.Drawing.Point(875, 52);
            this.tb_P_Comfort.MaxLength = 20;
            this.tb_P_Comfort.Name = "tb_P_Comfort";
            this.tb_P_Comfort.Size = new System.Drawing.Size(277, 36);
            this.tb_P_Comfort.TabIndex = 0;
            this.tb_P_Comfort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Letter);
            // 
            // lbl_P_Comfort
            // 
            this.lbl_P_Comfort.AutoSize = true;
            this.lbl_P_Comfort.Font = new System.Drawing.Font("Palatino Linotype", 16F);
            this.lbl_P_Comfort.ForeColor = System.Drawing.Color.Navy;
            this.lbl_P_Comfort.Location = new System.Drawing.Point(704, 50);
            this.lbl_P_Comfort.Name = "lbl_P_Comfort";
            this.lbl_P_Comfort.Size = new System.Drawing.Size(114, 36);
            this.lbl_P_Comfort.TabIndex = 31;
            this.lbl_P_Comfort.Text = "Comfort";
            // 
            // tb_P_Material
            // 
            this.tb_P_Material.Enabled = false;
            this.tb_P_Material.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.tb_P_Material.Location = new System.Drawing.Point(875, 138);
            this.tb_P_Material.MaxLength = 20;
            this.tb_P_Material.Name = "tb_P_Material";
            this.tb_P_Material.Size = new System.Drawing.Size(277, 36);
            this.tb_P_Material.TabIndex = 0;
            // 
            // lbl_P_Size
            // 
            this.lbl_P_Size.AutoSize = true;
            this.lbl_P_Size.Font = new System.Drawing.Font("Palatino Linotype", 16F);
            this.lbl_P_Size.ForeColor = System.Drawing.Color.Navy;
            this.lbl_P_Size.Location = new System.Drawing.Point(704, 227);
            this.lbl_P_Size.Name = "lbl_P_Size";
            this.lbl_P_Size.Size = new System.Drawing.Size(64, 36);
            this.lbl_P_Size.TabIndex = 28;
            this.lbl_P_Size.Text = "Size";
            // 
            // lbl_P_Material
            // 
            this.lbl_P_Material.AutoSize = true;
            this.lbl_P_Material.Font = new System.Drawing.Font("Palatino Linotype", 16F);
            this.lbl_P_Material.ForeColor = System.Drawing.Color.Navy;
            this.lbl_P_Material.Location = new System.Drawing.Point(704, 136);
            this.lbl_P_Material.Name = "lbl_P_Material";
            this.lbl_P_Material.Size = new System.Drawing.Size(113, 36);
            this.lbl_P_Material.TabIndex = 26;
            this.lbl_P_Material.Text = "Material";
            // 
            // tb_P_Company
            // 
            this.tb_P_Company.Enabled = false;
            this.tb_P_Company.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.tb_P_Company.Location = new System.Drawing.Point(300, 229);
            this.tb_P_Company.MaxLength = 20;
            this.tb_P_Company.Name = "tb_P_Company";
            this.tb_P_Company.Size = new System.Drawing.Size(277, 36);
            this.tb_P_Company.TabIndex = 0;
            // 
            // tb_P_Id
            // 
            this.tb_P_Id.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.tb_P_Id.Location = new System.Drawing.Point(300, 51);
            this.tb_P_Id.MaxLength = 5;
            this.tb_P_Id.Name = "tb_P_Id";
            this.tb_P_Id.Size = new System.Drawing.Size(145, 36);
            this.tb_P_Id.TabIndex = 1;
            this.tb_P_Id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numeric);
            // 
            // lbl_P_Company
            // 
            this.lbl_P_Company.AutoSize = true;
            this.lbl_P_Company.Font = new System.Drawing.Font("Palatino Linotype", 16F);
            this.lbl_P_Company.ForeColor = System.Drawing.Color.Navy;
            this.lbl_P_Company.Location = new System.Drawing.Point(112, 225);
            this.lbl_P_Company.Name = "lbl_P_Company";
            this.lbl_P_Company.Size = new System.Drawing.Size(128, 36);
            this.lbl_P_Company.TabIndex = 24;
            this.lbl_P_Company.Text = "Company";
            // 
            // lbl_P_Id
            // 
            this.lbl_P_Id.AutoSize = true;
            this.lbl_P_Id.Font = new System.Drawing.Font("Palatino Linotype", 16F);
            this.lbl_P_Id.ForeColor = System.Drawing.Color.Navy;
            this.lbl_P_Id.Location = new System.Drawing.Point(112, 49);
            this.lbl_P_Id.Name = "lbl_P_Id";
            this.lbl_P_Id.Size = new System.Drawing.Size(128, 36);
            this.lbl_P_Id.TabIndex = 22;
            this.lbl_P_Id.Text = "Pillow ID";
            // 
            // gb_Update_Pillow_Details
            // 
            this.gb_Update_Pillow_Details.BackColor = System.Drawing.Color.LightCyan;
            this.gb_Update_Pillow_Details.Controls.Add(this.tb_P_Sales_Price);
            this.gb_Update_Pillow_Details.Controls.Add(this.tb_P_Purchase_Price);
            this.gb_Update_Pillow_Details.Controls.Add(this.lbl_P_Sales_Price);
            this.gb_Update_Pillow_Details.Controls.Add(this.lbl_P_Purchase_Price);
            this.gb_Update_Pillow_Details.Controls.Add(this.tb_P_Details);
            this.gb_Update_Pillow_Details.Controls.Add(this.lbl_P_Details);
            this.gb_Update_Pillow_Details.Controls.Add(this.btn_Update);
            this.gb_Update_Pillow_Details.Font = new System.Drawing.Font("Rockwell", 8F);
            this.gb_Update_Pillow_Details.ForeColor = System.Drawing.Color.Crimson;
            this.gb_Update_Pillow_Details.Location = new System.Drawing.Point(61, 370);
            this.gb_Update_Pillow_Details.Name = "gb_Update_Pillow_Details";
            this.gb_Update_Pillow_Details.Size = new System.Drawing.Size(1280, 409);
            this.gb_Update_Pillow_Details.TabIndex = 0;
            this.gb_Update_Pillow_Details.TabStop = false;
            this.gb_Update_Pillow_Details.Text = "Update Details";
            // 
            // tb_P_Sales_Price
            // 
            this.tb_P_Sales_Price.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.tb_P_Sales_Price.Location = new System.Drawing.Point(936, 214);
            this.tb_P_Sales_Price.MaxLength = 5;
            this.tb_P_Sales_Price.Name = "tb_P_Sales_Price";
            this.tb_P_Sales_Price.Size = new System.Drawing.Size(239, 36);
            this.tb_P_Sales_Price.TabIndex = 5;
            this.tb_P_Sales_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numeric);
            // 
            // tb_P_Purchase_Price
            // 
            this.tb_P_Purchase_Price.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.tb_P_Purchase_Price.Location = new System.Drawing.Point(363, 216);
            this.tb_P_Purchase_Price.MaxLength = 5;
            this.tb_P_Purchase_Price.Name = "tb_P_Purchase_Price";
            this.tb_P_Purchase_Price.Size = new System.Drawing.Size(227, 36);
            this.tb_P_Purchase_Price.TabIndex = 4;
            this.tb_P_Purchase_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numeric);
            // 
            // lbl_P_Sales_Price
            // 
            this.lbl_P_Sales_Price.AutoSize = true;
            this.lbl_P_Sales_Price.Font = new System.Drawing.Font("Palatino Linotype", 16F);
            this.lbl_P_Sales_Price.ForeColor = System.Drawing.Color.Navy;
            this.lbl_P_Sales_Price.Location = new System.Drawing.Point(749, 214);
            this.lbl_P_Sales_Price.Name = "lbl_P_Sales_Price";
            this.lbl_P_Sales_Price.Size = new System.Drawing.Size(139, 36);
            this.lbl_P_Sales_Price.TabIndex = 15;
            this.lbl_P_Sales_Price.Text = "Sales Price";
            // 
            // lbl_P_Purchase_Price
            // 
            this.lbl_P_Purchase_Price.AutoSize = true;
            this.lbl_P_Purchase_Price.Font = new System.Drawing.Font("Palatino Linotype", 16F);
            this.lbl_P_Purchase_Price.ForeColor = System.Drawing.Color.Navy;
            this.lbl_P_Purchase_Price.Location = new System.Drawing.Point(140, 216);
            this.lbl_P_Purchase_Price.Name = "lbl_P_Purchase_Price";
            this.lbl_P_Purchase_Price.Size = new System.Drawing.Size(186, 36);
            this.lbl_P_Purchase_Price.TabIndex = 13;
            this.lbl_P_Purchase_Price.Text = "Purchase Price";
            // 
            // tb_P_Details
            // 
            this.tb_P_Details.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.tb_P_Details.Location = new System.Drawing.Point(580, 30);
            this.tb_P_Details.MaxLength = 50;
            this.tb_P_Details.Multiline = true;
            this.tb_P_Details.Name = "tb_P_Details";
            this.tb_P_Details.Size = new System.Drawing.Size(345, 115);
            this.tb_P_Details.TabIndex = 3;
            // 
            // lbl_P_Details
            // 
            this.lbl_P_Details.AutoSize = true;
            this.lbl_P_Details.Font = new System.Drawing.Font("Palatino Linotype", 16F);
            this.lbl_P_Details.ForeColor = System.Drawing.Color.Navy;
            this.lbl_P_Details.Location = new System.Drawing.Point(370, 66);
            this.lbl_P_Details.Name = "lbl_P_Details";
            this.lbl_P_Details.Size = new System.Drawing.Size(179, 36);
            this.lbl_P_Details.TabIndex = 11;
            this.lbl_P_Details.Text = "Pillow Details";
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.Blue;
            this.btn_Update.Font = new System.Drawing.Font("Times New Roman", 22F);
            this.btn_Update.ForeColor = System.Drawing.Color.White;
            this.btn_Update.Location = new System.Drawing.Point(586, 308);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(203, 53);
            this.btn_Update.TabIndex = 6;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // frm_Update_Pillow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1400, 860);
            this.ControlBox = false;
            this.Controls.Add(this.gb_Pillow_Details);
            this.Controls.Add(this.gb_Update_Pillow_Details);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Update_Pillow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Update Pillow Details";
            this.Load += new System.EventHandler(this.frm_Update_Pillow_Load);
            this.gb_Pillow_Details.ResumeLayout(false);
            this.gb_Pillow_Details.PerformLayout();
            this.gb_Update_Pillow_Details.ResumeLayout(false);
            this.gb_Update_Pillow_Details.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Pillow_Details;
        private System.Windows.Forms.GroupBox gb_Update_Pillow_Details;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.TextBox tb_P_Company;
        private System.Windows.Forms.TextBox tb_P_Id;
        private System.Windows.Forms.Label lbl_P_Company;
        private System.Windows.Forms.Label lbl_P_Id;
        private System.Windows.Forms.TextBox tb_P_Size;
        private System.Windows.Forms.TextBox tb_P_Comfort;
        private System.Windows.Forms.Label lbl_P_Comfort;
        private System.Windows.Forms.TextBox tb_P_Material;
        private System.Windows.Forms.Label lbl_P_Size;
        private System.Windows.Forms.Label lbl_P_Material;
        private System.Windows.Forms.TextBox tb_P_Details;
        private System.Windows.Forms.Label lbl_P_Details;
        private System.Windows.Forms.TextBox tb_P_Sales_Price;
        private System.Windows.Forms.TextBox tb_P_Purchase_Price;
        private System.Windows.Forms.Label lbl_P_Sales_Price;
        private System.Windows.Forms.Label lbl_P_Purchase_Price;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox tb_P_Name;
        private System.Windows.Forms.Label lbl_P_Name;
    }
}