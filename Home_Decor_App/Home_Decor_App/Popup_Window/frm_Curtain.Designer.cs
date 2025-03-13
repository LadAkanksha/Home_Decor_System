
namespace Home_Decor_App.Popup_Window
{
    partial class frm_Curtain
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
            this.lbl_CrPrice = new System.Windows.Forms.Label();
            this.cmb_CurSize = new System.Windows.Forms.ComboBox();
            this.lbl_CrSize = new System.Windows.Forms.Label();
            this.cmb_CurStyle = new System.Windows.Forms.ComboBox();
            this.lbl_CrStyle = new System.Windows.Forms.Label();
            this.cmb_CurMaterial = new System.Windows.Forms.ComboBox();
            this.lbl_CrMaterial = new System.Windows.Forms.Label();
            this.cmb_CurCompany = new System.Windows.Forms.ComboBox();
            this.lbl_CrCompany = new System.Windows.Forms.Label();
            this.tb_CurPrice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_Cancel.Font = new System.Drawing.Font("Algerian", 21F);
            this.btn_Cancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Cancel.Location = new System.Drawing.Point(64, 596);
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
            this.btn_Ok.Location = new System.Drawing.Point(328, 596);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(190, 60);
            this.btn_Ok.TabIndex = 5;
            this.btn_Ok.Text = "OK";
            this.btn_Ok.UseVisualStyleBackColor = false;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // lbl_CrPrice
            // 
            this.lbl_CrPrice.AutoSize = true;
            this.lbl_CrPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 17F);
            this.lbl_CrPrice.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbl_CrPrice.Location = new System.Drawing.Point(83, 473);
            this.lbl_CrPrice.Name = "lbl_CrPrice";
            this.lbl_CrPrice.Size = new System.Drawing.Size(82, 40);
            this.lbl_CrPrice.TabIndex = 49;
            this.lbl_CrPrice.Text = "Price";
            // 
            // cmb_CurSize
            // 
            this.cmb_CurSize.BackColor = System.Drawing.Color.White;
            this.cmb_CurSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_CurSize.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.cmb_CurSize.FormattingEnabled = true;
            this.cmb_CurSize.Location = new System.Drawing.Point(294, 367);
            this.cmb_CurSize.MaxLength = 5;
            this.cmb_CurSize.Name = "cmb_CurSize";
            this.cmb_CurSize.Size = new System.Drawing.Size(249, 39);
            this.cmb_CurSize.TabIndex = 4;
            this.cmb_CurSize.SelectedIndexChanged += new System.EventHandler(this.cmb_CurSize_SelectedIndexChanged);
            // 
            // lbl_CrSize
            // 
            this.lbl_CrSize.AutoSize = true;
            this.lbl_CrSize.Font = new System.Drawing.Font("Segoe UI Semibold", 17F);
            this.lbl_CrSize.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbl_CrSize.Location = new System.Drawing.Point(82, 362);
            this.lbl_CrSize.Name = "lbl_CrSize";
            this.lbl_CrSize.Size = new System.Drawing.Size(69, 40);
            this.lbl_CrSize.TabIndex = 48;
            this.lbl_CrSize.Text = "Size";
            // 
            // cmb_CurStyle
            // 
            this.cmb_CurStyle.BackColor = System.Drawing.Color.White;
            this.cmb_CurStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_CurStyle.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.cmb_CurStyle.FormattingEnabled = true;
            this.cmb_CurStyle.Location = new System.Drawing.Point(295, 263);
            this.cmb_CurStyle.MaxLength = 20;
            this.cmb_CurStyle.Name = "cmb_CurStyle";
            this.cmb_CurStyle.Size = new System.Drawing.Size(248, 39);
            this.cmb_CurStyle.TabIndex = 3;
            this.cmb_CurStyle.SelectedIndexChanged += new System.EventHandler(this.cmb_CurStyle_SelectedIndexChanged);
            // 
            // lbl_CrStyle
            // 
            this.lbl_CrStyle.AutoSize = true;
            this.lbl_CrStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 17F);
            this.lbl_CrStyle.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbl_CrStyle.Location = new System.Drawing.Point(82, 263);
            this.lbl_CrStyle.Name = "lbl_CrStyle";
            this.lbl_CrStyle.Size = new System.Drawing.Size(80, 40);
            this.lbl_CrStyle.TabIndex = 47;
            this.lbl_CrStyle.Text = "Style";
            // 
            // cmb_CurMaterial
            // 
            this.cmb_CurMaterial.BackColor = System.Drawing.Color.White;
            this.cmb_CurMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_CurMaterial.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.cmb_CurMaterial.FormattingEnabled = true;
            this.cmb_CurMaterial.Location = new System.Drawing.Point(294, 160);
            this.cmb_CurMaterial.MaxLength = 20;
            this.cmb_CurMaterial.Name = "cmb_CurMaterial";
            this.cmb_CurMaterial.Size = new System.Drawing.Size(249, 39);
            this.cmb_CurMaterial.TabIndex = 2;
            this.cmb_CurMaterial.SelectedIndexChanged += new System.EventHandler(this.cmb_CurMaterial_SelectedIndexChanged);
            // 
            // lbl_CrMaterial
            // 
            this.lbl_CrMaterial.AutoSize = true;
            this.lbl_CrMaterial.Font = new System.Drawing.Font("Segoe UI Semibold", 17F);
            this.lbl_CrMaterial.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbl_CrMaterial.Location = new System.Drawing.Point(82, 159);
            this.lbl_CrMaterial.Name = "lbl_CrMaterial";
            this.lbl_CrMaterial.Size = new System.Drawing.Size(126, 40);
            this.lbl_CrMaterial.TabIndex = 46;
            this.lbl_CrMaterial.Text = "Material";
            // 
            // cmb_CurCompany
            // 
            this.cmb_CurCompany.BackColor = System.Drawing.Color.White;
            this.cmb_CurCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_CurCompany.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.cmb_CurCompany.FormattingEnabled = true;
            this.cmb_CurCompany.Location = new System.Drawing.Point(294, 56);
            this.cmb_CurCompany.MaxLength = 20;
            this.cmb_CurCompany.Name = "cmb_CurCompany";
            this.cmb_CurCompany.Size = new System.Drawing.Size(249, 39);
            this.cmb_CurCompany.TabIndex = 1;
            this.cmb_CurCompany.SelectedIndexChanged += new System.EventHandler(this.cmb_CurCompany_SelectedIndexChanged);
            // 
            // lbl_CrCompany
            // 
            this.lbl_CrCompany.AutoSize = true;
            this.lbl_CrCompany.Font = new System.Drawing.Font("Segoe UI Semibold", 17F);
            this.lbl_CrCompany.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbl_CrCompany.Location = new System.Drawing.Point(82, 55);
            this.lbl_CrCompany.Name = "lbl_CrCompany";
            this.lbl_CrCompany.Size = new System.Drawing.Size(142, 40);
            this.lbl_CrCompany.TabIndex = 45;
            this.lbl_CrCompany.Text = "Company";
            // 
            // tb_CurPrice
            // 
            this.tb_CurPrice.Enabled = false;
            this.tb_CurPrice.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.tb_CurPrice.Location = new System.Drawing.Point(294, 477);
            this.tb_CurPrice.Name = "tb_CurPrice";
            this.tb_CurPrice.Size = new System.Drawing.Size(249, 38);
            this.tb_CurPrice.TabIndex = 5;
            // 
            // frm_Curtain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(600, 700);
            this.Controls.Add(this.tb_CurPrice);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.lbl_CrPrice);
            this.Controls.Add(this.cmb_CurSize);
            this.Controls.Add(this.lbl_CrSize);
            this.Controls.Add(this.cmb_CurStyle);
            this.Controls.Add(this.lbl_CrStyle);
            this.Controls.Add(this.cmb_CurMaterial);
            this.Controls.Add(this.lbl_CrMaterial);
            this.Controls.Add(this.cmb_CurCompany);
            this.Controls.Add(this.lbl_CrCompany);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Curtain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Curtain Information";
            this.Load += new System.EventHandler(this.frm_Curtain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Ok;
        private System.Windows.Forms.Label lbl_CrPrice;
        private System.Windows.Forms.ComboBox cmb_CurSize;
        private System.Windows.Forms.Label lbl_CrSize;
        private System.Windows.Forms.ComboBox cmb_CurStyle;
        private System.Windows.Forms.Label lbl_CrStyle;
        private System.Windows.Forms.ComboBox cmb_CurMaterial;
        private System.Windows.Forms.Label lbl_CrMaterial;
        private System.Windows.Forms.ComboBox cmb_CurCompany;
        private System.Windows.Forms.Label lbl_CrCompany;
        private System.Windows.Forms.TextBox tb_CurPrice;
    }
}