
namespace Home_Decor_App.Product_Details.Pillow
{
    partial class frm_View_Pillow_List
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
            this.gb_Search_By = new System.Windows.Forms.GroupBox();
            this.lbl_Company = new System.Windows.Forms.Label();
            this.lbl_Comfort = new System.Windows.Forms.Label();
            this.cmb_P_Comfort = new System.Windows.Forms.ComboBox();
            this.lbl_Material = new System.Windows.Forms.Label();
            this.cmb_P_Company = new System.Windows.Forms.ComboBox();
            this.cmb_P_Material = new System.Windows.Forms.ComboBox();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.dgv_Pillow_Details = new System.Windows.Forms.DataGridView();
            this.gb_Search_By.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Pillow_Details)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_Search_By
            // 
            this.gb_Search_By.BackColor = System.Drawing.Color.LightCyan;
            this.gb_Search_By.Controls.Add(this.lbl_Company);
            this.gb_Search_By.Controls.Add(this.lbl_Comfort);
            this.gb_Search_By.Controls.Add(this.cmb_P_Comfort);
            this.gb_Search_By.Controls.Add(this.lbl_Material);
            this.gb_Search_By.Controls.Add(this.cmb_P_Company);
            this.gb_Search_By.Controls.Add(this.cmb_P_Material);
            this.gb_Search_By.Font = new System.Drawing.Font("Rockwell", 9F);
            this.gb_Search_By.ForeColor = System.Drawing.Color.Crimson;
            this.gb_Search_By.Location = new System.Drawing.Point(61, 56);
            this.gb_Search_By.Name = "gb_Search_By";
            this.gb_Search_By.Size = new System.Drawing.Size(1280, 166);
            this.gb_Search_By.TabIndex = 10;
            this.gb_Search_By.TabStop = false;
            this.gb_Search_By.Text = "Search By";
            // 
            // lbl_Company
            // 
            this.lbl_Company.AutoSize = true;
            this.lbl_Company.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbl_Company.ForeColor = System.Drawing.Color.DeepPink;
            this.lbl_Company.Location = new System.Drawing.Point(142, 47);
            this.lbl_Company.Name = "lbl_Company";
            this.lbl_Company.Size = new System.Drawing.Size(115, 29);
            this.lbl_Company.TabIndex = 6;
            this.lbl_Company.Text = "Company";
            // 
            // lbl_Comfort
            // 
            this.lbl_Comfort.AutoSize = true;
            this.lbl_Comfort.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbl_Comfort.ForeColor = System.Drawing.Color.DeepPink;
            this.lbl_Comfort.Location = new System.Drawing.Point(996, 47);
            this.lbl_Comfort.Name = "lbl_Comfort";
            this.lbl_Comfort.Size = new System.Drawing.Size(98, 29);
            this.lbl_Comfort.TabIndex = 2;
            this.lbl_Comfort.Text = "Comfort";
            // 
            // cmb_P_Comfort
            // 
            this.cmb_P_Comfort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_P_Comfort.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cmb_P_Comfort.FormattingEnabled = true;
            this.cmb_P_Comfort.Location = new System.Drawing.Point(945, 85);
            this.cmb_P_Comfort.Name = "cmb_P_Comfort";
            this.cmb_P_Comfort.Size = new System.Drawing.Size(211, 37);
            this.cmb_P_Comfort.TabIndex = 3;
            this.cmb_P_Comfort.SelectedIndexChanged += new System.EventHandler(this.cmb_P_Comfort_SelectedIndexChanged);
            // 
            // lbl_Material
            // 
            this.lbl_Material.AutoSize = true;
            this.lbl_Material.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbl_Material.ForeColor = System.Drawing.Color.DeepPink;
            this.lbl_Material.Location = new System.Drawing.Point(557, 47);
            this.lbl_Material.Name = "lbl_Material";
            this.lbl_Material.Size = new System.Drawing.Size(99, 29);
            this.lbl_Material.TabIndex = 5;
            this.lbl_Material.Text = "Material";
            // 
            // cmb_P_Company
            // 
            this.cmb_P_Company.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_P_Company.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cmb_P_Company.FormattingEnabled = true;
            this.cmb_P_Company.Location = new System.Drawing.Point(93, 85);
            this.cmb_P_Company.Name = "cmb_P_Company";
            this.cmb_P_Company.Size = new System.Drawing.Size(214, 37);
            this.cmb_P_Company.TabIndex = 1;
            this.cmb_P_Company.SelectedIndexChanged += new System.EventHandler(this.cmb_P_Company_SelectedIndexChanged);
            // 
            // cmb_P_Material
            // 
            this.cmb_P_Material.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_P_Material.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cmb_P_Material.FormattingEnabled = true;
            this.cmb_P_Material.Location = new System.Drawing.Point(505, 85);
            this.cmb_P_Material.Name = "cmb_P_Material";
            this.cmb_P_Material.Size = new System.Drawing.Size(210, 37);
            this.cmb_P_Material.TabIndex = 2;
            this.cmb_P_Material.SelectedIndexChanged += new System.EventHandler(this.cmb_P_Material_SelectedIndexChanged);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.Blue;
            this.btn_Refresh.Font = new System.Drawing.Font("Times New Roman", 22F);
            this.btn_Refresh.ForeColor = System.Drawing.Color.White;
            this.btn_Refresh.Location = new System.Drawing.Point(599, 721);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(213, 67);
            this.btn_Refresh.TabIndex = 7;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            // 
            // dgv_Pillow_Details
            // 
            this.dgv_Pillow_Details.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Pillow_Details.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgv_Pillow_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Pillow_Details.Location = new System.Drawing.Point(61, 245);
            this.dgv_Pillow_Details.Name = "dgv_Pillow_Details";
            this.dgv_Pillow_Details.RowHeadersWidth = 51;
            this.dgv_Pillow_Details.RowTemplate.Height = 24;
            this.dgv_Pillow_Details.Size = new System.Drawing.Size(1280, 431);
            this.dgv_Pillow_Details.TabIndex = 6;
            // 
            // frm_View_Pillow_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1400, 860);
            this.ControlBox = false;
            this.Controls.Add(this.gb_Search_By);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.dgv_Pillow_Details);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_View_Pillow_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "View Pillow List";
            this.Load += new System.EventHandler(this.frm_View_Pillow_List_Load);
            this.gb_Search_By.ResumeLayout(false);
            this.gb_Search_By.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Pillow_Details)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Search_By;
        private System.Windows.Forms.Label lbl_Company;
        private System.Windows.Forms.Label lbl_Comfort;
        private System.Windows.Forms.ComboBox cmb_P_Comfort;
        private System.Windows.Forms.Label lbl_Material;
        private System.Windows.Forms.ComboBox cmb_P_Company;
        private System.Windows.Forms.ComboBox cmb_P_Material;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.DataGridView dgv_Pillow_Details;
    }
}