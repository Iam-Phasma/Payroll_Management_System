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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();

            this.FormClosing += frmLogin_FormClosing;   //disables controlbox
            this.ControlBox = false;

        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;       //disables controlbox
        }


        private void lblRequestPassReset_Click(object sender, EventArgs e)
        {
            frmReport frmReport = new frmReport();   //open form
            frmReport.Show();
        }

        private void lblRequestPassReset_MouseHover(object sender, EventArgs e)    //will change the color of the label upon mouse hover
        {
            lblRequestPassReset.ForeColor = Color.Yellow;
        }

        private void lblRequestPassReset_MouseLeave(object sender, EventArgs e)    //will revert the original color of a label upon unhover
        {
            lblRequestPassReset.ForeColor = Color.FromArgb(221,72, 48);
        }





        private void tbIDLogin_GotFocus(object sender, EventArgs e)    //used to erase the field if the user clicked the textbox
        {                                                              //however, it is disabled once a user has typed something in the field
            if (string.IsNullOrEmpty(tbIDLogin.Text)){

            }
            else if (tbIDLogin.Text == "User ID")     //will clear the field
            {
                tbIDLogin.Text = "";
            }
        }

        private void tbPassLogin_GotFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbPassLogin.Text))
            {

            }
            else if (tbPassLogin.Text == "Password")   //will clear the field
            {
                tbPassLogin.Text = "";
            }
        }

        private void tbIDLogin_TextChanged(object sender, EventArgs e)  //this will remove the red tag error when a user starts typing in the field again
        {
            lblLoginEmptyError.Visible = false;
        }

        private void tbPassLogin_TextChanged(object sender, EventArgs e)
        {
            lblLoginEmptyError.Visible = false;
        }












        private void frmLogin_Load(object sender, EventArgs e)
        {
            lblLoginEmptyError.Visible = false;   //hide login error
            lblChooseLogin.Visible = false;

            tbIDLogin.Select(0, 0);           //prevent from text from being highlighted in a textbox upon loaded
            tbIDLogin.HideSelection = true;   //hides the "|" from blinking inside the texbox upon loaded even though user have not select any
            tbIDLogin.TabStop = false;        //prevents the textbox from being focus upon loaded

            tbPassLogin.Select(0, 0);
            tbPassLogin.HideSelection = true;
            tbPassLogin.TabStop = false;

            btnSignIn.FlatAppearance.BorderSize = 0; //remove sign in button border
            btnClearLogin.FlatAppearance.BorderSize = 0;

            this.FormBorderStyle = FormBorderStyle.FixedSingle; //diable resizing the form

            //btnSignIn.Enabled = false; //stay disbable if none of the admin/employee is chosen.

            //rbEmployee.Checked = true;


            


        }

        



        private static bool frmAdminDashboardOpen = false;   //if the button is open, only one instance of form will be opened
        private static bool frmemployeeDashboardOpen = false;
        private void btnSignIn_Click_1(object sender, EventArgs e)   //if the fields is empty and sign in button is clicked, therfore error message.
        {
            this.FormClosing -= frmLogin_FormClosing;

            if (string.IsNullOrEmpty(tbIDLogin.Text) || string.IsNullOrEmpty(tbPassLogin.Text))   //if either radio button is selected, log in button will be disabled
            {
                lblLoginEmptyError.Visible = true;
            }

            if (rbAdmin.Checked == true || rbEmployee.Checked == true)  //check if either choices are selected, else, sign in disabled
            {

                if (rbAdmin.Checked == true && rbEmployee.Checked == false)  //check if admin is true and employee is false. Therefore, open admin dashboard.
                {
                    if (!frmAdminDashboardOpen) //open form if not currently open
                    {
                        frmAdminDashboardOpen = true;
                        frmAdminDashboard formManage = new frmAdminDashboard();
                        formManage.FormClosed += new FormClosedEventHandler(frmAdminDashboardOpen_FormClosed);
                        formManage.Show();

                        lblLoginEmptyError.Visible = false;
                        lblChooseLogin.Visible = false;

                        this.Close(); //close current form
                    }
                }else if (rbAdmin.Checked == false && rbEmployee.Checked == true)
                {
                    if (!frmemployeeDashboardOpen)
                    {
                        frmemployeeDashboardOpen = true;
                        frmemployeeDashboard formEmployeeDashboard = new frmemployeeDashboard();
                        formEmployeeDashboard.FormClosed += new FormClosedEventHandler(frmemployeeDashboardOpen_FormClosed);
                        formEmployeeDashboard.Show();

                        lblLoginEmptyError.Visible = false;
                        lblChooseLogin.Visible = false;

                        this.Close();
                    }



                    lblChooseLogin.Visible = false;  //enable log in button if either 2 radio button is selected
                }
                

                
            }else if (rbAdmin.Checked == false && rbEmployee.Checked == false)    //if either radio button is not selected, show error message
            {
                lblChooseLogin.Visible = true;
            }


            
        }

        private void frmAdminDashboardOpen_FormClosed(object sender, FormClosedEventArgs e)  //if employee or admin dashboard is closed, set value to false.
        {
            frmAdminDashboardOpen = false;                                                   //this is used to enable login button to open employee or admin dashboard
        }

        private void frmemployeeDashboardOpen_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmemployeeDashboardOpen = false;
        }





        private void btnClearLogin_Click(object sender, EventArgs e)    //will clear the 2 textbox fields
        {
            tbIDLogin.Clear();
            tbPassLogin.Clear();
        }

        private void lblExitLogin_Click(object sender, EventArgs e)
        {
            this.FormClosing -= frmLogin_FormClosing;                        //if log in form is closed. Stop application.

            Application.Exit();
        }
    }
}
