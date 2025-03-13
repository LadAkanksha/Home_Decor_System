
namespace Home_Decor_App.Report.Report_Form
{
    partial class frm_Receive_Order_Report
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
            this.crv_Receive_Order_Report = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crv_Receive_Order_Report
            // 
            this.crv_Receive_Order_Report.ActiveViewIndex = -1;
            this.crv_Receive_Order_Report.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv_Receive_Order_Report.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv_Receive_Order_Report.DisplayStatusBar = false;
            this.crv_Receive_Order_Report.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crv_Receive_Order_Report.Location = new System.Drawing.Point(0, 0);
            this.crv_Receive_Order_Report.Name = "crv_Receive_Order_Report";
            this.crv_Receive_Order_Report.Size = new System.Drawing.Size(1382, 813);
            this.crv_Receive_Order_Report.TabIndex = 0;
            this.crv_Receive_Order_Report.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frm_Receive_Order_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 813);
            this.Controls.Add(this.crv_Receive_Order_Report);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Receive_Order_Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Receive_Order_Report";
            this.Load += new System.EventHandler(this.frm_Receive_Order_Report_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv_Receive_Order_Report;
    }
}