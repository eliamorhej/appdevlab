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
    //  Made by Thomas Meyer, Elia Morhej and Jeeva Piritivirajah
    //
    public partial class categoryForm : Form
    {
        string currentDirectory = Directory.GetCurrentDirectory();
        string categoriesStr;
        string assessmentStr;
        string amountStr;
        List<int> li = new List<int>();
        int totalAssessmentValue;

        public string nameOfCourse { get; set; }
        public categoryForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This method first checks if the textboxes are empty. If they are, show a messagebox and return.
        /// It then tries to parse the assessment and amount boxes. If it parses unsuccessfully, it shows a messagebox and returns.
        /// It then parses the assessment and amount textboxes and checks if they are bigger than 100 or smaller than 0. Shows a messagebox and returns if that is the case.
        /// It checks if the first char is an upper case letter, which it requires. If it isn't, show a messagebox and return.
        /// The filePath gets created and a file is appended to it if it does not exist already. After creating the new file it puts the text inside of the textboxes into it.
        /// If it isn't empty, then it loops through the file and first checks if there is already a category with the same name. Also check if there is a category name
        /// with the same starting letter. If there is a category with the same exact name, It finds its values and modifies them with new ones as long as they respect
        /// every single previous constraint. If it has the same starting letter but not full name, it does not let you add a new category. If we decide to add a completely new one,
        /// It loops through the second line and checks if the sum of all of the assessments + the one that we want to add is going to equal more than 100. If so, messagebox and return.
        /// If everything passes and there are no errors/message boxes, it appends the values in the textboxes to the text file.
        /// </summary>
        /// <param name="sender">The event</param>
        /// <param name="e">The arguments of the event</param>
        private void button1_Click(object sender, EventArgs e)
        {
            li = new List<int>();
            if (string.IsNullOrEmpty(categories.Text) || String.IsNullOrEmpty(assessment.Text) || string.IsNullOrEmpty(amount.Text))
            {
                MessageBox.Show("Please make sure to enter enough information in each text box as follows:\nString for the category name, Integer for the assessment weight and amount.");
                return;
            }
            int i;
            if (!int.TryParse(assessment.Text, out i) || !int.TryParse(amount.Text, out i))
            {
                MessageBox.Show("Categories and amount both have to be integers");
                return;
            }
            if (int.Parse(assessment.Text) < 0 || int.Parse(assessment.Text) > 100 || int.Parse(amount.Text) < 0 || int.Parse(amount.Text) > 100)
            {
                MessageBox.Show("The assessment and amount numbers must be above 0 and below 100");
                return;
            }
            if (!Char.IsUpper(categories.Text.ToCharArray()[0]))
            {
                MessageBox.Show("The fist letter of the category must be a capital letter");
                return;
            }

            // Combine the current directory with "Data" to end up with CurrentDirectory/Data
            string filePath = System.IO.Path.Combine(currentDirectory, "Data");
            string categoriesFilePath = System.IO.Path.Combine(currentDirectory, "Data", "Categories_" + nameOfCourse + ".txt");
            if (!File.Exists(categoriesFilePath))
            {
                // Append the category name to the file. This creates a file if it does not exist
                using (StreamWriter outputFile = File.AppendText(categoriesFilePath))
                {
                    // Create the file
                    outputFile.WriteLine(categories.Text + ",");
                    outputFile.WriteLine(assessment.Text + ",");
                    outputFile.Write(amount.Text + ",");
                }
            }
            else
            {
                char[] separators = new char[] { ',' };
                string[] firstLine;
                string[] secondLine;
                string[] thirdLine;
                using (StreamReader reader = new StreamReader(categoriesFilePath))
                {
                    // Splitting the lines into arrays of elements (categories, assessment, amount)
                    firstLine = reader.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries);
                    secondLine = reader.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries);
                    thirdLine = reader.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries);
                    // Loops through first line, trims and checks if there is a category of the same name already existant.
                }
                int counter = 0;
                bool test = false;
                categoriesStr = "";
                foreach (string str in firstLine)
                {
                    if (str.Trim().Equals(categories.Text))
                    {
                        MessageBox.Show("This category already exists! Modifying!");
                        test = true;
                    }
                    else
                    {
                        if (str.Trim().Substring(0, 1).ToLower().Equals(categories.Text.Substring(0, 1).ToLower()))
                        {
                            MessageBox.Show("Error: Two categories cannot have the same starting letter");
                            return;
                        }
                    }
                    
                    // Also check if the same starting letter exists already.

                    // Adds to the string which is going to be used to put back into the text file
                    
                    categoriesStr += str.Trim() + ", ";
                    if (test == false)
                    {
                        counter++;
                    }
                }
                
                if (test == true)
                {
                    List<string> firstLineList = firstLine.ToList<string>();
                    List<string> secondLineList = secondLine.ToList<string>();
                    List<string> thirdLineList = thirdLine.ToList<string>();

                    firstLineList.RemoveAt(counter);
                    secondLineList.RemoveAt(counter);
                    thirdLineList.RemoveAt(counter);

                    List<int> toCalc = new List<int>();
                    foreach (string l in secondLineList)
                    {
                        toCalc.Add(int.Parse(l.Trim()));
                    }
                    toCalc.Add(int.Parse(assessment.Text));
                    int c = toCalc.Sum();
                    if (c > 100)
                    {
                        MessageBox.Show("Error, The assessment total cannot be higher than 100%");
                        return;

                    }
                    firstLineList.Add(" " + categories.Text);
                    secondLineList.Add(" " + assessment.Text);
                    thirdLineList.Add(" " + amount.Text);
                    string category = categories.Text.Substring(0, 1);
                    string studentFilePath = System.IO.Path.Combine(currentDirectory, "Data", "Students_" + nameOfCourse + ".txt");
                    string line;
                    List<string> studentInfo = new List<string>();
                    using (StreamReader reader = new StreamReader(studentFilePath))
                    {
                        while ((line = reader.ReadLine()) != null)
                        {
                            studentInfo.Add(line);
                        }
                    }
                    List<string> ids = new List<string>();
                    foreach (string si in studentInfo)
                    {
                        ids.Add(si.Split(',')[0].Trim());
                    }

                    foreach (string id in ids)
                    {
                        string properFilePath = System.IO.Path.Combine(currentDirectory, "Data", id + "-" + nameOfCourse + ".txt");
                        List<string> finalGrades = new List<string>();
                        using (StreamReader reader = new StreamReader(properFilePath))
                        {

                            while ((line = reader.ReadLine()) != null)
                            {
                                string[] grades = line.Split(',');
                                if ((int.Parse(grades[1].Trim()) <= int.Parse(amount.Text)) || !(grades[0].Trim()).Equals(category))
                                {
                                    finalGrades.Add(line);
                                }
                            }

                        }
                        File.WriteAllText(properFilePath, String.Empty);
                        using (StreamWriter outputFile = new StreamWriter(properFilePath))
                        {
                            foreach (string l in finalGrades)
                            {
                                outputFile.WriteLine(l);
                            }
                        }
                    }
                    string finalFl = "";
                    string finalSl = "";
                    string finalTl = "";
                    foreach (string fll in firstLineList)
                    {
                        finalFl += fll + ",";
                    }
                    foreach (string fsl in secondLineList)
                    {
                        finalSl += fsl + ",";
                    }
                    foreach (string ftl in thirdLineList)
                    {
                        finalTl += ftl + ",";
                    }
                    finalFl.Trim();
                    finalSl.Trim();
                    finalTl.Trim();
                    File.WriteAllText(categoriesFilePath, String.Empty);
                    using (StreamWriter outputFile = new StreamWriter(categoriesFilePath))
                    {
                        outputFile.WriteLine(finalFl.Trim());
                        outputFile.WriteLine(finalSl.Trim());
                        outputFile.WriteLine(finalTl.Trim());
                    }
                    this.Close();
                    return;
                }


                // Loops through second line, adds all numbers of assessment to list after parsing
                // to later verify if they make up more than 100% of grade
                foreach (string str in secondLine)
                {
                    li.Add(int.Parse(str.Trim()));
                    // Adds to the string which is going to be used to put back into the text file
                    assessmentStr += str.Trim() + ", ";
                }
                foreach (string str in thirdLine)
                {
                    // Adds to the string which is going to be used to put back into the text file
                    amountStr += str.Trim() + ", ";
                }
                // Verifies if all assessments + the one we want to put is equal to more than 100% of the grade
                li.Add(int.Parse(assessment.Text));
                totalAssessmentValue = li.Sum();
                if (totalAssessmentValue > 100)
                {
                    MessageBox.Show("Error: Sum of all assessments cannot be equal to a number above 100");
                    return;
                }
                categoriesStr.TrimEnd();
                assessmentStr.TrimEnd();
                amountStr.TrimEnd();
                categoriesStr += categories.Text + ",";
                assessmentStr += assessment.Text + ",";
                amountStr += amount.Text + ",";
                // Clears the file since it's easier to replace the items inside this way
                File.WriteAllText(categoriesFilePath, String.Empty);
                using (StreamWriter outputFile = new StreamWriter(categoriesFilePath))
                {
                    outputFile.WriteLine(categoriesStr);
                    outputFile.WriteLine(assessmentStr);
                    outputFile.WriteLine(amountStr);
                }
            }
            this.Close();
        }
    }

}
