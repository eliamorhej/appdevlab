using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace FinalProject
{
    //
    //  Made by Thomas Meyer, Elia Morhej and Jeeva Piritivirajah
    //
    public partial class Form1 : Form
    {
        
        string currentDirectory = Directory.GetCurrentDirectory();
        string nameOfSelectedCourse = "";
        Timer timer = new Timer();
        public Form1()
        {
            InitializeComponent();
            showProperComboBox();
        }

        /// <summary>
        /// This method checks, using a regex, if the coursename is correctly formatted.
        /// If it isn't, show a messagebox and return.
        /// If it is, it checks if a file currently exists which corresponds to where the courses textfile should be.
        /// If the textfile doesn't exist, make a new one and append the course name to it
        /// If the textfile does exist, read the file, go through and check if the course already exists.
        /// If it does, send a message box and return.
        /// Otherwise, append the new course to the textfile.
        /// </summary>
        /// <param name="sender">The object sender</param>
        /// <param name="e">The event arguments</param>
        private void addToCourseButton_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
            // Regex to check if the coursename is correctly entered
            Regex rx = new Regex(@"^[0-9]{3}-[0-9]{3}-[a-zA-Z]{2}[a-zA-Z]?$");
            // If the name entered does not match the regex, it returns after putting a message
            // inside a messageBox
            if (!rx.IsMatch(addCourseTextBox.Text))
            {
                MessageBox.Show("Invalid course name.\nPlease enter a name which corresponds to the following pattern.\n" +
                    "3 Numbers - 3 Numbers - 2 OR 3 Letters.\n Example: 000-000-VA");
                return;
            }


            // Combine the current directory with "Data" to end up with CurrentDirectory/Data
            string filePath = System.IO.Path.Combine(currentDirectory, "Data");
            // If the Directory does not exist, it gets created. Otherwise, it goes into that directory
            System.IO.Directory.CreateDirectory(filePath);
            // Sets the filepath to CurrentDirectory/Data/Courses.txt. (This does not mean that courses.txt exists yet)
            string coursesFilePath = System.IO.Path.Combine(currentDirectory, "Data", "Courses.txt");

            
            // IF the file does NOT exist (in this case the Courses.txt file)

            if (!File.Exists(coursesFilePath))
            {
                // Append the course name to the file. This creates a file if it does not exist
                using (StreamWriter outputFile = File.AppendText(coursesFilePath))
                {
                    // Write the name of the course to the textFile
                    outputFile.WriteLine(addCourseTextBox.Text);
                }
            } else
            {
                // Read the file
                string line = "";
                List<string> listOfStrings = new List<string>();
                using (StreamReader reader = new StreamReader(coursesFilePath))
                {
                    while ((line = reader.ReadLine()) != null)
                    {
                        listOfStrings.Add(line);
                    }
                }
                // Go through the file and check if the course already exists
                foreach (String s in listOfStrings)
                {
                    if (s.Equals(addCourseTextBox.Text))
                    {
                        MessageBox.Show("Error! This course already exists!");
                        return;
                    }
                }
                // Add the course to the textFile if it does not exist
                using (StreamWriter outputFile = File.AppendText(coursesFilePath))
                {
                    outputFile.WriteLine(addCourseTextBox.Text);
                }
                // Show the combobox
                showProperComboBox();
                textBox.Text = "Added Successfully";
            }
        }

        /// <summary>
        /// This method just clears the courseComboBox and then
        /// reads the courses text file which contains all the courses
        /// puts them into a list (if the file exists) and then
        /// adds the list to the combobox, populating it.
        /// </summary>
        private void showProperComboBox()
        {
            // Clear The ComboBox
            courseComboBox.Items.Clear();
            // Check if the file exists
            string coursesFilePath = System.IO.Path.Combine(currentDirectory, "Data", "Courses.txt");
            if (!File.Exists(coursesFilePath))
            {
                return;
            }
            // If the text actually exists, it reads the text.
            string line = "";
            List<string> listOfCourses = new List<string>();
            using (StreamReader reader = new StreamReader(coursesFilePath))
            {
                while ((line = reader.ReadLine()) != null)
                {
                    listOfCourses.Add(line);
                }
            }
            
            // Add the items from the list to the ComboBox
            courseComboBox.Items.AddRange(listOfCourses.ToArray());
        }

        /// <summary>
        /// This method is used to show the proper student combobox. 
        /// This method is used to update the combobox whenever a student gets added.
        /// </summary>
        private void showProperStudentComboBox()
        {
            studentComboBox.Items.Clear();
            string studentFilePath = System.IO.Path.Combine(currentDirectory, "Data", "Students_" + nameOfSelectedCourse + ".txt");
            if (!File.Exists(studentFilePath))
            {
                return;
            }
            string line = "";
            List<string> stu = new List<string>();
            using (StreamReader reader = new StreamReader(studentFilePath))
            {
                while ((line = reader.ReadLine()) != null)
                {
                    stu.Add(line);
                }
            }
            studentComboBox.Items.AddRange(stu.ToArray());
        }
        
        /// <summary>
        /// This is used to create a timer
        /// which updates the combobox every 1/10th of a second
        /// because we are unable to let the form1 know when the form to create
        /// a student has been submitted.
        /// </summary>
        private void updateCb()
        {
            timer.Interval = (10 * 10);
            timer.Tick += new EventHandler(timer_tick);
            timer.Start();


        }

        /// <summary>
        /// Whenever the timer ticks it will run the
        /// showProperStudentComboBox method in order to
        /// update the combobox.
        /// </summary>
        /// <param name="sender">The sender object</param>
        /// <param name="e">The event arguments</param>
        private void timer_tick(object sender, EventArgs e)
        {
            showProperStudentComboBox();
        }


        /// <summary>
        /// Whenever you click the button, if there isn't a course that has
        /// been selected it will show a messagebox and return.
        /// Otherwise, it will set the second panel to visible,
        /// set the first panel to non visible and then
        /// run the showProperstudentCombobox method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openCourseButton_Click_1(object sender, EventArgs e)
        {
            if (courseComboBox.SelectedIndex <= - 1)
            {
                MessageBox.Show("Please select a course before clicking the button!");
                return;
            } else
            {
                nameOfSelectedCourse = courseComboBox.Text;
                coursePanel.Visible = false;
                CategoryPanel.Visible = true;
                showProperStudentComboBox();
            }
        }

        
        /// <summary>
        /// when the button gets clicked,
        /// create a new form2 and set the nameOfCourse inside the new form
        /// to the nameOfselectedCourse field
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            categoryForm form2 = new categoryForm();
            form2.Show();
            form2.nameOfCourse = nameOfSelectedCourse;
        }

        /// <summary>
        /// When the button gets clicked
        /// create a new form3
        /// and set the nameOfCourse to the nameOfSelectedCourse
        /// </summary>
        /// <param name="sender">The sender object</param>
        /// <param name="e">The event arguments</param>
        private void button4_Click(object sender, EventArgs e)
        {
            studentForm form3 = new studentForm();
            form3.form = this;
            form3.Show();
            form3.nameOfCourse = nameOfSelectedCourse;
            updateCb();
            
        }

        /// <summary>
        /// Whenever you click the button
        /// It checks if the combobox has been selected
        /// If it has not, shows a messagebox and returns
        /// If it has, set the second panel to non visible
        /// and set the third panel to visible
        /// run the showStudentGrades() method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void viewStudentButton_Click(object sender, EventArgs e)
        {
            if (studentComboBox.SelectedIndex <= -1)
            {
                MessageBox.Show("Please select a student before clicking the button!");
                return;
            } else
            {
                CategoryPanel.Visible = false;
                studentPanel.Visible = true;
                showStudentGrades();
            }
        }

        /// <summary>
        /// This method shows the grades
        /// for the specific student that was chosen
        /// inside the rich text box
        /// </summary>
        private void showStudentGrades()
        {
            gradeTextBox.Text = "";
            categoryNameComboBox.Items.Clear();
            string line;
            string[] studentInfo = studentComboBox.Text.Split(',');
            string id = studentInfo[0];
            string studentGradePath = System.IO.Path.Combine(currentDirectory, "Data", id + "-" + nameOfSelectedCourse + ".txt");
            // Get the stuff inside of the student's text file
            // and display it in the gradeTextBox
            using (StreamReader reader = new StreamReader(studentGradePath))
            {
                gradeTextBox.Text = "Category letter, item, Points Earned\n";
                while ((line = reader.ReadLine()) != null)
                {

                    gradeTextBox.Text += line + "\n";
                }
            }
            List<string> listOfCategoryNames = new List<string>();
            string categoryFilePath = System.IO.Path.Combine(currentDirectory, "Data", "Categories_" + nameOfSelectedCourse + ".txt");
            // Get the list of categories for the selected course
            if (!File.Exists(categoryFilePath))
            {
                MessageBox.Show("Category file does not exist. Please add a category");
                return;
            }
            using (StreamReader reader = new StreamReader(categoryFilePath))
            {
                string[] names = reader.ReadLine().Split(',');
                foreach (string n in names)
                {
                    listOfCategoryNames.Add(n.Trim());
                }
                categoryNameComboBox.Items.AddRange(listOfCategoryNames.ToArray());
            }
        }
        
        /// <summary>
        /// This method stop the timer so that it does not keep updating
        /// constantly, wasting the computer's resources.
        /// </summary>
        /// <param name="sender">The sent object</param>
        /// <param name="e">The event arguments</param>
        private void studentComboBox_Enter(object sender, EventArgs e)
        {
            timer.Stop();
        }

        /// <summary>
        /// When the index for the categoryNameComboBox changes
        /// It checks to see if the file is empty.
        /// If it is empty, it shows a messagebox and then returns.
        /// Otherwise, it adds to the list of numbers, the numbers that are
        /// inside the category text file.
        /// </summary>
        /// <param name="sender">The sender object</param>
        /// <param name="e">The event arguments</param>
        private void categoryNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            numberComboBox.Items.Clear();
            string categoryFilePath = System.IO.Path.Combine(currentDirectory, "Data", "Categories_" + nameOfSelectedCourse + ".txt");
            List<string> listOfNumbers = new List<string>();
            // If the file is empty, showmessagebox and return
            using (StreamReader reader = new StreamReader(categoryFilePath))
            {
                if (new FileInfo(categoryFilePath).Length == 0)
                {
                    MessageBox.Show("File does not contain any text");
                    return;
                }
                reader.ReadLine();
                reader.ReadLine();
                string[] numbers = reader.ReadLine().Split(',');
                string numForCategory = numbers[categoryNameComboBox.SelectedIndex];
                int n;
                if (!int.TryParse(numForCategory, out n))
                {
                    MessageBox.Show("Improper selection of combobox");
                    return;
                }
                for (int i = 1; i < int.Parse(numForCategory) + 1; i++)
                {
                    listOfNumbers.Add(i.ToString());
                }
            }
                numberComboBox.Items.AddRange(listOfNumbers.ToArray());
        }

        /// <summary>
        /// Whenever the button is clicked
        /// it checks if the categoryname, number and student boxes either have something in them or something selected.
        /// If they don't a message box apperas to let you know that you actually have to select something. If you do,
        /// it will either make a new one or change an existing one depending on if it actually already exists or not.
        /// </summary>
        /// <param name="sender">The sent objects</param>
        /// <param name="e">The event arguments</param>
        private void addRecordButton_Click(object sender, EventArgs e)
        {
            if (categoryNameComboBox.SelectedIndex <= -1 || numberComboBox.SelectedIndex <= -1 || string.IsNullOrEmpty(studentGradeBox.Text))
            {
                MessageBox.Show("Please make sure that something is entered/selected in every single box");
                return;
            }
            int i;
            if (!int.TryParse(studentGradeBox.Text, out i)) {
                MessageBox.Show("Please enter an integer for the grade");
                return;
            }
            if (int.Parse(studentGradeBox.Text) > 100 || int.Parse(studentGradeBox.Text) < 0)
            {
                MessageBox.Show("A grade cannot be higher than 100");
                return;
            }
            string line;
            string[] studentInfo = studentComboBox.Text.Split(',');
            string id = studentInfo[0];
            List<string> toWrite = new List<string>();
            string studentGradePath = System.IO.Path.Combine(currentDirectory, "Data", id + "-" + nameOfSelectedCourse + ".txt");
            using (StreamReader reader = new StreamReader(studentGradePath))
            {
                string toTest = categoryNameComboBox.Text.Substring(0, 1) + ", " + numberComboBox.Text;
                string toAdd = toTest + ", " + studentGradeBox.Text;
                while ((line = reader.ReadLine()) != null)
                {
                    if (!toTest.Equals(line.Substring(0, 1)))
                    {
                        toWrite.Add(line);
                    }
                }
                toWrite.Add(toAdd);
            }

            File.WriteAllText(studentGradePath, String.Empty);
            using (StreamWriter outputfile = new StreamWriter(studentGradePath))
            {
                foreach (string s in toWrite)
                {
                    outputfile.WriteLine(s);
                }
            }
            showStudentGrades();
        }

        /// <summary>
        /// This button, when pressed, is going to calculate the
        /// average student grades
        /// </summary>
        /// <param name="sender">The object sender</param>
        /// <param name="e">The event arguments</param>
        private void calculateButton_Click(object sender, EventArgs e)
        {
            
            // Run Calculate Method
            calculate();
            
            

        }

        /// <summary>
        /// This method calculates the average student grades and puts them into a separate file
        /// in a separate directory called "FinalReport"
        /// </summary>
        private void calculate()
        {
            // New directory path
            string dir = System.IO.Path.Combine(currentDirectory, "FinalReport");
            // Creates directory if not exist
            System.IO.Directory.CreateDirectory(dir);


            string studentsPath = System.IO.Path.Combine(currentDirectory, "Data", "Students_" + nameOfSelectedCourse + ".txt");
            if (!File.Exists(studentsPath))
            {
                MessageBox.Show("Error: No students yet added to the class!");
                return;
            }
            List<string> studentInfo = new List<string>();
            string line;
            string studInfoStr;
            List<string> studFinalInfo = new List<string>();
            using (StreamReader reader = new StreamReader(studentsPath))
            {
                while ((line = reader.ReadLine()) != null)
                {
                    studentInfo.Add(line);
                }
            }
            if (studentInfo.Count == 0)
            {
                MessageBox.Show("Error, no student grades to be calculated yet");
                return;
            }
            List<string> veryFinalList = new List<string>();
            foreach (string s in studentInfo)
            {
                studInfoStr = "";
                string[] sArr = s.Split(',');
                studInfoStr = sArr[2].Trim() + ", " + sArr[3].Trim() + ", ";
                string str = sArr[0];
                string studentFilePath = System.IO.Path.Combine(currentDirectory, "Data", str + "-" + nameOfSelectedCourse + ".txt");
                string categoryFilePath = System.IO.Path.Combine(currentDirectory, "Data", "Categories_" + nameOfSelectedCourse + ".txt");
                HashSet<string> categories = new HashSet<string>();

                using (StreamReader reader2 = new StreamReader(studentFilePath))
                {
                    while ((line = reader2.ReadLine()) != null)
                    {
                        string[] info = line.Split(',');
                        string cat = info[0].Trim();
                        categories.Add(cat);
                    }
                }
                List<string> listOfEverything = new List<string>();
                using (StreamReader reader3 = new StreamReader(categoryFilePath))
                {
                    string firstLine = reader3.ReadLine().Trim(',');
                    string secondLine = reader3.ReadLine().Trim(',');
                    
                    string[] firstLineArray = firstLine.Split(',');
                    string[] secondLineArray = secondLine.Split(',');

                    string x;
                    for (int i = 0; i < firstLineArray.Length; i++)
                    {
                        x = "";
                        string sub = firstLineArray[i].Trim().Substring(0, 1);
                        x += sub + ", " + secondLineArray[i].Trim();
                        listOfEverything.Add(x);
                    }
                }
                int counter = 0;
                List<string> finalList = new List<string>();
                using (StreamReader reader4 = new StreamReader(studentFilePath))
                {
                    int count = 0;
                    foreach (string l in listOfEverything)
                    {
                        counter = 0;
                        reader4.BaseStream.Position = 0;
                        reader4.DiscardBufferedData();
                        while ((line = reader4.ReadLine()) != null)
                        {
                            string[] sInfo = line.Split(',');
                            //if (sInfo.Length < 2)
                            //{
                            //    MessageBox.Show("Error, there are no grades for one of the students");
                            //    return;
                            //}
                            if (l.Substring(0, 1).Equals(sInfo[0]))
                            {
                                counter++;
                            }
                        }
                        double totalForStudentPerCategory = 0;
                        reader4.BaseStream.Position = 0;
                        reader4.DiscardBufferedData();
                        while ((line = reader4.ReadLine()) != null)
                        {
                            String[] sInfo = line.Split(',');
                            if (l.Substring(0, 1).Equals(sInfo[0]))
                            {
                                totalForStudentPerCategory += int.Parse(sInfo[2]);
                            }
                        }
                        totalForStudentPerCategory = totalForStudentPerCategory / counter;
                        totalForStudentPerCategory = totalForStudentPerCategory * ((double)int.Parse(l.Split(',')[1].Trim()) / 100);
                        finalList.Add(l + ", " + totalForStudentPerCategory);
                        count++;
                    }
                    double totalWeight = 0.0;
                    foreach (string finalListStr in finalList)
                    {
                        string[] flsArr = finalListStr.Split(',');
                        totalWeight += int.Parse(flsArr[1].Trim());
                    }
                    totalWeight = totalWeight / 100;
                    double finalGrade = 0.0;
                    foreach (string finalListStr in finalList)
                    {
                        if (!double.IsNaN(double.Parse(finalListStr.Split(',')[2].Trim())))
                        {
                            finalGrade += double.Parse(finalListStr.Split(',')[2].Trim());
                        }
                        
                    }
                    finalGrade = Math.Round(finalGrade / totalWeight, 2);
                    
                    veryFinalList.Add(s.Split(',')[2].Trim() + ", " + s.Split(',')[3].Trim() + ", " + finalGrade);
                }
            }
            string finalReportFilePath = System.IO.Path.Combine(currentDirectory, "FinalReport", nameOfSelectedCourse + "_summary" + ".txt");
            if (!File.Exists(finalReportFilePath))
            {
                using (StreamWriter outputFile = File.AppendText(finalReportFilePath))
                {
                    foreach (string entry in veryFinalList)
                    {
                        outputFile.WriteLine(entry);
                    }
                }
            }
            else
            {
                File.WriteAllText(finalReportFilePath, String.Empty);
                using (StreamWriter outputFile = new StreamWriter(finalReportFilePath))
                {
                    foreach (string entry in veryFinalList)
                    {
                        outputFile.WriteLine(entry);
                    }
                }
            }
            // Directory of created textFile
            string dirFull = System.IO.Path.Combine(currentDirectory, "FinalReport", nameOfSelectedCourse + "_summary" + ".txt");
            // Messagebox to show where it has been created
            MessageBox.Show("Your report has been generated and has been placed in the following directory:\n" + dirFull);

        }

        /// <summary>
        /// Removes all files that have anything to do with this course name.
        /// This removes the name from the courses file and both the file in the 
        /// Data and the FinalReport directories.
        /// </summary>
        /// <param name="sender">The sent object</param>
        /// <param name="e">The event arguments</param>
        private void removeCourseButton_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
            string coursePath = System.IO.Path.Combine(currentDirectory, "Data", "Courses.txt");
            if (!File.Exists(coursePath))
            {
                MessageBox.Show("The course file does not exist. Make sure you actually have courses to delete");
                return;
            } else
            {
                string line;
                List<string> courses = new List<string>();
                using (StreamReader reader = new StreamReader(coursePath))
                {
                    while ((line = reader.ReadLine()) != null)
                    {
                        courses.Add(line);
                    }
                }
                string toRemove = "";
                foreach (string s in courses)
                {
                    if (s.Equals(removeTextBox.Text))
                    {
                        toRemove = removeTextBox.Text;
                    }
                }
                if (toRemove == "")
                {
                    MessageBox.Show("Could not find the course");
                    return;
                } else
                {
                    courses.Remove(toRemove);
                    File.WriteAllText(coursePath, String.Empty);
                    using (StreamWriter outputFile = new StreamWriter(coursePath))
                    {
                        foreach(string str in courses)
                        {
                            outputFile.WriteLine(str);
                        }
                    }
                    showProperComboBox();
                }

                string otherFilePath = System.IO.Path.Combine(currentDirectory, "Data");
                if (!Directory.Exists(otherFilePath))
                {
                    MessageBox.Show("Data Directory does not exist! The file has been deleted from the course List though.");
                    return;
                } else
                {
                    string[] fileNames = Directory.GetFiles(otherFilePath);
                    foreach (string s in fileNames)
                    {
                        string[] actualFileName = s.Split('\\');
                        if (actualFileName[actualFileName.Length - 1].Contains(removeTextBox.Text))
                        {
                            File.Delete(s);
                        }
                    }
                    
                }

                string otherFilePath2 = System.IO.Path.Combine(currentDirectory, "FinalReport");
                if (!Directory.Exists(otherFilePath2))
                {
                    MessageBox.Show("FinalReport Directory does not exist! The file has been deleted from the course list though.");
                    return;
                }
                else
                {
                    string[] fileNames = Directory.GetFiles(otherFilePath2);
                    foreach (string s in fileNames)
                    {
                        string[] actualFileName = s.Split('\\');
                        if (actualFileName[actualFileName.Length - 1].Contains(removeTextBox.Text))
                        {
                            File.Delete(s);
                        }
                    }
                }
                textBox.Text = "The Files for this course have all been deleted";
            }
        }

        private void backToCategories_Click(object sender, EventArgs e)
        {
            CategoryPanel.Visible = true;
            studentPanel.Visible = false;
        }

        private void backToMainMenu_Click(object sender, EventArgs e)
        {
            coursePanel.Visible = true;
            CategoryPanel.Visible = false;
        }
    }
}

