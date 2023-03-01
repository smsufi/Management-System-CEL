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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace WindowsFormsApp1
{
    public partial class StudentPortal : Form
    {
        string connectionString = "Data Source=DESKTOP-1PPGL5P\\SQLEXPRESS;Initial Catalog=StdDB;Integrated Security = True";


        public int Id;
        public string id;
        public string name, dept, email, pass, gender;
        string dob;
        float sem, cgpa;
        long phn;
        DateTime dt;
        

        public string setEmail { get { return email; } set { email = value; } }
        public string setId { get { return id; } set { id = value; } }

        public StudentPortal()
        {
            InitializeComponent();
        }

        private void StudentPortal_Load(object sender, EventArgs e)
        {
            btnSave.Hide();
            emailTextBox.Text = email;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlTransaction tr = conn.BeginTransaction())
                {
                    try
                    {
                        SqlCommand cd = new SqlCommand("Select * from studentTab where stdID = '" + id + "'", conn, tr);
                        cd.ExecuteNonQuery();
                        tr.Commit();
                        SqlDataReader dr = cd.ExecuteReader();
                        if (dr.Read())
                        {

                            Id = dr.GetInt32(0);
                            name = dr.GetString(1);
                            dept = dr.GetString(2);
                            sem = (float)dr.GetDouble(3);
                            cgpa = (float)dr.GetDouble(4);
                            phn = dr.GetInt64(5);
                            pass = dr.GetString(7);
                            gender = dr.GetString(8);
                            //dob = dr.GetString(9);
                            dt = dr.GetDateTime(9);


                            IdLabel.Text = Convert.ToString(id);
                            deptLabel.Text = dept;
                            semLabel.Text = Convert.ToString(sem);
                            cgpaLabel.Text = Convert.ToString(cgpa);

                            nameLabel.Text = name;
                            phoneLabel.Text = Convert.ToString(phn);
                            emailLabel.Text = email;
                            passLabel.Text = pass;
                            genderLabel.Text = gender;
                            //dateTimePicker1.Text = dob;
                            dobLabel.Text = Convert.ToString(dt.ToString("dd-MM-yyyy"));
                        }
                    }
                    catch
                    {
                        tr.Rollback();
                        MessageBox.Show("Error occurred");
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
                
            
        }
        private void IdLabel_Click(object sender, EventArgs e)
        {

        }

        private void deptLabel_Click(object sender, EventArgs e)
        {

        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passTextBox_TextChanged(object sender, EventArgs e)
        {
            passTextBox.PasswordChar = '\0';
        }

        private void eyeBtn_Click(object sender, EventArgs e)
        {
            if (passTextBox.PasswordChar == '*')
            {
                hideBtn.BringToFront();
                passTextBox.PasswordChar = '\0';
            }
        }

        private void genComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            StudentLogin f = new StudentLogin();
            f.Show();
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            nameTextBox.Text = name;            
            phnTextBox.Text = Convert.ToString(phn);
            emailTextBox.Text = email;
            passTextBox.Text = pass;
            genComboBox.Text = gender;
            dt = DateTime.Parse(dateTimePicker1.Text);
            //dtTextBox.Text = Convert.ToString(dt.ToString("dd-MM-yyyy"));
            nameLabel.Hide();
            genderLabel.Hide();
            dobLabel.Hide();
            emailLabel.Hide();
            phoneLabel.Hide();
            dobLabel.Hide();
            passLabel.Hide();
            btnCancel.BringToFront();
            btnSave.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlTransaction tr = conn.BeginTransaction())
                {
                    try
                    {
                        //id = IdLabel.Text;
                        Id = Convert.ToInt32(IdLabel.Text);
                        name = nameTextBox.Text;
                        dept = deptLabel.Text;
                        //sem = (float) Convert.ToDouble(semLabel.Text);
                        //cgpa = (float)Convert.ToDouble(cgpaLabel.Text);
                        phn = Convert.ToInt32(phnTextBox.Text);
                        email = emailTextBox.Text;
                        pass = passTextBox.Text;
                        gender = genComboBox.Text;
                        dt = DateTime.Parse(dateTimePicker1.Text);

                        SqlCommand cd = new SqlCommand("Update studentTab set stdName = '" + name + "' where stdID = '" + Id + "'", conn, tr);
                        cd.ExecuteNonQuery();
                        tr.Commit();
                        MessageBox.Show("Successfully Updated!");

                    }
                    catch
                    {
                        tr.Rollback();
                        MessageBox.Show("Error occurred");
                    }
                    finally
                    {
                        conn.Close();


                    }
                }
            }
                

            


        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void genderLabel_Click(object sender, EventArgs e)
        {

        }

        private void dobLabel_Click(object sender, EventArgs e)
        {

        }

        private void emailLabel_Click(object sender, EventArgs e)
        {

        }

        private void phoneLabel_Click(object sender, EventArgs e)
        {

        }

        private void passLabel_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            nameLabel.Show();
            genderLabel.Show();
            dobLabel.Show();
            emailLabel.Show();
            phoneLabel.Show();
            passLabel.Show();
            btnEdit.BringToFront();
            btnSave.Hide();
        }

        

        private void hideBtn_Click(object sender, EventArgs e)
        {
            if (passTextBox.PasswordChar == '\0')
            {
                eyeBtn.BringToFront();
                passTextBox.PasswordChar = '*';
            }
        }

        private void phnTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void semLabel_Click(object sender, EventArgs e)
        {

        }

        private void cgpaLabel_Click(object sender, EventArgs e)
        {

        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
