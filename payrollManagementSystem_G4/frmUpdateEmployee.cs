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
    public partial class frmUpdateEmployee : Form
    {
        public frmUpdateEmployee()
        {
            InitializeComponent();

            this.FormClosing += frmUpdateEmployee_FormClosing;
            this.ControlBox = false;
        }

        private void frmUpdateEmployee_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }


        private void btnCancelReport_Click(object sender, EventArgs e)
        {
            this.FormClosing -= frmUpdateEmployee_FormClosing;

            frmmanageEmployeesAndStaffs frmmanageEmployeesAndStaffs = new frmmanageEmployeesAndStaffs();
            frmmanageEmployeesAndStaffs.Show();

            this.Close();
        }

        private void frmUpdateEmployee_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void lblLogoutWelcome_Click(object sender, EventArgs e)
        {
            this.FormClosing -= frmUpdateEmployee_FormClosing;

            frmmanageEmployeesAndStaffs frmmanageEmployeesAndStaffs = new frmmanageEmployeesAndStaffs();
            frmmanageEmployeesAndStaffs.Show();

            this.Close();
        }
    }
}
