using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WindowsFormsApp1
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
            radioButton1.Checked = true;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-1PPGL5P\\SQLEXPRESS;Initial Catalog=StdDB;Integrated Security = True";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            //SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-1PPGL5P\SQLEXPRESS;Initial Catalog=StdDB;Integrated Security = True");


            long mbl;
            string mail, pass;
            mail = textBox1.Text;
            mbl = Convert.ToInt64(textBox1.Text);
            pass = textBox2.Text;
            
            try
            {
                /*string query = "Select * from adminTab where admEmail = '" + mail + "' and admPassword = '" + pass + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);*/

                if (btnRadio)
                {
                    SqlCommand command = new SqlCommand("Select * from adminTab where admEmail = '" + mail + "' and admPassword = '" + pass + "'", conn);
                    SqlDataReader dr = command.ExecuteReader();
                    if (dr.Read())
                    {
                        AdminPortal f2 = new AdminPortal();
                        f2.Show();
                        this.Hide();
                    }
                    else
                        MessageBox.Show("Invalid Email or Password");
                    
                }
                else if (!btnRadio)
                {
                    SqlCommand command = new SqlCommand("Select * from adminTab where admMobile = '" + mbl + "' and admPassword = '" + pass + "'", conn);
                    SqlDataReader dr = command.ExecuteReader();
                    if (dr.Read())
                    {
                        AdminPortal f2 = new AdminPortal();
                        f2.Show();
                        this.Hide();
                    }
                    else
                        MessageBox.Show("Invalid Phone or Password");
                }
                //SqlCommand command = new SqlCommand("Select * from adminTab where admEmail = '" + mail + "' and admPassword = '" + pass + "'", conn);
                //SqlDataReader dr = command.ExecuteReader();

                /*if (dt.Rows.Count > 0)
                if (dr.Read())
                {
                    Form2 f2 = new Form2();
                    f2.Show();
                    this.Hide();
                }*/
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar == '*')
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

        bool btnRadio;
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            btnRadio = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            btnRadio = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Student_Management_System f1 = new Student_Management_System();
            f1.Show();
            this.Hide();
        }
    }
}
