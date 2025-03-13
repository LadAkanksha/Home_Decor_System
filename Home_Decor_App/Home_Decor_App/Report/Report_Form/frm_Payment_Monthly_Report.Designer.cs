
namespace Home_Decor_App.Report.Report_Form
{
    partial class frm_Payment_Monthly_Report
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
            this.crv_Payment_Monthly_Report = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.cmb_Year = new System.Windows.Forms.ComboBox();
            this.cmb_Month = new System.Windows.Forms.ComboBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.lbl_Month = new System.Windows.Forms.Label();
            this.lbl_Year = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // crv_Payment_Monthly_Report
            // 
            this.crv_Payment_Monthly_Report.ActiveViewIndex = -1;
            this.crv_Payment_Monthly_Report.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv_Payment_Monthly_Report.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv_Payment_Monthly_Report.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.crv_Payment_Monthly_Report.Location = new System.Drawing.Point(0, 79);
            this.crv_Payment_Monthly_Report.Name = "crv_Payment_Monthly_Report";
            this.crv_Payment_Monthly_Report.Size = new System.Drawing.Size(1382, 734);
            this.crv_Payment_Monthly_Report.TabIndex = 0;
            this.crv_Payment_Monthly_Report.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
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
            this.cmb_Year.Location = new System.Drawing.Point(739, 23);
            this.cmb_Year.Name = "cmb_Year";
            this.cmb_Year.Size = new System.Drawing.Size(233, 39);
            this.cmb_Year.TabIndex = 7;
            this.cmb_Year.SelectedIndexChanged += new System.EventHandler(this.cmb_Year_SelectedIndexChanged);
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
            this.cmb_Month.Location = new System.Drawing.Point(322, 23);
            this.cmb_Month.Name = "cmb_Month";
            this.cmb_Month.Size = new System.Drawing.Size(233, 39);
            this.cmb_Month.TabIndex = 6;
            this.cmb_Month.SelectedIndexChanged += new System.EventHandler(this.cmb_Month_SelectedIndexChanged);
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.Teal;
            this.btn_Search.Font = new System.Drawing.Font("Sylfaen", 20F, System.Drawing.FontStyle.Bold);
            this.btn_Search.ForeColor = System.Drawing.Color.Cornsilk;
            this.btn_Search.Location = new System.Drawing.Point(1082, 3);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(183, 70);
            this.btn_Search.TabIndex = 8;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // lbl_Month
            // 
            this.lbl_Month.AutoSize = true;
            this.lbl_Month.BackColor = System.Drawing.Color.LightCyan;
            this.lbl_Month.Font = new System.Drawing.Font("Palatino Linotype", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Month.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_Month.Location = new System.Drawing.Point(214, 24);
            this.lbl_Month.Name = "lbl_Month";
            this.lbl_Month.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_Month.Size = new System.Drawing.Size(102, 34);
            this.lbl_Month.TabIndex = 9;
            this.lbl_Month.Text = "Month";
            // 
            // lbl_Year
            // 
            this.lbl_Year.AutoSize = true;
            this.lbl_Year.BackColor = System.Drawing.Color.LightCyan;
            this.lbl_Year.Font = new System.Drawing.Font("Palatino Linotype", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Year.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_Year.Location = new System.Drawing.Point(658, 24);
            this.lbl_Year.Name = "lbl_Year";
            this.lbl_Year.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_Year.Size = new System.Drawing.Size(75, 34);
            this.lbl_Year.TabIndex = 10;
            this.lbl_Year.Text = "Year";
            // 
            // frm_Payment_Monthly_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 813);
            this.Controls.Add(this.lbl_Year);
            this.Controls.Add(this.lbl_Month);
            this.Controls.Add(this.cmb_Year);
            this.Controls.Add(this.cmb_Month);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.crv_Payment_Monthly_Report);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Payment_Monthly_Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monthly Payment Report";
            this.Load += new System.EventHandler(this.frm_Payment_Monthly_Report_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv_Payment_Monthly_Report;
        private System.Windows.Forms.ComboBox cmb_Year;
        private System.Windows.Forms.ComboBox cmb_Month;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label lbl_Month;
        private System.Windows.Forms.Label lbl_Year;
    }
}