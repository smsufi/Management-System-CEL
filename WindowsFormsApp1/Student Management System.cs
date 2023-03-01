using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Student_Management_System : Form
    {
        public Student_Management_System()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminLogin f2 = new AdminLogin();
            f2.Show();
            this.Hide();
        }

        private void btnStudentLogin_Click(object sender, EventArgs e)
        {
            StudentLogin f3 = new StudentLogin();
            f3.Show();
            this.Hide();
        }

        private void Student_Management_System_Load(object sender, EventArgs e)
        {

        }
    }
}
