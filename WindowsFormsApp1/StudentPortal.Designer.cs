namespace WindowsFormsApp1
{
    partial class StudentPortal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentPortal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelId = new System.Windows.Forms.Label();
            this.cgpaLabel = new System.Windows.Forms.Label();
            this.semLabel = new System.Windows.Forms.Label();
            this.deptLabel = new System.Windows.Forms.Label();
            this.IdLabel = new System.Windows.Forms.Label();
            this.labelCgpa = new System.Windows.Forms.Label();
            this.labelSem = new System.Windows.Forms.Label();
            this.labelDept = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.genComboBox = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.phnTextBox = new System.Windows.Forms.TextBox();
            this.passTextBox = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.eyeBtn = new System.Windows.Forms.Button();
            this.hideBtn = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.dobLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.passLabel = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(47)))), ((int)(((byte)(85)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 103);
            this.panel1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(29, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Portal";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.labelId);
            this.panel2.Controls.Add(this.cgpaLabel);
            this.panel2.Controls.Add(this.semLabel);
            this.panel2.Controls.Add(this.deptLabel);
            this.panel2.Controls.Add(this.IdLabel);
            this.panel2.Controls.Add(this.labelCgpa);
            this.panel2.Controls.Add(this.labelSem);
            this.panel2.Controls.Add(this.labelDept);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 103);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(232, 347);
            this.panel2.TabIndex = 15;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelId.Location = new System.Drawing.Point(27, 22);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(98, 19);
            this.labelId.TabIndex = 25;
            this.labelId.Text = "Student ID:";
            // 
            // cgpaLabel
            // 
            this.cgpaLabel.AutoSize = true;
            this.cgpaLabel.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cgpaLabel.Location = new System.Drawing.Point(36, 270);
            this.cgpaLabel.Name = "cgpaLabel";
            this.cgpaLabel.Size = new System.Drawing.Size(125, 19);
            this.cgpaLabel.TabIndex = 24;
            this.cgpaLabel.Text = "Student\'s CGPA";
            this.cgpaLabel.Click += new System.EventHandler(this.cgpaLabel_Click);
            // 
            // semLabel
            // 
            this.semLabel.AutoSize = true;
            this.semLabel.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.semLabel.Location = new System.Drawing.Point(36, 197);
            this.semLabel.Name = "semLabel";
            this.semLabel.Size = new System.Drawing.Size(149, 19);
            this.semLabel.TabIndex = 23;
            this.semLabel.Text = "Student\'s Semester";
            this.semLabel.Click += new System.EventHandler(this.semLabel_Click);
            // 
            // deptLabel
            // 
            this.deptLabel.AutoSize = true;
            this.deptLabel.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deptLabel.Location = new System.Drawing.Point(36, 124);
            this.deptLabel.Name = "deptLabel";
            this.deptLabel.Size = new System.Drawing.Size(164, 19);
            this.deptLabel.TabIndex = 22;
            this.deptLabel.Text = "Student\'s Department";
            this.deptLabel.Click += new System.EventHandler(this.deptLabel_Click);
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdLabel.Location = new System.Drawing.Point(36, 53);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(97, 19);
            this.IdLabel.TabIndex = 21;
            this.IdLabel.Text = "Student\'s ID";
            this.IdLabel.Click += new System.EventHandler(this.IdLabel_Click);
            // 
            // labelCgpa
            // 
            this.labelCgpa.AutoSize = true;
            this.labelCgpa.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCgpa.Location = new System.Drawing.Point(27, 236);
            this.labelCgpa.Name = "labelCgpa";
            this.labelCgpa.Size = new System.Drawing.Size(61, 19);
            this.labelCgpa.TabIndex = 19;
            this.labelCgpa.Text = "CGPA:";
            // 
            // labelSem
            // 
            this.labelSem.AutoSize = true;
            this.labelSem.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSem.Location = new System.Drawing.Point(27, 161);
            this.labelSem.Name = "labelSem";
            this.labelSem.Size = new System.Drawing.Size(89, 19);
            this.labelSem.TabIndex = 18;
            this.labelSem.Text = "Semester:";
            // 
            // labelDept
            // 
            this.labelDept.AutoSize = true;
            this.labelDept.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDept.Location = new System.Drawing.Point(27, 88);
            this.labelDept.Name = "labelDept";
            this.labelDept.Size = new System.Drawing.Size(107, 19);
            this.labelDept.TabIndex = 17;
            this.labelDept.Text = "Department:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(391, 125);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(59, 19);
            this.labelName.TabIndex = 16;
            this.labelName.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(377, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 25;
            this.label2.Text = "Gender:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(335, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 19);
            this.label3.TabIndex = 26;
            this.label3.Text = "Date of Birth:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(393, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 19);
            this.label4.TabIndex = 27;
            this.label4.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(385, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 19);
            this.label5.TabIndex = 28;
            this.label5.Text = "Phone:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(357, 324);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 19);
            this.label6.TabIndex = 29;
            this.label6.Text = "Password:";
            // 
            // genComboBox
            // 
            this.genComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genComboBox.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genComboBox.FormattingEnabled = true;
            this.genComboBox.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.genComboBox.Location = new System.Drawing.Point(497, 159);
            this.genComboBox.Name = "genComboBox";
            this.genComboBox.Size = new System.Drawing.Size(176, 24);
            this.genComboBox.TabIndex = 30;
            this.genComboBox.SelectedIndexChanged += new System.EventHandler(this.genComboBox_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(497, 201);
            this.dateTimePicker1.MaxDate = new System.DateTime(2029, 12, 25, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(176, 22);
            this.dateTimePicker1.TabIndex = 31;
            this.dateTimePicker1.Value = new System.DateTime(2023, 3, 1, 0, 0, 0, 0);
            // 
            // emailTextBox
            // 
            this.emailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailTextBox.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.Location = new System.Drawing.Point(497, 241);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(176, 22);
            this.emailTextBox.TabIndex = 32;
            this.emailTextBox.TextChanged += new System.EventHandler(this.emailTextBox_TextChanged);
            // 
            // phnTextBox
            // 
            this.phnTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phnTextBox.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phnTextBox.Location = new System.Drawing.Point(497, 281);
            this.phnTextBox.Name = "phnTextBox";
            this.phnTextBox.Size = new System.Drawing.Size(176, 22);
            this.phnTextBox.TabIndex = 33;
            this.phnTextBox.TextChanged += new System.EventHandler(this.phnTextBox_TextChanged);
            // 
            // passTextBox
            // 
            this.passTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passTextBox.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passTextBox.Location = new System.Drawing.Point(497, 321);
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.Size = new System.Drawing.Size(176, 22);
            this.passTextBox.TabIndex = 34;
            this.passTextBox.TextChanged += new System.EventHandler(this.passTextBox_TextChanged);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnEdit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(290, 373);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(110, 48);
            this.btnEdit.TabIndex = 35;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DarkGreen;
            this.btnSave.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(447, 373);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(111, 48);
            this.btnSave.TabIndex = 36;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.DarkRed;
            this.btnLogout.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(601, 373);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(112, 48);
            this.btnLogout.TabIndex = 37;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameTextBox.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(497, 122);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(176, 22);
            this.nameTextBox.TabIndex = 38;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // eyeBtn
            // 
            this.eyeBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.eyeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eyeBtn.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eyeBtn.ForeColor = System.Drawing.Color.Black;
            this.eyeBtn.Image = ((System.Drawing.Image)(resources.GetObject("eyeBtn.Image")));
            this.eyeBtn.Location = new System.Drawing.Point(647, 321);
            this.eyeBtn.Name = "eyeBtn";
            this.eyeBtn.Size = new System.Drawing.Size(26, 22);
            this.eyeBtn.TabIndex = 39;
            this.eyeBtn.UseVisualStyleBackColor = false;
            this.eyeBtn.Click += new System.EventHandler(this.eyeBtn_Click);
            // 
            // hideBtn
            // 
            this.hideBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.hideBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hideBtn.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hideBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.hideBtn.Image = ((System.Drawing.Image)(resources.GetObject("hideBtn.Image")));
            this.hideBtn.Location = new System.Drawing.Point(647, 321);
            this.hideBtn.Name = "hideBtn";
            this.hideBtn.Size = new System.Drawing.Size(26, 22);
            this.hideBtn.TabIndex = 40;
            this.hideBtn.UseVisualStyleBackColor = false;
            this.hideBtn.Click += new System.EventHandler(this.hideBtn_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(497, 122);
            this.nameLabel.MinimumSize = new System.Drawing.Size(180, 25);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(180, 25);
            this.nameLabel.TabIndex = 26;
            this.nameLabel.Text = "Student\'s Name";
            this.nameLabel.Click += new System.EventHandler(this.nameLabel_Click);
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderLabel.Location = new System.Drawing.Point(497, 159);
            this.genderLabel.MinimumSize = new System.Drawing.Size(180, 30);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(180, 30);
            this.genderLabel.TabIndex = 42;
            this.genderLabel.Text = "Student\'s Gender";
            this.genderLabel.Click += new System.EventHandler(this.genderLabel_Click);
            // 
            // dobLabel
            // 
            this.dobLabel.AutoSize = true;
            this.dobLabel.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobLabel.Location = new System.Drawing.Point(497, 201);
            this.dobLabel.MinimumSize = new System.Drawing.Size(180, 25);
            this.dobLabel.Name = "dobLabel";
            this.dobLabel.Size = new System.Drawing.Size(180, 25);
            this.dobLabel.TabIndex = 43;
            this.dobLabel.Text = "Student\'s DOB";
            this.dobLabel.Click += new System.EventHandler(this.dobLabel_Click);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(497, 241);
            this.emailLabel.MinimumSize = new System.Drawing.Size(180, 25);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(180, 25);
            this.emailLabel.TabIndex = 44;
            this.emailLabel.Text = "Student\'s Email";
            this.emailLabel.Click += new System.EventHandler(this.emailLabel_Click);
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLabel.Location = new System.Drawing.Point(497, 281);
            this.phoneLabel.MinimumSize = new System.Drawing.Size(180, 25);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(180, 25);
            this.phoneLabel.TabIndex = 45;
            this.phoneLabel.Text = "Student\'s Phone";
            this.phoneLabel.Click += new System.EventHandler(this.phoneLabel_Click);
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passLabel.Location = new System.Drawing.Point(497, 321);
            this.passLabel.MinimumSize = new System.Drawing.Size(180, 25);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(180, 25);
            this.passLabel.TabIndex = 46;
            this.passLabel.Text = "Student\'s Password";
            this.passLabel.Click += new System.EventHandler(this.passLabel_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(290, 373);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 48);
            this.btnCancel.TabIndex = 47;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // StudentPortal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.hideBtn);
            this.Controls.Add(this.eyeBtn);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.passTextBox);
            this.Controls.Add(this.phnTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.dobLabel);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.genderLabel);
            this.Controls.Add(this.genComboBox);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnCancel);
            this.Name = "StudentPortal";
            this.Text = "Student Portal";
            this.Load += new System.EventHandler(this.StudentPortal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label cgpaLabel;
        private System.Windows.Forms.Label semLabel;
        private System.Windows.Forms.Label deptLabel;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Label labelCgpa;
        private System.Windows.Forms.Label labelSem;
        private System.Windows.Forms.Label labelDept;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox genComboBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox phnTextBox;
        private System.Windows.Forms.TextBox passTextBox;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button eyeBtn;
        private System.Windows.Forms.Button hideBtn;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Label dobLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.Button btnCancel;
    }
}