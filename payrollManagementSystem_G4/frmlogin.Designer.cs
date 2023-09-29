
namespace payrollManagementSystem_G4
{
    partial class frmLogin
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPassLogin = new System.Windows.Forms.TextBox();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRequestPassReset = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tbIDLogin = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblLoginEmptyError = new System.Windows.Forms.Label();
            this.rbEmployee = new System.Windows.Forms.RadioButton();
            this.rbAdmin = new System.Windows.Forms.RadioButton();
            this.ttIDLogin = new System.Windows.Forms.ToolTip(this.components);
            this.ttPasswordLogin = new System.Windows.Forms.ToolTip(this.components);
            this.btnClearLogin = new System.Windows.Forms.Button();
            this.ttRequestReset = new System.Windows.Forms.ToolTip(this.components);
            this.ttClear = new System.Windows.Forms.ToolTip(this.components);
            this.lblChooseLogin = new System.Windows.Forms.Label();
            this.lblExitLogin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(72)))), ((int)(((byte)(48)))));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 86);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(33, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGIN AS";
            // 
            // tbPassLogin
            // 
            this.tbPassLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.tbPassLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPassLogin.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassLogin.ForeColor = System.Drawing.Color.White;
            this.tbPassLogin.Location = new System.Drawing.Point(34, 351);
            this.tbPassLogin.Name = "tbPassLogin";
            this.tbPassLogin.Size = new System.Drawing.Size(316, 22);
            this.tbPassLogin.TabIndex = 3;
            this.tbPassLogin.Text = "Password";
            this.ttPasswordLogin.SetToolTip(this.tbPassLogin, "Enter your password");
            this.tbPassLogin.Click += new System.EventHandler(this.tbPassLogin_GotFocus);
            this.tbPassLogin.TextChanged += new System.EventHandler(this.tbPassLogin_TextChanged);
            // 
            // btnSignIn
            // 
            this.btnSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(72)))), ((int)(((byte)(48)))));
            this.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignIn.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn.Location = new System.Drawing.Point(18, 425);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(273, 47);
            this.btnSignIn.TabIndex = 5;
            this.btnSignIn.Text = "SIGN IN";
            this.btnSignIn.UseVisualStyleBackColor = false;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(18, 520);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Forgot Password?";
            // 
            // lblRequestPassReset
            // 
            this.lblRequestPassReset.AutoSize = true;
            this.lblRequestPassReset.BackColor = System.Drawing.Color.Transparent;
            this.lblRequestPassReset.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequestPassReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(72)))), ((int)(((byte)(48)))));
            this.lblRequestPassReset.Location = new System.Drawing.Point(247, 520);
            this.lblRequestPassReset.Name = "lblRequestPassReset";
            this.lblRequestPassReset.Size = new System.Drawing.Size(105, 19);
            this.lblRequestPassReset.TabIndex = 7;
            this.lblRequestPassReset.Text = "Request Reset";
            this.ttRequestReset.SetToolTip(this.lblRequestPassReset, "Request a Password Reset");
            this.lblRequestPassReset.Click += new System.EventHandler(this.lblRequestPassReset_Click);
            this.lblRequestPassReset.MouseLeave += new System.EventHandler(this.lblRequestPassReset_MouseLeave);
            this.lblRequestPassReset.MouseHover += new System.EventHandler(this.lblRequestPassReset_MouseHover);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(18, 339);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(334, 47);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // tbIDLogin
            // 
            this.tbIDLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.tbIDLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbIDLogin.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIDLogin.ForeColor = System.Drawing.Color.White;
            this.tbIDLogin.Location = new System.Drawing.Point(35, 288);
            this.tbIDLogin.Name = "tbIDLogin";
            this.tbIDLogin.Size = new System.Drawing.Size(316, 22);
            this.tbIDLogin.TabIndex = 9;
            this.tbIDLogin.Text = "User ID";
            this.ttIDLogin.SetToolTip(this.tbIDLogin, "Enter your ID");
            this.tbIDLogin.Click += new System.EventHandler(this.tbIDLogin_GotFocus);
            this.tbIDLogin.TextChanged += new System.EventHandler(this.tbIDLogin_TextChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Location = new System.Drawing.Point(18, 275);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(334, 47);
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // lblLoginEmptyError
            // 
            this.lblLoginEmptyError.AutoSize = true;
            this.lblLoginEmptyError.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginEmptyError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(60)))), ((int)(((byte)(62)))));
            this.lblLoginEmptyError.Location = new System.Drawing.Point(129, 401);
            this.lblLoginEmptyError.Name = "lblLoginEmptyError";
            this.lblLoginEmptyError.Size = new System.Drawing.Size(115, 15);
            this.lblLoginEmptyError.TabIndex = 11;
            this.lblLoginEmptyError.Text = "Required login input";
            this.lblLoginEmptyError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rbEmployee
            // 
            this.rbEmployee.AutoSize = true;
            this.rbEmployee.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEmployee.ForeColor = System.Drawing.Color.White;
            this.rbEmployee.Location = new System.Drawing.Point(18, 202);
            this.rbEmployee.Name = "rbEmployee";
            this.rbEmployee.Size = new System.Drawing.Size(94, 23);
            this.rbEmployee.TabIndex = 12;
            this.rbEmployee.TabStop = true;
            this.rbEmployee.Text = "Employee";
            this.rbEmployee.UseVisualStyleBackColor = true;
            // 
            // rbAdmin
            // 
            this.rbAdmin.AutoSize = true;
            this.rbAdmin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAdmin.ForeColor = System.Drawing.Color.White;
            this.rbAdmin.Location = new System.Drawing.Point(18, 176);
            this.rbAdmin.Name = "rbAdmin";
            this.rbAdmin.Size = new System.Drawing.Size(72, 23);
            this.rbAdmin.TabIndex = 13;
            this.rbAdmin.TabStop = true;
            this.rbAdmin.Text = "Admin";
            this.rbAdmin.UseVisualStyleBackColor = true;
            // 
            // btnClearLogin
            // 
            this.btnClearLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(72)))), ((int)(((byte)(48)))));
            this.btnClearLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearLogin.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearLogin.Location = new System.Drawing.Point(297, 425);
            this.btnClearLogin.Name = "btnClearLogin";
            this.btnClearLogin.Size = new System.Drawing.Size(53, 47);
            this.btnClearLogin.TabIndex = 14;
            this.btnClearLogin.Text = "C";
            this.ttClear.SetToolTip(this.btnClearLogin, "Clear All Fields");
            this.btnClearLogin.UseVisualStyleBackColor = false;
            this.btnClearLogin.Click += new System.EventHandler(this.btnClearLogin_Click);
            // 
            // lblChooseLogin
            // 
            this.lblChooseLogin.AutoSize = true;
            this.lblChooseLogin.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChooseLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(60)))), ((int)(((byte)(62)))));
            this.lblChooseLogin.Location = new System.Drawing.Point(31, 228);
            this.lblChooseLogin.Name = "lblChooseLogin";
            this.lblChooseLogin.Size = new System.Drawing.Size(101, 15);
            this.lblChooseLogin.TabIndex = 15;
            this.lblChooseLogin.Text = "Selection required";
            this.lblChooseLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblExitLogin
            // 
            this.lblExitLogin.AutoSize = true;
            this.lblExitLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblExitLogin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExitLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(72)))), ((int)(((byte)(48)))));
            this.lblExitLogin.Location = new System.Drawing.Point(323, 9);
            this.lblExitLogin.Name = "lblExitLogin";
            this.lblExitLogin.Size = new System.Drawing.Size(34, 19);
            this.lblExitLogin.TabIndex = 75;
            this.lblExitLogin.Text = "Exit";
            this.lblExitLogin.Click += new System.EventHandler(this.lblExitLogin_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(369, 557);
            this.Controls.Add(this.lblExitLogin);
            this.Controls.Add(this.lblChooseLogin);
            this.Controls.Add(this.btnClearLogin);
            this.Controls.Add(this.rbAdmin);
            this.Controls.Add(this.rbEmployee);
            this.Controls.Add(this.lblLoginEmptyError);
            this.Controls.Add(this.tbIDLogin);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.tbPassLogin);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblRequestPassReset);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.Text = "Account Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPassLogin;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRequestPassReset;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox tbIDLogin;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblLoginEmptyError;
        private System.Windows.Forms.RadioButton rbEmployee;
        private System.Windows.Forms.RadioButton rbAdmin;
        private System.Windows.Forms.ToolTip ttIDLogin;
        private System.Windows.Forms.ToolTip ttPasswordLogin;
        private System.Windows.Forms.Button btnClearLogin;
        private System.Windows.Forms.ToolTip ttRequestReset;
        private System.Windows.Forms.ToolTip ttClear;
        private System.Windows.Forms.Label lblChooseLogin;
        private System.Windows.Forms.Label lblExitLogin;
    }
}

