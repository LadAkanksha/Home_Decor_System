
namespace Home_Decor_App.Customer_Details
{
    partial class frm_View_Customer_Details
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
            this.gb_Search_Customer_Details = new System.Windows.Forms.GroupBox();
            this.lbl_Year = new System.Windows.Forms.Label();
            this.lbl_Month = new System.Windows.Forms.Label();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.cmb_Searchby_Year = new System.Windows.Forms.ComboBox();
            this.cmb_Searchby_Month = new System.Windows.Forms.ComboBox();
            this.lbl_Search_Customer_Bill = new System.Windows.Forms.Label();
            this.dgv_Customer_Details = new System.Windows.Forms.DataGridView();
            this.gb_Search_Customer_Details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Customer_Details)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_Search_Customer_Details
            // 
            this.gb_Search_Customer_Details.BackColor = System.Drawing.Color.LightCyan;
            this.gb_Search_Customer_Details.Controls.Add(this.lbl_Year);
            this.gb_Search_Customer_Details.Controls.Add(this.lbl_Month);
            this.gb_Search_Customer_Details.Controls.Add(this.btn_Refresh);
            this.gb_Search_Customer_Details.Controls.Add(this.cmb_Searchby_Year);
            this.gb_Search_Customer_Details.Controls.Add(this.cmb_Searchby_Month);
            this.gb_Search_Customer_Details.Controls.Add(this.lbl_Search_Customer_Bill);
            this.gb_Search_Customer_Details.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.gb_Search_Customer_Details.ForeColor = System.Drawing.Color.Crimson;
            this.gb_Search_Customer_Details.Location = new System.Drawing.Point(61, 56);
            this.gb_Search_Customer_Details.Name = "gb_Search_Customer_Details";
            this.gb_Search_Customer_Details.Size = new System.Drawing.Size(1280, 143);
            this.gb_Search_Customer_Details.TabIndex = 2;
            this.gb_Search_Customer_Details.TabStop = false;
            this.gb_Search_Customer_Details.Text = "Search Customer";
            // 
            // lbl_Year
            // 
            this.lbl_Year.AutoSize = true;
            this.lbl_Year.Font = new System.Drawing.Font("Palatino Linotype", 16F);
            this.lbl_Year.ForeColor = System.Drawing.Color.DeepPink;
            this.lbl_Year.Location = new System.Drawing.Point(767, 29);
            this.lbl_Year.Name = "lbl_Year";
            this.lbl_Year.Size = new System.Drawing.Size(66, 36);
            this.lbl_Year.TabIndex = 22;
            this.lbl_Year.Text = "Year";
            // 
            // lbl_Month
            // 
            this.lbl_Month.AutoSize = true;
            this.lbl_Month.Font = new System.Drawing.Font("Palatino Linotype", 16F);
            this.lbl_Month.ForeColor = System.Drawing.Color.DeepPink;
            this.lbl_Month.Location = new System.Drawing.Point(487, 29);
            this.lbl_Month.Name = "lbl_Month";
            this.lbl_Month.Size = new System.Drawing.Size(93, 36);
            this.lbl_Month.TabIndex = 21;
            this.lbl_Month.Text = "Month";
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.LightPink;
            this.btn_Refresh.Font = new System.Drawing.Font("Times New Roman", 22F);
            this.btn_Refresh.ForeColor = System.Drawing.Color.DarkGreen;
            this.btn_Refresh.Location = new System.Drawing.Point(1025, 52);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(186, 74);
            this.btn_Refresh.TabIndex = 3;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // cmb_Searchby_Year
            // 
            this.cmb_Searchby_Year.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Searchby_Year.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.cmb_Searchby_Year.FormattingEnabled = true;
            this.cmb_Searchby_Year.Items.AddRange(new object[] {
            "2024",
            "2025",
            "2026",
            "2027"});
            this.cmb_Searchby_Year.Location = new System.Drawing.Point(713, 78);
            this.cmb_Searchby_Year.MaxLength = 10;
            this.cmb_Searchby_Year.Name = "cmb_Searchby_Year";
            this.cmb_Searchby_Year.Size = new System.Drawing.Size(211, 34);
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
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cmb_Searchby_Month.Location = new System.Drawing.Point(434, 78);
            this.cmb_Searchby_Month.MaxLength = 10;
            this.cmb_Searchby_Month.Name = "cmb_Searchby_Month";
            this.cmb_Searchby_Month.Size = new System.Drawing.Size(203, 34);
            this.cmb_Searchby_Month.TabIndex = 1;
            this.cmb_Searchby_Month.SelectedIndexChanged += new System.EventHandler(this.cmb_Searchby_Month_SelectedIndexChanged);
            // 
            // lbl_Search_Customer_Bill
            // 
            this.lbl_Search_Customer_Bill.AutoSize = true;
            this.lbl_Search_Customer_Bill.Font = new System.Drawing.Font("Palatino Linotype", 17F);
            this.lbl_Search_Customer_Bill.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Search_Customer_Bill.Location = new System.Drawing.Point(46, 56);
            this.lbl_Search_Customer_Bill.Name = "lbl_Search_Customer_Bill";
            this.lbl_Search_Customer_Bill.Size = new System.Drawing.Size(286, 38);
            this.lbl_Search_Customer_Bill.TabIndex = 0;
            this.lbl_Search_Customer_Bill.Text = "Search Customer Bill";
            // 
            // dgv_Customer_Details
            // 
            this.dgv_Customer_Details.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgv_Customer_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Customer_Details.Location = new System.Drawing.Point(61, 221);
            this.dgv_Customer_Details.Name = "dgv_Customer_Details";
            this.dgv_Customer_Details.RowHeadersWidth = 51;
            this.dgv_Customer_Details.RowTemplate.Height = 24;
            this.dgv_Customer_Details.Size = new System.Drawing.Size(1280, 505);
            this.dgv_Customer_Details.TabIndex = 4;
            this.dgv_Customer_Details.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Customer_Details_CellContentDoubleClick);
            // 
            // frm_View_Customer_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1400, 860);
            this.ControlBox = false;
            this.Controls.Add(this.dgv_Customer_Details);
            this.Controls.Add(this.gb_Search_Customer_Details);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_View_Customer_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "View Customer Details";
            this.Load += new System.EventHandler(this.frm_View_Customer_Details_Load);
            this.gb_Search_Customer_Details.ResumeLayout(false);
            this.gb_Search_Customer_Details.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Customer_Details)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Search_Customer_Details;
        private System.Windows.Forms.DataGridView dgv_Customer_Details;
        private System.Windows.Forms.Label lbl_Year;
        private System.Windows.Forms.Label lbl_Month;
        private System.Windows.Forms.ComboBox cmb_Searchby_Year;
        private System.Windows.Forms.ComboBox cmb_Searchby_Month;
        private System.Windows.Forms.Label lbl_Search_Customer_Bill;
        private System.Windows.Forms.Button btn_Refresh;
    }
}