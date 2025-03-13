
namespace Home_Decor_App.Expence_Details
{
    partial class frm_Add_Expence
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
            this.gb_Expence_Details = new System.Windows.Forms.GroupBox();
            this.cmb_Paid_By = new System.Windows.Forms.ComboBox();
            this.btn_Browse = new System.Windows.Forms.Button();
            this.pb_Bill_Image = new System.Windows.Forms.PictureBox();
            this.dtp_E_Date = new System.Windows.Forms.DateTimePicker();
            this.tb_Amount_Paid = new System.Windows.Forms.TextBox();
            this.tb_Expence_Details = new System.Windows.Forms.TextBox();
            this.tb_E_Id = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.lbl_Paid_By = new System.Windows.Forms.Label();
            this.lbl_Bill_Image = new System.Windows.Forms.Label();
            this.lbl_Amount_Paid = new System.Windows.Forms.Label();
            this.lbl_Expence_Details = new System.Windows.Forms.Label();
            this.lbl_E_Date = new System.Windows.Forms.Label();
            this.lbl_E_Id = new System.Windows.Forms.Label();
            this.gb_Expence_Details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Bill_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_Expence_Details
            // 
            this.gb_Expence_Details.BackColor = System.Drawing.Color.LightCyan;
            this.gb_Expence_Details.Controls.Add(this.cmb_Paid_By);
            this.gb_Expence_Details.Controls.Add(this.btn_Browse);
            this.gb_Expence_Details.Controls.Add(this.pb_Bill_Image);
            this.gb_Expence_Details.Controls.Add(this.dtp_E_Date);
            this.gb_Expence_Details.Controls.Add(this.tb_Amount_Paid);
            this.gb_Expence_Details.Controls.Add(this.tb_Expence_Details);
            this.gb_Expence_Details.Controls.Add(this.tb_E_Id);
            this.gb_Expence_Details.Controls.Add(this.btn_Save);
            this.gb_Expence_Details.Controls.Add(this.btn_Refresh);
            this.gb_Expence_Details.Controls.Add(this.lbl_Paid_By);
            this.gb_Expence_Details.Controls.Add(this.lbl_Bill_Image);
            this.gb_Expence_Details.Controls.Add(this.lbl_Amount_Paid);
            this.gb_Expence_Details.Controls.Add(this.lbl_Expence_Details);
            this.gb_Expence_Details.Controls.Add(this.lbl_E_Date);
            this.gb_Expence_Details.Controls.Add(this.lbl_E_Id);
            this.gb_Expence_Details.Font = new System.Drawing.Font("Rockwell", 9F);
            this.gb_Expence_Details.ForeColor = System.Drawing.Color.Crimson;
            this.gb_Expence_Details.Location = new System.Drawing.Point(61, 61);
            this.gb_Expence_Details.Name = "gb_Expence_Details";
            this.gb_Expence_Details.Size = new System.Drawing.Size(1280, 740);
            this.gb_Expence_Details.TabIndex = 0;
            this.gb_Expence_Details.TabStop = false;
            this.gb_Expence_Details.Text = "Expence Details";
            // 
            // cmb_Paid_By
            // 
            this.cmb_Paid_By.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Paid_By.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.cmb_Paid_By.FormattingEnabled = true;
            this.cmb_Paid_By.Location = new System.Drawing.Point(938, 502);
            this.cmb_Paid_By.MaxLength = 40;
            this.cmb_Paid_By.Name = "cmb_Paid_By";
            this.cmb_Paid_By.Size = new System.Drawing.Size(266, 34);
            this.cmb_Paid_By.TabIndex = 6;
            // 
            // btn_Browse
            // 
            this.btn_Browse.BackColor = System.Drawing.Color.LightPink;
            this.btn_Browse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Browse.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
            this.btn_Browse.ForeColor = System.Drawing.Color.DarkGreen;
            this.btn_Browse.Location = new System.Drawing.Point(1009, 392);
            this.btn_Browse.Name = "btn_Browse";
            this.btn_Browse.Size = new System.Drawing.Size(125, 39);
            this.btn_Browse.TabIndex = 5;
            this.btn_Browse.Text = "Browse";
            this.btn_Browse.UseVisualStyleBackColor = false;
            this.btn_Browse.Click += new System.EventHandler(this.btn_Browse_Click);
            // 
            // pb_Bill_Image
            // 
            this.pb_Bill_Image.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pb_Bill_Image.Location = new System.Drawing.Point(938, 246);
            this.pb_Bill_Image.Name = "pb_Bill_Image";
            this.pb_Bill_Image.Size = new System.Drawing.Size(266, 140);
            this.pb_Bill_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Bill_Image.TabIndex = 22;
            this.pb_Bill_Image.TabStop = false;
            // 
            // dtp_E_Date
            // 
            this.dtp_E_Date.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.dtp_E_Date.Location = new System.Drawing.Point(938, 98);
            this.dtp_E_Date.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dtp_E_Date.Name = "dtp_E_Date";
            this.dtp_E_Date.Size = new System.Drawing.Size(266, 34);
            this.dtp_E_Date.TabIndex = 4;
            // 
            // tb_Amount_Paid
            // 
            this.tb_Amount_Paid.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.tb_Amount_Paid.Location = new System.Drawing.Point(303, 502);
            this.tb_Amount_Paid.MaxLength = 5;
            this.tb_Amount_Paid.Name = "tb_Amount_Paid";
            this.tb_Amount_Paid.Size = new System.Drawing.Size(292, 34);
            this.tb_Amount_Paid.TabIndex = 3;
            // 
            // tb_Expence_Details
            // 
            this.tb_Expence_Details.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.tb_Expence_Details.Location = new System.Drawing.Point(303, 265);
            this.tb_Expence_Details.MaxLength = 100;
            this.tb_Expence_Details.Multiline = true;
            this.tb_Expence_Details.Name = "tb_Expence_Details";
            this.tb_Expence_Details.Size = new System.Drawing.Size(292, 109);
            this.tb_Expence_Details.TabIndex = 2;
            // 
            // tb_E_Id
            // 
            this.tb_E_Id.Enabled = false;
            this.tb_E_Id.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.tb_E_Id.Location = new System.Drawing.Point(303, 98);
            this.tb_E_Id.MaxLength = 5;
            this.tb_E_Id.Name = "tb_E_Id";
            this.tb_E_Id.Size = new System.Drawing.Size(292, 34);
            this.tb_E_Id.TabIndex = 1;
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.Blue;
            this.btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Save.Font = new System.Drawing.Font("Times New Roman", 22F);
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(779, 633);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(174, 53);
            this.btn_Save.TabIndex = 7;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.Blue;
            this.btn_Refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Refresh.Font = new System.Drawing.Font("Times New Roman", 22F);
            this.btn_Refresh.ForeColor = System.Drawing.Color.White;
            this.btn_Refresh.Location = new System.Drawing.Point(341, 633);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(174, 53);
            this.btn_Refresh.TabIndex = 8;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // lbl_Paid_By
            // 
            this.lbl_Paid_By.AutoSize = true;
            this.lbl_Paid_By.Font = new System.Drawing.Font("Palatino Linotype", 15F);
            this.lbl_Paid_By.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Paid_By.Location = new System.Drawing.Point(724, 499);
            this.lbl_Paid_By.Name = "lbl_Paid_By";
            this.lbl_Paid_By.Size = new System.Drawing.Size(99, 33);
            this.lbl_Paid_By.TabIndex = 6;
            this.lbl_Paid_By.Text = "Paid By";
            // 
            // lbl_Bill_Image
            // 
            this.lbl_Bill_Image.AutoSize = true;
            this.lbl_Bill_Image.Font = new System.Drawing.Font("Palatino Linotype", 15F);
            this.lbl_Bill_Image.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Bill_Image.Location = new System.Drawing.Point(724, 284);
            this.lbl_Bill_Image.Name = "lbl_Bill_Image";
            this.lbl_Bill_Image.Size = new System.Drawing.Size(129, 33);
            this.lbl_Bill_Image.TabIndex = 0;
            this.lbl_Bill_Image.Text = "Bill Image";
            // 
            // lbl_Amount_Paid
            // 
            this.lbl_Amount_Paid.AutoSize = true;
            this.lbl_Amount_Paid.Font = new System.Drawing.Font("Palatino Linotype", 15F);
            this.lbl_Amount_Paid.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Amount_Paid.Location = new System.Drawing.Point(79, 499);
            this.lbl_Amount_Paid.Name = "lbl_Amount_Paid";
            this.lbl_Amount_Paid.Size = new System.Drawing.Size(161, 33);
            this.lbl_Amount_Paid.TabIndex = 0;
            this.lbl_Amount_Paid.Text = "Amount Paid";
            // 
            // lbl_Expence_Details
            // 
            this.lbl_Expence_Details.AutoSize = true;
            this.lbl_Expence_Details.Font = new System.Drawing.Font("Palatino Linotype", 15F);
            this.lbl_Expence_Details.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Expence_Details.Location = new System.Drawing.Point(79, 284);
            this.lbl_Expence_Details.Name = "lbl_Expence_Details";
            this.lbl_Expence_Details.Size = new System.Drawing.Size(191, 33);
            this.lbl_Expence_Details.TabIndex = 3;
            this.lbl_Expence_Details.Text = "Expence Details";
            // 
            // lbl_E_Date
            // 
            this.lbl_E_Date.AutoSize = true;
            this.lbl_E_Date.Font = new System.Drawing.Font("Palatino Linotype", 15F);
            this.lbl_E_Date.ForeColor = System.Drawing.Color.Navy;
            this.lbl_E_Date.Location = new System.Drawing.Point(724, 98);
            this.lbl_E_Date.Name = "lbl_E_Date";
            this.lbl_E_Date.Size = new System.Drawing.Size(164, 33);
            this.lbl_E_Date.TabIndex = 0;
            this.lbl_E_Date.Text = "Expence Date";
            // 
            // lbl_E_Id
            // 
            this.lbl_E_Id.AutoSize = true;
            this.lbl_E_Id.Font = new System.Drawing.Font("Palatino Linotype", 15F);
            this.lbl_E_Id.ForeColor = System.Drawing.Color.Navy;
            this.lbl_E_Id.Location = new System.Drawing.Point(79, 98);
            this.lbl_E_Id.Name = "lbl_E_Id";
            this.lbl_E_Id.Size = new System.Drawing.Size(134, 33);
            this.lbl_E_Id.TabIndex = 1;
            this.lbl_E_Id.Text = "Expence Id";
            // 
            // frm_Add_Expence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1400, 860);
            this.ControlBox = false;
            this.Controls.Add(this.gb_Expence_Details);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Add_Expence";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Expences";
            this.Load += new System.EventHandler(this.frm_Add_Expence_Load);
            this.gb_Expence_Details.ResumeLayout(false);
            this.gb_Expence_Details.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Bill_Image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Expence_Details;
        private System.Windows.Forms.Label lbl_Paid_By;
        private System.Windows.Forms.Label lbl_Bill_Image;
        private System.Windows.Forms.Label lbl_Amount_Paid;
        private System.Windows.Forms.Label lbl_Expence_Details;
        private System.Windows.Forms.Label lbl_E_Date;
        private System.Windows.Forms.Label lbl_E_Id;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.TextBox tb_Amount_Paid;
        private System.Windows.Forms.TextBox tb_Expence_Details;
        private System.Windows.Forms.TextBox tb_E_Id;
        private System.Windows.Forms.DateTimePicker dtp_E_Date;
        private System.Windows.Forms.PictureBox pb_Bill_Image;
        private System.Windows.Forms.Button btn_Browse;
        private System.Windows.Forms.ComboBox cmb_Paid_By;
    }
}