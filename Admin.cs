using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Window
{
    public partial class Admin : System.Windows.Forms.Form
    {
        public Admin()
        {
            InitializeComponent();
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
                listBox2.Items.Add(Coursedatabase[i]);
            }
         

            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\katie\Downloads\UserDatabase.txt");
            List<String> Userdatabase = new List<String>();
            var Userlist = new Dictionary<int, dynamic>();

            foreach (string line in lines)
            {
                // Use a tab to indent each line of the file.
                Userdatabase.Add(line);
                Console.WriteLine("\n" + line);

            }
            for (int i = 0; i < Userdatabase.Count(); i++)
            {
                string[] Userstring = Userdatabase[i].Split(' ');
                string username = Userstring[0];
                string password = Userstring[1];
                string firstname = Userstring[2];
                string middlename = Userstring[3];
                string lastname = Userstring[4];
                string status = Userstring[5];
                dynamic d1 = new System.Dynamic.ExpandoObject();
                Userlist[i] = d1;
                Userlist[i].usrs = "User" + i;
                Console.WriteLine(Userlist[i].usrs);

                Userlist[i].usrs = new { usrname = username, pswd = password, fname = firstname, mname = middlename, lname = lastname, s = status };

                //Console.WriteLine("Key {0}, Username: {1}, Password: {2}, First name: {3}, Middle name: {4}, Last name: {5}, Status {6}\n", Userlist[i].usrs, Userlist[i].usrs.usrname, Userlist[i].usrs.pswd, Userlist[i].usrs.fname, Userlist[i].usrs.mname, Userlist[i].usrs.lname, Userlist[i].usrs.s);
            }
            
            // This is loading in the users into the correct places
            for (int i = 0; i < Userdatabase.Count()-1; i++)
            {
                if ((Userlist[i].usrs.s == "admin"))
                { listBox1.Items.Add(Userlist[i].usrs.usrname + " " + Userlist[i].usrs.s); }
                else if(Userlist[i].usrs.s == "faculty")
                            { listBox3.Items.Add(Userlist[i].usrs.usrname + " " + Userlist[i].usrs.s); }
                else { listBox4.Items.Add(Userlist[i].usrs.usrname + " " + Userlist[i].usrs.s); }
               
            } 

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            // *************** SHOULD ADD THE PROFS NAME TO THE ROSTER TOO *********************
            
            listBox6.Items.Clear();
            string curCourse = listBox2.SelectedItem.ToString();

            string courseNum = curCourse.Substring(0, curCourse.IndexOf(' '));
            //string courseName = curCourse.Substring(curCourse.IndexOf(courseNum), curCourse.IndexOf(' '));
            //string profName = "Instructor: " + curCourse.Substring(curCourse.IndexOf(courseName), curCourse.IndexOf(' '));
            listBox6.Items.Add(courseNum); //Prints out the class number to the roster before displaying the students
            //listBox6.Items.Add(profName);

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
                        listBox6.Items.Add(splitLines[0]);
                    }
                    else
                    {
                        string[] splitLines2 = line.Split(courseNum);
                        if (splitLines2.Contains(courseNum))
                        {

                            if (splitLines[Array.IndexOf(splitLines2, courseNum) + 1] == "F23")
                            { listBox6.Items.Add(splitLines[0]); }


                        }
                    }
                }


            }
        }

        private void listBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
           




        }

        private void listBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Refresh Button that can be used after deleting a user
        }

        private void listBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Steal Advisee code from faculty menu


        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
// Ask Naomi to do this bit

        }
    }
}
