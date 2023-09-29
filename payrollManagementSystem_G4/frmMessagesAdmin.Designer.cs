
namespace payrollManagementSystem_G4
{
    partial class frmMessagesAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbMessageListMessages = new System.Windows.Forms.ComboBox();
            this.tbMessageSummaryMessages = new System.Windows.Forms.TextBox();
            this.btnRemoveManage = new System.Windows.Forms.Button();
            this.btnOpenMessage = new System.Windows.Forms.Button();
            this.tbMessageBodyMessages = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFromIDMessages = new System.Windows.Forms.Label();
            this.lblCloseMessages = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(72)))), ((int)(((byte)(48)))));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 86);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(33, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 60);
            this.label1.TabIndex = 21;
            this.label1.Text = "MESSAGES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(39, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 19);
            this.label2.TabIndex = 59;
            this.label2.Text = "New Messages";
            // 
            // cbMessageListMessages
            // 
            this.cbMessageListMessages.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMessageListMessages.FormattingEnabled = true;
            this.cbMessageListMessages.Location = new System.Drawing.Point(43, 178);
            this.cbMessageListMessages.Name = "cbMessageListMessages";
            this.cbMessageListMessages.Size = new System.Drawing.Size(316, 27);
            this.cbMessageListMessages.TabIndex = 85;
            // 
            // tbMessageSummaryMessages
            // 
            this.tbMessageSummaryMessages.Enabled = false;
            this.tbMessageSummaryMessages.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMessageSummaryMessages.Location = new System.Drawing.Point(43, 253);
            this.tbMessageSummaryMessages.Multiline = true;
            this.tbMessageSummaryMessages.Name = "tbMessageSummaryMessages";
            this.tbMessageSummaryMessages.Size = new System.Drawing.Size(410, 67);
            this.tbMessageSummaryMessages.TabIndex = 86;
            // 
            // btnRemoveManage
            // 
            this.btnRemoveManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(72)))), ((int)(((byte)(48)))));
            this.btnRemoveManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveManage.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveManage.Location = new System.Drawing.Point(369, 599);
            this.btnRemoveManage.Name = "btnRemoveManage";
            this.btnRemoveManage.Size = new System.Drawing.Size(84, 47);
            this.btnRemoveManage.TabIndex = 87;
            this.btnRemoveManage.Text = "Remove";
            this.btnRemoveManage.UseVisualStyleBackColor = false;
            // 
            // btnOpenMessage
            // 
            this.btnOpenMessage.BackColor = System.Drawing.Color.White;
            this.btnOpenMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenMessage.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenMessage.Location = new System.Drawing.Point(383, 179);
            this.btnOpenMessage.Name = "btnOpenMessage";
            this.btnOpenMessage.Size = new System.Drawing.Size(70, 27);
            this.btnOpenMessage.TabIndex = 88;
            this.btnOpenMessage.Text = "Open";
            this.btnOpenMessage.UseVisualStyleBackColor = false;
            this.btnOpenMessage.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbMessageBodyMessages
            // 
            this.tbMessageBodyMessages.Enabled = false;
            this.tbMessageBodyMessages.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMessageBodyMessages.Location = new System.Drawing.Point(43, 341);
            this.tbMessageBodyMessages.Multiline = true;
            this.tbMessageBodyMessages.Name = "tbMessageBodyMessages";
            this.tbMessageBodyMessages.Size = new System.Drawing.Size(410, 240);
            this.tbMessageBodyMessages.TabIndex = 89;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(39, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 19);
            this.label3.TabIndex = 90;
            this.label3.Text = "Message from:";
            // 
            // lblFromIDMessages
            // 
            this.lblFromIDMessages.AutoSize = true;
            this.lblFromIDMessages.BackColor = System.Drawing.Color.Transparent;
            this.lblFromIDMessages.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFromIDMessages.ForeColor = System.Drawing.Color.White;
            this.lblFromIDMessages.Location = new System.Drawing.Point(150, 222);
            this.lblFromIDMessages.Name = "lblFromIDMessages";
            this.lblFromIDMessages.Size = new System.Drawing.Size(33, 19);
            this.lblFromIDMessages.TabIndex = 91;
            this.lblFromIDMessages.Text = "null";
            this.lblFromIDMessages.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCloseMessages
            // 
            this.lblCloseMessages.AutoSize = true;
            this.lblCloseMessages.BackColor = System.Drawing.Color.Transparent;
            this.lblCloseMessages.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCloseMessages.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(72)))), ((int)(((byte)(48)))));
            this.lblCloseMessages.Location = new System.Drawing.Point(439, 9);
            this.lblCloseMessages.Name = "lblCloseMessages";
            this.lblCloseMessages.Size = new System.Drawing.Size(44, 19);
            this.lblCloseMessages.TabIndex = 107;
            this.lblCloseMessages.Text = "Close";
            this.lblCloseMessages.Click += new System.EventHandler(this.lblCloseMessages_Click);
            // 
            // frmMessagesAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(495, 658);
            this.Controls.Add(this.lblCloseMessages);
            this.Controls.Add(this.lblFromIDMessages);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbMessageBodyMessages);
            this.Controls.Add(this.btnOpenMessage);
            this.Controls.Add(this.btnRemoveManage);
            this.Controls.Add(this.tbMessageSummaryMessages);
            this.Controls.Add(this.cbMessageListMessages);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMessagesAdmin";
            this.Text = "Messages";
            this.Load += new System.EventHandler(this.frmMessagesAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbMessageListMessages;
        private System.Windows.Forms.TextBox tbMessageSummaryMessages;
        private System.Windows.Forms.Button btnRemoveManage;
        private System.Windows.Forms.Button btnOpenMessage;
        private System.Windows.Forms.TextBox tbMessageBodyMessages;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFromIDMessages;
        public System.Windows.Forms.Label lblCloseMessages;
    }
}