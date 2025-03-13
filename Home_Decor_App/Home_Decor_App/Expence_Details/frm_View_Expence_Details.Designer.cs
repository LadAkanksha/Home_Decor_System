
namespace Home_Decor_App.Expence_Details
{
    partial class frm_View_Expence_Details
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
            this.gb_Search_Expence = new System.Windows.Forms.GroupBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.cmb_Searchby_Year = new System.Windows.Forms.ComboBox();
            this.cmb_Searchby_Month = new System.Windows.Forms.ComboBox();
            this.lbl_Search_Expence = new System.Windows.Forms.Label();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.dgv_Expence_Details = new System.Windows.Forms.DataGridView();
            this.gb_Search_Expence.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Expence_Details)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_Search_Expence
            // 
            this.gb_Search_Expence.BackColor = System.Drawing.Color.LightCyan;
            this.gb_Search_Expence.Controls.Add(this.btn_Search);
            this.gb_Search_Expence.Controls.Add(this.cmb_Searchby_Year);
            this.gb_Search_Expence.Controls.Add(this.cmb_Searchby_Month);
            this.gb_Search_Expence.Controls.Add(this.lbl_Search_Expence);
            this.gb_Search_Expence.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.gb_Search_Expence.ForeColor = System.Drawing.Color.Crimson;
            this.gb_Search_Expence.Location = new System.Drawing.Point(61, 61);
            this.gb_Search_Expence.Name = "gb_Search_Expence";
            this.gb_Search_Expence.Size = new System.Drawing.Size(1280, 143);
            this.gb_Search_Expence.TabIndex = 0;
            this.gb_Search_Expence.TabStop = false;
            this.gb_Search_Expence.Text = "Search Expence Details";
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.LightPink;
            this.btn_Search.Font = new System.Drawing.Font("Times New Roman", 22F);
            this.btn_Search.ForeColor = System.Drawing.Color.DarkGreen;
            this.btn_Search.Location = new System.Drawing.Point(1015, 56);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(186, 46);
            this.btn_Search.TabIndex = 3;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // cmb_Searchby_Year
            // 
            this.cmb_Searchby_Year.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Searchby_Year.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.cmb_Searchby_Year.FormattingEnabled = true;
            this.cmb_Searchby_Year.Items.AddRange(new object[] {
            "2021",
            "2022",
            "2023",
            "2024",
            "2025"});
            this.cmb_Searchby_Year.Location = new System.Drawing.Point(660, 62);
            this.cmb_Searchby_Year.MaxLength = 10;
            this.cmb_Searchby_Year.Name = "cmb_Searchby_Year";
            this.cmb_Searchby_Year.Size = new System.Drawing.Size(260, 34);
            this.cmb_Searchby_Year.TabIndex = 2;
            this.cmb_Searchby_Year.SelectedIndexChanged += new System.EventHandler(this.cmb_Searchby_Year_SelectedIndexChanged);
            // 
            // cmb_Searchby_Month
            // 
            this.cmb_Searchby_Month.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Searchby_Month.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.cmb_Searchby_Month.FormattingEnabled = true;
            this.cmb_Searchby_Month.Items.AddRange(new object[] {
            "January",
            "February",
            "March\t",
            "April",
            "May",
            "June",
            "July",
            "August",
            "Septmber",
            "Octomber",
            "November",
            "December"});
            this.cmb_Searchby_Month.Location = new System.Drawing.Point(338, 62);
            this.cmb_Searchby_Month.MaxLength = 10;
            this.cmb_Searchby_Month.Name = "cmb_Searchby_Month";
            this.cmb_Searchby_Month.Size = new System.Drawing.Size(260, 34);
            this.cmb_Searchby_Month.TabIndex = 1;
            this.cmb_Searchby_Month.SelectedIndexChanged += new System.EventHandler(this.cmb_Searchby_Month_SelectedIndexChanged);
            // 
            // lbl_Search_Expence
            // 
            this.lbl_Search_Expence.AutoSize = true;
            this.lbl_Search_Expence.Font = new System.Drawing.Font("Palatino Linotype", 17F);
            this.lbl_Search_Expence.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Search_Expence.Location = new System.Drawing.Point(46, 56);
            this.lbl_Search_Expence.Name = "lbl_Search_Expence";
            this.lbl_Search_Expence.Size = new System.Drawing.Size(217, 38);
            this.lbl_Search_Expence.TabIndex = 0;
            this.lbl_Search_Expence.Text = "Search Expence";
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.Blue;
            this.btn_Refresh.Font = new System.Drawing.Font("Times New Roman", 22F);
            this.btn_Refresh.ForeColor = System.Drawing.Color.White;
            this.btn_Refresh.Location = new System.Drawing.Point(550, 743);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(213, 67);
            this.btn_Refresh.TabIndex = 5;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // dgv_Expence_Details
            // 
            this.dgv_Expence_Details.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Expence_Details.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Expence_Details.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Expence_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Expence_Details.Location = new System.Drawing.Point(60, 234);
            this.dgv_Expence_Details.Name = "dgv_Expence_Details";
            this.dgv_Expence_Details.RowHeadersWidth = 51;
            this.dgv_Expence_Details.RowTemplate.Height = 24;
            this.dgv_Expence_Details.Size = new System.Drawing.Size(1280, 485);
            this.dgv_Expence_Details.TabIndex = 4;
            // 
            // frm_View_Expence_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1400, 860);
            this.ControlBox = false;
            this.Controls.Add(this.gb_Search_Expence);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.dgv_Expence_Details);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_View_Expence_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "View Expence List";
            this.Load += new System.EventHandler(this.frm_View_Expence_Details_Load);
            this.gb_Search_Expence.ResumeLayout(false);
            this.gb_Search_Expence.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Expence_Details)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Search_Expence;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.ComboBox cmb_Searchby_Year;
        private System.Windows.Forms.ComboBox cmb_Searchby_Month;
        private System.Windows.Forms.Label lbl_Search_Expence;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.DataGridView dgv_Expence_Details;
    }
}