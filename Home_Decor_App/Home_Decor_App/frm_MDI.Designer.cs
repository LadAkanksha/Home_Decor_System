
namespace Home_Decor_App
{
    partial class frm_MDI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_MDI));
            this.ms_Menu = new System.Windows.Forms.MenuStrip();
            this.MI_Customer = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_Product = new System.Windows.Forms.ToolStripMenuItem();
            this.mattressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pillowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewListToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cushionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewListToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.curtainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewListToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_Stock = new System.Windows.Forms.ToolStripMenuItem();
            this.receivedOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewPaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_Supplier = new System.Windows.Forms.ToolStripMenuItem();
            this.addSupplierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateSupplierDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewSupplierDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_Employee = new System.Windows.Forms.ToolStripMenuItem();
            this.addEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_Expence = new System.Windows.Forms.ToolStripMenuItem();
            this.addExpenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewExpensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_Management = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteViewUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_Report = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_Login_User = new System.Windows.Forms.Label();
            this.ms_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ms_Menu
            // 
            this.ms_Menu.BackColor = System.Drawing.Color.Gold;
            this.ms_Menu.Font = new System.Drawing.Font("Palatino Linotype", 14F);
            this.ms_Menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ms_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MI_Customer,
            this.MI_Product,
            this.MI_Stock,
            this.MI_Supplier,
            this.MI_Employee,
            this.MI_Expence,
            this.MI_Management,
            this.MI_Report});
            this.ms_Menu.Location = new System.Drawing.Point(0, 0);
            this.ms_Menu.Name = "ms_Menu";
            this.ms_Menu.Size = new System.Drawing.Size(1387, 40);
            this.ms_Menu.TabIndex = 0;
            this.ms_Menu.Text = "Menu Strip";
            // 
            // MI_Customer
            // 
            this.MI_Customer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewCustomerToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.MI_Customer.Name = "MI_Customer";
            this.MI_Customer.Size = new System.Drawing.Size(132, 36);
            this.MI_Customer.Text = "Customer";
            // 
            // addNewCustomerToolStripMenuItem
            // 
            this.addNewCustomerToolStripMenuItem.Name = "addNewCustomerToolStripMenuItem";
            this.addNewCustomerToolStripMenuItem.Size = new System.Drawing.Size(317, 36);
            this.addNewCustomerToolStripMenuItem.Text = "Add New Customer";
            this.addNewCustomerToolStripMenuItem.Click += new System.EventHandler(this.addNewCustomerToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(317, 36);
            this.viewToolStripMenuItem.Text = "Customer List";
            this.viewToolStripMenuItem.Click += new System.EventHandler(this.viewToolStripMenuItem_Click);
            // 
            // MI_Product
            // 
            this.MI_Product.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mattressToolStripMenuItem,
            this.pillowToolStripMenuItem,
            this.cushionToolStripMenuItem,
            this.curtainToolStripMenuItem});
            this.MI_Product.Name = "MI_Product";
            this.MI_Product.Size = new System.Drawing.Size(113, 36);
            this.MI_Product.Text = "Product";
            // 
            // mattressToolStripMenuItem
            // 
            this.mattressToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.viewListToolStripMenuItem});
            this.mattressToolStripMenuItem.Name = "mattressToolStripMenuItem";
            this.mattressToolStripMenuItem.Size = new System.Drawing.Size(195, 36);
            this.mattressToolStripMenuItem.Text = "Mattress";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(202, 36);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(202, 36);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // viewListToolStripMenuItem
            // 
            this.viewListToolStripMenuItem.Name = "viewListToolStripMenuItem";
            this.viewListToolStripMenuItem.Size = new System.Drawing.Size(202, 36);
            this.viewListToolStripMenuItem.Text = "View List";
            this.viewListToolStripMenuItem.Click += new System.EventHandler(this.viewListToolStripMenuItem_Click);
            // 
            // pillowToolStripMenuItem
            // 
            this.pillowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem1,
            this.updateToolStripMenuItem1,
            this.viewListToolStripMenuItem1});
            this.pillowToolStripMenuItem.Name = "pillowToolStripMenuItem";
            this.pillowToolStripMenuItem.Size = new System.Drawing.Size(195, 36);
            this.pillowToolStripMenuItem.Text = "Pillow";
            // 
            // addToolStripMenuItem1
            // 
            this.addToolStripMenuItem1.Name = "addToolStripMenuItem1";
            this.addToolStripMenuItem1.Size = new System.Drawing.Size(202, 36);
            this.addToolStripMenuItem1.Text = "Add ";
            this.addToolStripMenuItem1.Click += new System.EventHandler(this.addToolStripMenuItem1_Click);
            // 
            // updateToolStripMenuItem1
            // 
            this.updateToolStripMenuItem1.Name = "updateToolStripMenuItem1";
            this.updateToolStripMenuItem1.Size = new System.Drawing.Size(202, 36);
            this.updateToolStripMenuItem1.Text = "Update";
            this.updateToolStripMenuItem1.Click += new System.EventHandler(this.updateToolStripMenuItem1_Click);
            // 
            // viewListToolStripMenuItem1
            // 
            this.viewListToolStripMenuItem1.Name = "viewListToolStripMenuItem1";
            this.viewListToolStripMenuItem1.Size = new System.Drawing.Size(202, 36);
            this.viewListToolStripMenuItem1.Text = "View List";
            this.viewListToolStripMenuItem1.Click += new System.EventHandler(this.viewListToolStripMenuItem1_Click);
            // 
            // cushionToolStripMenuItem
            // 
            this.cushionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem2,
            this.updateToolStripMenuItem2,
            this.viewListToolStripMenuItem2});
            this.cushionToolStripMenuItem.Name = "cushionToolStripMenuItem";
            this.cushionToolStripMenuItem.Size = new System.Drawing.Size(195, 36);
            this.cushionToolStripMenuItem.Text = "Cushion";
            // 
            // addToolStripMenuItem2
            // 
            this.addToolStripMenuItem2.Name = "addToolStripMenuItem2";
            this.addToolStripMenuItem2.Size = new System.Drawing.Size(202, 36);
            this.addToolStripMenuItem2.Text = "Add ";
            this.addToolStripMenuItem2.Click += new System.EventHandler(this.addToolStripMenuItem2_Click);
            // 
            // updateToolStripMenuItem2
            // 
            this.updateToolStripMenuItem2.Name = "updateToolStripMenuItem2";
            this.updateToolStripMenuItem2.Size = new System.Drawing.Size(202, 36);
            this.updateToolStripMenuItem2.Text = "Update";
            this.updateToolStripMenuItem2.Click += new System.EventHandler(this.updateToolStripMenuItem2_Click);
            // 
            // viewListToolStripMenuItem2
            // 
            this.viewListToolStripMenuItem2.Name = "viewListToolStripMenuItem2";
            this.viewListToolStripMenuItem2.Size = new System.Drawing.Size(202, 36);
            this.viewListToolStripMenuItem2.Text = "View List";
            this.viewListToolStripMenuItem2.Click += new System.EventHandler(this.viewListToolStripMenuItem2_Click);
            // 
            // curtainToolStripMenuItem
            // 
            this.curtainToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem3,
            this.updateToolStripMenuItem3,
            this.viewListToolStripMenuItem3});
            this.curtainToolStripMenuItem.Name = "curtainToolStripMenuItem";
            this.curtainToolStripMenuItem.Size = new System.Drawing.Size(195, 36);
            this.curtainToolStripMenuItem.Text = "Curtain";
            // 
            // addToolStripMenuItem3
            // 
            this.addToolStripMenuItem3.Name = "addToolStripMenuItem3";
            this.addToolStripMenuItem3.Size = new System.Drawing.Size(202, 36);
            this.addToolStripMenuItem3.Text = "Add";
            this.addToolStripMenuItem3.Click += new System.EventHandler(this.addToolStripMenuItem3_Click);
            // 
            // updateToolStripMenuItem3
            // 
            this.updateToolStripMenuItem3.Name = "updateToolStripMenuItem3";
            this.updateToolStripMenuItem3.Size = new System.Drawing.Size(202, 36);
            this.updateToolStripMenuItem3.Text = "Update";
            this.updateToolStripMenuItem3.Click += new System.EventHandler(this.updateToolStripMenuItem3_Click);
            // 
            // viewListToolStripMenuItem3
            // 
            this.viewListToolStripMenuItem3.Name = "viewListToolStripMenuItem3";
            this.viewListToolStripMenuItem3.Size = new System.Drawing.Size(202, 36);
            this.viewListToolStripMenuItem3.Text = "View List";
            this.viewListToolStripMenuItem3.Click += new System.EventHandler(this.viewListToolStripMenuItem3_Click);
            // 
            // MI_Stock
            // 
            this.MI_Stock.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.receivedOrderToolStripMenuItem,
            this.stockUpdatesToolStripMenuItem,
            this.paymentDetailsToolStripMenuItem});
            this.MI_Stock.Name = "MI_Stock";
            this.MI_Stock.Size = new System.Drawing.Size(86, 36);
            this.MI_Stock.Text = "Stock";
            // 
            // receivedOrderToolStripMenuItem
            // 
            this.receivedOrderToolStripMenuItem.Name = "receivedOrderToolStripMenuItem";
            this.receivedOrderToolStripMenuItem.Size = new System.Drawing.Size(275, 36);
            this.receivedOrderToolStripMenuItem.Text = "Received Order";
            this.receivedOrderToolStripMenuItem.Click += new System.EventHandler(this.receivedOrderToolStripMenuItem_Click);
            // 
            // stockUpdatesToolStripMenuItem
            // 
            this.stockUpdatesToolStripMenuItem.Name = "stockUpdatesToolStripMenuItem";
            this.stockUpdatesToolStripMenuItem.Size = new System.Drawing.Size(275, 36);
            this.stockUpdatesToolStripMenuItem.Text = "Stock Updates";
            this.stockUpdatesToolStripMenuItem.Click += new System.EventHandler(this.stockUpdatesToolStripMenuItem_Click);
            // 
            // paymentDetailsToolStripMenuItem
            // 
            this.paymentDetailsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPaymentToolStripMenuItem,
            this.viewPaymentToolStripMenuItem});
            this.paymentDetailsToolStripMenuItem.Name = "paymentDetailsToolStripMenuItem";
            this.paymentDetailsToolStripMenuItem.Size = new System.Drawing.Size(275, 36);
            this.paymentDetailsToolStripMenuItem.Text = "Payment Details";
            // 
            // addPaymentToolStripMenuItem
            // 
            this.addPaymentToolStripMenuItem.Name = "addPaymentToolStripMenuItem";
            this.addPaymentToolStripMenuItem.Size = new System.Drawing.Size(255, 36);
            this.addPaymentToolStripMenuItem.Text = "Add Payment";
            this.addPaymentToolStripMenuItem.Click += new System.EventHandler(this.addPaymentToolStripMenuItem_Click);
            // 
            // viewPaymentToolStripMenuItem
            // 
            this.viewPaymentToolStripMenuItem.Name = "viewPaymentToolStripMenuItem";
            this.viewPaymentToolStripMenuItem.Size = new System.Drawing.Size(255, 36);
            this.viewPaymentToolStripMenuItem.Text = "View Payment";
            this.viewPaymentToolStripMenuItem.Click += new System.EventHandler(this.viewPaymentToolStripMenuItem_Click);
            // 
            // MI_Supplier
            // 
            this.MI_Supplier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addSupplierToolStripMenuItem,
            this.updateSupplierDetailsToolStripMenuItem,
            this.viewSupplierDetailsToolStripMenuItem});
            this.MI_Supplier.Name = "MI_Supplier";
            this.MI_Supplier.Size = new System.Drawing.Size(117, 36);
            this.MI_Supplier.Text = "Supplier";
            // 
            // addSupplierToolStripMenuItem
            // 
            this.addSupplierToolStripMenuItem.Name = "addSupplierToolStripMenuItem";
            this.addSupplierToolStripMenuItem.Size = new System.Drawing.Size(356, 36);
            this.addSupplierToolStripMenuItem.Text = "Add Supplier Details";
            this.addSupplierToolStripMenuItem.Click += new System.EventHandler(this.addSupplierToolStripMenuItem_Click);
            // 
            // updateSupplierDetailsToolStripMenuItem
            // 
            this.updateSupplierDetailsToolStripMenuItem.Name = "updateSupplierDetailsToolStripMenuItem";
            this.updateSupplierDetailsToolStripMenuItem.Size = new System.Drawing.Size(356, 36);
            this.updateSupplierDetailsToolStripMenuItem.Text = "Update Supplier Details";
            this.updateSupplierDetailsToolStripMenuItem.Click += new System.EventHandler(this.updateSupplierDetailsToolStripMenuItem_Click);
            // 
            // viewSupplierDetailsToolStripMenuItem
            // 
            this.viewSupplierDetailsToolStripMenuItem.Name = "viewSupplierDetailsToolStripMenuItem";
            this.viewSupplierDetailsToolStripMenuItem.Size = new System.Drawing.Size(356, 36);
            this.viewSupplierDetailsToolStripMenuItem.Text = "View Supplier Details";
            this.viewSupplierDetailsToolStripMenuItem.Click += new System.EventHandler(this.viewSupplierDetailsToolStripMenuItem_Click);
            // 
            // MI_Employee
            // 
            this.MI_Employee.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEmployeeToolStripMenuItem,
            this.updateEmployeeToolStripMenuItem,
            this.viewDetailsToolStripMenuItem});
            this.MI_Employee.Name = "MI_Employee";
            this.MI_Employee.Size = new System.Drawing.Size(133, 36);
            this.MI_Employee.Text = "Employee";
            // 
            // addEmployeeToolStripMenuItem
            // 
            this.addEmployeeToolStripMenuItem.Name = "addEmployeeToolStripMenuItem";
            this.addEmployeeToolStripMenuItem.Size = new System.Drawing.Size(293, 36);
            this.addEmployeeToolStripMenuItem.Text = "Add Employee";
            this.addEmployeeToolStripMenuItem.Click += new System.EventHandler(this.addEmployeeToolStripMenuItem_Click);
            // 
            // updateEmployeeToolStripMenuItem
            // 
            this.updateEmployeeToolStripMenuItem.Name = "updateEmployeeToolStripMenuItem";
            this.updateEmployeeToolStripMenuItem.Size = new System.Drawing.Size(293, 36);
            this.updateEmployeeToolStripMenuItem.Text = "Update Employee";
            this.updateEmployeeToolStripMenuItem.Click += new System.EventHandler(this.updateEmployeeToolStripMenuItem_Click);
            // 
            // viewDetailsToolStripMenuItem
            // 
            this.viewDetailsToolStripMenuItem.Name = "viewDetailsToolStripMenuItem";
            this.viewDetailsToolStripMenuItem.Size = new System.Drawing.Size(293, 36);
            this.viewDetailsToolStripMenuItem.Text = "View Details";
            this.viewDetailsToolStripMenuItem.Click += new System.EventHandler(this.viewDetailsToolStripMenuItem_Click);
            // 
            // MI_Expence
            // 
            this.MI_Expence.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addExpenseToolStripMenuItem,
            this.viewExpensesToolStripMenuItem});
            this.MI_Expence.Name = "MI_Expence";
            this.MI_Expence.Size = new System.Drawing.Size(129, 36);
            this.MI_Expence.Text = "Expences";
            // 
            // addExpenseToolStripMenuItem
            // 
            this.addExpenseToolStripMenuItem.Name = "addExpenseToolStripMenuItem";
            this.addExpenseToolStripMenuItem.Size = new System.Drawing.Size(262, 36);
            this.addExpenseToolStripMenuItem.Text = "Add Expense";
            this.addExpenseToolStripMenuItem.Click += new System.EventHandler(this.addExpenseToolStripMenuItem_Click);
            // 
            // viewExpensesToolStripMenuItem
            // 
            this.viewExpensesToolStripMenuItem.Name = "viewExpensesToolStripMenuItem";
            this.viewExpensesToolStripMenuItem.Size = new System.Drawing.Size(262, 36);
            this.viewExpensesToolStripMenuItem.Text = "View Expenses";
            this.viewExpensesToolStripMenuItem.Click += new System.EventHandler(this.viewExpensesToolStripMenuItem_Click);
            // 
            // MI_Management
            // 
            this.MI_Management.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewUserToolStripMenuItem,
            this.updateUserToolStripMenuItem,
            this.deleteViewUserToolStripMenuItem});
            this.MI_Management.Name = "MI_Management";
            this.MI_Management.Size = new System.Drawing.Size(224, 36);
            this.MI_Management.Text = "User Management";
            // 
            // addNewUserToolStripMenuItem
            // 
            this.addNewUserToolStripMenuItem.Name = "addNewUserToolStripMenuItem";
            this.addNewUserToolStripMenuItem.Size = new System.Drawing.Size(334, 36);
            this.addNewUserToolStripMenuItem.Text = "Add New User";
            this.addNewUserToolStripMenuItem.Click += new System.EventHandler(this.addNewUserToolStripMenuItem_Click);
            // 
            // updateUserToolStripMenuItem
            // 
            this.updateUserToolStripMenuItem.Name = "updateUserToolStripMenuItem";
            this.updateUserToolStripMenuItem.Size = new System.Drawing.Size(334, 36);
            this.updateUserToolStripMenuItem.Text = "Update User";
            this.updateUserToolStripMenuItem.Click += new System.EventHandler(this.updateUserToolStripMenuItem_Click);
            // 
            // deleteViewUserToolStripMenuItem
            // 
            this.deleteViewUserToolStripMenuItem.Name = "deleteViewUserToolStripMenuItem";
            this.deleteViewUserToolStripMenuItem.Size = new System.Drawing.Size(334, 36);
            this.deleteViewUserToolStripMenuItem.Text = "Delete and View User";
            this.deleteViewUserToolStripMenuItem.Click += new System.EventHandler(this.deleteViewUserToolStripMenuItem_Click);
            // 
            // MI_Report
            // 
            this.MI_Report.Name = "MI_Report";
            this.MI_Report.Size = new System.Drawing.Size(101, 36);
            this.MI_Report.Text = "Report";
            this.MI_Report.Click += new System.EventHandler(this.MI_Report_Click);
            // 
            // lbl_Login_User
            // 
            this.lbl_Login_User.AutoSize = true;
            this.lbl_Login_User.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.lbl_Login_User.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Login_User.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbl_Login_User.Location = new System.Drawing.Point(1156, 4);
            this.lbl_Login_User.Name = "lbl_Login_User";
            this.lbl_Login_User.Size = new System.Drawing.Size(115, 32);
            this.lbl_Login_User.TabIndex = 2;
            this.lbl_Login_User.Text = "Welcome";
            this.lbl_Login_User.Click += new System.EventHandler(this.lbl_Login_User_Click);
            // 
            // frm_MDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1387, 853);
            this.Controls.Add(this.lbl_Login_User);
            this.Controls.Add(this.ms_Menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.ms_Menu;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_MDI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.frm_MDI_Load);
            this.ms_Menu.ResumeLayout(false);
            this.ms_Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ms_Menu;
        private System.Windows.Forms.ToolStripMenuItem MI_Customer;
        private System.Windows.Forms.ToolStripMenuItem MI_Product;
        private System.Windows.Forms.ToolStripMenuItem MI_Stock;
        private System.Windows.Forms.ToolStripMenuItem MI_Supplier;
        private System.Windows.Forms.ToolStripMenuItem MI_Employee;
        private System.Windows.Forms.ToolStripMenuItem MI_Expence;
        private System.Windows.Forms.ToolStripMenuItem MI_Management;
        private System.Windows.Forms.ToolStripMenuItem MI_Report;
        private System.Windows.Forms.ToolStripMenuItem addNewCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mattressToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pillowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem viewListToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cushionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem viewListToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem curtainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem viewListToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem addSupplierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateSupplierDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewSupplierDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem receivedOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockUpdatesToolStripMenuItem;
        private System.Windows.Forms.Label lbl_Login_User;
        private System.Windows.Forms.ToolStripMenuItem deleteViewUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addExpenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewExpensesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPaymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewPaymentToolStripMenuItem;
    }
}