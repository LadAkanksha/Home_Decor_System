
namespace Home_Decor_App.User_Management
{
    partial class frm_Delate_User
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
            this.gb_Delete_User = new System.Windows.Forms.GroupBox();
            this.cmb_Username = new System.Windows.Forms.ComboBox();
            this.cmb_User_Role = new System.Windows.Forms.ComboBox();
            this.tb_Admin_Password = new System.Windows.Forms.TextBox();
            this.lbl_Admin_Password = new System.Windows.Forms.Label();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.lbl_User_Role = new System.Windows.Forms.Label();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.gb_Delete_User.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Delete_User
            // 
            this.gb_Delete_User.BackColor = System.Drawing.Color.LightCyan;
            this.gb_Delete_User.Controls.Add(this.cmb_Username);
            this.gb_Delete_User.Controls.Add(this.cmb_User_Role);
            this.gb_Delete_User.Controls.Add(this.tb_Admin_Password);
            this.gb_Delete_User.Controls.Add(this.lbl_Admin_Password);
            this.gb_Delete_User.Controls.Add(this.lbl_Username);
            this.gb_Delete_User.Controls.Add(this.lbl_User_Role);
            this.gb_Delete_User.Font = new System.Drawing.Font("Rockwell", 9F);
            this.gb_Delete_User.ForeColor = System.Drawing.Color.Crimson;
            this.gb_Delete_User.Location = new System.Drawing.Point(116, 94);
            this.gb_Delete_User.Name = "gb_Delete_User";
            this.gb_Delete_User.Size = new System.Drawing.Size(1044, 565);
            this.gb_Delete_User.TabIndex = 8;
            this.gb_Delete_User.TabStop = false;
            this.gb_Delete_User.Text = "Delete User";
            // 
            // cmb_Username
            // 
            this.cmb_Username.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cmb_Username.FormattingEnabled = true;
            this.cmb_Username.Location = new System.Drawing.Point(596, 237);
            this.cmb_Username.Name = "cmb_Username";
            this.cmb_Username.Size = new System.Drawing.Size(246, 37);
            this.cmb_Username.TabIndex = 2;
            // 
            // cmb_User_Role
            // 
            this.cmb_User_Role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_User_Role.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cmb_User_Role.FormattingEnabled = true;
            this.cmb_User_Role.Location = new System.Drawing.Point(596, 103);
            this.cmb_User_Role.Name = "cmb_User_Role";
            this.cmb_User_Role.Size = new System.Drawing.Size(246, 37);
            this.cmb_User_Role.TabIndex = 1;
            // 
            // tb_Admin_Password
            // 
            this.tb_Admin_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.tb_Admin_Password.Location = new System.Drawing.Point(596, 370);
            this.tb_Admin_Password.MaxLength = 10;
            this.tb_Admin_Password.Name = "tb_Admin_Password";
            this.tb_Admin_Password.Size = new System.Drawing.Size(246, 36);
            this.tb_Admin_Password.TabIndex = 3;
            // 
            // lbl_Admin_Password
            // 
            this.lbl_Admin_Password.AutoSize = true;
            this.lbl_Admin_Password.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_Admin_Password.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_Admin_Password.Location = new System.Drawing.Point(187, 370);
            this.lbl_Admin_Password.Name = "lbl_Admin_Password";
            this.lbl_Admin_Password.Size = new System.Drawing.Size(230, 37);
            this.lbl_Admin_Password.TabIndex = 3;
            this.lbl_Admin_Password.Text = "Admin Password";
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_Username.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_Username.Location = new System.Drawing.Point(187, 236);
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
            this.lbl_User_Role.Location = new System.Drawing.Point(187, 102);
            this.lbl_User_Role.Name = "lbl_User_Role";
            this.lbl_User_Role.Size = new System.Drawing.Size(139, 37);
            this.lbl_User_Role.TabIndex = 0;
            this.lbl_User_Role.Text = "User Role";
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.Navy;
            this.btn_Delete.Font = new System.Drawing.Font("Times New Roman", 22F);
            this.btn_Delete.ForeColor = System.Drawing.Color.White;
            this.btn_Delete.Location = new System.Drawing.Point(499, 701);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(277, 71);
            this.btn_Delete.TabIndex = 4;
            this.btn_Delete.Text = "Delete User";
            this.btn_Delete.UseVisualStyleBackColor = false;
            // 
            // frm_Delate_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1300, 900);
            this.ControlBox = false;
            this.Controls.Add(this.gb_Delete_User);
            this.Controls.Add(this.btn_Delete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Delate_User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Delete User";
            this.gb_Delete_User.ResumeLayout(false);
            this.gb_Delete_User.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Delete_User;
        private System.Windows.Forms.ComboBox cmb_Username;
        private System.Windows.Forms.ComboBox cmb_User_Role;
        private System.Windows.Forms.TextBox tb_Admin_Password;
        private System.Windows.Forms.Label lbl_Admin_Password;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Label lbl_User_Role;
        private System.Windows.Forms.Button btn_Delete;
    }
}