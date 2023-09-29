
namespace payrollManagementSystem_G4
{
    partial class frmmanageEmployeesAndStaffs
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
            this.label2 = new System.Windows.Forms.Label();
            this.tbIDManage = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnSearchManage = new System.Windows.Forms.Button();
            this.btnInsertManage = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnRemoveManage = new System.Windows.Forms.Button();
            this.btnUpdateManage = new System.Windows.Forms.Button();
            this.ttSearchTextBox = new System.Windows.Forms.ToolTip(this.components);
            this.ttInsert = new System.Windows.Forms.ToolTip(this.components);
            this.ttUpdate = new System.Windows.Forms.ToolTip(this.components);
            this.ttRemove = new System.Windows.Forms.ToolTip(this.components);
            this.btnClearManage = new System.Windows.Forms.Button();
            this.lblSearchResultManage = new System.Windows.Forms.Label();
            this.ttClear = new System.Windows.Forms.ToolTip(this.components);
            this.lblBackManageEmployeeStaff = new System.Windows.Forms.Label();
            this.lblFullnameManage = new System.Windows.Forms.Label();
            this.lblGenderManage = new System.Windows.Forms.Label();
            this.lblContactManage = new System.Windows.Forms.Label();
            this.lblAgeManage = new System.Windows.Forms.Label();
            this.lblStatusManage = new System.Windows.Forms.Label();
            this.lblPositionManage = new System.Windows.Forms.Label();
            this.lblDepartmentManage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(39, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Search People";
            // 
            // tbIDManage
            // 
            this.tbIDManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.tbIDManage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbIDManage.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIDManage.ForeColor = System.Drawing.Color.White;
            this.tbIDManage.Location = new System.Drawing.Point(57, 188);
            this.tbIDManage.Name = "tbIDManage";
            this.tbIDManage.Size = new System.Drawing.Size(351, 22);
            this.tbIDManage.TabIndex = 8;
            this.tbIDManage.Text = "Enter ID";
            this.ttSearchTextBox.SetToolTip(this.tbIDManage, "Enter Employee ID");
            this.tbIDManage.TextChanged += new System.EventHandler(this.tbSearchPeopleManage_TextChanged);
            this.tbIDManage.GotFocus += new System.EventHandler(this.tbSearchPeople_GotFocus);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Location = new System.Drawing.Point(43, 175);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(380, 47);
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // btnSearchManage
            // 
            this.btnSearchManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSearchManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchManage.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchManage.Location = new System.Drawing.Point(429, 175);
            this.btnSearchManage.Name = "btnSearchManage";
            this.btnSearchManage.Size = new System.Drawing.Size(84, 47);
            this.btnSearchManage.TabIndex = 15;
            this.btnSearchManage.Text = "Search";
            this.btnSearchManage.UseVisualStyleBackColor = false;
            // 
            // btnInsertManage
            // 
            this.btnInsertManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(72)))), ((int)(((byte)(48)))));
            this.btnInsertManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertManage.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertManage.Location = new System.Drawing.Point(519, 231);
            this.btnInsertManage.Name = "btnInsertManage";
            this.btnInsertManage.Size = new System.Drawing.Size(84, 47);
            this.btnInsertManage.TabIndex = 16;
            this.btnInsertManage.Text = "Insert";
            this.ttInsert.SetToolTip(this.btnInsertManage, "Insert New Employee");
            this.btnInsertManage.UseVisualStyleBackColor = false;
            this.btnInsertManage.Click += new System.EventHandler(this.btnInsertManage_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(72)))), ((int)(((byte)(48)))));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 86);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(33, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 60);
            this.label1.TabIndex = 17;
            this.label1.Text = "MANAGE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(39, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 19);
            this.label3.TabIndex = 19;
            this.label3.Text = "Search result";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.pictureBox2.Location = new System.Drawing.Point(-1, 298);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(622, 333);
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(39, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 19);
            this.label4.TabIndex = 21;
            this.label4.Text = "Employee Details";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(39, 374);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 19);
            this.label5.TabIndex = 22;
            this.label5.Text = "Fullname";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(39, 406);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 19);
            this.label6.TabIndex = 23;
            this.label6.Text = "Gender";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(39, 438);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 19);
            this.label7.TabIndex = 24;
            this.label7.Text = "Age";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(39, 468);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 19);
            this.label8.TabIndex = 27;
            this.label8.Text = "Contact";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(39, 551);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 19);
            this.label9.TabIndex = 26;
            this.label9.Text = "Position";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(39, 521);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 19);
            this.label10.TabIndex = 25;
            this.label10.Text = "Department";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.label12.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(39, 580);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 19);
            this.label12.TabIndex = 28;
            this.label12.Text = "Status";
            // 
            // btnRemoveManage
            // 
            this.btnRemoveManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(72)))), ((int)(((byte)(48)))));
            this.btnRemoveManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveManage.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveManage.Location = new System.Drawing.Point(519, 559);
            this.btnRemoveManage.Name = "btnRemoveManage";
            this.btnRemoveManage.Size = new System.Drawing.Size(84, 47);
            this.btnRemoveManage.TabIndex = 30;
            this.btnRemoveManage.Text = "Remove";
            this.ttRemove.SetToolTip(this.btnRemoveManage, "Delete the Employee Record on the Database");
            this.btnRemoveManage.UseVisualStyleBackColor = false;
            // 
            // btnUpdateManage
            // 
            this.btnUpdateManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(72)))), ((int)(((byte)(48)))));
            this.btnUpdateManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateManage.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateManage.Location = new System.Drawing.Point(429, 559);
            this.btnUpdateManage.Name = "btnUpdateManage";
            this.btnUpdateManage.Size = new System.Drawing.Size(84, 47);
            this.btnUpdateManage.TabIndex = 29;
            this.btnUpdateManage.Text = "Update";
            this.ttUpdate.SetToolTip(this.btnUpdateManage, "Update Searched Employee Details");
            this.btnUpdateManage.UseVisualStyleBackColor = false;
            this.btnUpdateManage.Click += new System.EventHandler(this.btnUpdateManage_Click);
            // 
            // btnClearManage
            // 
            this.btnClearManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClearManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearManage.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearManage.Location = new System.Drawing.Point(519, 175);
            this.btnClearManage.Name = "btnClearManage";
            this.btnClearManage.Size = new System.Drawing.Size(84, 47);
            this.btnClearManage.TabIndex = 31;
            this.btnClearManage.Text = "Clear";
            this.ttClear.SetToolTip(this.btnClearManage, "Clear All Fields");
            this.btnClearManage.UseVisualStyleBackColor = false;
            this.btnClearManage.Click += new System.EventHandler(this.btnClearManage_Click);
            // 
            // lblSearchResultManage
            // 
            this.lblSearchResultManage.AutoSize = true;
            this.lblSearchResultManage.BackColor = System.Drawing.Color.Transparent;
            this.lblSearchResultManage.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchResultManage.ForeColor = System.Drawing.Color.White;
            this.lblSearchResultManage.Location = new System.Drawing.Point(160, 249);
            this.lblSearchResultManage.Name = "lblSearchResultManage";
            this.lblSearchResultManage.Size = new System.Drawing.Size(33, 19);
            this.lblSearchResultManage.TabIndex = 32;
            this.lblSearchResultManage.Text = "null";
            // 
            // lblBackManageEmployeeStaff
            // 
            this.lblBackManageEmployeeStaff.AutoSize = true;
            this.lblBackManageEmployeeStaff.BackColor = System.Drawing.Color.Transparent;
            this.lblBackManageEmployeeStaff.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBackManageEmployeeStaff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(72)))), ((int)(((byte)(48)))));
            this.lblBackManageEmployeeStaff.Location = new System.Drawing.Point(562, 9);
            this.lblBackManageEmployeeStaff.Name = "lblBackManageEmployeeStaff";
            this.lblBackManageEmployeeStaff.Size = new System.Drawing.Size(41, 19);
            this.lblBackManageEmployeeStaff.TabIndex = 76;
            this.lblBackManageEmployeeStaff.Text = "Back";
            this.lblBackManageEmployeeStaff.Click += new System.EventHandler(this.lblLogoutWelcome_Click);
            // 
            // lblFullnameManage
            // 
            this.lblFullnameManage.AutoSize = true;
            this.lblFullnameManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.lblFullnameManage.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullnameManage.ForeColor = System.Drawing.Color.White;
            this.lblFullnameManage.Location = new System.Drawing.Point(160, 374);
            this.lblFullnameManage.Name = "lblFullnameManage";
            this.lblFullnameManage.Size = new System.Drawing.Size(33, 19);
            this.lblFullnameManage.TabIndex = 98;
            this.lblFullnameManage.Text = "null";
            // 
            // lblGenderManage
            // 
            this.lblGenderManage.AutoSize = true;
            this.lblGenderManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.lblGenderManage.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenderManage.ForeColor = System.Drawing.Color.White;
            this.lblGenderManage.Location = new System.Drawing.Point(160, 406);
            this.lblGenderManage.Name = "lblGenderManage";
            this.lblGenderManage.Size = new System.Drawing.Size(33, 19);
            this.lblGenderManage.TabIndex = 99;
            this.lblGenderManage.Text = "null";
            // 
            // lblContactManage
            // 
            this.lblContactManage.AutoSize = true;
            this.lblContactManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.lblContactManage.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactManage.ForeColor = System.Drawing.Color.White;
            this.lblContactManage.Location = new System.Drawing.Point(160, 470);
            this.lblContactManage.Name = "lblContactManage";
            this.lblContactManage.Size = new System.Drawing.Size(33, 19);
            this.lblContactManage.TabIndex = 101;
            this.lblContactManage.Text = "null";
            // 
            // lblAgeManage
            // 
            this.lblAgeManage.AutoSize = true;
            this.lblAgeManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.lblAgeManage.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgeManage.ForeColor = System.Drawing.Color.White;
            this.lblAgeManage.Location = new System.Drawing.Point(160, 438);
            this.lblAgeManage.Name = "lblAgeManage";
            this.lblAgeManage.Size = new System.Drawing.Size(33, 19);
            this.lblAgeManage.TabIndex = 100;
            this.lblAgeManage.Text = "null";
            // 
            // lblStatusManage
            // 
            this.lblStatusManage.AutoSize = true;
            this.lblStatusManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.lblStatusManage.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusManage.ForeColor = System.Drawing.Color.White;
            this.lblStatusManage.Location = new System.Drawing.Point(160, 585);
            this.lblStatusManage.Name = "lblStatusManage";
            this.lblStatusManage.Size = new System.Drawing.Size(33, 19);
            this.lblStatusManage.TabIndex = 104;
            this.lblStatusManage.Text = "null";
            // 
            // lblPositionManage
            // 
            this.lblPositionManage.AutoSize = true;
            this.lblPositionManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.lblPositionManage.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPositionManage.ForeColor = System.Drawing.Color.White;
            this.lblPositionManage.Location = new System.Drawing.Point(160, 553);
            this.lblPositionManage.Name = "lblPositionManage";
            this.lblPositionManage.Size = new System.Drawing.Size(33, 19);
            this.lblPositionManage.TabIndex = 103;
            this.lblPositionManage.Text = "null";
            // 
            // lblDepartmentManage
            // 
            this.lblDepartmentManage.AutoSize = true;
            this.lblDepartmentManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.lblDepartmentManage.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartmentManage.ForeColor = System.Drawing.Color.White;
            this.lblDepartmentManage.Location = new System.Drawing.Point(160, 521);
            this.lblDepartmentManage.Name = "lblDepartmentManage";
            this.lblDepartmentManage.Size = new System.Drawing.Size(33, 19);
            this.lblDepartmentManage.TabIndex = 102;
            this.lblDepartmentManage.Text = "null";
            // 
            // frmmanageEmployeesAndStaffs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(17)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(620, 628);
            this.Controls.Add(this.lblStatusManage);
            this.Controls.Add(this.lblPositionManage);
            this.Controls.Add(this.lblDepartmentManage);
            this.Controls.Add(this.lblContactManage);
            this.Controls.Add(this.lblAgeManage);
            this.Controls.Add(this.lblGenderManage);
            this.Controls.Add(this.lblFullnameManage);
            this.Controls.Add(this.lblBackManageEmployeeStaff);
            this.Controls.Add(this.lblSearchResultManage);
            this.Controls.Add(this.btnClearManage);
            this.Controls.Add(this.btnRemoveManage);
            this.Controls.Add(this.btnUpdateManage);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInsertManage);
            this.Controls.Add(this.btnSearchManage);
            this.Controls.Add(this.tbIDManage);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmmanageEmployeesAndStaffs";
            this.Text = "Mange Employees and Staffs";
            this.Load += new System.EventHandler(this.frmmanageEmployeesAndStaffs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbIDManage;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnSearchManage;
        private System.Windows.Forms.Button btnInsertManage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnRemoveManage;
        private System.Windows.Forms.Button btnUpdateManage;
        private System.Windows.Forms.ToolTip ttSearchTextBox;
        private System.Windows.Forms.ToolTip ttInsert;
        private System.Windows.Forms.ToolTip ttRemove;
        private System.Windows.Forms.ToolTip ttUpdate;
        private System.Windows.Forms.Button btnClearManage;
        private System.Windows.Forms.Label lblSearchResultManage;
        private System.Windows.Forms.ToolTip ttClear;
        private System.Windows.Forms.Label lblFullnameManage;
        private System.Windows.Forms.Label lblGenderManage;
        private System.Windows.Forms.Label lblContactManage;
        private System.Windows.Forms.Label lblAgeManage;
        private System.Windows.Forms.Label lblStatusManage;
        private System.Windows.Forms.Label lblPositionManage;
        private System.Windows.Forms.Label lblDepartmentManage;
        public System.Windows.Forms.Label lblBackManageEmployeeStaff;
    }
}