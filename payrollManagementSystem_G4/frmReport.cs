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
    public partial class frmReport : Form
    {
        public frmReport()
        {
            InitializeComponent();
        }

        private void btnCancelReport_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            lblSubmitSuccessReport.Visible = false;

            tbIDReport.Select(0, 0);              //disables textbox from being highlighted and cursor typing enabled when the form is loaded.
            tbIDReport.HideSelection = true;
            tbIDReport.TabStop = false;

            tbSummaryReport.Select(0, 0);
            tbSummaryReport.HideSelection = true;
            tbSummaryReport.TabStop = false;

            tbMessageReport.Select(0, 0);
            tbMessageReport.HideSelection = true;
            tbMessageReport.TabStop = false;
        }


        private void tbIDReport_GotFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbIDReport.Text))   //if the field has this value and not null, clear button is enabled
            {

            }
            else if (tbIDReport.Text == "Enter ID")
            {
                tbIDReport.Text = "";
            }
        }



        private void btnSubmitReport_Click(object sender, EventArgs e)
        {
            lblSubmitSuccessReport.Visible = true;
            btnSubmitReport.Enabled = false;

            btnCancelReport.Enabled = false;

        }
    }
}
