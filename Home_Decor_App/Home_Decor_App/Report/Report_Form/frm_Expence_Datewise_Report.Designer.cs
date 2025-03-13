
namespace Home_Decor_App.Report.Report_Form
{
    partial class frm_Expence_Datewise_Report
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
            this.crv_Expence_Datewise_Report = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.dtp_FDate = new System.Windows.Forms.DateTimePicker();
            this.dtp_Tdate = new System.Windows.Forms.DateTimePicker();
            this.lbl_FDate = new System.Windows.Forms.Label();
            this.lbl_TDate = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crv_Expence_Datewise_Report
            // 
            this.crv_Expence_Datewise_Report.ActiveViewIndex = -1;
            this.crv_Expence_Datewise_Report.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv_Expence_Datewise_Report.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv_Expence_Datewise_Report.DisplayStatusBar = false;
            this.crv_Expence_Datewise_Report.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.crv_Expence_Datewise_Report.Location = new System.Drawing.Point(0, 61);
            this.crv_Expence_Datewise_Report.Name = "crv_Expence_Datewise_Report";
            this.crv_Expence_Datewise_Report.Size = new System.Drawing.Size(1382, 752);
            this.crv_Expence_Datewise_Report.TabIndex = 0;
            this.crv_Expence_Datewise_Report.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // dtp_FDate
            // 
            this.dtp_FDate.Font = new System.Drawing.Font("Rockwell", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_FDate.Location = new System.Drawing.Point(201, 12);
            this.dtp_FDate.Name = "dtp_FDate";
            this.dtp_FDate.Size = new System.Drawing.Size(248, 33);
            this.dtp_FDate.TabIndex = 1;
            // 
            // dtp_Tdate
            // 
            this.dtp_Tdate.Font = new System.Drawing.Font("Rockwell", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Tdate.Location = new System.Drawing.Point(664, 12);
            this.dtp_Tdate.Name = "dtp_Tdate";
            this.dtp_Tdate.Size = new System.Drawing.Size(248, 33);
            this.dtp_Tdate.TabIndex = 2;
            // 
            // lbl_FDate
            // 
            this.lbl_FDate.AutoSize = true;
            this.lbl_FDate.BackColor = System.Drawing.Color.MintCream;
            this.lbl_FDate.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FDate.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_FDate.Location = new System.Drawing.Point(51, 14);
            this.lbl_FDate.Name = "lbl_FDate";
            this.lbl_FDate.Size = new System.Drawing.Size(129, 32);
            this.lbl_FDate.TabIndex = 3;
            this.lbl_FDate.Text = "From Date";
            // 
            // lbl_TDate
            // 
            this.lbl_TDate.AutoSize = true;
            this.lbl_TDate.BackColor = System.Drawing.Color.MintCream;
            this.lbl_TDate.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TDate.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_TDate.Location = new System.Drawing.Point(538, 13);
            this.lbl_TDate.Name = "lbl_TDate";
            this.lbl_TDate.Size = new System.Drawing.Size(102, 32);
            this.lbl_TDate.TabIndex = 4;
            this.lbl_TDate.Text = "To Date";
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Search.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.btn_Search.ForeColor = System.Drawing.Color.White;
            this.btn_Search.Location = new System.Drawing.Point(978, 1);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(129, 54);
            this.btn_Search.TabIndex = 5;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // frm_Expence_Datewise_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 813);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.lbl_TDate);
            this.Controls.Add(this.lbl_FDate);
            this.Controls.Add(this.dtp_Tdate);
            this.Controls.Add(this.dtp_FDate);
            this.Controls.Add(this.crv_Expence_Datewise_Report);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Expence_Datewise_Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expence Report";
            this.Load += new System.EventHandler(this.frm_Expence_Datewise_Report_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv_Expence_Datewise_Report;
        private System.Windows.Forms.DateTimePicker dtp_FDate;
        private System.Windows.Forms.DateTimePicker dtp_Tdate;
        private System.Windows.Forms.Label lbl_FDate;
        private System.Windows.Forms.Label lbl_TDate;
        private System.Windows.Forms.Button btn_Search;
    }
}