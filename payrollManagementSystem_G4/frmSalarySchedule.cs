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
    public partial class frmSalarySchedule : Form
    {
        public frmSalarySchedule()
        {
            InitializeComponent();

            this.FormClosing += frmSalarySchedule_FormClosing;
            this.ControlBox = false;
        }

        private void frmSalarySchedule_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }



        private void lblLogoutWelcome_Click(object sender, EventArgs e)
        {
            this.FormClosing -= frmSalarySchedule_FormClosing;

            frmAdminDashboard frmAdminDashboard = new frmAdminDashboard();
            frmAdminDashboard.Show();

            this.Close();
        }

        private void btnClearSalarySched_Click(object sender, EventArgs e)
        {
            tbIDSalarySched.Clear();     //clear field
        }

        private void frmSalarySchedule_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            tbIDSalarySched.Select(0, 0);
            tbIDSalarySched.HideSelection = true;
            tbIDSalarySched.TabStop = false;

            cbPositionRateSalarySched.DropDownStyle = ComboBoxStyle.DropDownList;   //set combo box read only
            cbPositionRateSalarySched.Items.Add("Regular Employee");
            cbPositionRateSalarySched.Items.Add("Manager");
            cbPositionRateSalarySched.Items.Add("Admin");

            btnClearFieldsSalarySched.Enabled = false;
            btnDoneSalarySched.Enabled = false;
        }

        private void btnEditSalarySced_Click(object sender, EventArgs e)
        {
            btnEditSalarySced.Enabled = false;
            btnDoneSalarySched.Enabled = true;
            btnClearFieldsSalarySched.Enabled = true;

            tbInSalarySchedMon.Enabled = true;
            tbInSalarySchedTue.Enabled = true;
            tbInSalarySchedWed.Enabled = true;
            tbInSalarySchedThu.Enabled = true;
            tbInSalarySchedFri.Enabled = true;
            tbInSalarySchedSat.Enabled = true;
            tbInSalarySchedSun.Enabled = true;

            tbOutSalarySchedMon.Enabled = true;
            tbOutSalarySchedTue.Enabled = true;
            tbOutSalarySchedWed.Enabled = true;
            tbOutSalarySchedThu.Enabled = true;
            tbOutSalarySchedFri.Enabled = true;
            tbOutSalarySchedSat.Enabled = true;
            tbOutSalarySchedSun.Enabled = true;

            tbAllowanceSalarySched.Enabled = true;
            tbOTSalarySched.Enabled = true;
            tbAbsencesSalarySched.Enabled = true;
            cbPositionRateSalarySched.Enabled = true;
            tbLeaveSalarySched.Enabled = true;
            tbMiscSalarySched.Enabled = true;
        }

        private void btnDoneSalarySched_Click(object sender, EventArgs e)
        {
            btnDoneSalarySched.Enabled = false;
            btnEditSalarySced.Enabled = true;
            btnClearFieldsSalarySched.Enabled = false;

            tbInSalarySchedMon.Enabled = false;
            tbInSalarySchedTue.Enabled = false;
            tbInSalarySchedWed.Enabled = false;
            tbInSalarySchedThu.Enabled = false;
            tbInSalarySchedFri.Enabled = false;
            tbInSalarySchedSat.Enabled = false;
            tbInSalarySchedSun.Enabled = false;

            tbOutSalarySchedMon.Enabled = false;
            tbOutSalarySchedTue.Enabled = false;
            tbOutSalarySchedWed.Enabled = false;
            tbOutSalarySchedThu.Enabled = false;
            tbOutSalarySchedFri.Enabled = false;
            tbOutSalarySchedSat.Enabled = false;
            tbOutSalarySchedSun.Enabled = false;

            tbAllowanceSalarySched.Enabled = false;
            tbOTSalarySched.Enabled = false;
            tbAbsencesSalarySched.Enabled = false;
            cbPositionRateSalarySched.Enabled = false;
            tbLeaveSalarySched.Enabled = false;
            tbMiscSalarySched.Enabled = false;
        }
    }
}
