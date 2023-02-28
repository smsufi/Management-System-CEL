using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class StudentLogin : Form
    {
        public StudentLogin()
        {
            InitializeComponent();
            radioBtnEmail.Checked = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-1PPGL5P\\SQLEXPRESS;Initial Catalog=StdDB;Integrated Security = True";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            string id;
            string phn;
            string mail, pass;
            id = textBox3.Text;
            phn = textBox1.Text;
            mail = textBox1.Text;
            pass = textBox2.Text;

            try
            {
                if(btnRadio)
                {
                    SqlCommand cd = new SqlCommand("Select * from studentTab where stdID = '" + id + "' and stdEmail = '" + mail + "' and stdPassword = '" + pass + "'", conn);
                    SqlDataReader dr = cd.ExecuteReader();



                    if (dr.Read())
                    {
                        StudentPortal f = new StudentPortal();
                        f.setId = textBox3.Text;
                        f.setEmail = textBox1.Text;
                        f.Show();
                        this.Hide();
                    }
                    else
                        MessageBox.Show("Invalid Id or Email or Password");

                }
                else if (!btnRadio) 
                {
                    SqlCommand cd = new SqlCommand("Select * from studentTab where stdID = '" + id + "' and stdPhone = '" + phn + "' and stdPassword = '" + pass + "'", conn);
                    SqlDataReader dr = cd.ExecuteReader();

                    if (dr.Read())
                    {
                        StudentPortal f = new StudentPortal();
                        f.Show();
                        this.Hide();
                    }
                    else
                        MessageBox.Show("Invalid Id or Phone or Password");
                }
            }
            catch { MessageBox.Show("Error occurred"); }
            finally { conn.Close(); }



        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            Student_Management_System f2 = new Student_Management_System();
            f2.Show();
            this.Hide();
        }

        bool btnRadio;
        private void radioBtnEmail_CheckedChanged(object sender, EventArgs e)
        {
            btnRadio = true;
        }

        private void radioBtnPhone_CheckedChanged(object sender, EventArgs e)
        {
            btnRadio = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox2.PasswordChar == '*')
            {
                button3.BringToFront();
                textBox2.PasswordChar = '\0';
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar == '\0')
            {
                button2.BringToFront();
                textBox2.PasswordChar = '*';
            }
        }

        private void StudentLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
