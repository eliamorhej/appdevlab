using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    //
    //  Made by Elia Morhej, Jeeva Piritivirajah and Thomas Meyer
    //
    public partial class studentForm : Form
    {
        public Form1 form { get; set; }
        string currentDirectory = Directory.GetCurrentDirectory();
        public string nameOfCourse { get; set; }
        public studentForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method works on the click of the submit button.
        /// It first checks whether the four textboxes are empty.
        /// If they are, show a messagebox and return.
        /// It then checks if the section number textbox contains an integer. If it doesn't, show a messagebox and return.
        /// It then checks if a file exists already that corresponds to the one we're trying to crete.
        /// If it does not exist, it makes a new file and appends the data inside of the textboxes to the new file.
        /// Otherwise, it checks if we do not have a student that has the same Student ID
        /// If we don't it appends the student to the new file and also creates a file which
        /// is going to contain the information of the student.
        /// </summary>
        /// <param name="sender">The object sent</param>
        /// <param name="e">The argument</param>
        private void submitButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(studentID.Text) || String.IsNullOrEmpty(sectionNumber.Text) || string.IsNullOrEmpty(lastName.Text) || string.IsNullOrEmpty(firstName.Text))
            {
                MessageBox.Show("Please make sure to enter enough information in each text box as follows:\nString for the Student ID, Integer for the Section Number, Strings for Last and First name.");
                return;
            }
            int i;
            if (!int.TryParse(sectionNumber.Text, out i))
            {
                MessageBox.Show("Section Number has to be an Integer");
                return;
            }

            // Combine the current directory with "Data" to end up with CurrentDirectory/Data
            string filePath = System.IO.Path.Combine(currentDirectory, "Data");
            string studentsFilePath = System.IO.Path.Combine(currentDirectory, "Data", "Students_" + nameOfCourse + ".txt");
            if (!File.Exists(studentsFilePath))
            {
                // Append the category name to the file. This creates a file if it does not exist
                using (StreamWriter outputFile = File.AppendText(studentsFilePath))
                {
                    // Create the file
                    outputFile.Write(studentID.Text + ", " + sectionNumber.Text + ", " + lastName.Text + ", " + firstName.Text);

                }

                string studentDirectory = System.IO.Path.Combine(currentDirectory, "Data", studentID.Text + "-" + nameOfCourse + ".txt");
                using (StreamWriter outputfile = File.AppendText(studentDirectory))
                {
                    outputfile.Write("");
                }
            } else
            {
                string line;
                List<string> listOfStrings = new List<string>();
                List<string[]> listOfArrays = new List<string[]>();
                using (StreamReader reader = new StreamReader(studentsFilePath))
                {
                    while ((line = reader.ReadLine()) != null)
                    {
                        listOfStrings.Add(line);
                    }
                }
                // check if a student with the same studentID exists already since the studentID is kind of like the primary key
                foreach (String str in listOfStrings)
                {
                    string[] arr = str.Split(',');
                    listOfArrays.Add(arr);
                }
                string toRemove = "";
                foreach (string[] a in listOfArrays)
                {
                    if (a[0].Trim().Equals(studentID.Text))
                    {
                       foreach(string astr in a)
                        {
                            toRemove += astr + ",";
                        }
                        toRemove = toRemove.Substring(0, toRemove.Length - 1);
                        listOfStrings.Remove(toRemove);
                        MessageBox.Show("Student with the same ID detected, modifying information");
                        File.WriteAllText(studentsFilePath, String.Empty);
                        using (StreamWriter outputFile = new StreamWriter(studentsFilePath))
                        {
                            foreach (string l in listOfStrings)
                            {
                                outputFile.WriteLine(l);
                            }
                        }
                    }
                }

                // Append textbox contents to the textfile
                string toAppend = studentID.Text + ", " + sectionNumber.Text + ", " + lastName.Text + ", " + firstName.Text;
                using (StreamWriter outputFile = File.AppendText(studentsFilePath))
                {
                    outputFile.WriteLine(toAppend);
                }
                // create new studentDirectory file which is a file which would contain all of the information about the grades that
                // that specific student has.
                string studentDirectory = System.IO.Path.Combine(currentDirectory, "Data", studentID.Text + "-" + nameOfCourse + ".txt");
                using (StreamWriter outputfile = File.AppendText(studentDirectory))
                {
                    outputfile.Write("");
                }
            }
            this.Close();
        }
    }
}
