
namespace Home_Decor_App.Employee_Details
{
    partial class frm_View_Employee_Details
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_Employee_Details = new System.Windows.Forms.DataGridView();
            this.lbl_Post = new System.Windows.Forms.Label();
            this.cmb_Post = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Employee_Details)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Employee_Details
            // 
            this.dgv_Employee_Details.BackgroundColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Employee_Details.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Employee_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Employee_Details.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Employee_Details.Location = new System.Drawing.Point(12, 190);
            this.dgv_Employee_Details.Name = "dgv_Employee_Details";
            this.dgv_Employee_Details.RowHeadersWidth = 51;
            this.dgv_Employee_Details.RowTemplate.Height = 24;
            this.dgv_Employee_Details.Size = new System.Drawing.Size(1376, 582);
            this.dgv_Employee_Details.TabIndex = 1;
            // 
            // lbl_Post
            // 
            this.lbl_Post.AutoSize = true;
            this.lbl_Post.BackColor = System.Drawing.Color.LightPink;
            this.lbl_Post.Font = new System.Drawing.Font("Palatino Linotype", 17F, System.Drawing.FontStyle.Bold);
            this.lbl_Post.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lbl_Post.Location = new System.Drawing.Point(374, 81);
            this.lbl_Post.Name = "lbl_Post";
            this.lbl_Post.Padding = new System.Windows.Forms.Padding(5);
            this.lbl_Post.Size = new System.Drawing.Size(189, 49);
            this.lbl_Post.TabIndex = 0;
            this.lbl_Post.Text = "Designation";
            // 
            // cmb_Post
            // 
            this.cmb_Post.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Post.Font = new System.Drawing.Font("Times New Roman", 20F);
            this.cmb_Post.FormattingEnabled = true;
            this.cmb_Post.Location = new System.Drawing.Point(606, 81);
            this.cmb_Post.MaxLength = 10;
            this.cmb_Post.Name = "cmb_Post";
            this.cmb_Post.Size = new System.Drawing.Size(267, 45);
            this.cmb_Post.TabIndex = 1;
            this.cmb_Post.SelectedIndexChanged += new System.EventHandler(this.cmb_Post_SelectedIndexChanged);
            // 
            // frm_View_Employee_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1400, 860);
            this.ControlBox = false;
            this.Controls.Add(this.dgv_Employee_Details);
            this.Controls.Add(this.cmb_Post);
            this.Controls.Add(this.lbl_Post);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_View_Employee_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "View Employee Details";
            this.Load += new System.EventHandler(this.frm_View_Employee_Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Employee_Details)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Employee_Details;
        private System.Windows.Forms.Label lbl_Post;
        private System.Windows.Forms.ComboBox cmb_Post;
    }
}