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

       List<String> assignedCourses = new List<String>(); // a local variable that I can pass between lists


        public Faculty(string user)
        {
            InitializeComponent();
            string FacultyName;
            FacultyName = user;
            List<String> Coursedatabase = new List<String>();
            var Courselist = new Dictionary<int, dynamic>();
            string[] lines2 = System.IO.File.ReadAllLines(@"C:\Users\katie\OneDrive\Desktop\Databases SE\CourseDatabase.txt");
            System.Console.WriteLine("Contents of Course database");

            List<String> Userdatabase = new List<String>();
            string[] users = System.IO.File.ReadAllLines(@"C:\SE Repos\UserDatabase.txt");

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
            foreach (string line in users)
            {
                // Use a tab to indent each line of the file.
                Userdatabase.Add(line);
                Console.WriteLine("\n" + line);
            }

            for (int i = 0; i < Courselist.Count; i++)
            {
                if (Courselist[i].courses.instructorname == FacultyName)
                {
                    listBox1.Items.Add(Coursedatabase[i]);
                    assignedCourses.Add(Coursedatabase[i]);
                }

                listBox2.Items.Add(Coursedatabase[i]);

            }

            for (int i = 0; i < Userdatabase.Count; i++)
            {
                string[] Userstring = Userdatabase[i].Split(" ");
                string advisor = Userstring[5];
                if (FacultyName == advisor)
                {
                    string advisee = Userstring[2] + " " + Userstring[3] + " " + Userstring[4];
                    adviseeList.Items.Add(advisee);
                }
            }




        }
        public string user { get; set; }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Rosters_listBox3.Items.Clear();
            string curCourse = listBox1.SelectedItem.ToString();

            string courseNum = curCourse.Substring(0, curCourse.IndexOf(' '));
            Rosters_listBox3.Items.Add(courseNum); //Prints out the class number to the roster before displaying the students

            //code fine up to here

            //string[] OGCourseDataBase = System.IO.File.ReadAllLines(@"C:\Users\katie\OneDrive\Desktop\Databases SE\OrginalCourseHistoryDatabase.txt");
            string[] CourseHisDataBase = System.IO.File.ReadAllLines(@"C:\Users\katie\OneDrive\Desktop\Databases SE\CourseHistoryDatabase.txt");
            List<string> addedCoursesDataBase = new List<string>();

            foreach (string line in CourseHisDataBase)
            {
                string[] splitLines = line.Split(' ');
                if (splitLines.Contains(courseNum))
                {

                    if (splitLines[Array.IndexOf(splitLines, courseNum) + 1] == "F23")
                    {
                        Rosters_listBox3.Items.Add(splitLines[0]);
                    }
                    else
                    {
                        string[] splitLines2 = line.Split(courseNum);
                        if (splitLines2.Contains(courseNum)) 
                        {

                            if (splitLines[Array.IndexOf(splitLines2, courseNum) + 1] == "F23")
                            { Rosters_listBox3.Items.Add(splitLines[0]); }


                        }
                    }
                }
                

            }

            






            
               //Saying i have an out of index issue
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

            ////Need to add the rosters in this box
            //string[] OGCourseDataBase = System.IO.File.ReadAllLines(@"C:\Users\katie\OneDrive\Desktop\Databases SE\OrginalCourseDatabase.txt");
            //string[] CourseDataBase = System.IO.File.ReadAllLines(@"C:\Users\katie\OneDrive\Desktop\Databases SE\CourseDatabase.txt");
            //List<string> addedCoursesDataBase;

            //int i = 0; //counter
            //foreach (string line in CourseDataBase)
            //{
            //    string toadd = (line.Split(OGCourseDataBase[i])).ToString();
            //    addedCoursesDataBase.Add(toadd);
            //    i++;
            //}



            //int j = 0; //coutner
            //foreach (string line in assignedCourses)
            //{
            //    List<int> includedIndex;
            //    if (addedCoursesDataBase.Contains(line))
            //    {
            //      includedIndex.Add(j);
            //    }

            //    if (includedIndex.Count() != 0)
            //    {
            //        Rosters_listBox3.Items.Add(line);



            //    }


            //    j++;
            }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void adviseeList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
