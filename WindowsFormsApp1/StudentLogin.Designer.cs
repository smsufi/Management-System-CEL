namespace WindowsFormsApp1
{
    partial class StudentLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioBtnPhone = new System.Windows.Forms.RadioButton();
            this.radioBtnEmail = new System.Windows.Forms.RadioButton();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.panel1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(29, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(429, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Login Panel";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Green;
            this.btnLogin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(199, 325);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(135, 58);
            this.btnLogin.TabIndex = 11;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(497, 190);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(212, 27);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Black;
            this.textBox2.Location = new System.Drawing.Point(497, 243);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(212, 27);
            this.textBox2.TabIndex = 10;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioBtnPhone);
            this.groupBox1.Controls.Add(this.radioBtnEmail);
            this.groupBox1.Location = new System.Drawing.Point(62, 159);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 111);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Email/Phone ";
            // 
            // radioBtnPhone
            // 
            this.radioBtnPhone.AutoSize = true;
            this.radioBtnPhone.Location = new System.Drawing.Point(50, 69);
            this.radioBtnPhone.Name = "radioBtnPhone";
            this.radioBtnPhone.Size = new System.Drawing.Size(121, 20);
            this.radioBtnPhone.TabIndex = 1;
            this.radioBtnPhone.TabStop = true;
            this.radioBtnPhone.Text = "Login by Phone";
            this.radioBtnPhone.UseVisualStyleBackColor = true;
            this.radioBtnPhone.CheckedChanged += new System.EventHandler(this.radioBtnPhone_CheckedChanged);
            // 
            // radioBtnEmail
            // 
            this.radioBtnEmail.AutoSize = true;
            this.radioBtnEmail.Location = new System.Drawing.Point(50, 32);
            this.radioBtnEmail.Name = "radioBtnEmail";
            this.radioBtnEmail.Size = new System.Drawing.Size(116, 20);
            this.radioBtnEmail.TabIndex = 0;
            this.radioBtnEmail.TabStop = true;
            this.radioBtnEmail.Text = "Login by Email";
            this.radioBtnEmail.UseVisualStyleBackColor = true;
            this.radioBtnEmail.CheckedChanged += new System.EventHandler(this.radioBtnEmail_CheckedChanged);
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.BackColor = System.Drawing.Color.DarkRed;
            this.btnMainMenu.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMenu.ForeColor = System.Drawing.Color.White;
            this.btnMainMenu.Location = new System.Drawing.Point(433, 325);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(188, 58);
            this.btnMainMenu.TabIndex = 18;
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = false;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gainsboro;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(684, 243);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 27);
            this.button2.TabIndex = 16;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(360, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(360, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Email/Phone";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gainsboro;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(684, 243);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(25, 27);
            this.button3.TabIndex = 17;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(360, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Student ID";
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.Black;
            this.textBox3.Location = new System.Drawing.Point(497, 139);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(212, 27);
            this.textBox3.TabIndex = 20;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // StudentLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox2);
            this.Name = "StudentLogin";
            this.Text = "Student Login Form";
            this.Load += new System.EventHandler(this.StudentLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioBtnPhone;
        private System.Windows.Forms.RadioButton radioBtnEmail;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
    }
}