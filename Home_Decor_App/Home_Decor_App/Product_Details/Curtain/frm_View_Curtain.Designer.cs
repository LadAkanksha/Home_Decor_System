
namespace Home_Decor_App.Product_Details.Curtain
{
    partial class frm_View_Curtain
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
            this.lbl_Material = new System.Windows.Forms.Label();
            this.cmb_Cur_Company = new System.Windows.Forms.ComboBox();
            this.lbl_Style = new System.Windows.Forms.Label();
            this.cmb_Cur_Material = new System.Windows.Forms.ComboBox();
            this.cmb_Cur_Style = new System.Windows.Forms.ComboBox();
            this.dgv_Curtain_Details = new System.Windows.Forms.DataGridView();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.gb_Search_By.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Curtain_Details)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_Search_By
            // 
            this.gb_Search_By.BackColor = System.Drawing.Color.LightCyan;
            this.gb_Search_By.Controls.Add(this.lbl_Company);
            this.gb_Search_By.Controls.Add(this.lbl_Material);
            this.gb_Search_By.Controls.Add(this.cmb_Cur_Company);
            this.gb_Search_By.Controls.Add(this.lbl_Style);
            this.gb_Search_By.Controls.Add(this.cmb_Cur_Material);
            this.gb_Search_By.Controls.Add(this.cmb_Cur_Style);
            this.gb_Search_By.Font = new System.Drawing.Font("Rockwell", 9F);
            this.gb_Search_By.ForeColor = System.Drawing.Color.Crimson;
            this.gb_Search_By.Location = new System.Drawing.Point(61, 56);
            this.gb_Search_By.Name = "gb_Search_By";
            this.gb_Search_By.Size = new System.Drawing.Size(1280, 166);
            this.gb_Search_By.TabIndex = 0;
            this.gb_Search_By.TabStop = false;
            this.gb_Search_By.Text = "Search By";
            // 
            // lbl_Company
            // 
            this.lbl_Company.AutoSize = true;
            this.lbl_Company.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbl_Company.ForeColor = System.Drawing.Color.DeepPink;
            this.lbl_Company.Location = new System.Drawing.Point(163, 41);
            this.lbl_Company.Name = "lbl_Company";
            this.lbl_Company.Size = new System.Drawing.Size(115, 29);
            this.lbl_Company.TabIndex = 6;
            this.lbl_Company.Text = "Company";
            // 
            // lbl_Material
            // 
            this.lbl_Material.AutoSize = true;
            this.lbl_Material.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbl_Material.ForeColor = System.Drawing.Color.DeepPink;
            this.lbl_Material.Location = new System.Drawing.Point(583, 41);
            this.lbl_Material.Name = "lbl_Material";
            this.lbl_Material.Size = new System.Drawing.Size(99, 29);
            this.lbl_Material.TabIndex = 5;
            this.lbl_Material.Text = "Material";
            // 
            // cmb_Cur_Company
            // 
            this.cmb_Cur_Company.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Cur_Company.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cmb_Cur_Company.FormattingEnabled = true;
            this.cmb_Cur_Company.Location = new System.Drawing.Point(125, 79);
            this.cmb_Cur_Company.Name = "cmb_Cur_Company";
            this.cmb_Cur_Company.Size = new System.Drawing.Size(214, 37);
            this.cmb_Cur_Company.TabIndex = 1;
            this.cmb_Cur_Company.SelectedIndexChanged += new System.EventHandler(this.cmb_Cur_Company_SelectedIndexChanged);
            // 
            // lbl_Style
            // 
            this.lbl_Style.AutoSize = true;
            this.lbl_Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbl_Style.ForeColor = System.Drawing.Color.DeepPink;
            this.lbl_Style.Location = new System.Drawing.Point(994, 41);
            this.lbl_Style.Name = "lbl_Style";
            this.lbl_Style.Size = new System.Drawing.Size(66, 29);
            this.lbl_Style.TabIndex = 2;
            this.lbl_Style.Text = "Style";
            // 
            // cmb_Cur_Material
            // 
            this.cmb_Cur_Material.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Cur_Material.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cmb_Cur_Material.FormattingEnabled = true;
            this.cmb_Cur_Material.Location = new System.Drawing.Point(510, 79);
            this.cmb_Cur_Material.Name = "cmb_Cur_Material";
            this.cmb_Cur_Material.Size = new System.Drawing.Size(243, 37);
            this.cmb_Cur_Material.TabIndex = 2;
            this.cmb_Cur_Material.SelectedIndexChanged += new System.EventHandler(this.cmb_Cur_Material_SelectedIndexChanged);
            // 
            // cmb_Cur_Style
            // 
            this.cmb_Cur_Style.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Cur_Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cmb_Cur_Style.FormattingEnabled = true;
            this.cmb_Cur_Style.Location = new System.Drawing.Point(914, 79);
            this.cmb_Cur_Style.Name = "cmb_Cur_Style";
            this.cmb_Cur_Style.Size = new System.Drawing.Size(231, 37);
            this.cmb_Cur_Style.TabIndex = 3;
            this.cmb_Cur_Style.SelectedIndexChanged += new System.EventHandler(this.cmb_Cur_Style_SelectedIndexChanged);
            // 
            // dgv_Curtain_Details
            // 
            this.dgv_Curtain_Details.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Curtain_Details.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgv_Curtain_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Curtain_Details.Location = new System.Drawing.Point(61, 247);
            this.dgv_Curtain_Details.Name = "dgv_Curtain_Details";
            this.dgv_Curtain_Details.RowHeadersWidth = 51;
            this.dgv_Curtain_Details.RowTemplate.Height = 24;
            this.dgv_Curtain_Details.Size = new System.Drawing.Size(1280, 461);
            this.dgv_Curtain_Details.TabIndex = 0;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.Blue;
            this.btn_Refresh.Font = new System.Drawing.Font("Times New Roman", 22F);
            this.btn_Refresh.ForeColor = System.Drawing.Color.White;
            this.btn_Refresh.Location = new System.Drawing.Point(601, 758);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(213, 67);
            this.btn_Refresh.TabIndex = 6;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // frm_View_Curtain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1400, 860);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.gb_Search_By);
            this.Controls.Add(this.dgv_Curtain_Details);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_View_Curtain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "View Curtain List";
            this.Load += new System.EventHandler(this.frm_View_Curtain_Load);
            this.gb_Search_By.ResumeLayout(false);
            this.gb_Search_By.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Curtain_Details)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Search_By;
        private System.Windows.Forms.ComboBox cmb_Cur_Material;
        private System.Windows.Forms.DataGridView dgv_Curtain_Details;
        private System.Windows.Forms.Label lbl_Company;
        private System.Windows.Forms.Label lbl_Material;
        private System.Windows.Forms.ComboBox cmb_Cur_Company;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Label lbl_Style;
        private System.Windows.Forms.ComboBox cmb_Cur_Style;
    }
}