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
    public partial class frmemployeeDashboard : Form
    {
        public frmemployeeDashboard()
        {
            InitializeComponent();

            this.FormClosing += frmemployeeDashboard_FormClosing;    //disables form controlbox for closing the form
            this.ControlBox = false;

        }

        private void frmemployeeDashboard_FormClosing(object sender, FormClosingEventArgs e)     //disables the ability to close the form using controlbox
        {
            e.Cancel = true;
        }



        private void lblFileReportWelcome_MouseHover(object sender, EventArgs e)    //will change the color of the label upon mouse hover
        {
            lblFileReportWelcome.ForeColor = Color.Yellow;
        }

        private void lblFileReportWelcome_MouseLeave(object sender, EventArgs e)    //will revert the original color of a label upon unhover
        {
            lblFileReportWelcome.ForeColor = Color.FromArgb(221, 72, 48);
        }


        private void frmemployeeDashboard_Load(object sender, EventArgs e)       
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;                      //disable form resizing
        }

        private void lblFileReportWelcome_Click(object sender, EventArgs e)
        {
            frmReport frmReport = new frmReport();          //open form
            frmReport.Show();
        }


           
        
        private void lblLogoutWelcome_Click(object sender, EventArgs e)
        {
            this.FormClosing -= frmemployeeDashboard_FormClosing;         //enable closing the form without the controlbox
            
            frmReport frmReport = new frmReport();        //open form
            frmReport.Close();

            foreach (Form form in Application.OpenForms)     //closes a form that was opened on the current form if the main form closes. Only visible if the main form did not close upon opening the new form.
            {
                if (form.Name == "frmReport")       //closes the frmReport form if it is open and the main form is closed.
                {
                    form.Close();
                    break;
                }
            }



            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();

            this.Close();

            
        }
    }
}
