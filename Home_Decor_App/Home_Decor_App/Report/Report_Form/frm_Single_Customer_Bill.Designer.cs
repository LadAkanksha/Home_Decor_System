
namespace Home_Decor_App.Report.Report_Form
{
    partial class frm_Single_Customer_Bill
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
            this.crv_Single_Customer_Bill = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crv_Single_Customer_Bill
            // 
            this.crv_Single_Customer_Bill.ActiveViewIndex = -1;
            this.crv_Single_Customer_Bill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv_Single_Customer_Bill.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv_Single_Customer_Bill.DisplayStatusBar = false;
            this.crv_Single_Customer_Bill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crv_Single_Customer_Bill.Location = new System.Drawing.Point(0, 0);
            this.crv_Single_Customer_Bill.Name = "crv_Single_Customer_Bill";
            this.crv_Single_Customer_Bill.Size = new System.Drawing.Size(1244, 813);
            this.crv_Single_Customer_Bill.TabIndex = 0;
            this.crv_Single_Customer_Bill.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frm_Single_Customer_Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 813);
            this.Controls.Add(this.crv_Single_Customer_Bill);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Single_Customer_Bill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Customer Bill Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Single_Customer_Bill_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv_Single_Customer_Bill;
    }
}