namespace WindowsFormsApp1
{
    partial class Student_Management_System
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
            this.btnAdminLogin = new System.Windows.Forms.Button();
            this.btnStudentLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdminLogin
            // 
            this.btnAdminLogin.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAdminLogin.Font = new System.Drawing.Font("Arial", 15F);
            this.btnAdminLogin.Location = new System.Drawing.Point(319, 120);
            this.btnAdminLogin.Name = "btnAdminLogin";
            this.btnAdminLogin.Size = new System.Drawing.Size(153, 76);
            this.btnAdminLogin.TabIndex = 0;
            this.btnAdminLogin.Text = "Admin Login";
            this.btnAdminLogin.UseVisualStyleBackColor = false;
            this.btnAdminLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnStudentLogin
            // 
            this.btnStudentLogin.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnStudentLogin.Font = new System.Drawing.Font("Arial", 15F);
            this.btnStudentLogin.Location = new System.Drawing.Point(319, 266);
            this.btnStudentLogin.Name = "btnStudentLogin";
            this.btnStudentLogin.Size = new System.Drawing.Size(153, 76);
            this.btnStudentLogin.TabIndex = 1;
            this.btnStudentLogin.Text = "Student Login";
            this.btnStudentLogin.UseVisualStyleBackColor = false;
            this.btnStudentLogin.Click += new System.EventHandler(this.btnStudentLogin_Click);
            // 
            // Student_Management_System
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStudentLogin);
            this.Controls.Add(this.btnAdminLogin);
            this.Name = "Student_Management_System";
            this.Text = "Student_Management_System";
            this.Load += new System.EventHandler(this.Student_Management_System_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdminLogin;
        private System.Windows.Forms.Button btnStudentLogin;
    }
}