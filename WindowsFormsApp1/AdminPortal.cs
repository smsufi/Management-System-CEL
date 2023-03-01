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

        

        string dt;

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
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlTransaction tr = conn.BeginTransaction())
                {
                    try
                    {
                        Id = Convert.ToInt32(idTextBox.Text);
                        SqlCommand cd = new SqlCommand("Select * from studentTab where stdID = '" + Id + "'", conn, tr);
                        cd.ExecuteNonQuery();
                        tr.Commit();
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
                            dt = Convert.ToString(dr.GetDateTime(9));

                            nameLabel.Text = name;
                            deptLabel.Text = dept;
                            semLabel.Text = Convert.ToString(sem);
                            cgpaLabel.Text = Convert.ToString(cgpa);
                            phnLabel.Text = Convert.ToString(phn);
                            emailLabel.Text = email;
                            passLabel.Text = pass;
                            genLabel.Text = gender;
                            //dobLabel.Text = Convert.ToString(dt.ToString("dd-MM-yyyy"));
                            dobLabel.Text = dt;
                        }
                        else
                        {
                            nameLabel.Text = " ";
                            deptLabel.Text = " ";
                            semLabel.Text = " ";
                            cgpaLabel.Text = " ";
                            phnLabel.Text = " ";
                            emailLabel.Text = " ";
                            passLabel.Text = " ";
                            genLabel.Text = " ";
                            dobLabel.Text = " ";

                            MessageBox.Show("No data found!");
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
            //dt = DateTime.Parse(dateTimePicker1.Text);

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
            btnUpdate.Show();
            btnEdit.Hide();
            btnCancel.Show();

            
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            idLabel.Hide();
            nameTextBox.Show();
            deptTextBox.Show();
            semTextBox.Show();
            cgpaTextBox.Show();
            phnTextBox.Show();
            emailTextBox.Show();
            passTextBox.Show();
            genComboBox.Show();
            dateTimePicker1.Show();

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

        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            name = nameTextBox.Text;
            dept = deptTextBox.Text;
            sem = (float) Convert.ToDouble(semTextBox.Text);
            cgpa = (float) Convert.ToDouble(cgpaTextBox.Text);
            phn = Convert.ToInt64(phnTextBox.Text);
            email = emailTextBox.Text;
            pass = passTextBox.Text;
            gender = genComboBox.Text;
            dt = dateTimePicker1.Value.ToString("yyyy-MM-dd");

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlTransaction tr = conn.BeginTransaction())
                {
                    try
                    {
                        SqlCommand cd  = new SqlCommand("Insert into studentTab values ( '" + name + "', '" + dept + "', '" + sem + "', '" + cgpa + "', '" + phn + "', '" + email + "', '" + pass + "', '" + gender + "', '" + dob + "') ", conn, tr);
                        cd.ExecuteNonQuery();
                        tr.Commit();
                        MessageBox.Show("Successfully Inserted!");
                    }
                    catch
                    {
                        tr.Rollback();
                        MessageBox.Show("Error Occurred");
                    }
                    finally
                    {
                        conn.Close();
                    }

                }
            }
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
            btnUpdate.Hide();
            btnEdit.Show();
            btnCancel.Hide();

            btnSearch.PerformClick();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlTransaction tr = conn.BeginTransaction())
                {
                    try
                    {
                        Id = Convert.ToInt32(idTextBox.Text);
                        SqlCommand cd = new SqlCommand("Delete from studentTab where stdID = '" + Id + "'", conn, tr);
                        cd.ExecuteNonQuery();
                        tr.Commit();
                        MessageBox.Show("Deleted Successfully!");

                        idTextBox.Clear();
                        nameLabel.Text = " ";
                        deptLabel.Text = " ";
                        semLabel.Text = " ";
                        cgpaLabel.Text = " ";
                        phnLabel.Text = " ";
                        emailLabel.Text = " ";
                        passLabel.Text = " ";
                        genLabel.Text = " ";
                        dobLabel.Text = " ";
                    }
                    catch
                    {
                        tr.Rollback();
                        MessageBox.Show("Error Occurred");
                    }
                    finally
                    {
                        conn.Close();
                    }
                }

                
            }
            
        }
    }
}
