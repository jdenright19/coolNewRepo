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
            string[] lines2 = System.IO.File.ReadAllLines(@"C:\Users\jdenright19\Desktop\CourseDatabase.txt.txt");
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
         

            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\jdenright19\Desktop\UserDatabase.txt.txt");
            List<String> Userdatabase = new List<String>();
            var Userlist = new Dictionary<int, dynamic>();

            foreach (string line in lines)
            {
                // Use a tab to indent each line of the file.
                Userdatabase.Add(line);
                Console.WriteLine("\n" + line);

            }
            for (int i = 0; i < Userdatabase.Capacity - 1; i++)
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
            for (int i = 0; i < Userdatabase.Count; i++)
            {
                listBox1.Items.Add(Userlist[i].usrs.usrname + " " + Userlist[i].usrs.s);
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
