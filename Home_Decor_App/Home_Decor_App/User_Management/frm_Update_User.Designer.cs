
namespace Home_Decor_App.User_Management
{
    partial class frm_Update_User
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
            this.gb_Update_User = new System.Windows.Forms.GroupBox();
            this.cmb_Username = new System.Windows.Forms.ComboBox();
            this.cmb_User_Role = new System.Windows.Forms.ComboBox();
            this.tb_Confirm_Password = new System.Windows.Forms.TextBox();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.lbl_Confirm_Password = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.lbl_User_Role = new System.Windows.Forms.Label();
            this.btn_Update = new System.Windows.Forms.Button();
            this.gb_Update_User.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Update_User
            // 
            this.gb_Update_User.BackColor = System.Drawing.Color.LightCyan;
            this.gb_Update_User.Controls.Add(this.cmb_Username);
            this.gb_Update_User.Controls.Add(this.cmb_User_Role);
            this.gb_Update_User.Controls.Add(this.tb_Confirm_Password);
            this.gb_Update_User.Controls.Add(this.tb_Password);
            this.gb_Update_User.Controls.Add(this.lbl_Confirm_Password);
            this.gb_Update_User.Controls.Add(this.lbl_Password);
            this.gb_Update_User.Controls.Add(this.lbl_Username);
            this.gb_Update_User.Controls.Add(this.lbl_User_Role);
            this.gb_Update_User.Font = new System.Drawing.Font("Rockwell", 9F);
            this.gb_Update_User.ForeColor = System.Drawing.Color.Crimson;
            this.gb_Update_User.Location = new System.Drawing.Point(116, 94);
            this.gb_Update_User.Name = "gb_Update_User";
            this.gb_Update_User.Size = new System.Drawing.Size(1044, 565);
            this.gb_Update_User.TabIndex = 6;
            this.gb_Update_User.TabStop = false;
            this.gb_Update_User.Text = "Update User";
            // 
            // cmb_Username
            // 
            this.cmb_Username.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cmb_Username.FormattingEnabled = true;
            this.cmb_Username.Location = new System.Drawing.Point(596, 190);
            this.cmb_Username.Name = "cmb_Username";
            this.cmb_Username.Size = new System.Drawing.Size(246, 37);
            this.cmb_Username.TabIndex = 2;
            // 
            // cmb_User_Role
            // 
            this.cmb_User_Role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_User_Role.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cmb_User_Role.FormattingEnabled = true;
            this.cmb_User_Role.Location = new System.Drawing.Point(596, 66);
            this.cmb_User_Role.Name = "cmb_User_Role";
            this.cmb_User_Role.Size = new System.Drawing.Size(246, 37);
            this.cmb_User_Role.TabIndex = 1;
            this.cmb_User_Role.SelectedIndexChanged += new System.EventHandler(this.cmb_User_Role_SelectedIndexChanged);
            // 
            // tb_Confirm_Password
            // 
            this.tb_Confirm_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.tb_Confirm_Password.Location = new System.Drawing.Point(596, 436);
            this.tb_Confirm_Password.MaxLength = 10;
            this.tb_Confirm_Password.Name = "tb_Confirm_Password";
            this.tb_Confirm_Password.Size = new System.Drawing.Size(246, 36);
            this.tb_Confirm_Password.TabIndex = 4;
            // 
            // tb_Password
            // 
            this.tb_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.tb_Password.Location = new System.Drawing.Point(596, 315);
            this.tb_Password.MaxLength = 10;
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.Size = new System.Drawing.Size(246, 36);
            this.tb_Password.TabIndex = 3;
            // 
            // lbl_Confirm_Password
            // 
            this.lbl_Confirm_Password.AutoSize = true;
            this.lbl_Confirm_Password.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_Confirm_Password.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_Confirm_Password.Location = new System.Drawing.Point(187, 435);
            this.lbl_Confirm_Password.Name = "lbl_Confirm_Password";
            this.lbl_Confirm_Password.Size = new System.Drawing.Size(246, 37);
            this.lbl_Confirm_Password.TabIndex = 3;
            this.lbl_Confirm_Password.Text = "Confirm Password";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_Password.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_Password.Location = new System.Drawing.Point(187, 314);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(135, 37);
            this.lbl_Password.TabIndex = 2;
            this.lbl_Password.Text = "Password";
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_Username.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_Username.Location = new System.Drawing.Point(187, 189);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(144, 37);
            this.lbl_Username.TabIndex = 1;
            this.lbl_Username.Text = "Username";
            // 
            // lbl_User_Role
            // 
            this.lbl_User_Role.AutoSize = true;
            this.lbl_User_Role.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_User_Role.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_User_Role.Location = new System.Drawing.Point(187, 65);
            this.lbl_User_Role.Name = "lbl_User_Role";
            this.lbl_User_Role.Size = new System.Drawing.Size(139, 37);
            this.lbl_User_Role.TabIndex = 0;
            this.lbl_User_Role.Text = "User Role";
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.Navy;
            this.btn_Update.Font = new System.Drawing.Font("Times New Roman", 22F);
            this.btn_Update.ForeColor = System.Drawing.Color.White;
            this.btn_Update.Location = new System.Drawing.Point(499, 701);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(277, 71);
            this.btn_Update.TabIndex = 5;
            this.btn_Update.Text = "Update User";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // frm_Update_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1300, 900);
            this.ControlBox = false;
            this.Controls.Add(this.gb_Update_User);
            this.Controls.Add(this.btn_Update);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Update_User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Update User";
            this.Load += new System.EventHandler(this.frm_Update_User_Load);
            this.gb_Update_User.ResumeLayout(false);
            this.gb_Update_User.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Update_User;
        private System.Windows.Forms.ComboBox cmb_User_Role;
        private System.Windows.Forms.TextBox tb_Confirm_Password;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Label lbl_Confirm_Password;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Label lbl_User_Role;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.ComboBox cmb_Username;
    }
}