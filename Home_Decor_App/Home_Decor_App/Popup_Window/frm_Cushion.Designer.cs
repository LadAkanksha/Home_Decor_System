
namespace Home_Decor_App.Popup_Window
{
    partial class frm_Cushion
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
            this.lbl_CuPrice = new System.Windows.Forms.Label();
            this.cmb_CusSize = new System.Windows.Forms.ComboBox();
            this.lbl_CuSize = new System.Windows.Forms.Label();
            this.cmb_CusComfort = new System.Windows.Forms.ComboBox();
            this.lbl_CuComfort = new System.Windows.Forms.Label();
            this.cmb_CusMaterial = new System.Windows.Forms.ComboBox();
            this.lbl_CuMaterial = new System.Windows.Forms.Label();
            this.cmb_CusCompany = new System.Windows.Forms.ComboBox();
            this.lbl_CuCompany = new System.Windows.Forms.Label();
            this.tb_CusPrice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_Cancel.Font = new System.Drawing.Font("Algerian", 21F);
            this.btn_Cancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Cancel.Location = new System.Drawing.Point(57, 596);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(190, 60);
            this.btn_Cancel.TabIndex = 7;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Ok
            // 
            this.btn_Ok.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_Ok.Font = new System.Drawing.Font("Algerian", 21F);
            this.btn_Ok.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Ok.Location = new System.Drawing.Point(327, 596);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(190, 60);
            this.btn_Ok.TabIndex = 6;
            this.btn_Ok.Text = "OK";
            this.btn_Ok.UseVisualStyleBackColor = false;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // lbl_CuPrice
            // 
            this.lbl_CuPrice.AutoSize = true;
            this.lbl_CuPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 17F);
            this.lbl_CuPrice.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbl_CuPrice.Location = new System.Drawing.Point(74, 471);
            this.lbl_CuPrice.Name = "lbl_CuPrice";
            this.lbl_CuPrice.Size = new System.Drawing.Size(82, 40);
            this.lbl_CuPrice.TabIndex = 44;
            this.lbl_CuPrice.Text = "Price";
            // 
            // cmb_CusSize
            // 
            this.cmb_CusSize.BackColor = System.Drawing.Color.White;
            this.cmb_CusSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_CusSize.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.cmb_CusSize.FormattingEnabled = true;
            this.cmb_CusSize.Location = new System.Drawing.Point(286, 369);
            this.cmb_CusSize.MaxLength = 5;
            this.cmb_CusSize.Name = "cmb_CusSize";
            this.cmb_CusSize.Size = new System.Drawing.Size(229, 39);
            this.cmb_CusSize.TabIndex = 4;
            this.cmb_CusSize.SelectedIndexChanged += new System.EventHandler(this.cmb_CusSize_SelectedIndexChanged);
            // 
            // lbl_CuSize
            // 
            this.lbl_CuSize.AutoSize = true;
            this.lbl_CuSize.Font = new System.Drawing.Font("Segoe UI Semibold", 17F);
            this.lbl_CuSize.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbl_CuSize.Location = new System.Drawing.Point(74, 368);
            this.lbl_CuSize.Name = "lbl_CuSize";
            this.lbl_CuSize.Size = new System.Drawing.Size(69, 40);
            this.lbl_CuSize.TabIndex = 43;
            this.lbl_CuSize.Text = "Size";
            // 
            // cmb_CusComfort
            // 
            this.cmb_CusComfort.BackColor = System.Drawing.Color.White;
            this.cmb_CusComfort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_CusComfort.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.cmb_CusComfort.FormattingEnabled = true;
            this.cmb_CusComfort.Location = new System.Drawing.Point(286, 263);
            this.cmb_CusComfort.MaxLength = 20;
            this.cmb_CusComfort.Name = "cmb_CusComfort";
            this.cmb_CusComfort.Size = new System.Drawing.Size(229, 39);
            this.cmb_CusComfort.TabIndex = 3;
            this.cmb_CusComfort.SelectedIndexChanged += new System.EventHandler(this.cmb_CusComfort_SelectedIndexChanged);
            // 
            // lbl_CuComfort
            // 
            this.lbl_CuComfort.AutoSize = true;
            this.lbl_CuComfort.Font = new System.Drawing.Font("Segoe UI Semibold", 17F);
            this.lbl_CuComfort.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbl_CuComfort.Location = new System.Drawing.Point(74, 262);
            this.lbl_CuComfort.Name = "lbl_CuComfort";
            this.lbl_CuComfort.Size = new System.Drawing.Size(127, 40);
            this.lbl_CuComfort.TabIndex = 42;
            this.lbl_CuComfort.Text = "Comfort";
            // 
            // cmb_CusMaterial
            // 
            this.cmb_CusMaterial.BackColor = System.Drawing.Color.White;
            this.cmb_CusMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_CusMaterial.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.cmb_CusMaterial.FormattingEnabled = true;
            this.cmb_CusMaterial.Location = new System.Drawing.Point(286, 159);
            this.cmb_CusMaterial.MaxLength = 20;
            this.cmb_CusMaterial.Name = "cmb_CusMaterial";
            this.cmb_CusMaterial.Size = new System.Drawing.Size(229, 39);
            this.cmb_CusMaterial.TabIndex = 2;
            this.cmb_CusMaterial.SelectedIndexChanged += new System.EventHandler(this.cmb_CusMaterial_SelectedIndexChanged);
            // 
            // lbl_CuMaterial
            // 
            this.lbl_CuMaterial.AutoSize = true;
            this.lbl_CuMaterial.Font = new System.Drawing.Font("Segoe UI Semibold", 17F);
            this.lbl_CuMaterial.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbl_CuMaterial.Location = new System.Drawing.Point(74, 155);
            this.lbl_CuMaterial.Name = "lbl_CuMaterial";
            this.lbl_CuMaterial.Size = new System.Drawing.Size(126, 40);
            this.lbl_CuMaterial.TabIndex = 41;
            this.lbl_CuMaterial.Text = "Material";
            // 
            // cmb_CusCompany
            // 
            this.cmb_CusCompany.BackColor = System.Drawing.Color.White;
            this.cmb_CusCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_CusCompany.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.cmb_CusCompany.FormattingEnabled = true;
            this.cmb_CusCompany.Location = new System.Drawing.Point(286, 58);
            this.cmb_CusCompany.MaxLength = 20;
            this.cmb_CusCompany.Name = "cmb_CusCompany";
            this.cmb_CusCompany.Size = new System.Drawing.Size(229, 39);
            this.cmb_CusCompany.TabIndex = 1;
            this.cmb_CusCompany.SelectedIndexChanged += new System.EventHandler(this.cmb_CusCompany_SelectedIndexChanged);
            // 
            // lbl_CuCompany
            // 
            this.lbl_CuCompany.AutoSize = true;
            this.lbl_CuCompany.Font = new System.Drawing.Font("Segoe UI Semibold", 17F);
            this.lbl_CuCompany.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbl_CuCompany.Location = new System.Drawing.Point(74, 57);
            this.lbl_CuCompany.Name = "lbl_CuCompany";
            this.lbl_CuCompany.Size = new System.Drawing.Size(142, 40);
            this.lbl_CuCompany.TabIndex = 40;
            this.lbl_CuCompany.Text = "Company";
            // 
            // tb_CusPrice
            // 
            this.tb_CusPrice.Enabled = false;
            this.tb_CusPrice.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.tb_CusPrice.Location = new System.Drawing.Point(286, 475);
            this.tb_CusPrice.Name = "tb_CusPrice";
            this.tb_CusPrice.Size = new System.Drawing.Size(231, 38);
            this.tb_CusPrice.TabIndex = 5;
            // 
            // frm_Cushion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(600, 700);
            this.Controls.Add(this.tb_CusPrice);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.lbl_CuPrice);
            this.Controls.Add(this.cmb_CusSize);
            this.Controls.Add(this.lbl_CuSize);
            this.Controls.Add(this.cmb_CusComfort);
            this.Controls.Add(this.lbl_CuComfort);
            this.Controls.Add(this.cmb_CusMaterial);
            this.Controls.Add(this.lbl_CuMaterial);
            this.Controls.Add(this.cmb_CusCompany);
            this.Controls.Add(this.lbl_CuCompany);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Cushion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Cushion";
            this.Load += new System.EventHandler(this.frm_Cushion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Ok;
        private System.Windows.Forms.Label lbl_CuPrice;
        private System.Windows.Forms.ComboBox cmb_CusSize;
        private System.Windows.Forms.Label lbl_CuSize;
        private System.Windows.Forms.ComboBox cmb_CusComfort;
        private System.Windows.Forms.Label lbl_CuComfort;
        private System.Windows.Forms.ComboBox cmb_CusMaterial;
        private System.Windows.Forms.Label lbl_CuMaterial;
        private System.Windows.Forms.ComboBox cmb_CusCompany;
        private System.Windows.Forms.Label lbl_CuCompany;
        private System.Windows.Forms.TextBox tb_CusPrice;
    }
}