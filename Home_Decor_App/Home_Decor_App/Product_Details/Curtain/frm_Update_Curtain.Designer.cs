
namespace Home_Decor_App.Product_Details.Curtain
{
    partial class frm_Update_Curtain
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
            this.tb_Cur_Id = new System.Windows.Forms.TextBox();
            this.tb_Cur_Details = new System.Windows.Forms.TextBox();
            this.lbl_Cur_Details = new System.Windows.Forms.Label();
            this.lbl_Cur_Id = new System.Windows.Forms.Label();
            this.lbl_Cur_Company = new System.Windows.Forms.Label();
            this.btn_Update = new System.Windows.Forms.Button();
            this.tb_Cur_Sales_Price = new System.Windows.Forms.TextBox();
            this.tb_Cur_Purchase_Price = new System.Windows.Forms.TextBox();
            this.lbl_Cur_Material = new System.Windows.Forms.Label();
            this.lbl_Cur_Purchase_Price = new System.Windows.Forms.Label();
            this.lbl_Cur_Sales_Price = new System.Windows.Forms.Label();
            this.gb_Update_Curtain_Details = new System.Windows.Forms.GroupBox();
            this.tb_Cur_Style = new System.Windows.Forms.TextBox();
            this.lbl_Style = new System.Windows.Forms.Label();
            this.lbl_Cur_Size = new System.Windows.Forms.Label();
            this.gb_Curtain_Details = new System.Windows.Forms.GroupBox();
            this.tb_Cur_Name = new System.Windows.Forms.TextBox();
            this.lbl_Cur_Name = new System.Windows.Forms.Label();
            this.tb_Cur_Size = new System.Windows.Forms.TextBox();
            this.tb_Cur_Material = new System.Windows.Forms.TextBox();
            this.tb_Cur_Company = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.gb_Update_Curtain_Details.SuspendLayout();
            this.gb_Curtain_Details.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_Cur_Id
            // 
            this.tb_Cur_Id.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.tb_Cur_Id.Location = new System.Drawing.Point(285, 58);
            this.tb_Cur_Id.MaxLength = 5;
            this.tb_Cur_Id.Name = "tb_Cur_Id";
            this.tb_Cur_Id.Size = new System.Drawing.Size(140, 36);
            this.tb_Cur_Id.TabIndex = 1;
            this.tb_Cur_Id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numeric);
            // 
            // tb_Cur_Details
            // 
            this.tb_Cur_Details.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.tb_Cur_Details.Location = new System.Drawing.Point(553, 47);
            this.tb_Cur_Details.MaxLength = 50;
            this.tb_Cur_Details.Multiline = true;
            this.tb_Cur_Details.Name = "tb_Cur_Details";
            this.tb_Cur_Details.Size = new System.Drawing.Size(345, 115);
            this.tb_Cur_Details.TabIndex = 3;
            // 
            // lbl_Cur_Details
            // 
            this.lbl_Cur_Details.AutoSize = true;
            this.lbl_Cur_Details.Font = new System.Drawing.Font("Palatino Linotype", 16F);
            this.lbl_Cur_Details.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Cur_Details.Location = new System.Drawing.Point(334, 83);
            this.lbl_Cur_Details.Name = "lbl_Cur_Details";
            this.lbl_Cur_Details.Size = new System.Drawing.Size(195, 36);
            this.lbl_Cur_Details.TabIndex = 6;
            this.lbl_Cur_Details.Text = "Curtain Details";
            // 
            // lbl_Cur_Id
            // 
            this.lbl_Cur_Id.AutoSize = true;
            this.lbl_Cur_Id.Font = new System.Drawing.Font("Palatino Linotype", 16F);
            this.lbl_Cur_Id.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Cur_Id.Location = new System.Drawing.Point(68, 54);
            this.lbl_Cur_Id.Name = "lbl_Cur_Id";
            this.lbl_Cur_Id.Size = new System.Drawing.Size(144, 36);
            this.lbl_Cur_Id.TabIndex = 0;
            this.lbl_Cur_Id.Text = "Curtain ID";
            // 
            // lbl_Cur_Company
            // 
            this.lbl_Cur_Company.AutoSize = true;
            this.lbl_Cur_Company.Font = new System.Drawing.Font("Palatino Linotype", 16F);
            this.lbl_Cur_Company.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Cur_Company.Location = new System.Drawing.Point(68, 232);
            this.lbl_Cur_Company.Name = "lbl_Cur_Company";
            this.lbl_Cur_Company.Size = new System.Drawing.Size(128, 36);
            this.lbl_Cur_Company.TabIndex = 1;
            this.lbl_Cur_Company.Text = "Company";
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.Blue;
            this.btn_Update.Font = new System.Drawing.Font("Times New Roman", 22F);
            this.btn_Update.ForeColor = System.Drawing.Color.White;
            this.btn_Update.Location = new System.Drawing.Point(512, 321);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(203, 53);
            this.btn_Update.TabIndex = 6;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // tb_Cur_Sales_Price
            // 
            this.tb_Cur_Sales_Price.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.tb_Cur_Sales_Price.Location = new System.Drawing.Point(862, 209);
            this.tb_Cur_Sales_Price.MaxLength = 5;
            this.tb_Cur_Sales_Price.Name = "tb_Cur_Sales_Price";
            this.tb_Cur_Sales_Price.Size = new System.Drawing.Size(243, 36);
            this.tb_Cur_Sales_Price.TabIndex = 5;
            this.tb_Cur_Sales_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numeric);
            // 
            // tb_Cur_Purchase_Price
            // 
            this.tb_Cur_Purchase_Price.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.tb_Cur_Purchase_Price.Location = new System.Drawing.Point(285, 209);
            this.tb_Cur_Purchase_Price.MaxLength = 5;
            this.tb_Cur_Purchase_Price.Name = "tb_Cur_Purchase_Price";
            this.tb_Cur_Purchase_Price.Size = new System.Drawing.Size(220, 36);
            this.tb_Cur_Purchase_Price.TabIndex = 4;
            this.tb_Cur_Purchase_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numeric);
            // 
            // lbl_Cur_Material
            // 
            this.lbl_Cur_Material.AutoSize = true;
            this.lbl_Cur_Material.Font = new System.Drawing.Font("Palatino Linotype", 16F);
            this.lbl_Cur_Material.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Cur_Material.Location = new System.Drawing.Point(684, 56);
            this.lbl_Cur_Material.Name = "lbl_Cur_Material";
            this.lbl_Cur_Material.Size = new System.Drawing.Size(113, 36);
            this.lbl_Cur_Material.TabIndex = 2;
            this.lbl_Cur_Material.Text = "Material";
            // 
            // lbl_Cur_Purchase_Price
            // 
            this.lbl_Cur_Purchase_Price.AutoSize = true;
            this.lbl_Cur_Purchase_Price.Font = new System.Drawing.Font("Palatino Linotype", 16F);
            this.lbl_Cur_Purchase_Price.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Cur_Purchase_Price.Location = new System.Drawing.Point(57, 207);
            this.lbl_Cur_Purchase_Price.Name = "lbl_Cur_Purchase_Price";
            this.lbl_Cur_Purchase_Price.Size = new System.Drawing.Size(186, 36);
            this.lbl_Cur_Purchase_Price.TabIndex = 7;
            this.lbl_Cur_Purchase_Price.Text = "Purchase Price";
            // 
            // lbl_Cur_Sales_Price
            // 
            this.lbl_Cur_Sales_Price.AutoSize = true;
            this.lbl_Cur_Sales_Price.Font = new System.Drawing.Font("Palatino Linotype", 16F);
            this.lbl_Cur_Sales_Price.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Cur_Sales_Price.Location = new System.Drawing.Point(660, 211);
            this.lbl_Cur_Sales_Price.Name = "lbl_Cur_Sales_Price";
            this.lbl_Cur_Sales_Price.Size = new System.Drawing.Size(139, 36);
            this.lbl_Cur_Sales_Price.TabIndex = 8;
            this.lbl_Cur_Sales_Price.Text = "Sales Price";
            // 
            // gb_Update_Curtain_Details
            // 
            this.gb_Update_Curtain_Details.BackColor = System.Drawing.Color.LightCyan;
            this.gb_Update_Curtain_Details.Controls.Add(this.btn_Update);
            this.gb_Update_Curtain_Details.Controls.Add(this.tb_Cur_Sales_Price);
            this.gb_Update_Curtain_Details.Controls.Add(this.tb_Cur_Details);
            this.gb_Update_Curtain_Details.Controls.Add(this.lbl_Cur_Details);
            this.gb_Update_Curtain_Details.Controls.Add(this.tb_Cur_Purchase_Price);
            this.gb_Update_Curtain_Details.Controls.Add(this.lbl_Cur_Purchase_Price);
            this.gb_Update_Curtain_Details.Controls.Add(this.lbl_Cur_Sales_Price);
            this.gb_Update_Curtain_Details.Font = new System.Drawing.Font("Rockwell", 9F);
            this.gb_Update_Curtain_Details.ForeColor = System.Drawing.Color.Crimson;
            this.gb_Update_Curtain_Details.Location = new System.Drawing.Point(61, 370);
            this.gb_Update_Curtain_Details.Name = "gb_Update_Curtain_Details";
            this.gb_Update_Curtain_Details.Size = new System.Drawing.Size(1280, 409);
            this.gb_Update_Curtain_Details.TabIndex = 0;
            this.gb_Update_Curtain_Details.TabStop = false;
            this.gb_Update_Curtain_Details.Text = "Update Details";
            // 
            // tb_Cur_Style
            // 
            this.tb_Cur_Style.Enabled = false;
            this.tb_Cur_Style.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.tb_Cur_Style.Location = new System.Drawing.Point(863, 143);
            this.tb_Cur_Style.MaxLength = 20;
            this.tb_Cur_Style.Name = "tb_Cur_Style";
            this.tb_Cur_Style.Size = new System.Drawing.Size(277, 36);
            this.tb_Cur_Style.TabIndex = 0;
            this.tb_Cur_Style.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Letter);
            // 
            // lbl_Style
            // 
            this.lbl_Style.AutoSize = true;
            this.lbl_Style.Font = new System.Drawing.Font("Palatino Linotype", 16F);
            this.lbl_Style.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Style.Location = new System.Drawing.Point(684, 141);
            this.lbl_Style.Name = "lbl_Style";
            this.lbl_Style.Size = new System.Drawing.Size(73, 36);
            this.lbl_Style.TabIndex = 19;
            this.lbl_Style.Text = "Style";
            // 
            // lbl_Cur_Size
            // 
            this.lbl_Cur_Size.AutoSize = true;
            this.lbl_Cur_Size.Font = new System.Drawing.Font("Palatino Linotype", 16F);
            this.lbl_Cur_Size.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Cur_Size.Location = new System.Drawing.Point(684, 232);
            this.lbl_Cur_Size.Name = "lbl_Cur_Size";
            this.lbl_Cur_Size.Size = new System.Drawing.Size(64, 36);
            this.lbl_Cur_Size.TabIndex = 3;
            this.lbl_Cur_Size.Text = "Size";
            // 
            // gb_Curtain_Details
            // 
            this.gb_Curtain_Details.BackColor = System.Drawing.Color.LightCyan;
            this.gb_Curtain_Details.Controls.Add(this.tb_Cur_Style);
            this.gb_Curtain_Details.Controls.Add(this.tb_Cur_Name);
            this.gb_Curtain_Details.Controls.Add(this.lbl_Style);
            this.gb_Curtain_Details.Controls.Add(this.lbl_Cur_Name);
            this.gb_Curtain_Details.Controls.Add(this.tb_Cur_Size);
            this.gb_Curtain_Details.Controls.Add(this.tb_Cur_Material);
            this.gb_Curtain_Details.Controls.Add(this.tb_Cur_Company);
            this.gb_Curtain_Details.Controls.Add(this.btn_Search);
            this.gb_Curtain_Details.Controls.Add(this.tb_Cur_Id);
            this.gb_Curtain_Details.Controls.Add(this.lbl_Cur_Id);
            this.gb_Curtain_Details.Controls.Add(this.lbl_Cur_Company);
            this.gb_Curtain_Details.Controls.Add(this.lbl_Cur_Material);
            this.gb_Curtain_Details.Controls.Add(this.lbl_Cur_Size);
            this.gb_Curtain_Details.Font = new System.Drawing.Font("Rockwell", 9F);
            this.gb_Curtain_Details.ForeColor = System.Drawing.Color.Crimson;
            this.gb_Curtain_Details.Location = new System.Drawing.Point(61, 56);
            this.gb_Curtain_Details.Name = "gb_Curtain_Details";
            this.gb_Curtain_Details.Size = new System.Drawing.Size(1280, 308);
            this.gb_Curtain_Details.TabIndex = 0;
            this.gb_Curtain_Details.TabStop = false;
            this.gb_Curtain_Details.Text = "Curtain Details";
            // 
            // tb_Cur_Name
            // 
            this.tb_Cur_Name.Enabled = false;
            this.tb_Cur_Name.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.tb_Cur_Name.Location = new System.Drawing.Point(285, 143);
            this.tb_Cur_Name.MaxLength = 40;
            this.tb_Cur_Name.Name = "tb_Cur_Name";
            this.tb_Cur_Name.Size = new System.Drawing.Size(264, 36);
            this.tb_Cur_Name.TabIndex = 24;
            this.tb_Cur_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Letter);
            // 
            // lbl_Cur_Name
            // 
            this.lbl_Cur_Name.AutoSize = true;
            this.lbl_Cur_Name.Font = new System.Drawing.Font("Palatino Linotype", 16F);
            this.lbl_Cur_Name.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Cur_Name.Location = new System.Drawing.Point(68, 141);
            this.lbl_Cur_Name.Name = "lbl_Cur_Name";
            this.lbl_Cur_Name.Size = new System.Drawing.Size(86, 36);
            this.lbl_Cur_Name.TabIndex = 25;
            this.lbl_Cur_Name.Text = "Name";
            // 
            // tb_Cur_Size
            // 
            this.tb_Cur_Size.Enabled = false;
            this.tb_Cur_Size.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.tb_Cur_Size.Location = new System.Drawing.Point(863, 234);
            this.tb_Cur_Size.MaxLength = 20;
            this.tb_Cur_Size.Name = "tb_Cur_Size";
            this.tb_Cur_Size.Size = new System.Drawing.Size(277, 36);
            this.tb_Cur_Size.TabIndex = 0;
            // 
            // tb_Cur_Material
            // 
            this.tb_Cur_Material.Enabled = false;
            this.tb_Cur_Material.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.tb_Cur_Material.Location = new System.Drawing.Point(863, 60);
            this.tb_Cur_Material.MaxLength = 20;
            this.tb_Cur_Material.Name = "tb_Cur_Material";
            this.tb_Cur_Material.Size = new System.Drawing.Size(277, 36);
            this.tb_Cur_Material.TabIndex = 0;
            // 
            // tb_Cur_Company
            // 
            this.tb_Cur_Company.Enabled = false;
            this.tb_Cur_Company.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.tb_Cur_Company.Location = new System.Drawing.Point(286, 234);
            this.tb_Cur_Company.MaxLength = 20;
            this.tb_Cur_Company.Name = "tb_Cur_Company";
            this.tb_Cur_Company.Size = new System.Drawing.Size(263, 36);
            this.tb_Cur_Company.TabIndex = 0;
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.LightPink;
            this.btn_Search.Font = new System.Drawing.Font("Times New Roman", 20F);
            this.btn_Search.ForeColor = System.Drawing.Color.DarkGreen;
            this.btn_Search.Location = new System.Drawing.Point(431, 50);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(139, 51);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // frm_Update_Curtain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1400, 860);
            this.ControlBox = false;
            this.Controls.Add(this.gb_Update_Curtain_Details);
            this.Controls.Add(this.gb_Curtain_Details);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Update_Curtain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Update Curtain Details";
            this.Load += new System.EventHandler(this.frm_Update_Curtain_Details_Load);
            this.gb_Update_Curtain_Details.ResumeLayout(false);
            this.gb_Update_Curtain_Details.PerformLayout();
            this.gb_Curtain_Details.ResumeLayout(false);
            this.gb_Curtain_Details.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tb_Cur_Id;
        private System.Windows.Forms.TextBox tb_Cur_Details;
        private System.Windows.Forms.Label lbl_Cur_Details;
        private System.Windows.Forms.Label lbl_Cur_Id;
        private System.Windows.Forms.Label lbl_Cur_Company;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.TextBox tb_Cur_Sales_Price;
        private System.Windows.Forms.TextBox tb_Cur_Purchase_Price;
        private System.Windows.Forms.Label lbl_Cur_Material;
        private System.Windows.Forms.Label lbl_Cur_Purchase_Price;
        private System.Windows.Forms.Label lbl_Cur_Sales_Price;
        private System.Windows.Forms.GroupBox gb_Update_Curtain_Details;
        private System.Windows.Forms.Label lbl_Cur_Size;
        private System.Windows.Forms.GroupBox gb_Curtain_Details;
        private System.Windows.Forms.TextBox tb_Cur_Style;
        private System.Windows.Forms.Label lbl_Style;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox tb_Cur_Company;
        private System.Windows.Forms.TextBox tb_Cur_Size;
        private System.Windows.Forms.TextBox tb_Cur_Material;
        private System.Windows.Forms.TextBox tb_Cur_Name;
        private System.Windows.Forms.Label lbl_Cur_Name;
    }
}