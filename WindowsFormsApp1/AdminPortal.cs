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
    public partial class AdminPortal : Form
    {
        string connectionString = "Data Source=DESKTOP-1PPGL5P\\SQLEXPRESS;Initial Catalog=StdDB;Integrated Security = True";

        public int Id;
        public string id;
        public string name, dept, pass, gender, email;
        string dob;
        float sem, cgpa;

        long phn;

        

        DateTime dt;

        //public int Id { get { return Id; } set { Id = value; } }
        //public string email { get { return email; } set { email = value; } }


        public AdminPortal()
        {
            InitializeComponent();
        }

        private void AdminPortal_Load(object sender, EventArgs e)
        {


        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            try
            {
                Id = Convert.ToInt32(idTextBox.Text);
                SqlCommand cd = new SqlCommand("Select * from studentTab where stdID = '" + Id + "'", conn);
                SqlDataReader dr = cd.ExecuteReader();

                if (dr.Read())
                {
                    //Id = dr.GetInt32(0);
                    name = dr.GetString(1);
                    dept = dr.GetString(2);
                    sem = (float)dr.GetDouble(3);
                    cgpa = (float)dr.GetDouble(4);
                    phn = dr.GetInt64(5);
                    email = dr.GetString(6);
                    pass = dr.GetString(7);
                    gender = dr.GetString(8);
                    dt = dr.GetDateTime(9);

                    nameLabel.Text = name;
                    deptLabel.Text = dept;
                    semLabel.Text = Convert.ToString(sem);
                    cgpaLabel.Text = Convert.ToString(cgpa);
                    phnLabel.Text = Convert.ToString(phn);
                    emailLabel.Text = email;
                    passLabel.Text = pass;
                    genLabel.Text = gender;
                    dobLabel.Text = Convert.ToString(dt.ToString("dd-MM-yyyy"));
                }
            }
            catch
            {
                MessageBox.Show("Error occurred");
            }
            finally
            {
                conn.Close();
            }


        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            idLabel.Show();
            nameTextBox.Show();
            deptTextBox.Show();
            semTextBox.Show();
            cgpaTextBox.Show();
            phnTextBox.Show();
            emailTextBox.Show();
            passTextBox.Show();
            genComboBox.Show();
            dateTimePicker1.Show();

            idLabel.Text = Convert.ToString(Id);
            nameTextBox.Text = name;
            deptTextBox.Text = dept;
            semTextBox.Text = Convert.ToString(sem);
            cgpaTextBox.Text = Convert.ToString(cgpa);
            phnTextBox.Text = Convert.ToString(phn);
            emailTextBox.Text = email;
            passTextBox.Text = pass;
            genComboBox.Text = gender; 
            dt = DateTime.Parse(dateTimePicker1.Text);

            idTextBox.Hide();
            nameLabel.Hide();
            deptLabel.Hide();
            semLabel.Hide();
            cgpaLabel.Hide();
            phnLabel.Hide();
            emailLabel.Hide();
            passLabel.Hide();
            genLabel.Hide();
            dobLabel.Hide();

            btnDelete.Hide();
            btnSave.Show();
            btnEdit.Hide();
            btnCancel.Show();

            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            idLabel.Hide();
            nameTextBox.Hide();
            deptTextBox.Hide();
            semTextBox.Hide();
            cgpaTextBox.Hide();
            phnTextBox.Hide();
            emailTextBox.Hide();
            passTextBox.Hide();
            genComboBox.Hide();
            dateTimePicker1.Hide();

            idTextBox.Show();
            nameLabel.Show();
            deptLabel.Show();
            semLabel.Show();
            cgpaLabel.Show();
            phnLabel.Show();
            emailLabel.Show();
            passLabel.Show();
            genLabel.Show();
            dobLabel.Show();

            btnDelete.Show();
            btnSave.Hide();
            btnEdit.Show();
            btnCancel.Hide();

            btnSearch.PerformClick();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            try
            {
                Id = Convert.ToInt32(idTextBox.Text);
                SqlCommand cd = new SqlCommand("Delete from studentTab where stdID = '" + Id + "'", conn);
                
            }
            catch
            {

            }
            finally
            {
                conn.Close();
            }
        }
    }
}
