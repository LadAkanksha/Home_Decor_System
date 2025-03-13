
namespace Home_Decor_App.User_Management
{
    partial class frm_Delete_and_View_User
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gb_Delete_User = new System.Windows.Forms.GroupBox();
            this.tb_User_Role = new System.Windows.Forms.TextBox();
            this.tb_Confirm_Password = new System.Windows.Forms.TextBox();
            this.tb_Username = new System.Windows.Forms.TextBox();
            this.lbl_Admin_Password = new System.Windows.Forms.Label();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.lbl_User_Role = new System.Windows.Forms.Label();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.dgv_User_Details = new System.Windows.Forms.DataGridView();
            this.gb_Delete_User.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_User_Details)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_Delete_User
            // 
            this.gb_Delete_User.BackColor = System.Drawing.Color.LightCyan;
            this.gb_Delete_User.Controls.Add(this.tb_User_Role);
            this.gb_Delete_User.Controls.Add(this.tb_Confirm_Password);
            this.gb_Delete_User.Controls.Add(this.tb_Username);
            this.gb_Delete_User.Controls.Add(this.lbl_Admin_Password);
            this.gb_Delete_User.Controls.Add(this.lbl_Username);
            this.gb_Delete_User.Controls.Add(this.lbl_User_Role);
            this.gb_Delete_User.Font = new System.Drawing.Font("Rockwell", 10F);
            this.gb_Delete_User.ForeColor = System.Drawing.Color.Crimson;
            this.gb_Delete_User.Location = new System.Drawing.Point(55, 99);
            this.gb_Delete_User.Name = "gb_Delete_User";
            this.gb_Delete_User.Size = new System.Drawing.Size(533, 522);
            this.gb_Delete_User.TabIndex = 6;
            this.gb_Delete_User.TabStop = false;
            this.gb_Delete_User.Text = "Delete User";
            // 
            // tb_User_Role
            // 
            this.tb_User_Role.Enabled = false;
            this.tb_User_Role.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.tb_User_Role.Location = new System.Drawing.Point(249, 107);
            this.tb_User_Role.MaxLength = 20;
            this.tb_User_Role.Name = "tb_User_Role";
            this.tb_User_Role.Size = new System.Drawing.Size(246, 36);
            this.tb_User_Role.TabIndex = 5;
            // 
            // tb_Confirm_Password
            // 
            this.tb_Confirm_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.tb_Confirm_Password.Location = new System.Drawing.Point(249, 389);
            this.tb_Confirm_Password.MaxLength = 10;
            this.tb_Confirm_Password.Name = "tb_Confirm_Password";
            this.tb_Confirm_Password.PasswordChar = '*';
            this.tb_Confirm_Password.Size = new System.Drawing.Size(246, 36);
            this.tb_Confirm_Password.TabIndex = 4;
            this.tb_Confirm_Password.TextChanged += new System.EventHandler(this.tb_Confirm_Password_TextChanged);
            // 
            // tb_Username
            // 
            this.tb_Username.Enabled = false;
            this.tb_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.tb_Username.Location = new System.Drawing.Point(249, 243);
            this.tb_Username.MaxLength = 20;
            this.tb_Username.Name = "tb_Username";
            this.tb_Username.Size = new System.Drawing.Size(246, 36);
            this.tb_Username.TabIndex = 2;
            // 
            // lbl_Admin_Password
            // 
            this.lbl_Admin_Password.AutoSize = true;
            this.lbl_Admin_Password.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_Admin_Password.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_Admin_Password.Location = new System.Drawing.Point(6, 388);
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
            this.lbl_Username.Location = new System.Drawing.Point(37, 242);
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
            this.lbl_User_Role.Location = new System.Drawing.Point(37, 106);
            this.lbl_User_Role.Name = "lbl_User_Role";
            this.lbl_User_Role.Size = new System.Drawing.Size(139, 37);
            this.lbl_User_Role.TabIndex = 0;
            this.lbl_User_Role.Text = "User Role";
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.DarkBlue;
            this.btn_Delete.Enabled = false;
            this.btn_Delete.Font = new System.Drawing.Font("Times New Roman", 22F);
            this.btn_Delete.ForeColor = System.Drawing.Color.White;
            this.btn_Delete.Location = new System.Drawing.Point(162, 651);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(277, 63);
            this.btn_Delete.TabIndex = 7;
            this.btn_Delete.Text = "Delete User";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // dgv_User_Details
            // 
            this.dgv_User_Details.AllowUserToAddRows = false;
            this.dgv_User_Details.AllowUserToDeleteRows = false;
            this.dgv_User_Details.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_User_Details.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_User_Details.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_User_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_User_Details.Location = new System.Drawing.Point(667, 99);
            this.dgv_User_Details.Name = "dgv_User_Details";
            this.dgv_User_Details.ReadOnly = true;
            this.dgv_User_Details.RowHeadersWidth = 51;
            this.dgv_User_Details.RowTemplate.Height = 24;
            this.dgv_User_Details.Size = new System.Drawing.Size(577, 615);
            this.dgv_User_Details.TabIndex = 8;
            this.dgv_User_Details.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_User_Details_CellDoubleClick);
            // 
            // frm_Delete_and_View_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1300, 900);
            this.ControlBox = false;
            this.Controls.Add(this.dgv_User_Details);
            this.Controls.Add(this.gb_Delete_User);
            this.Controls.Add(this.btn_Delete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Delete_and_View_User";
            this.Text = "Delete and View User";
            this.Load += new System.EventHandler(this.frm_Delete_and_View_User_Load);
            this.gb_Delete_User.ResumeLayout(false);
            this.gb_Delete_User.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_User_Details)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Delete_User;
        private System.Windows.Forms.TextBox tb_Confirm_Password;
        private System.Windows.Forms.TextBox tb_Username;
        private System.Windows.Forms.Label lbl_Admin_Password;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Label lbl_User_Role;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.DataGridView dgv_User_Details;
        private System.Windows.Forms.TextBox tb_User_Role;
    }
}