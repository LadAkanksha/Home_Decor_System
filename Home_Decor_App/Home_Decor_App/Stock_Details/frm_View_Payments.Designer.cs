
namespace Home_Decor_App.Stock_Details
{
    partial class frm_View_Payments
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
            this.gb_Search_Payment_Details = new System.Windows.Forms.GroupBox();
            this.lbl_Year = new System.Windows.Forms.Label();
            this.lbl_Month = new System.Windows.Forms.Label();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.cmb_Searchby_Year = new System.Windows.Forms.ComboBox();
            this.cmb_Searchby_Month = new System.Windows.Forms.ComboBox();
            this.lbl_Search_Payments = new System.Windows.Forms.Label();
            this.dgv_Payment_Details = new System.Windows.Forms.DataGridView();
            this.gb_Search_Payment_Details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Payment_Details)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_Search_Payment_Details
            // 
            this.gb_Search_Payment_Details.BackColor = System.Drawing.Color.LightCyan;
            this.gb_Search_Payment_Details.Controls.Add(this.lbl_Year);
            this.gb_Search_Payment_Details.Controls.Add(this.lbl_Month);
            this.gb_Search_Payment_Details.Controls.Add(this.btn_Refresh);
            this.gb_Search_Payment_Details.Controls.Add(this.cmb_Searchby_Year);
            this.gb_Search_Payment_Details.Controls.Add(this.cmb_Searchby_Month);
            this.gb_Search_Payment_Details.Controls.Add(this.lbl_Search_Payments);
            this.gb_Search_Payment_Details.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.gb_Search_Payment_Details.ForeColor = System.Drawing.Color.Crimson;
            this.gb_Search_Payment_Details.Location = new System.Drawing.Point(61, 56);
            this.gb_Search_Payment_Details.Name = "gb_Search_Payment_Details";
            this.gb_Search_Payment_Details.Size = new System.Drawing.Size(1280, 143);
            this.gb_Search_Payment_Details.TabIndex = 5;
            this.gb_Search_Payment_Details.TabStop = false;
            this.gb_Search_Payment_Details.Text = "Search Payments";
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
            this.btn_Refresh.Location = new System.Drawing.Point(1019, 41);
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
            // lbl_Search_Payments
            // 
            this.lbl_Search_Payments.AutoSize = true;
            this.lbl_Search_Payments.Font = new System.Drawing.Font("Palatino Linotype", 17F);
            this.lbl_Search_Payments.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Search_Payments.Location = new System.Drawing.Point(46, 56);
            this.lbl_Search_Payments.Name = "lbl_Search_Payments";
            this.lbl_Search_Payments.Size = new System.Drawing.Size(321, 38);
            this.lbl_Search_Payments.TabIndex = 0;
            this.lbl_Search_Payments.Text = "Search Payment Details";
            // 
            // dgv_Payment_Details
            // 
            this.dgv_Payment_Details.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Payment_Details.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgv_Payment_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Payment_Details.Location = new System.Drawing.Point(61, 216);
            this.dgv_Payment_Details.Name = "dgv_Payment_Details";
            this.dgv_Payment_Details.RowHeadersWidth = 51;
            this.dgv_Payment_Details.RowTemplate.Height = 24;
            this.dgv_Payment_Details.Size = new System.Drawing.Size(1280, 548);
            this.dgv_Payment_Details.TabIndex = 6;
            // 
            // frm_View_Payments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1400, 860);
            this.ControlBox = false;
            this.Controls.Add(this.gb_Search_Payment_Details);
            this.Controls.Add(this.dgv_Payment_Details);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_View_Payments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frm_View_Payments";
            this.Load += new System.EventHandler(this.frm_View_Payments_Load);
            this.gb_Search_Payment_Details.ResumeLayout(false);
            this.gb_Search_Payment_Details.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Payment_Details)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Search_Payment_Details;
        private System.Windows.Forms.Label lbl_Year;
        private System.Windows.Forms.Label lbl_Month;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.ComboBox cmb_Searchby_Year;
        private System.Windows.Forms.ComboBox cmb_Searchby_Month;
        private System.Windows.Forms.Label lbl_Search_Payments;
        private System.Windows.Forms.DataGridView dgv_Payment_Details;
    }
}