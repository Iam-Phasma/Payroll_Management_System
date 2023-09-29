using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace payrollManagementSystem_G4
{
    public partial class frmAdminDashboard : Form
    {
        public frmAdminDashboard()
        {
            InitializeComponent();

            this.FormClosing += frmAdminDashboard_FormClosing;  //disables the form controlbox
            this.ControlBox = false;
        }

        private void frmAdminDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;         //cancel the closing event
        }




        private static bool frmManageEmployeeAndStaffOpen = false;                //this block of code prevents every forms to close if the main form (login form is closed)
        private void btnManageEmployeeAdmin_Click(object sender, EventArgs e)     //this can happen during the login, when a user has loged-in. The login form will close then.
        {
            this.FormClosing -= frmAdminDashboard_FormClosing;

            if (!frmManageEmployeeAndStaffOpen)                                //prevents another instance of form showing if the form trying to open is still open
            {
                frmManageEmployeeAndStaffOpen = true;
                frmmanageEmployeesAndStaffs formManage = new frmmanageEmployeesAndStaffs();
                formManage.FormClosed += new FormClosedEventHandler(frmmanageEmployeesAndStaffs_FormClosed);
                formManage.Show();

                this.Close();     //close current form
            }
        }

        private void frmmanageEmployeesAndStaffs_FormClosed(object sender, FormClosedEventArgs e)  //also extension of form close prevention
        {
            frmManageEmployeeAndStaffOpen = false;
        }

        private void frmAdminDashboard_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;  //diable form resizing

            tbSSSAdmin.TabStop = false;                           //diable the textbox from being highlighted
            tbPagibigAdmin.TabStop = false;
            tbPhilhealthAdmin.TabStop = false;
            tbOvertimeAdmin.TabStop = false;
            tbHolidayAdmin.TabStop = false;
            tbBonusAdmin.TabStop = false;
            tbRateAdminAdmin.TabStop = false;
            tbRateManagerAdmin.TabStop = false;
            tbRegEmployeeAdmin.TabStop = false;
            tbAbsentDeductionAdmin.TabStop = false;

            tbSSSAdmin.Enabled = false;                 //enable all texbox to be edited. 
            tbPagibigAdmin.Enabled = false;
            tbPhilhealthAdmin.Enabled = false;
            tbOvertimeAdmin.Enabled = false;
            tbHolidayAdmin.Enabled = false;
            tbBonusAdmin.Enabled = false;
            tbRateAdminAdmin.Enabled = false;
            tbRateManagerAdmin.Enabled = false;
            tbRegEmployeeAdmin.Enabled = false;
            tbAbsentDeductionAdmin.Enabled = false;

            btnDoneAdmin.Enabled = false;
            btnClearAdmin.Enabled = false;

            
        }


        

        private void btnEditAdmin_Click(object sender, EventArgs e)    //enable all texbox to be edited. 
        {

            tbSSSAdmin.Enabled = true;
            tbPagibigAdmin.Enabled = true;
            tbPhilhealthAdmin.Enabled = true;
            tbOvertimeAdmin.Enabled = true;
            tbHolidayAdmin.Enabled = true;
            tbBonusAdmin.Enabled = true;
            tbRateAdminAdmin.Enabled = true;
            tbRateManagerAdmin.Enabled = true;
            tbRegEmployeeAdmin.Enabled = true;
            tbAbsentDeductionAdmin.Enabled = true;
            

            btnDoneAdmin.Enabled = true;           //enable all buttons to be edited. 
            btnClearAdmin.Enabled = true;

            btnEditAdmin.Enabled = false;
            lblLogoutWelcome.Enabled = false;

            btnManageEmployeeAdmin.Enabled = false;          //enable all texbox to be !edited. 
            btnSalaryScheduleAdmin.Enabled = false;
            btnMessagesAdmin.Enabled = false;

        }

        private void btnDoneAdmin_Click(object sender, EventArgs e)  //disable all textbox upon exiting edit mode
        {
            tbSSSAdmin.Enabled = false;
            tbPagibigAdmin.Enabled = false;
            tbPhilhealthAdmin.Enabled = false;
            tbOvertimeAdmin.Enabled = false;
            tbHolidayAdmin.Enabled = false;
            tbBonusAdmin.Enabled = false;
            tbRateAdminAdmin.Enabled = false;
            tbRateManagerAdmin.Enabled = false;
            tbRegEmployeeAdmin.Enabled = false;
            tbAbsentDeductionAdmin.Enabled = false;

            btnClearAdmin.Enabled = false;
            btnDoneAdmin.Enabled = false;
            btnEditAdmin.Enabled = true;

            lblLogoutWelcome.Enabled = true;

            btnManageEmployeeAdmin.Enabled = true;
            btnSalaryScheduleAdmin.Enabled = true;
            btnMessagesAdmin.Enabled = true;
        }

        private void btnClearAdmin_Click(object sender, EventArgs e)  //clear all fields on the admin general benefits
        {
            tbSSSAdmin.Clear();
            tbPagibigAdmin.Clear();
            tbPhilhealthAdmin.Clear();
            tbOvertimeAdmin.Clear();
            tbHolidayAdmin.Clear();
            tbBonusAdmin.Clear();
            tbRateAdminAdmin.Clear();
            tbRateManagerAdmin.Clear();
            tbRegEmployeeAdmin.Clear();
            tbAbsentDeductionAdmin.Clear();
        }

        private void lblLogoutWelcome_Click(object sender, EventArgs e)
        {

            this.FormClosing -= frmAdminDashboard_FormClosing;   //prevents the form from closing using controlbox


            /*
            frmmanageEmployeesAndStaffs frmmanageEmployeesAndStaffs = new frmmanageEmployeesAndStaffs();
            frmMessagesAdmin frmMessagesAdmin = new frmMessagesAdmin();
            frmSalarySchedule frmSalarySchedule = new frmSalarySchedule();
            
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name == "frmmanageEmployeesAndStaffs")
                {
                    form.Close();
                    break;
                }
            }

            foreach (Form form in Application.OpenForms)
            {
                if (form.Name == "frmMessagesAdmin")
                {
                    form.Close();
                    break;
                }
            }

            foreach (Form form in Application.OpenForms)
            {
                if (form.Name == "frmSalarySchedule")
                {
                    form.Close();
                    break;
                }
            }

            
            List<string> formsToClose = new List<string>() { "frmReport", "frmMessagesAdmin", "frmSalarySchedule"};
            foreach (Form form in Application.OpenForms.OfType<Form>().ToList())
            {
                if (formsToClose.Contains(form.Name))
                {
                    form.Close();
                }
            }
            */


            frmLogin frmLogin = new frmLogin();   //login form will open after user has loged out
            frmLogin.Show();

            this.Close();    //close current form

        }

        private void btnSalaryScheduleAdmin_Click(object sender, EventArgs e)
        {
            this.FormClosing -= frmAdminDashboard_FormClosing;                   //also disable the form controlbox

            frmSalarySchedule frmSalarySchedule = new frmSalarySchedule();    //open form
            frmSalarySchedule.Show();

            this.Close();                                                      //close current form
        }

        private void btnMessagesAdmin_Click(object sender, EventArgs e)
        {
            this.FormClosing -= frmAdminDashboard_FormClosing;                    //also disable the form controlbox

            frmMessagesAdmin frmMessagesAdmin = new frmMessagesAdmin();
            frmMessagesAdmin.Show();

            this.Close();
        }
    }
}
