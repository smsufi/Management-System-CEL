using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Student_Management_System());


        }
    }

    interface StudentTable
    {
        int Id { get; set; }
        string Name { get; set; }
        string Department { get; set; }
        string Semester { get; set; }
        string Cgpa { get; set; }
        long Phone { get; set; }
        string Email { get; set; }
        string Password { get; set; }
    }

    public class stdTable : StudentTable
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public string Semester { get; set;}
        public string Cgpa { get; set; }
        public long Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        
        
    }

    


}
