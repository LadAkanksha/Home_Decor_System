
namespace Home_Decor_App.Popup_Window
{
    partial class frm_Mattress
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
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Ok = new System.Windows.Forms.Button();
            this.lbl_MPrice = new System.Windows.Forms.Label();
            this.cmb_MSize = new System.Windows.Forms.ComboBox();
            this.lbl_MSize = new System.Windows.Forms.Label();
            this.cmb_MComfort = new System.Windows.Forms.ComboBox();
            this.lbl_MComfort = new System.Windows.Forms.Label();
            this.cmb_MMaterial = new System.Windows.Forms.ComboBox();
            this.lbl_MMaterial = new System.Windows.Forms.Label();
            this.cmb_MCompany = new System.Windows.Forms.ComboBox();
            this.lbl_MCompany = new System.Windows.Forms.Label();
            this.tb_MPrice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_Cancel.Font = new System.Drawing.Font("Algerian", 21F);
            this.btn_Cancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Cancel.Location = new System.Drawing.Point(65, 600);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(190, 60);
            this.btn_Cancel.TabIndex = 6;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Ok
            // 
            this.btn_Ok.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_Ok.Font = new System.Drawing.Font("Algerian", 21F);
            this.btn_Ok.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Ok.Location = new System.Drawing.Point(327, 600);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(190, 60);
            this.btn_Ok.TabIndex = 5;
            this.btn_Ok.Text = "OK";
            this.btn_Ok.UseVisualStyleBackColor = false;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // lbl_MPrice
            // 
            this.lbl_MPrice.AutoSize = true;
            this.lbl_MPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 17F);
            this.lbl_MPrice.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbl_MPrice.Location = new System.Drawing.Point(74, 481);
            this.lbl_MPrice.Name = "lbl_MPrice";
            this.lbl_MPrice.Size = new System.Drawing.Size(82, 40);
            this.lbl_MPrice.TabIndex = 46;
            this.lbl_MPrice.Text = "Price";
            // 
            // cmb_MSize
            // 
            this.cmb_MSize.BackColor = System.Drawing.Color.White;
            this.cmb_MSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_MSize.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.cmb_MSize.FormattingEnabled = true;
            this.cmb_MSize.Location = new System.Drawing.Point(286, 378);
            this.cmb_MSize.MaxLength = 5;
            this.cmb_MSize.Name = "cmb_MSize";
            this.cmb_MSize.Size = new System.Drawing.Size(238, 39);
            this.cmb_MSize.TabIndex = 4;
            this.cmb_MSize.SelectedIndexChanged += new System.EventHandler(this.cmb_MSize_SelectedIndexChanged);
            // 
            // lbl_MSize
            // 
            this.lbl_MSize.AutoSize = true;
            this.lbl_MSize.Font = new System.Drawing.Font("Segoe UI Semibold", 17F);
            this.lbl_MSize.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbl_MSize.Location = new System.Drawing.Point(74, 374);
            this.lbl_MSize.Name = "lbl_MSize";
            this.lbl_MSize.Size = new System.Drawing.Size(69, 40);
            this.lbl_MSize.TabIndex = 45;
            this.lbl_MSize.Text = "Size";
            // 
            // cmb_MComfort
            // 
            this.cmb_MComfort.BackColor = System.Drawing.Color.White;
            this.cmb_MComfort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_MComfort.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.cmb_MComfort.FormattingEnabled = true;
            this.cmb_MComfort.Location = new System.Drawing.Point(286, 271);
            this.cmb_MComfort.MaxLength = 20;
            this.cmb_MComfort.Name = "cmb_MComfort";
            this.cmb_MComfort.Size = new System.Drawing.Size(238, 39);
            this.cmb_MComfort.TabIndex = 3;
            this.cmb_MComfort.SelectedIndexChanged += new System.EventHandler(this.cmb_MComfort_SelectedIndexChanged);
            // 
            // lbl_MComfort
            // 
            this.lbl_MComfort.AutoSize = true;
            this.lbl_MComfort.Font = new System.Drawing.Font("Segoe UI Semibold", 17F);
            this.lbl_MComfort.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbl_MComfort.Location = new System.Drawing.Point(74, 270);
            this.lbl_MComfort.Name = "lbl_MComfort";
            this.lbl_MComfort.Size = new System.Drawing.Size(127, 40);
            this.lbl_MComfort.TabIndex = 44;
            this.lbl_MComfort.Text = "Comfort";
            // 
            // cmb_MMaterial
            // 
            this.cmb_MMaterial.BackColor = System.Drawing.Color.White;
            this.cmb_MMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_MMaterial.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.cmb_MMaterial.FormattingEnabled = true;
            this.cmb_MMaterial.Location = new System.Drawing.Point(286, 161);
            this.cmb_MMaterial.MaxLength = 20;
            this.cmb_MMaterial.Name = "cmb_MMaterial";
            this.cmb_MMaterial.Size = new System.Drawing.Size(238, 39);
            this.cmb_MMaterial.TabIndex = 2;
            this.cmb_MMaterial.SelectedIndexChanged += new System.EventHandler(this.cmb_MMaterial_SelectedIndexChanged);
            // 
            // lbl_MMaterial
            // 
            this.lbl_MMaterial.AutoSize = true;
            this.lbl_MMaterial.Font = new System.Drawing.Font("Segoe UI Semibold", 17F);
            this.lbl_MMaterial.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbl_MMaterial.Location = new System.Drawing.Point(74, 160);
            this.lbl_MMaterial.Name = "lbl_MMaterial";
            this.lbl_MMaterial.Size = new System.Drawing.Size(126, 40);
            this.lbl_MMaterial.TabIndex = 43;
            this.lbl_MMaterial.Text = "Material";
            // 
            // cmb_MCompany
            // 
            this.cmb_MCompany.BackColor = System.Drawing.Color.White;
            this.cmb_MCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_MCompany.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.cmb_MCompany.FormattingEnabled = true;
            this.cmb_MCompany.Location = new System.Drawing.Point(286, 53);
            this.cmb_MCompany.MaxLength = 20;
            this.cmb_MCompany.Name = "cmb_MCompany";
            this.cmb_MCompany.Size = new System.Drawing.Size(238, 39);
            this.cmb_MCompany.TabIndex = 1;
            this.cmb_MCompany.SelectedIndexChanged += new System.EventHandler(this.cmb_MCompany_SelectedIndexChanged);
            // 
            // lbl_MCompany
            // 
            this.lbl_MCompany.AutoSize = true;
            this.lbl_MCompany.Font = new System.Drawing.Font("Segoe UI Semibold", 17F);
            this.lbl_MCompany.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbl_MCompany.Location = new System.Drawing.Point(74, 52);
            this.lbl_MCompany.Name = "lbl_MCompany";
            this.lbl_MCompany.Size = new System.Drawing.Size(142, 40);
            this.lbl_MCompany.TabIndex = 35;
            this.lbl_MCompany.Text = "Company";
            // 
            // tb_MPrice
            // 
            this.tb_MPrice.Enabled = false;
            this.tb_MPrice.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.tb_MPrice.Location = new System.Drawing.Point(288, 485);
            this.tb_MPrice.Name = "tb_MPrice";
            this.tb_MPrice.Size = new System.Drawing.Size(238, 38);
            this.tb_MPrice.TabIndex = 0;
            // 
            // frm_Mattress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(600, 700);
            this.Controls.Add(this.tb_MPrice);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.lbl_MPrice);
            this.Controls.Add(this.cmb_MSize);
            this.Controls.Add(this.lbl_MSize);
            this.Controls.Add(this.cmb_MComfort);
            this.Controls.Add(this.lbl_MComfort);
            this.Controls.Add(this.cmb_MMaterial);
            this.Controls.Add(this.lbl_MMaterial);
            this.Controls.Add(this.cmb_MCompany);
            this.Controls.Add(this.lbl_MCompany);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Mattress";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Mattress";
            this.Load += new System.EventHandler(this.frm_Mattress_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Ok;
        private System.Windows.Forms.Label lbl_MPrice;
        private System.Windows.Forms.ComboBox cmb_MSize;
        private System.Windows.Forms.Label lbl_MSize;
        private System.Windows.Forms.ComboBox cmb_MComfort;
        private System.Windows.Forms.Label lbl_MComfort;
        private System.Windows.Forms.ComboBox cmb_MMaterial;
        private System.Windows.Forms.Label lbl_MMaterial;
        private System.Windows.Forms.ComboBox cmb_MCompany;
        private System.Windows.Forms.Label lbl_MCompany;
        private System.Windows.Forms.TextBox tb_MPrice;
    }
}