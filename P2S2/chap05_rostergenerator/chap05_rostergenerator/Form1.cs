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
using System.Drawing.Printing;

namespace RosterGenerator
{
    public partial class StartupForm : Form {

        /*
         * Author: Christian Chernock
         * Date: 3/25/2018
         * 
         * Roster Generator
         * 
         * Allows you to add, delete, edit, and move players around however you want until you have a roster of desired players.
         * You can then print, or save the players you've chosen to a seperate file.
         * 
         * 
         */

        public StartupForm()
        {
            InitializeComponent();
        }

        private void StartupForm_Load(object sender, EventArgs e)
        {
            TeamComboBox.SelectedIndex = 0;
        }

        //****************************
        //
        // Basic form buttons below
        //

        private void ExitBttn_Click(object sender, EventArgs e) {
            ApplicationExit();
        }

        private void DeleteAllAvailBttn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to clear the available players?", "Confirm clear",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                AvailPlayersListBox.Items.Clear();
            }
        }

        private void Mov1AvailBttn_Click(object sender, EventArgs e) {

            if (AvailPlayersListBox.SelectedIndex == -1) {
                MessageBox.Show("No player selected in \"Available Players\".");
            } else {
                SelPlayersListBox.Items.Add(AvailPlayersListBox.SelectedItem.ToString());
                AvailPlayersListBox.Items.RemoveAt(AvailPlayersListBox.SelectedIndex);
            }
        }

        private void Mov1SelBttn_Click(object sender, EventArgs e) {

            if (SelPlayersListBox.SelectedIndex == -1) {
                MessageBox.Show("No player selected in \"Selected Players\".");
            } else {
                AvailPlayersListBox.Items.Add(SelPlayersListBox.SelectedItem.ToString());
                SelPlayersListBox.Items.RemoveAt(SelPlayersListBox.SelectedIndex);
            }
        }

        private void MovAllAvailBttn_Click(object sender, EventArgs e) {

            if (AvailPlayersListBox.Items.Count == 0) {
                MessageBox.Show("There are no players to be moved.");
            } else {

                while (AvailPlayersListBox.Items.Count != 0) {
                    SelPlayersListBox.Items.Insert(0, AvailPlayersListBox.Items[0].ToString());
                    AvailPlayersListBox.Items.RemoveAt(0);
                }

            }
        }

        private void MovAllSelAvailBttn_Click(object sender, EventArgs e) {

            if (SelPlayersListBox.Items.Count == 0) {
                MessageBox.Show("There are no players to be moved.");
            } else {

                while (SelPlayersListBox.Items.Count != 0) {
                    AvailPlayersListBox.Items.Insert(0, SelPlayersListBox.Items[0].ToString());
                    SelPlayersListBox.Items.RemoveAt(0);
                }
            }
        }

        private void Delete1AvailBttn_Click(object sender, EventArgs e) {

            if (AvailPlayersListBox.SelectedIndex != -1) { 
                AvailPlayersListBox.Items.RemoveAt(AvailPlayersListBox.SelectedIndex);
            } else if (SelPlayersListBox.SelectedIndex != -1) {
                SelPlayersListBox.Items.RemoveAt(SelPlayersListBox.SelectedIndex);
            } else {
                MessageBox.Show("No player selected.");
            }
        }

        //**********************************
        // Edit names and Add write in buttons
        //
        // These two buttons work together for name editing
        //
        // When you edit it changes the name of the buttons and thier funtion
        // 
        // If the variable BackupPlayerName is not "" it means we are editing a name and that is how the buttons know to act differently
        //

        string BackupPlayerName = "";     // Holds un-edited player names incase the user cancels editing a name 
        bool WhichEditPlayerName = true;// Tells which List Box the edited name belongs to so we can put it back
        // true = Available Players list
        // false = Selected Players list

        private void EditAvailBttn_Click(object sender, EventArgs e) {
            if (BackupPlayerName == "") {

                if (AvailPlayersListBox.SelectedIndex != -1) {

                    BackupPlayerName = AvailPlayersListBox.SelectedItem.ToString();
                    AvailPlayersListBox.Items.RemoveAt(AvailPlayersListBox.SelectedIndex);

                    WhichEditPlayerName = true;

                } else if (SelPlayersListBox.SelectedIndex != -1) {

                    BackupPlayerName = SelPlayersListBox.SelectedItem.ToString();
                    SelPlayersListBox.Items.RemoveAt(SelPlayersListBox.SelectedIndex);

                    WhichEditPlayerName = false;

                } else {

                    MessageBox.Show("No player selected.");
                    return;
                }

                WriteInPlayerTextBox.Text = BackupPlayerName;
                WriteInLabel.Text = "Edit Name";
                EditAvailBttn.Text = "Cancel Edit";
                AddWriteInPlayerBttn.Text = "Confirm Edit";

                EditAvailBttn.Focus();

            } else {

                WriteInLabel.Text = "Write-in Player";
                EditAvailBttn.Text = "&Edit";
                AddWriteInPlayerBttn.Text = "&Add";

                if (WhichEditPlayerName) {
                    AvailPlayersListBox.Items.Add(BackupPlayerName);
                } else {
                    SelPlayersListBox.Items.Add(BackupPlayerName);
                }

                BackupPlayerName = "";

                WriteInPlayerTextBox.Clear();
                WriteInPlayerTextBox.Focus();

            }
        }

        private void AddWriteInPlayerBttn_Click(object sender, EventArgs e) {

            if (BackupPlayerName != "") {

                if (WriteInPlayerTextBox.Text == "") {

                    MessageBox.Show("Edited name cannot be blank.");
                    WriteInPlayerTextBox.Focus();

                } else {

                    WriteInLabel.Text = "Write-in Player";
                    EditAvailBttn.Text = "&Edit";
                    AddWriteInPlayerBttn.Text = "&Add";

                    if (WhichEditPlayerName) {
                        AvailPlayersListBox.Items.Add(WriteInPlayerTextBox.Text);
                    } else {
                        SelPlayersListBox.Items.Add(WriteInPlayerTextBox.Text);
                    }

                    BackupPlayerName = "";

                    WriteInPlayerTextBox.Clear();
                    WriteInPlayerTextBox.Focus();

                }

            } else {

                if (WriteInPlayerTextBox.Text == "") {

                    MessageBox.Show("Please enter a player name first.");
                    WriteInPlayerTextBox.Focus();

                } else {

                    AvailPlayersListBox.Items.Add(WriteInPlayerTextBox.Text);
                    WriteInPlayerTextBox.Clear();
                    WriteInPlayerTextBox.Focus();

                }
            }

        }

        //**************************************
        //
        // Import and Export Buttons
        //

        private void ImportRosterBttn_Click(object sender, EventArgs e) {

            try {

                StreamWriter DefaultRosterFile;

                DefaultRosterFile = File.CreateText("DefaultRosterFile.txt");

                DefaultRosterFile.WriteLine("Anderson, Pete");
                DefaultRosterFile.WriteLine("Coggins, Rich");
                DefaultRosterFile.WriteLine("McAndrew, Jim");
                DefaultRosterFile.WriteLine("Williams, Ted");

                DefaultRosterFile.Close();
                MessageBox.Show("Default roster file created. Click \"OK\" to import this roster.");

            } catch (Exception GenericException) {
                MessageBox.Show(GenericException.Message);
                return;
            }

            try {

                StreamReader InputFile;

                InputFile = File.OpenText("DefaultRosterFile.txt");
                AvailPlayersListBox.Items.Clear();

                while (!InputFile.EndOfStream) {
                    string PlayerNameString = InputFile.ReadLine();
                    AvailPlayersListBox.Items.Add(PlayerNameString);
                }

                InputFile.Close();
                MessageBox.Show("Default roster file imported. Click \"OK\" to continue.");

            } catch (Exception GenericException) {
                MessageBox.Show(GenericException.Message);
            }
        }

        private void ExportRosterBttn_Click(object sender, EventArgs e) {

            if (SelPlayersListBox.Items.Count == 0) {
                MessageBox.Show("No selected players to export.");
                return;
            }

            try {

                ExportRosterFolderBrowserDialog.ShowDialog();

                string SelectedLocationString = ExportRosterFolderBrowserDialog.SelectedPath + "/";
                StreamWriter SelectedPlayersRosterFile;

                SelectedPlayersRosterFile = File.CreateText(SelectedLocationString + "SelectedPlayersRoster.txt");

                SelectedPlayersRosterFile.WriteLine(WriteOutputToString());

                SelectedPlayersRosterFile.Close();
                MessageBox.Show("Selected player(s) roster file exported. Click \"OK\" to continue.");

            } catch (Exception GenericException) {
                MessageBox.Show(GenericException.Message);
            }

        }

        //**************************************
        //
        // Print button
        //

        private void PrintRosterBttn_Click(object sender, EventArgs e) {

            string Print = WriteOutputToString();

            PrintDocument p = new PrintDocument();

            p.PrintPage += delegate (object sender1, PrintPageEventArgs e1) {
                e1.Graphics.DrawString(Print, new Font("Times New Roman", 12), new SolidBrush(Color.Black), new RectangleF(0, 0, p.DefaultPageSettings.PrintableArea.Width, p.DefaultPageSettings.PrintableArea.Height));
            };

            try {
                p.Print();
            } catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }
        }
        
        //
        //
        //********************************

        private void moveUpToolStripMenuItem_Click(object sender, EventArgs e) {
            MoveUpButton();
        }

        private void MoveUpFormBttn_Click(object sender, EventArgs e) {
            MoveUpButton();
        }

        private void MoveUpButton() {
            MoveListBoxItem(-1);
        }

        private void MoveDownButton() {
            MoveListBoxItem(1);
        }

        private void sortToolStripMenuItem_Click(object sender, EventArgs e) {
            AvailPlayersListBox.Sorted = true;
            SelPlayersListBox.Sorted = true;
        }

        private void MoveDownFormBttn_Click(object sender, EventArgs e) {
            MoveDownButton();
        }

        private void moveDownToolStripMenuItem_Click(object sender, EventArgs e) {
            MoveDownButton();
        }

        //**************************
        //
        // Move List Box Item function
        //
        // the value passed on to it is how far up or down to move it on the list
        //
        // Values < 0 means move up,
        // > 0 means move down
        //

        private void MoveListBoxItem(int UpOrDown) {

            ListBox SelectedListBox;

            AvailPlayersListBox.Sorted = false;
            SelPlayersListBox.Sorted = false;

            if (AvailPlayersListBox.SelectedIndex != -1) {

                SelectedListBox = AvailPlayersListBox;

            } else if (SelPlayersListBox.SelectedIndex != -1) {

                SelectedListBox = SelPlayersListBox;

            } else {
                MessageBox.Show("No player is selected.");
                return;

            }

            int a = SelectedListBox.SelectedIndex;
            int b = a + UpOrDown;

                if (b <= -1) {

                    MessageBox.Show("Already at the top of the list.");
                    return;
                } else if (b >= SelectedListBox.Items.Count) {
                    MessageBox.Show("Already at the bottom of the list.");
                    return;
                }

            string temp = SelectedListBox.SelectedItem.ToString();
            SelectedListBox.Items.RemoveAt(a);

            SelectedListBox.Items.Insert(b, temp);
        }

        //**************************
        //
        // Exit Application function
        //
        // Also displays a message box to make sure the user wants to exit
        //

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            ApplicationExit();
        }

        private void ApplicationExit() {
            if (MessageBox.Show("Are you sure you want to exit the application?", "Close Application",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                Application.Exit();
            }
        }
    

        //************************
        //
        // Formats and writes Selected Players list box to a string
        // which is then returned
        // 

        private string WriteOutputToString() {

            string output;

            output = TeamComboBox.SelectedItem.ToString() + "  - Selected Player(s)\r\n";

            output += String.Empty.PadRight(50, '=').ToString() + "\r\n";

            for (int CurPlayerInteger = 0; CurPlayerInteger < SelPlayersListBox.Items.Count; CurPlayerInteger += 1) {

                output += ((CurPlayerInteger + 1).ToString() +
                    ". " + SelPlayersListBox.Items[CurPlayerInteger].ToString() + "\r\n");

            }

            output += ("\r\n\r\n\r\nNote: Manager signature gets written below.\r\n\r\n");
            output += (String.Empty.PadRight(40, '_').ToString() +
                String.Empty.PadRight(10, ' ') + DateTime.Now.ToString("MM/dd/yyyy"));

            return output;
        }
    }
}
