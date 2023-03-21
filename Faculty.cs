using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Login_Window
{
    public partial class Faculty : System.Windows.Forms.Form
    {

       List<String> assignedCourse = new List<String>(); // a local variable that I can pass between lists


        public Faculty(string user)
        {
            InitializeComponent();
            string FacultyName;
            FacultyName = user;
            List<String> Coursedatabase = new List<String>();
            var Courselist = new Dictionary<int, dynamic>();
            string[] lines2 = System.IO.File.ReadAllLines(@"C:\Users\katie\OneDrive\Desktop\Databases SE\CourseDatabase.txt");
            System.Console.WriteLine("Contents of Course database");

            foreach (string line in lines2)
            {
                // Use a tab to indent each line of the file.
                Coursedatabase.Add(line);
                Console.WriteLine("\n" + line);
            }

            for (int i = 0; i < Coursedatabase.Count; i++)
            {
                string[] Coursestring = Coursedatabase[i].Split(' ');
                string courseName = Coursestring[0];
                string courseTitle = Coursestring[1];
                string instructor = Coursestring[2];
                string courseCredit = Coursestring[3];
                string numSeats = Coursestring[4];
                string numTimeBlock1 = Coursestring[5];
                string numTimeBlock2 = Coursestring[6];
                //string numTimeBlock3 = Coursestring[7];
                dynamic d1 = new System.Dynamic.ExpandoObject();
                Courselist[i] = d1;
                Courselist[i].courses = "User" + i;
                Courselist[i].courses = new { coursename = courseName, coursetitle = courseTitle, instructorname = instructor, courseCreditNum = courseCredit, nSeats = numSeats, nTime1 = numTimeBlock1, nTime2 = numTimeBlock2 };

            }
            for (int i = 0; i < Courselist.Count; i++)
            {
                if (Courselist[i].courses.instructorname == FacultyName)
                {
                    listBox1.Items.Add(Coursedatabase[i]);
                    assignedCourse.Add(Coursedatabase[i]);
                }

                listBox2.Items.Add(Coursedatabase[i]);

            }




        }
        public string user { get; set; }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {




        }

        private void rostersToolStripMenuItem_Click(object sender, EventArgs e)
        {

            // this needs to pull up a seperate window to pull up the rosters for the classes you are assigned


        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

            //Need to add the rosters in this box
            





        }
    }
}
