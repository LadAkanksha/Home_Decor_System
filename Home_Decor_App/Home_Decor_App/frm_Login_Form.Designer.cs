
namespace Home_Decor_App
{
    partial class frm_Login_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Login_Form));
            this.pnl_Title_Name = new System.Windows.Forms.Panel();
            this.lbl_Subtitle = new System.Windows.Forms.Label();
            this.lbl_Title_Name = new System.Windows.Forms.Label();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.cmb_User_Role = new System.Windows.Forms.ComboBox();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.lbl_Role = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.pb_Shop_Image = new System.Windows.Forms.PictureBox();
            this.cmb_Username = new System.Windows.Forms.ComboBox();
            this.pnl_Title_Name.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Shop_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Title_Name
            // 
            this.pnl_Title_Name.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pnl_Title_Name.Controls.Add(this.lbl_Subtitle);
            this.pnl_Title_Name.Controls.Add(this.lbl_Title_Name);
            this.pnl_Title_Name.Location = new System.Drawing.Point(0, -3);
            this.pnl_Title_Name.Name = "pnl_Title_Name";
            this.pnl_Title_Name.Size = new System.Drawing.Size(1023, 115);
            this.pnl_Title_Name.TabIndex = 9;
            // 
            // lbl_Subtitle
            // 
            this.lbl_Subtitle.AutoSize = true;
            this.lbl_Subtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Subtitle.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_Subtitle.Location = new System.Drawing.Point(646, 81);
            this.lbl_Subtitle.Name = "lbl_Subtitle";
            this.lbl_Subtitle.Size = new System.Drawing.Size(226, 25);
            this.lbl_Subtitle.TabIndex = 0;
            this.lbl_Subtitle.Text = "Wake Up Positively !!!";
            // 
            // lbl_Title_Name
            // 
            this.lbl_Title_Name.AutoSize = true;
            this.lbl_Title_Name.Font = new System.Drawing.Font("Calibri", 45F);
            this.lbl_Title_Name.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Title_Name.Location = new System.Drawing.Point(145, 0);
            this.lbl_Title_Name.Name = "lbl_Title_Name";
            this.lbl_Title_Name.Size = new System.Drawing.Size(710, 91);
            this.lbl_Title_Name.TabIndex = 0;
            this.lbl_Title_Name.Text = "Sunshine Home Decor";
            // 
            // btn_Submit
            // 
            this.btn_Submit.BackColor = System.Drawing.Color.DarkRed;
            this.btn_Submit.Font = new System.Drawing.Font("Times New Roman", 22F);
            this.btn_Submit.ForeColor = System.Drawing.Color.White;
            this.btn_Submit.Location = new System.Drawing.Point(659, 520);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(174, 64);
            this.btn_Submit.TabIndex = 4;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = false;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // cmb_User_Role
            // 
            this.cmb_User_Role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_User_Role.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.cmb_User_Role.FormattingEnabled = true;
            this.cmb_User_Role.Location = new System.Drawing.Point(753, 183);
            this.cmb_User_Role.Name = "cmb_User_Role";
            this.cmb_User_Role.Size = new System.Drawing.Size(219, 40);
            this.cmb_User_Role.TabIndex = 1;
            this.cmb_User_Role.SelectedIndexChanged += new System.EventHandler(this.cmb_User_Role_SelectedIndexChanged);
            // 
            // tb_Password
            // 
            this.tb_Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.tb_Password.Location = new System.Drawing.Point(753, 415);
            this.tb_Password.MaxLength = 10;
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.PasswordChar = '*';
            this.tb_Password.Size = new System.Drawing.Size(219, 36);
            this.tb_Password.TabIndex = 3;
            // 
            // lbl_Role
            // 
            this.lbl_Role.AutoSize = true;
            this.lbl_Role.Font = new System.Drawing.Font("Palatino Linotype", 19F, System.Drawing.FontStyle.Bold);
            this.lbl_Role.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_Role.Location = new System.Drawing.Point(527, 178);
            this.lbl_Role.Name = "lbl_Role";
            this.lbl_Role.Size = new System.Drawing.Size(87, 44);
            this.lbl_Role.TabIndex = 13;
            this.lbl_Role.Text = "Role";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Palatino Linotype", 19F, System.Drawing.FontStyle.Bold);
            this.lbl_Password.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_Password.Location = new System.Drawing.Point(527, 412);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(160, 44);
            this.lbl_Password.TabIndex = 12;
            this.lbl_Password.Text = "Password";
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Font = new System.Drawing.Font("Palatino Linotype", 19F, System.Drawing.FontStyle.Bold);
            this.lbl_Username.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_Username.Location = new System.Drawing.Point(527, 288);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(167, 44);
            this.lbl_Username.TabIndex = 11;
            this.lbl_Username.Text = "Username";
            // 
            // pb_Shop_Image
            // 
            this.pb_Shop_Image.Image = global::Home_Decor_App.Properties.Resources.LoginPage;
            this.pb_Shop_Image.Location = new System.Drawing.Point(0, 111);
            this.pb_Shop_Image.Name = "pb_Shop_Image";
            this.pb_Shop_Image.Size = new System.Drawing.Size(521, 507);
            this.pb_Shop_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Shop_Image.TabIndex = 10;
            this.pb_Shop_Image.TabStop = false;
            // 
            // cmb_Username
            // 
            this.cmb_Username.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.cmb_Username.FormattingEnabled = true;
            this.cmb_Username.Location = new System.Drawing.Point(753, 293);
            this.cmb_Username.Name = "cmb_Username";
            this.cmb_Username.Size = new System.Drawing.Size(219, 40);
            this.cmb_Username.TabIndex = 2;
            // 
            // frm_Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1023, 618);
            this.Controls.Add(this.cmb_Username);
            this.Controls.Add(this.pnl_Title_Name);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.cmb_User_Role);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.lbl_Role);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_Username);
            this.Controls.Add(this.pb_Shop_Image);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Login_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Page";
            this.Load += new System.EventHandler(this.frm_Login_Form_Load);
            this.pnl_Title_Name.ResumeLayout(false);
            this.pnl_Title_Name.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Shop_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Title_Name;
        private System.Windows.Forms.Label lbl_Subtitle;
        private System.Windows.Forms.Label lbl_Title_Name;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.ComboBox cmb_User_Role;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Label lbl_Role;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.PictureBox pb_Shop_Image;
        private System.Windows.Forms.ComboBox cmb_Username;
    }
}

