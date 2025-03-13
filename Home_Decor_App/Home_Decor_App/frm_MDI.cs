using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home_Decor_App
{
    public partial class frm_MDI : Form
    {
        public frm_MDI()
        {
            InitializeComponent();
        }

        

        private void frm_MDI_Load(object sender, EventArgs e)
        {
            lbl_Login_User.Text = "Welcome " + SharedContent.Login_User;
            SharedContent.Generate_Id();

            if(SharedContent.User_Role == "Cashier")
            {
                MI_Report.Visible = false;
                MI_Management.Visible = false;

            }
            else if (SharedContent.User_Role == "Manager")
            {
                MI_Report.Visible = false;
                MI_Management.Visible = false;

            }
            else if(SharedContent.User_Role == "Worker")
            {
                MI_Report.Visible = false;
                MI_Management.Visible = false;
                MI_Employee.Visible = false;
                MI_Expence.Visible = false;
            }
        }

        private void addNewCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer_Details.frm_Add_New_Customer ANC = new Customer_Details.frm_Add_New_Customer();
            ANC.MdiParent = this;
            ANC.WindowState = FormWindowState.Maximized;
            ANC.Show();
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer_Details.frm_View_Customer_Details VCD = new Customer_Details.frm_View_Customer_Details();
            VCD.MdiParent = this;
            VCD.WindowState = FormWindowState.Maximized;
            VCD.Show();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Product_Details.Mattress.frm_Add_Mattress AM = new Product_Details.Mattress.frm_Add_Mattress();
            AM.MdiParent = this;
            AM.WindowState = FormWindowState.Maximized;
            AM.Show();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Product_Details.Mattress.frm_Update_Mattress UM = new Product_Details.Mattress.frm_Update_Mattress();
            UM.MdiParent = this;
            UM.WindowState = FormWindowState.Maximized;
            UM.Show();
        }

        private void viewListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Product_Details.Mattress.frm_View_Mattress VM = new Product_Details.Mattress.frm_View_Mattress();
            VM.MdiParent = this;
            VM.WindowState = FormWindowState.Maximized;
            VM.Show();
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Product_Details.Pillow.frm_Add_Pillow AP = new Product_Details.Pillow.frm_Add_Pillow();
            AP.MdiParent = this;
            AP.WindowState = FormWindowState.Maximized;
            AP.Show();
        }

        private void updateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Product_Details.Pillow.frm_Update_Pillow UP = new Product_Details.Pillow.frm_Update_Pillow();
            UP.MdiParent = this;
            UP.WindowState = FormWindowState.Maximized;
            UP.Show();
        }

        private void viewListToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Product_Details.Pillow.frm_View_Pillow_List VPL = new Product_Details.Pillow.frm_View_Pillow_List();
            VPL.MdiParent = this;
            VPL.WindowState = FormWindowState.Maximized;
            VPL.Show();
        }

        private void addToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Product_Details.Cushion.frm_Add_Cushion AC = new Product_Details.Cushion.frm_Add_Cushion();
            AC.MdiParent = this;
            AC.WindowState = FormWindowState.Maximized;
            AC.Show();
        }

        private void updateToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Product_Details.Cushion.frm_Update_Cushion UC = new Product_Details.Cushion.frm_Update_Cushion();
            UC.MdiParent = this;
            UC.WindowState = FormWindowState.Maximized;
            UC.Show();
        }

        private void viewListToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Product_Details.Cushion.frm_View_Cushion_List VCL = new Product_Details.Cushion.frm_View_Cushion_List();
            VCL.MdiParent = this;
            VCL.WindowState = FormWindowState.Maximized;
            VCL.Show();
        }

        private void addToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Product_Details.Curtain.frm_Add_New_Curtain ANCD = new Product_Details.Curtain.frm_Add_New_Curtain();
            ANCD.MdiParent = this;
            ANCD.WindowState = FormWindowState.Maximized;
            ANCD.Show();
        }

        private void updateToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Product_Details.Curtain.frm_Update_Curtain UCD = new Product_Details.Curtain.frm_Update_Curtain();
            UCD.MdiParent = this;
            UCD.WindowState = FormWindowState.Maximized;
            UCD.Show();
        }

        private void viewListToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Product_Details.Curtain.frm_View_Curtain VCD = new Product_Details.Curtain.frm_View_Curtain();
            VCD.MdiParent = this;
            VCD.WindowState = FormWindowState.Maximized;
            VCD.Show();
        }

        private void receivedOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stock_Details.frm_Received_Order RO = new Stock_Details.frm_Received_Order();
            RO.MdiParent = this;
            RO.WindowState = FormWindowState.Maximized;
            RO.Show();
        }

        private void addPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stock_Details.frm_Payment_Details PD = new Stock_Details.frm_Payment_Details();
            PD.MdiParent = this;
            PD.WindowState = FormWindowState.Maximized;
            PD.Show();
        }

        private void viewPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stock_Details.frm_View_Payments VP = new Stock_Details.frm_View_Payments();
            VP.MdiParent = this;
            VP.WindowState = FormWindowState.Maximized;
            VP.Show();
        }

        private void addSupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Supplier_Details.frm_Add_Supplier AS = new Supplier_Details.frm_Add_Supplier();
            AS.MdiParent = this;
            AS.WindowState = FormWindowState.Maximized;
            AS.Show();
        }

        private void updateSupplierDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Supplier_Details.frm_Update_Supplier_Details USD = new Supplier_Details.frm_Update_Supplier_Details();
            USD.MdiParent = this;
            USD.WindowState = FormWindowState.Maximized;
            USD.Show();
        }

        private void viewSupplierDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Supplier_Details.frm_View_Supplier_Details VSD = new Supplier_Details.frm_View_Supplier_Details();
            VSD.MdiParent = this;
            VSD.WindowState = FormWindowState.Maximized;
            VSD.Show();
        }

        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee_Details.frm_Add_Employee AE = new Employee_Details.frm_Add_Employee();
            AE.MdiParent = this;
            AE.WindowState = FormWindowState.Maximized;
            AE.Show();
        }

        private void updateEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee_Details.frm_Update_Employee_Details UED = new Employee_Details.frm_Update_Employee_Details();
            UED.MdiParent = this;
            UED.WindowState = FormWindowState.Maximized;
            UED.Show();
        }

        private void viewDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee_Details.frm_View_Employee_Details VED = new Employee_Details.frm_View_Employee_Details();
            VED.MdiParent = this;
            VED.WindowState = FormWindowState.Maximized;
            VED.Show();
        }

        private void addExpenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Expence_Details.frm_Add_Expence AE = new Expence_Details.frm_Add_Expence();
            AE.MdiParent = this;
            AE.WindowState = FormWindowState.Maximized;
            AE.Show();
        }

        private void viewExpensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Expence_Details.frm_View_Expence_Details VED = new Expence_Details.frm_View_Expence_Details();
            VED.MdiParent = this;
            VED.WindowState = FormWindowState.Maximized;
            VED.Show();
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User_Management.frm_Add_User AU = new User_Management.frm_Add_User();
            AU.MdiParent = this;
            AU.WindowState = FormWindowState.Maximized;
            AU.Show();
        }

        private void updateUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User_Management.frm_Update_User UU = new User_Management.frm_Update_User();
            UU.MdiParent = this;
            UU.WindowState = FormWindowState.Maximized;
            UU.Show();
        }

        private void deleteViewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User_Management.frm_Delete_and_View_User DVU = new User_Management.frm_Delete_and_View_User();
            DVU.MdiParent = this;
            DVU.WindowState = FormWindowState.Maximized;
            DVU.Show();
        }

        private void lbl_Login_User_Click(object sender, EventArgs e)
        {
            DialogResult DR =  MessageBox.Show("Are You Sure, Do You Want To Logout ???","Information", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(DR == DialogResult.Yes)
            {
                frm_Login_Form LF = new frm_Login_Form();
                LF.Show();
                this.Hide();
            }
        }

        private void MI_Report_Click(object sender, EventArgs e)
        {
            Report.frm_Reports Obj = new Report.frm_Reports();
            Obj.MdiParent = this;
            Obj.WindowState = FormWindowState.Maximized;
            Obj.Show();
        }

        private void stockUpdatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stock_Details.frm_View_Orders VO = new Stock_Details.frm_View_Orders();
            VO.MdiParent = this;
            VO.WindowState = FormWindowState.Maximized;
            VO.Show();
        }
    }
}
