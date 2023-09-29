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
    public partial class frmMessagesAdmin : Form
    {
        public frmMessagesAdmin()
        {
            InitializeComponent();

            this.FormClosing += frmMessagesAdmin_FormClosing;
            this.ControlBox = false;
        }

        private void frmMessagesAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }


        private void frmMessagesAdmin_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;      //disable resizing form

            tbMessageSummaryMessages.Enabled = false;           //set textbox to read only
            cbMessageListMessages.DropDownStyle = ComboBoxStyle.DropDownList;     //set comboox to read only
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void lblCloseMessages_Click(object sender, EventArgs e)
        {
            this.FormClosing -= frmMessagesAdmin_FormClosing;

            frmAdminDashboard frmAdminDashboard = new frmAdminDashboard();
            frmAdminDashboard.Show();


            this.Close();
        }
    }
}
