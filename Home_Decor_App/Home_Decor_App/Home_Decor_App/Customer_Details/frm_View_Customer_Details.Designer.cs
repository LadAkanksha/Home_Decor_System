
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
            this.dgv_Customer_Details = new System.Windows.Forms.DataGridView();
            this.lbl_Year = new System.Windows.Forms.Label();
            this.lbl_Month = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.cmb_Searchby_Year = new System.Windows.Forms.ComboBox();
            this.cmb_Searchby_Month = new System.Windows.Forms.ComboBox();
            this.lbl_Search_Customer_Bill = new System.Windows.Forms.Label();
            this.gb_Search_Customer_Details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Customer_Details)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_Search_Customer_Details
            // 
            this.gb_Search_Customer_Details.BackColor = System.Drawing.Color.LightCyan;
            this.gb_Search_Customer_Details.Controls.Add(this.dgv_Customer_Details);
            this.gb_Search_Customer_Details.Controls.Add(this.lbl_Year);
            this.gb_Search_Customer_Details.Controls.Add(this.lbl_Month);
            this.gb_Search_Customer_Details.Controls.Add(this.btn_Search);
            this.gb_Search_Customer_Details.Controls.Add(this.cmb_Searchby_Year);
            this.gb_Search_Customer_Details.Controls.Add(this.cmb_Searchby_Month);
            this.gb_Search_Customer_Details.Controls.Add(this.lbl_Search_Customer_Bill);
            this.gb_Search_Customer_Details.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.gb_Search_Customer_Details.ForeColor = System.Drawing.Color.Crimson;
            this.gb_Search_Customer_Details.Location = new System.Drawing.Point(36, 84);
            this.gb_Search_Customer_Details.Name = "gb_Search_Customer_Details";
            this.gb_Search_Customer_Details.Size = new System.Drawing.Size(1209, 693);
            this.gb_Search_Customer_Details.TabIndex = 2;
            this.gb_Search_Customer_Details.TabStop = false;
            this.gb_Search_Customer_Details.Text = "Search Customer";
            // 
            // dgv_Customer_Details
            // 
            this.dgv_Customer_Details.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgv_Customer_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Customer_Details.Location = new System.Drawing.Point(42, 135);
            this.dgv_Customer_Details.Name = "dgv_Customer_Details";
            this.dgv_Customer_Details.RowHeadersWidth = 51;
            this.dgv_Customer_Details.RowTemplate.Height = 24;
            this.dgv_Customer_Details.Size = new System.Drawing.Size(1132, 526);
            this.dgv_Customer_Details.TabIndex = 4;
            // 
            // lbl_Year
            // 
            this.lbl_Year.AutoSize = true;
            this.lbl_Year.Font = new System.Drawing.Font("Palatino Linotype", 16F);
            this.lbl_Year.ForeColor = System.Drawing.Color.DeepPink;
            this.lbl_Year.Location = new System.Drawing.Point(728, 29);
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
            this.lbl_Month.Location = new System.Drawing.Point(461, 29);
            this.lbl_Month.Name = "lbl_Month";
            this.lbl_Month.Size = new System.Drawing.Size(93, 36);
            this.lbl_Month.TabIndex = 21;
            this.lbl_Month.Text = "Month";
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.Blue;
            this.btn_Search.Font = new System.Drawing.Font("Times New Roman", 22F);
            this.btn_Search.ForeColor = System.Drawing.Color.White;
            this.btn_Search.Location = new System.Drawing.Point(988, 48);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(186, 55);
            this.btn_Search.TabIndex = 3;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            // 
            // cmb_Searchby_Year
            // 
            this.cmb_Searchby_Year.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.cmb_Searchby_Year.FormattingEnabled = true;
            this.cmb_Searchby_Year.Location = new System.Drawing.Point(674, 78);
            this.cmb_Searchby_Year.MaxLength = 10;
            this.cmb_Searchby_Year.Name = "cmb_Searchby_Year";
            this.cmb_Searchby_Year.Size = new System.Drawing.Size(211, 34);
            this.cmb_Searchby_Year.TabIndex = 2;
            // 
            // cmb_Searchby_Month
            // 
            this.cmb_Searchby_Month.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.cmb_Searchby_Month.FormattingEnabled = true;
            this.cmb_Searchby_Month.Location = new System.Drawing.Point(408, 78);
            this.cmb_Searchby_Month.MaxLength = 10;
            this.cmb_Searchby_Month.Name = "cmb_Searchby_Month";
            this.cmb_Searchby_Month.Size = new System.Drawing.Size(203, 34);
            this.cmb_Searchby_Month.TabIndex = 1;
            // 
            // lbl_Search_Customer_Bill
            // 
            this.lbl_Search_Customer_Bill.AutoSize = true;
            this.lbl_Search_Customer_Bill.Font = new System.Drawing.Font("Palatino Linotype", 17F);
            this.lbl_Search_Customer_Bill.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Search_Customer_Bill.Location = new System.Drawing.Point(46, 58);
            this.lbl_Search_Customer_Bill.Name = "lbl_Search_Customer_Bill";
            this.lbl_Search_Customer_Bill.Size = new System.Drawing.Size(286, 38);
            this.lbl_Search_Customer_Bill.TabIndex = 0;
            this.lbl_Search_Customer_Bill.Text = "Search Customer Bill";
            // 
            // frm_View_Customer_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1280, 860);
            this.ControlBox = false;
            this.Controls.Add(this.gb_Search_Customer_Details);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_View_Customer_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "View Customer Details";
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
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.ComboBox cmb_Searchby_Year;
        private System.Windows.Forms.ComboBox cmb_Searchby_Month;
        private System.Windows.Forms.Label lbl_Search_Customer_Bill;
    }
}