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

namespace Project_3___Section_2 {
    public partial class P3S2EmployeesForm : Form {

        /*
         * Employee Data Generator
         *         by
         *  Christian Chernock
         * 
         * Adds entered employee data to a list, and allows the whole list to be viewed when desired but clicking a button.
         * 
         * The list can also be outputted to a .txt file.
         * 
         */

        public P3S2EmployeesForm() {
            InitializeComponent();
        }

        Employee myEmployee = new Employee();

        private void ExitButton_Click(object sender, EventArgs e) {

            if (MessageBox.Show("Are you sure you want to exit the application?", "Close Application",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                Application.Exit();
            }
        }

        private void AddButton_Click(object sender, EventArgs e) {


            if (NameTextBox.Text == "") {
                MessageBox.Show("Employee name not entered.");
                NameTextBox.Focus();
                return;
            }

            int IDNumber;

            try {
                IDNumber = int.Parse(IDTextBox.Text);
            } catch {
                MessageBox.Show("Invalid Employee ID.");
                IDTextBox.Focus();
                return;
            }

            myEmployee.NewEmployee(NameTextBox.Text,  IDNumber, DepartmentTextBox.Text, PositionTextBox.Text);

            NameTextBox.Clear();
            IDTextBox.Clear();
            DepartmentTextBox.Clear();
            PositionTextBox.Clear();

            ListBox.Items.Add("Employee: " + IDNumber + " added!");

            NameTextBox.Focus();

        }

        private void VeiwListButton_Click(object sender, EventArgs e) {

            if (myEmployee.EmployeeListCount() > 1) {

                ListBox.Items.Clear();

                for (int a = 0; a != myEmployee.EmployeeListCount(); a++) {

                    ListBox.Items.Add(myEmployee.EmployeeList( a ));
                }

            } else {

                ListBox.Items.Clear();
                ListBox.Items.Add("Employee list is empty!");
            }

        }

        private void ClearButton_Click(object sender, EventArgs e) {
            myEmployee.EmployeeListClear();
            ListBox.Items.Clear();
            ListBox.Items.Add("Cleared.");
        }

        private void OuputListBox_Click(object sender, EventArgs e) {

            // Try writing text file
            try {

                if (myEmployee.EmployeeListCount() < 2) {

                    MessageBox.Show("Employee list is empty!");
                    return;
                }

                StreamWriter outputFile;
                outputFile = File.CreateText("P3S2 List Box Export.txt");

                for (int a = 0; a != myEmployee.EmployeeListCount(); a++) {

                    outputFile.WriteLine(myEmployee.EmployeeList(a));

                }

                outputFile.Close();
                MessageBox.Show("Done!");            


            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
