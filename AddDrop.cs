
using Login_GUI;
using Login_Window;
using Overload_Warning;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Warning_Form;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Form
{
    public partial class AddDrop : System.Windows.Forms.Form
    {
        string time;
        //Global variables
        List<String> currentSchedNames = new List<String>(); //this is a internal list of what classes the student is enrolled into
        List<String> currentSchedTimes = new List<String>(); // and the time those classes occur
        float creditTot = 0; // This allows us to know the credit total in this form.
        int newCourseCntr;

        int line_to_edit;
        string oldLine;

        public AddDrop(string user)
        {
            InitializeComponent();
            List<String> Coursedatabase = new List<String>();
            string[] lines2 = System.IO.File.ReadAllLines(@"C:\Users\katie\OneDrive\Desktop\Databases SE\CourseDatabase.txt");
            this.user = user;

            //Katie's Pathway : C:\Users\katie\Downloads\main-master\main-master\CourseDatabase.txt
            //Jimmy's Pathway : C:\Users\turtl\Desktop\CourseDatabase.txt


            System.Console.WriteLine("Contents of Course database");
            foreach (string line in lines2)
            {
                // Use a tab to indent each line of the file.
                Coursedatabase.Add(line);
                Console.WriteLine("\n" + line);
            }
            for (int i = 0; i < Coursedatabase.Count; i++)
            {
                checkedListBox1.Items.Add(Coursedatabase[i]);
            }
        }


        public string user { get; set; }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //foreach (int indexChecked in checkedListBox1.CheckedIndices)
            //{
            //    checkedListBox2.Items.Add(checkedListBox1.Items[indexChecked]);
            //}
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Drop_btn_Click(object sender, EventArgs e)
        {
            List<String> CourseHistorydatabase = new List<String>();
            string[] lines2 = System.IO.File.ReadAllLines(@"C:\Users\katie\OneDrive\Desktop\Databases SE\CourseHistoryDatabase.txt");
            foreach (string line in lines2)
            {
                CourseHistorydatabase.Add(line);

            }
            for (int p = 0; p < CourseHistorydatabase.Count; p++)
            {
                string[] splitCourseHistory = CourseHistorydatabase[p].Split(" ");
                string currentUser = splitCourseHistory[0];
                if (currentUser == user)
                {
                    line_to_edit = p;
                    oldLine = CourseHistorydatabase[p];
                }
            }
            
            for (int i =dataGridView1.Rows.Count - 1; i >= 0; i--) //loops through our dataTable and finds any rows with a checked index, if the index is checked that whole row gets removed.
            {
                DataGridViewRow dataGridViewRow = dataGridView1.Rows[i];
                
                if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[9].Value) == true)
                {
                    string replacementLine;
                    replacementLine = (string)dataGridView1.Rows[i].Cells[0].Value;
                    replacementLine += " ";
                    replacementLine += "F23";
                    replacementLine += " ";
                    replacementLine += (string)dataGridView1.Rows[i].Cells[3].Value;
                    replacementLine += " ";
                    replacementLine += "N";
                   

                    string[] lines5 = File.ReadAllLines(@"C:\Users\katie\OneDrive\Desktop\Databases SE\CourseHistoryDatabase.txt");

                    
                    string[] splitText = oldLine.Split(replacementLine);
                    string newText = splitText[0];
                    
                    if (newCourseCntr > 1)
                    {
                        newText += splitText[1];
                    }
                    
                    string[] newText2 = newText.Split(" ");
                    int numClasses = int.Parse(newText2[1]);
                    numClasses -= 1;
                    string newText3 = newText2[0];
                    newText3 += " ";
                    newText3 += numClasses.ToString();
                    newText3 += " ";
                    for (int g = 2; g < newText2.Count(); g++)
                    {
                        newText3 += newText2[g];
                        newText3 += " ";
                    }
                    string lineToWrite = newText3;
                    // Write the new file over the old file.
                    using (StreamWriter writer = new StreamWriter(@"C:\Users\katie\OneDrive\Desktop\Databases SE\CourseHistoryDatabase.txt"))
                    {
                        for (int currentLine = 0; currentLine <= lines5.Length - 1; ++currentLine) //finds the line in the text file to edit and overwrites it.
                        {
                            if (currentLine == line_to_edit)
                            {
                                writer.WriteLine(lineToWrite);
                            }
                            else
                            {
                                writer.WriteLine(lines5[currentLine]);
                            }
                        }
                    }
                    dataGridView1.Rows.RemoveAt(i);
                    newCourseCntr -= 1;
                }
            }
            
            



           


        }

        private void tbl_courseSched_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_submit_Click(object sender, EventArgs e)
        {
            newCourseCntr += 1;
            List<string> courses = new List<string>(); // this is used to keep track of what courses have been selected in the select menu
            bool nameCheck = false; // this name check that we will use later to make sure we aren't adding any of the same courses twice
            bool timeCheck = false; // this is a time check that we will use later to make sure we aren't adding any courses to the schedule that have time conflicts
            bool credCheck = false;


            foreach (string item in checkedListBox1.CheckedItems) // for each course that was checked...
            {

                courses.Add(item); // we will add the string to the course list

            }

             // this is setting the template for the new rows I am going to make later



            for (int i = 0; i < courses.Capacity - 3; i++) // we are now going to look through the course list

            {
                //Splitting everything up in the course descriptions
                string[] courseInfo = courses[i].Split(' ');


                string courseNumber = courseInfo[0]; // course number
                string courseName = courseInfo[1]; // course name
                //we need to add these to the global variables if they aren't already on there

                //course history check
                List<String> historyData = new List<String>();
                var history = new Dictionary<String, List<String>>();
                string[] lines = System.IO.File.ReadAllLines(@"C:\Users\katie\OneDrive\Desktop\Databases SE\CourseHistoryDatabase.txt");
                System.Console.WriteLine("Contents of Course History:");
                foreach (string line in lines)
                {
                    historyData.Add(line);
                    //Debug.WriteLine("\n" + line);
                }
                for (int k = 0; k < historyData.Capacity - 1; k++)
                {
                    dynamic[] classInfo = historyData[k].Split(' ');
                    string username = classInfo[0];
                    history.Add(username, new List<String>());
                    int numCourses4 = int.Parse(classInfo[1]);
                    // iterate through numClasses, add courses to list, add to dictionary
                    int spot = 2;
                    for (int j = 0; j < numCourses4; j++)
                    {
                        history[username].Add(classInfo[spot]);
                        spot += 3;

                    }
                }

                if (history[user].Contains(courseNumber))
                {
                    warningForm error = new warningForm();
                    error.ShowDialog();
                }

                if (currentSchedNames.Count == 0) // if there is nothing in our global list then we can just add the class straight away and pass the check
                {
                    currentSchedNames.Add(courseName);
                    nameCheck = true;
                }


                else
                {
                    foreach (string item in currentSchedNames) // checking the global variable that has access to all of the courses the student has just enrolled in
                    {
                        if (item == courseNumber) // if the course is already been added
                        {
                            nameCheck = false; //it fails the name check 
                            warningForm error = new warningForm(); // show error window WILL REPLACE WITH ACTUAL GUI EVENTUALLY
                            error.ShowDialog(); //Show error
                            break; // break from the loop so we don't do anything crazy
                        }
                        else // if the item and course name aren't the same
                        {
                            nameCheck = true; // it is passing the namecheck as of now

                        }

                    }

                    if (nameCheck) { currentSchedNames.Add(courseName); } // if it did pass the name check we are going to add it to are global list
                }



                string instructor = courseInfo[2]; // instructor info
                string credit = courseInfo[3]; // credit info

                creditTot = (float)(creditTot + float.Parse(credit));

                if (creditTot >= 5) // CHECK LATER THIS IS SCREWED UP
                {
                    credCheck = false;

                }
                else
                {
                    credCheck = true;
                }

                if (credCheck == false)
                {
                    OverloadForm overloaderror = new OverloadForm();
                    overloaderror.ShowDialog();
                    break;
                }

                string numSeats = courseInfo[4]; // number of seats info

                //Need to translate these into actual times
                string timeBlocks = courseInfo[5]; // how many time blocks this course has
                string days = courseInfo[6]; // this is the time code that later has to be translated accordingly 

                if (nameCheck == true) // here we are doing a time check only if it passes the first name check (we don't want two error windows popping up if you try to enroll in the exact same class)
                {
                    if (currentSchedTimes.Count == 0) // if there is nothing in the global list we can just add it and pass the check
                    {
                        currentSchedTimes.Add(days);
                        timeCheck = true;
                    }

                    else
                    {
                        foreach (string item in currentSchedTimes) // for each item in the list
                        {
                            if (item == days) // if it is the EXACT same as the course number I NEED TO FIGURE OUT HOW TO DO CONFLICTING TIMES BETTER 
                            {

                                timeCheck = false; // fails the check
                                warningForm warningError = new warningForm();
                                warningError.ShowDialog(); //shows the error dialog THAT NEEDS TO BE ADDED 
                                break; // Breaks out of this loop no need to keep checking


                            }
                            else
                            {
                                timeCheck = true;

                            }
                        }
                        if (timeCheck == true) { currentSchedTimes.Add(days); } // only adds if we yield a passed check



                    }
                }

                if (nameCheck && timeCheck && credCheck)
                {  //Making my new row
                  

                    //Adding the things in the desired places
                    int index = dataGridView1.Rows.Add(); //creates new row
                    dataGridView1.Rows[index].Cells[0].Value = courseNumber; //enters values into their specified collumns
                    dataGridView1.Rows[index].Cells[1].Value = courseName;
                    dataGridView1.Rows[index].Cells[2].Value = instructor;
                    dataGridView1.Rows[index].Cells[3].Value = credit;
                    dataGridView1.Rows[index].Cells[4].Value = numSeats;
                    dataGridView1.Rows[index].Cells[5].Value = timeBlocks;
                    dataGridView1.Rows[index].Cells[6].Value = dayTranslation(days);
                    dataGridView1.Rows[index].Cells[7].Value = timeStartTranslation(days);
                    dataGridView1.Rows[index].Cells[8].Value = timeEndTranslation(days, time);

                    //only happens if there are two time blocks
                    if (courseInfo.Count() == 8)
                    {
                        index = dataGridView1.Rows.Add();
                        dataGridView1.Rows[index].Cells[6].Value = dayTranslation(days);
                        dataGridView1.Rows[index].Cells[7].Value = timeStartTranslation(days);
                        dataGridView1.Rows[index].Cells[8].Value = timeEndTranslation(days, time);
                        string extraTimeBlock = courseInfo[7];
                        
                    }
                    string[] lines3 = System.IO.File.ReadAllLines(@"C:\Users\katie\OneDrive\Desktop\Databases SE\CourseHistoryDatabase.txt");
                    List<String> CourseHistory = new List<String>();
                    var Historylist = new Dictionary<int, dynamic>();
                    foreach (string line in lines3)
                    {
                        // Use a tab to indent each line of the file.
                        CourseHistory.Add(line);
                        Console.WriteLine("\n" + line);

                    }
                    string newString;
                    string[] className = new string[10];
                    string[] semester = new string[10];
                    string[] creditNum = new string[10];
                    string[] Grade = new string[10];
                    
                    int lineIncriment;
                    for (int l = 0; l <CourseHistory.Capacity - 1; l++)
                    {
                        string[] Historystring = CourseHistory[l].Split(' '); //reading in the coursehistory
                        string username = Historystring[0];
                        string numCourses2 = Historystring[1];
                        int increment = 2;
                        
                        for (int o = 0; o < int.Parse(numCourses2); o++)//checks num of classes and adds different course vals based upon num of courses
                        {
                            className[o] = Historystring[increment];
                            increment++;
                            semester[o] = Historystring[increment];
                            increment++;
                            creditNum[o] = Historystring[increment];
                            increment++;
                            Grade[o] = Historystring[increment];
                            increment++;
                        }
                        
                        dynamic d1 = new System.Dynamic.ExpandoObject();
                        Historylist[l] = d1;
                        Historylist[l].usrs = "User" + l;
                        Console.WriteLine(Historylist[l].usrs);

                        Historylist[l].usrs = new { usrname = username, courseNum = numCourses2}; //saves some vals

                        //Console.WriteLine("Key {0}, Username: {1}, Password: {2}, First name: {3}, Middle name: {4}, Last name: {5}, Status {6}\n", Userlist[i].usrs, Userlist[i].usrs.usrname, Userlist[i].usrs.pswd, Userlist[i].usrs.fname, Userlist[i].usrs.mname, Userlist[i].usrs.lname, Userlist[i].usrs.s);
                    }

                    for (int b = 0; b < Historylist.Count; b++)
                    {
                        if (user == Historylist[b].usrs.usrname)
                        {
                            int increment2 = 0;
                            
                            string tempNum = Historylist[b].usrs.courseNum; //gets old values that were already in the text file and adds those entries into the string.
                            int tempVal = int.Parse(tempNum);
                            tempVal += 1; //increments by 1 to allow for a new class to be inputted
                            newString = Historylist[b].usrs.usrname;
                            newString += " ";
                            newString += tempVal.ToString();
                            newString += " ";
                            for (int g = 0; g < tempVal - 1; g++)
                            {
                                newString += className[increment2];
                                newString += " ";
                                newString += semester[increment2];
                                newString += " ";
                                newString += creditNum[increment2];
                                newString += " ";
                                newString += Grade[increment2];
                                newString += " ";
                                increment2++;
                            }
                            newString += courseNumber; //adds in the string for any new classes that were added through our database.
                            newString += " ";
                            newString += "F23";
                            newString += " ";
                            newString += credit;
                            newString += " ";
                            newString += "N";
                            int line_to_edit = b;
                            string[] lines5 = File.ReadAllLines(@"C:\Users\katie\OneDrive\Desktop\Databases SE\CourseHistoryDatabase.txt");
                            string lineToWrite = newString;
                            // Write the new file over the old file.
                            using (StreamWriter writer = new StreamWriter(@"C:\Users\katie\OneDrive\Desktop\Databases SE\CourseHistoryDatabase.txt"))
                            {
                                for (int currentLine = 0; currentLine <= lines5.Length -1; ++currentLine) //finds the line in the text file to edit and overwrites it.
                                {
                                    if (currentLine == line_to_edit)
                                    {
                                        writer.WriteLine(lineToWrite);
                                    }
                                    else
                                    {
                                        writer.WriteLine(lines5[currentLine]);
                                    }
                                }
                            }
                            //File.AppendAllText(@"C:\Users\turtl\Desktop\CourseHistoryDatabase.txt",
                            //newString + Environment.NewLine);




                        }

                    }
                    

                        // resetting my bool statements to false to then re iterate through more courses
                        timeCheck = false;
                    nameCheck = false;
                    credCheck = false;




                }



            }








            string dayTranslation(string timeReadIn)
            {
                int x = int.Parse(timeReadIn);

                if (x / 1000 == 21)
                {
                    return "MWF";
                }
                else if (x / 1000 == 8)
                {
                    return "R";
                }
                else if (x / 1000 == 15) { return "MTWR"; }
                else if (x / 1000 == 12) { return "WR"; }
                else if (x / 1000 == 1) { return "M"; }
                else if (x / 1000 == 2) { return "T"; }
                else if (x / 1000 == 4) { return "W"; }

                else
                {
                    return "F";
                }

            }

            //This is a dumb way to do this. Maybe coming back and fixing this may be good
            string timeStartTranslation(string timeReadIn)
            {
                int x = int.Parse(timeReadIn);
                float finalTime = 0;
                bool not12 = true;
                bool isPM = false;
                int y;
                float milTime = ((x / 10) % 100) / 2f;
               
                //These next conditional Statements are finding out the start time of the course
                if ((milTime / 12) <= 1) //AM
                {
                    if (milTime % 0.5 == 1) // If we have a 30 minute start time
                    {
                        finalTime = (int)(milTime - 0.5);
                        time = finalTime.ToString();
                        time = time + ":30 A.M.";

                    }
                    else
                    {
                        time = milTime.ToString();
                        time = time + ":00 A.M.";
                    }

                    
                    
                }
                // NEED TO MAKE AN IF ELSE IF THERE IS AN EXACT 12

                else //PM
                {
                    finalTime = (int)(milTime - 12); // Subtracting 12 hours from military time because it is in the PM // IT IS NOT SUBTRACTING BY 12 WTF

                    if (finalTime % 0.5 == 1) // If we have a 30 minute start time
                    {
                        finalTime = (int)(milTime - 0.5);

                        time = finalTime.ToString();
                        time = time + ":30 P.M.";

                    }
                    else
                    {
                        time = finalTime.ToString();
                        time = time + ":00 P.M.";
                    }

                    isPM = true;

                }
                string[] tempVal1 = time.Split(":");
                string firstNum1 = tempVal1[0];
                y = int.Parse(firstNum1);
                tempVal1[0] += ":";
                tempVal1[0] += tempVal1[1];


                string[] tempVal = time.Split(":");
                string firstNum = tempVal[0];
                y = int.Parse(firstNum);
                if (y == 0)
                {
                    tempVal[0] = "";
                    tempVal[0] += 12;
                    tempVal[0] += ":";
                    tempVal[0] += tempVal[1];
                    not12 = false;
                }
                if (not12 == true)
                {
                    return tempVal1[0];
                }
                else 
                {
                    return tempVal[0];
                }
            }

            // this block of conditional statements is going to add the end time of the course to the time string
            //This code isn't working for some reason
            string timeEndTranslation(string timeReadIn, string timeval)
            {

                int x = int.Parse(timeReadIn);
                float finalTime;
                string[] time = timeval.Split(':');
                string firstNum = time[0];
                string SecNum = time[1];
                bool isPM = false;
                finalTime = (x % 10);
                double timeComp = float.Parse(time[0]);
                if (time[1] == "30")
                {
                    timeComp += .5;
                }
                if (timeComp == 0)
                {
                    timeComp += 12;
                }

                for (int i = 0; i < finalTime; i++)
                {
                    timeComp += .5;
                }
                if (timeComp > 12)
                {
                    timeComp -= 12;
                    isPM = true;
                }
                if (timeComp % 1 != 0)
                {
                    timeComp -= .5;
                    time[0] = timeComp.ToString();
                    time[0] += ":30";
                }
                else
                {
                    time[0] = timeComp.ToString();
                    time[0] += ":00";
                }
                if (isPM == true)
                {
                    time[0] += " P.M.";
                }
                else 
                {
                    time[0] += " A.M.";
                }
                return time[0];
                /* bool isPM = false;

                 float milTime = ((x / 10) % 100) / 2f;
                 int endTime = (int)(x % 10);
                 finalTime = (int)(milTime - 0.5);
                 //string y; 
                 if (endTime == 3)
                 {
                     finalTime = finalTime + 1;

                     if (finalTime > 12)
                     {
                         finalTime = finalTime - 12;
                         time2 += " - ";
                         time2 += finalTime.ToString();

                         time2 += ":30 P.M.";
                     }
                     else
                     {
                         time2 += " - ";
                         time2 += finalTime.ToString();

                         time2 += ":30 ";
                         if (isPM == true) { time2 += "P.M."; }
                         else { time2 += "A.M."; }

                     }


                 }
                 else
                 {
                     finalTime = finalTime + 1;
                     time2 += " - ";

                     time2 += finalTime.ToString();  // here is the issue

                     time2 += ":00";
                     if (isPM == true) { time2 += "P.M."; }
                     else { time2 += "A.M."; }

                 }

                 endTime = (int)(x % 10);
                 //string y; 
                 if (endTime == 3)
                 {
                     finalTime = finalTime + 1;

                     if (finalTime > 12)
                     {
                         finalTime = finalTime - 12;

                         time2 += " - ";
                         time2 += finalTime.ToString();

                         time2 += ":30 P.M.";
                     }
                     else
                     {
                         time2 += " - ";
                         time2 += finalTime.ToString();

                         time2 += ":30 ";
                         if (isPM == true) { time2 += "P.M."; }
                         else { time2 += "A.M."; }

                     }


                 }
                 else
                 {
                     finalTime = finalTime + 1;
                     time2 += " - ";

                     time2 += finalTime.ToString();  // here is the issue

                     time2 += ":00";
                     if (isPM == true) { time2 += "P.M."; }
                     else { time2 += "A.M."; }

                 }

                */


            }


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            CourseHistory coursehistroyForm = new CourseHistory(this.user);
            coursehistroyForm.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lbl_currentSchedule_Click(object sender, EventArgs e)
        {

        }
    }

    internal class type
    {
    }
}
