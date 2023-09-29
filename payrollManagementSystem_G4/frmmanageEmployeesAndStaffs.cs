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
    public partial class frmmanageEmployeesAndStaffs : Form
    {



        public frmmanageEmployeesAndStaffs()
        {
            InitializeComponent();

            this.FormClosing += frmmanageEmployeesAndStaffs_FormClosing;
            this.ControlBox = false;
        }

        private void frmmanageEmployeesAndStaffs_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }




        private void tbSearchPeople_GotFocus(object sender, EventArgs e)    //used to erase the field if the user clicked the textbox
        {                                                                   //however, it is disabled once a user has typed something in the field
            if (string.IsNullOrEmpty(tbIDManage.Text))
            {

            }
            else if (tbIDManage.Text == "Enter ID")
            {
                tbIDManage.Text = "";
            }
        }












        private void frmmanageEmployeesAndStaffs_Load(object sender, EventArgs e)
        {
            this.FormClosing -= frmmanageEmployeesAndStaffs_FormClosing;

            this.FormBorderStyle = FormBorderStyle.FixedSingle; //diable resizing the form

            tbIDManage.TabStop = false; //prevents the textbox from being focus upon loaded

            btnSearchManage.FlatAppearance.BorderSize = 0; //remove button border
            btnInsertManage.FlatAppearance.BorderSize = 0;
            btnClearManage.FlatAppearance.BorderSize = 0;
            btnUpdateManage.FlatAppearance.BorderSize = 0;
            btnRemoveManage.FlatAppearance.BorderSize = 0;
        }

        private void btnClearManage_Click(object sender, EventArgs e)
        {
            tbIDManage.Clear();   //clear textfield
        }

        private void lblLogoutWelcome_Click(object sender, EventArgs e)
        {
            frmMessagesAdmin frmMessagesAdmin = new frmMessagesAdmin();
            frmMessagesAdmin.Close();

            this.FormClosing -= frmmanageEmployeesAndStaffs_FormClosing;


            //frmNewEmployee frmNewEmployee = new frmNewEmployee();
            //frmUpdateEmployee frmUpdateEmployee = new frmUpdateEmployee();

            

            /*

            foreach (Form form in Application.OpenForms)
            {
                if (form.Name == "frmUpdateEmployee")
                {
                    form.Close();
                    break;
                }
            }

            
            List<string> formsToClose = new List<string>() { "frmNewEmployee", "frmUpdateEmployee"};
            foreach (Form form in Application.OpenForms.OfType<Form>().ToList())
            {
                if (formsToClose.Contains(form.Name))
                {
                    form.Close();
                }
            }
            */

            frmAdminDashboard frmAdminDashboard = new frmAdminDashboard();   //open form
            frmAdminDashboard.Show();

            this.Close();           //close current form
        }

        private void tbSearchPeopleManage_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInsertManage_Click(object sender, EventArgs e)
        {
            this.FormClosing -= frmmanageEmployeesAndStaffs_FormClosing;

            frmNewEmployee frmNewEmployee = new frmNewEmployee();    //open form
            frmNewEmployee.Show();

            this.Close();          //close current form
        }

        private void btnUpdateManage_Click(object sender, EventArgs e)
        {
            this.FormClosing -= frmmanageEmployeesAndStaffs_FormClosing;

            frmUpdateEmployee frmUpdate = new frmUpdateEmployee();
            frmUpdate.Show();

            this.Close();

        }
    }
}
