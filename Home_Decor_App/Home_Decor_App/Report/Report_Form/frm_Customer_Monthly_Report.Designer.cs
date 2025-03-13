
namespace Home_Decor_App.Report.Report_Form
{
    partial class frm_Customer_Monthly_Report
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
            this.crv_Customer_Monthly_Report = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btn_Search = new System.Windows.Forms.Button();
            this.cmb_Month = new System.Windows.Forms.ComboBox();
            this.cmb_Year = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // crv_Customer_Monthly_Report
            // 
            this.crv_Customer_Monthly_Report.ActiveViewIndex = -1;
            this.crv_Customer_Monthly_Report.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv_Customer_Monthly_Report.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv_Customer_Monthly_Report.DisplayStatusBar = false;
            this.crv_Customer_Monthly_Report.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.crv_Customer_Monthly_Report.Location = new System.Drawing.Point(0, 66);
            this.crv_Customer_Monthly_Report.Name = "crv_Customer_Monthly_Report";
            this.crv_Customer_Monthly_Report.Size = new System.Drawing.Size(1382, 747);
            this.crv_Customer_Monthly_Report.TabIndex = 4;
            this.crv_Customer_Monthly_Report.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.Teal;
            this.btn_Search.Font = new System.Drawing.Font("Sylfaen", 18F, System.Drawing.FontStyle.Bold);
            this.btn_Search.ForeColor = System.Drawing.Color.Cornsilk;
            this.btn_Search.Location = new System.Drawing.Point(1087, 6);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(140, 54);
            this.btn_Search.TabIndex = 5;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // cmb_Month
            // 
            this.cmb_Month.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Month.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Bold);
            this.cmb_Month.FormattingEnabled = true;
            this.cmb_Month.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "Septmber",
            "Octomber",
            "November",
            "December"});
            this.cmb_Month.Location = new System.Drawing.Point(374, 12);
            this.cmb_Month.Name = "cmb_Month";
            this.cmb_Month.Size = new System.Drawing.Size(233, 39);
            this.cmb_Month.TabIndex = 1;
            this.cmb_Month.SelectedIndexChanged += new System.EventHandler(this.cmb_Month_SelectedIndexChanged);
            // 
            // cmb_Year
            // 
            this.cmb_Year.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Year.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Bold);
            this.cmb_Year.FormattingEnabled = true;
            this.cmb_Year.Items.AddRange(new object[] {
            "2023",
            "2024",
            "2025",
            "2026"});
            this.cmb_Year.Location = new System.Drawing.Point(801, 12);
            this.cmb_Year.Name = "cmb_Year";
            this.cmb_Year.Size = new System.Drawing.Size(233, 39);
            this.cmb_Year.TabIndex = 2;
            this.cmb_Year.SelectedIndexChanged += new System.EventHandler(this.cmb_Year_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(263, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Month";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(721, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "Year";
            // 
            // frm_Customer_Monthly_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 813);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_Year);
            this.Controls.Add(this.cmb_Month);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.crv_Customer_Monthly_Report);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Customer_Monthly_Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Monthly Report";
            this.Load += new System.EventHandler(this.frm_Customer_Monthly_Report_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv_Customer_Monthly_Report;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.ComboBox cmb_Month;
        private System.Windows.Forms.ComboBox cmb_Year;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}