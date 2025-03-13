
namespace Home_Decor_App.Popup_Window
{
    partial class frm_Pillow
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
            this.lbl_PPrice = new System.Windows.Forms.Label();
            this.cmb_PSize = new System.Windows.Forms.ComboBox();
            this.lbl_PSize = new System.Windows.Forms.Label();
            this.cmb_PComfort = new System.Windows.Forms.ComboBox();
            this.lbl_PComfort = new System.Windows.Forms.Label();
            this.cmb_PMaterial = new System.Windows.Forms.ComboBox();
            this.lbl_PMaterial = new System.Windows.Forms.Label();
            this.cmb_PCompany = new System.Windows.Forms.ComboBox();
            this.lbl_PCompany = new System.Windows.Forms.Label();
            this.tb_PPrice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_Cancel.Font = new System.Drawing.Font("Algerian", 21F);
            this.btn_Cancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Cancel.Location = new System.Drawing.Point(62, 596);
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
            this.btn_Ok.Location = new System.Drawing.Point(332, 596);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(190, 60);
            this.btn_Ok.TabIndex = 5;
            this.btn_Ok.Text = "OK";
            this.btn_Ok.UseVisualStyleBackColor = false;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // lbl_PPrice
            // 
            this.lbl_PPrice.AutoSize = true;
            this.lbl_PPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 17F);
            this.lbl_PPrice.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbl_PPrice.Location = new System.Drawing.Point(66, 484);
            this.lbl_PPrice.Name = "lbl_PPrice";
            this.lbl_PPrice.Size = new System.Drawing.Size(82, 40);
            this.lbl_PPrice.TabIndex = 46;
            this.lbl_PPrice.Text = "Price";
            // 
            // cmb_PSize
            // 
            this.cmb_PSize.BackColor = System.Drawing.Color.White;
            this.cmb_PSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_PSize.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.cmb_PSize.FormattingEnabled = true;
            this.cmb_PSize.Location = new System.Drawing.Point(278, 380);
            this.cmb_PSize.MaxLength = 5;
            this.cmb_PSize.Name = "cmb_PSize";
            this.cmb_PSize.Size = new System.Drawing.Size(252, 39);
            this.cmb_PSize.TabIndex = 4;
            this.cmb_PSize.SelectedIndexChanged += new System.EventHandler(this.cmb_PSize_SelectedIndexChanged);
            // 
            // lbl_PSize
            // 
            this.lbl_PSize.AutoSize = true;
            this.lbl_PSize.Font = new System.Drawing.Font("Segoe UI Semibold", 17F);
            this.lbl_PSize.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbl_PSize.Location = new System.Drawing.Point(66, 376);
            this.lbl_PSize.Name = "lbl_PSize";
            this.lbl_PSize.Size = new System.Drawing.Size(69, 40);
            this.lbl_PSize.TabIndex = 45;
            this.lbl_PSize.Text = "Size";
            // 
            // cmb_PComfort
            // 
            this.cmb_PComfort.BackColor = System.Drawing.Color.White;
            this.cmb_PComfort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_PComfort.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.cmb_PComfort.FormattingEnabled = true;
            this.cmb_PComfort.Location = new System.Drawing.Point(278, 274);
            this.cmb_PComfort.MaxLength = 20;
            this.cmb_PComfort.Name = "cmb_PComfort";
            this.cmb_PComfort.Size = new System.Drawing.Size(252, 39);
            this.cmb_PComfort.TabIndex = 3;
            this.cmb_PComfort.SelectedIndexChanged += new System.EventHandler(this.cmb_PComfort_SelectedIndexChanged);
            // 
            // lbl_PComfort
            // 
            this.lbl_PComfort.AutoSize = true;
            this.lbl_PComfort.Font = new System.Drawing.Font("Segoe UI Semibold", 17F);
            this.lbl_PComfort.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbl_PComfort.Location = new System.Drawing.Point(66, 270);
            this.lbl_PComfort.Name = "lbl_PComfort";
            this.lbl_PComfort.Size = new System.Drawing.Size(127, 40);
            this.lbl_PComfort.TabIndex = 44;
            this.lbl_PComfort.Text = "Comfort";
            // 
            // cmb_PMaterial
            // 
            this.cmb_PMaterial.BackColor = System.Drawing.Color.White;
            this.cmb_PMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_PMaterial.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.cmb_PMaterial.FormattingEnabled = true;
            this.cmb_PMaterial.Location = new System.Drawing.Point(278, 161);
            this.cmb_PMaterial.MaxLength = 20;
            this.cmb_PMaterial.Name = "cmb_PMaterial";
            this.cmb_PMaterial.Size = new System.Drawing.Size(252, 39);
            this.cmb_PMaterial.TabIndex = 2;
            this.cmb_PMaterial.SelectedIndexChanged += new System.EventHandler(this.cmb_PMaterial_SelectedIndexChanged);
            // 
            // lbl_PMaterial
            // 
            this.lbl_PMaterial.AutoSize = true;
            this.lbl_PMaterial.Font = new System.Drawing.Font("Segoe UI Semibold", 17F);
            this.lbl_PMaterial.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbl_PMaterial.Location = new System.Drawing.Point(66, 157);
            this.lbl_PMaterial.Name = "lbl_PMaterial";
            this.lbl_PMaterial.Size = new System.Drawing.Size(126, 40);
            this.lbl_PMaterial.TabIndex = 43;
            this.lbl_PMaterial.Text = "Material";
            // 
            // cmb_PCompany
            // 
            this.cmb_PCompany.BackColor = System.Drawing.Color.White;
            this.cmb_PCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_PCompany.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.cmb_PCompany.FormattingEnabled = true;
            this.cmb_PCompany.Location = new System.Drawing.Point(278, 59);
            this.cmb_PCompany.MaxLength = 20;
            this.cmb_PCompany.Name = "cmb_PCompany";
            this.cmb_PCompany.Size = new System.Drawing.Size(252, 39);
            this.cmb_PCompany.TabIndex = 1;
            this.cmb_PCompany.SelectedIndexChanged += new System.EventHandler(this.cmb_PCompany_SelectedIndexChanged);
            // 
            // lbl_PCompany
            // 
            this.lbl_PCompany.AutoSize = true;
            this.lbl_PCompany.Font = new System.Drawing.Font("Segoe UI Semibold", 17F);
            this.lbl_PCompany.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbl_PCompany.Location = new System.Drawing.Point(66, 55);
            this.lbl_PCompany.Name = "lbl_PCompany";
            this.lbl_PCompany.Size = new System.Drawing.Size(142, 40);
            this.lbl_PCompany.TabIndex = 42;
            this.lbl_PCompany.Text = "Company";
            // 
            // tb_PPrice
            // 
            this.tb_PPrice.Enabled = false;
            this.tb_PPrice.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.tb_PPrice.Location = new System.Drawing.Point(278, 488);
            this.tb_PPrice.Name = "tb_PPrice";
            this.tb_PPrice.Size = new System.Drawing.Size(252, 38);
            this.tb_PPrice.TabIndex = 0;
            // 
            // frm_Pillow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(600, 700);
            this.Controls.Add(this.tb_PPrice);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.lbl_PPrice);
            this.Controls.Add(this.cmb_PSize);
            this.Controls.Add(this.lbl_PSize);
            this.Controls.Add(this.cmb_PComfort);
            this.Controls.Add(this.lbl_PComfort);
            this.Controls.Add(this.cmb_PMaterial);
            this.Controls.Add(this.lbl_PMaterial);
            this.Controls.Add(this.cmb_PCompany);
            this.Controls.Add(this.lbl_PCompany);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Pillow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Pillow";
            this.Load += new System.EventHandler(this.frm_Pillow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Ok;
        private System.Windows.Forms.Label lbl_PPrice;
        private System.Windows.Forms.ComboBox cmb_PSize;
        private System.Windows.Forms.Label lbl_PSize;
        private System.Windows.Forms.ComboBox cmb_PComfort;
        private System.Windows.Forms.Label lbl_PComfort;
        private System.Windows.Forms.ComboBox cmb_PMaterial;
        private System.Windows.Forms.Label lbl_PMaterial;
        private System.Windows.Forms.ComboBox cmb_PCompany;
        private System.Windows.Forms.Label lbl_PCompany;
        private System.Windows.Forms.TextBox tb_PPrice;
    }
}