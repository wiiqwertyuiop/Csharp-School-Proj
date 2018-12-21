using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Project_3___Section_1 {

    public partial class P3S1DataFileTasksForm : Form {

        /*
         * Filter List by Letter
         *         by
         *  Christian Chernock
         * 
         * Imports a file and puts it into a listbox;
         * you can then filter the list and output it to a file using a drop down box.
         *
         * You can outputs the file as a comma delimited .csv file or a fixed width .txt file.
         * 
         */


        public P3S1DataFileTasksForm() {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e) {

            if (MessageBox.Show("Are you sure you want to exit the application?", "Close Application",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                Application.Exit();
            }

        }

        private void P3S1DataFileTasksForm_Load(object sender, EventArgs e) {

            try {

                // Read file
                StreamReader inputFile;
                inputFile = File.OpenText("P3S1 Data File For Import.txt");

                // Loop through file
                int a = 0;
                while (!inputFile.EndOfStream) {

                    // Read the current line in the file
                    string currentLine = inputFile.ReadLine();

                    // If we are not on the first two lines of the file
                    // and the current line is not blank...
                    if (a > 1 && currentLine != "") {
                        // ...add the current line from the text file to the CDC list
                        CDCListBox.Items.Add(currentLine);
                    }

                    a++;
                }

                // Close file
                inputFile.Close();

            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

            // Start at letter 'C' in drop down box
            LetterDropBox.SelectedIndex = 2;

        }

        private void ExportCSVButton_Click(object sender, EventArgs e) {

            // Try writing csv file
            try {

                StreamWriter outputFile;
                outputFile = File.CreateText("P3S1 Fixed Width Export.csv");

                char SortBy = LetterDropBox.Text[0]; // Get the letter to filter from drop box
                bool IsThereAtLeastOneMatch = false; // Used to tell if we have any matches or not

                // Loop through all of the CDC list
                for (int index = 0; index < CDCListBox.Items.Count; index++) {

                    // Read current country we are on
                    string Line = CDCListBox.Items[index].ToString();

                    // Get the first char and see if it matches our filter
                    if (char.ToUpper(Line[0]) == SortBy) { // SortBy is always capital, so make the country name capital as well just incase it isn't

                        
                        if (IsThereAtLeastOneMatch) { // If this is our first entry do put a comma yet
                            outputFile.Write(",");
                        }

                        IsThereAtLeastOneMatch = true;
                        outputFile.Write("\"" + Line + "\"");

                    }

                }

                if (!IsThereAtLeastOneMatch) {
                    outputFile.WriteLine("RECORD CRITERIA HAS 0 MATCHES");
                    MessageBox.Show("The criteria has no matches.");
                } else {
                    MessageBox.Show("Done!");
                }

                outputFile.Close();

            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

        }

        private void ExportTXTButton_Click(object sender, EventArgs e) {

            // Try writing text file
            try {

                StreamWriter outputFile;
                outputFile = File.CreateText("P3S1 Fixed Width Export.txt");

                char SortBy = LetterDropBox.Text[0];
                bool IsThereAtLeastOneMatch = false;

                int newline = 0;

                for (int index = 0; index < CDCListBox.Items.Count; index++) {

                    string Line = CDCListBox.Items[index].ToString();

                    if (char.ToUpper(Line[0]) == SortBy) {

                        //if (!IsThereAtLeastOneMatch) {
                            //outputFile.WriteLine(String.Format("{0,-9}1{0,9}2{0,9}3{0,9}4{0,9}5{0,9}6", ""));
                            //outputFile.WriteLine("123456789012345678901234567890123456789012345678901234567890");
                            IsThereAtLeastOneMatch = true;
                        //}

                        
                        if (newline >= 3) {
                            outputFile.WriteLine(String.Format("{0,9}", Line));
                            newline = 0;
                        } else {
                            outputFile.Write(String.Format("{0,-9}  ", Line));
                            newline++;
                        }
                        
                    }

                }

                if (!IsThereAtLeastOneMatch) {
                    outputFile.WriteLine("THE CRITERIA HAS NO MATCHES");
                    MessageBox.Show("The criteria has no matches.");
                } else {
                    MessageBox.Show("Done!");
                }

                outputFile.Close();

                

            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
