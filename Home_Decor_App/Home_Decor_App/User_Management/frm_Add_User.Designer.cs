
namespace Home_Decor_App.User_Management
{
    partial class frm_Add_User
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
            this.gb_Add_User = new System.Windows.Forms.GroupBox();
            this.cmb_User_Role = new System.Windows.Forms.ComboBox();
            this.tb_Confirm_Password = new System.Windows.Forms.TextBox();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.lbl_Confirm_Password = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.lbl_User_Role = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.tb_Username = new System.Windows.Forms.TextBox();
            this.gb_Add_User.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Add_User
            // 
            this.gb_Add_User.BackColor = System.Drawing.Color.LightCyan;
            this.gb_Add_User.Controls.Add(this.tb_Username);
            this.gb_Add_User.Controls.Add(this.cmb_User_Role);
            this.gb_Add_User.Controls.Add(this.tb_Confirm_Password);
            this.gb_Add_User.Controls.Add(this.tb_Password);
            this.gb_Add_User.Controls.Add(this.lbl_Confirm_Password);
            this.gb_Add_User.Controls.Add(this.lbl_Password);
            this.gb_Add_User.Controls.Add(this.lbl_Username);
            this.gb_Add_User.Controls.Add(this.lbl_User_Role);
            this.gb_Add_User.Font = new System.Drawing.Font("Rockwell", 9F);
            this.gb_Add_User.ForeColor = System.Drawing.Color.Crimson;
            this.gb_Add_User.Location = new System.Drawing.Point(116, 94);
            this.gb_Add_User.Name = "gb_Add_User";
            this.gb_Add_User.Size = new System.Drawing.Size(1044, 565);
            this.gb_Add_User.TabIndex = 0;
            this.gb_Add_User.TabStop = false;
            this.gb_Add_User.Text = "Add New User";
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
            // 
            // tb_Confirm_Password
            // 
            this.tb_Confirm_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.tb_Confirm_Password.Location = new System.Drawing.Point(596, 433);
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
            this.tb_Password.PasswordChar = '*';
            this.tb_Password.Size = new System.Drawing.Size(246, 36);
            this.tb_Password.TabIndex = 3;
            this.tb_Password.TextChanged += new System.EventHandler(this.tb_Password_TextChanged);
            // 
            // lbl_Confirm_Password
            // 
            this.lbl_Confirm_Password.AutoSize = true;
            this.lbl_Confirm_Password.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_Confirm_Password.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_Confirm_Password.Location = new System.Drawing.Point(187, 432);
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
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.DarkBlue;
            this.btn_Add.Font = new System.Drawing.Font("Times New Roman", 22F);
            this.btn_Add.ForeColor = System.Drawing.Color.White;
            this.btn_Add.Location = new System.Drawing.Point(501, 698);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(297, 71);
            this.btn_Add.TabIndex = 5;
            this.btn_Add.Text = "Add User";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // tb_Username
            // 
            this.tb_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.tb_Username.Location = new System.Drawing.Point(596, 190);
            this.tb_Username.MaxLength = 10;
            this.tb_Username.Name = "tb_Username";
            this.tb_Username.Size = new System.Drawing.Size(246, 36);
            this.tb_Username.TabIndex = 2;
            // 
            // frm_Add_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1300, 900);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.gb_Add_User);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Add_User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add User";
            this.Load += new System.EventHandler(this.frm_Add_User_Load);
            this.gb_Add_User.ResumeLayout(false);
            this.gb_Add_User.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Add_User;
        private System.Windows.Forms.Label lbl_User_Role;
        private System.Windows.Forms.Label lbl_Confirm_Password;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.ComboBox cmb_User_Role;
        private System.Windows.Forms.TextBox tb_Confirm_Password;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.TextBox tb_Username;
    }
}