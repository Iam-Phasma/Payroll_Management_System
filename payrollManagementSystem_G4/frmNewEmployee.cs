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
    public partial class frmNewEmployee : Form
    {
        public frmNewEmployee()
        {
            InitializeComponent();

            this.FormClosing += frmNewEmployee_FormClosing;
            this.ControlBox = false;
        }

        private void frmNewEmployee_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }


        private void frmNewEmployee_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            cbPositionNew.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPositionNew.Items.Add("Employee");
            cbPositionNew.Items.Add("Admin");
        }

        private void btnCancelReport_Click(object sender, EventArgs e)
        {
            this.FormClosing -= frmNewEmployee_FormClosing;

            frmmanageEmployeesAndStaffs frmmanageEmployeesAndStaffs = new frmmanageEmployeesAndStaffs();
            frmmanageEmployeesAndStaffs.Show();

            this.Close();
        }

        private void lblCloseNewEmployee_Click(object sender, EventArgs e)
        {
            this.FormClosing -= frmNewEmployee_FormClosing;

            frmmanageEmployeesAndStaffs frmmanageEmployeesAndStaffs = new frmmanageEmployeesAndStaffs();
            frmmanageEmployeesAndStaffs.Show();

            this.Close();
        }
    }
}
