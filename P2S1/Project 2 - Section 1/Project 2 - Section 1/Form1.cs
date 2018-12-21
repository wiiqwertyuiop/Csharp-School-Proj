using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_2___Section_1
{
    public partial class P2S1Form : Form
    {
        /* Author: Christian Chernock
         * Date: 3/24/2018 

         * This program calculates the daily change of growth in a population of organisms. 
         * It does so by taking the starting number of organisms, and increasing/decreasing it by a percentage over a specified number of days. 

        */

        public P2S1Form()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            outputListBox.Items.Add("Ready.");
            NumbOrganismsTextBox.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NumbOrganismsTextBox.Text = "";
            DailyINCTextBox.Text = "";
            DaysTextBox.Text = "";

            outputListBox.Items.Clear();
            outputListBox.Items.Add("Cleared.");

            NumbOrganismsTextBox.Focus();

            outputListBox.Items.Add("");
            outputListBox.Items.Add("Ready.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit the application?", "Close Application", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            decimal numbOrganisms;
            decimal percent;
            int days;

            String error = "number of organisms";

            outputListBox.Items.Clear();

            try {

                numbOrganisms = decimal.Parse(NumbOrganismsTextBox.Text);

                if (numbOrganisms <= 0)
                {
                    outputListBox.Items.Add("Number of organisms cannot be zero or negative.");
                    return;
                }

                error = "average daily increase";

                percent = decimal.Parse(DailyINCTextBox.Text);
                percent /= 100;

                error = "number of days";

                days = int.Parse(DaysTextBox.Text);

                if (days < 0)
                {
                    outputListBox.Items.Add("Number of days cannot be negative.");
                    return;
                }

            } catch {

                outputListBox.Items.Add("Invalid data entered for " + error + "!");
                return;
            }

            try
            {
                for (int a = 1; a != days + 1; a++)
                {
                    outputListBox.Items.Add("Day " + a + " approximate population is: " + numbOrganisms.ToString("#.###"));

                    //decimal temp = numbOrganisms * percent;
                    numbOrganisms += numbOrganisms * percent;

                    if (numbOrganisms <= 0.000001m)
                    {
                        outputListBox.Items.Add("");
                        outputListBox.Items.Add("Calculations stopped, too small.");
                        return;
                    }
                }
            } catch
            {
                outputListBox.Items.Add("");
                outputListBox.Items.Add("Calculations stopped, too large.");
                return;
            }

            outputListBox.Items.Add("");
            outputListBox.Items.Add("Done!");

        }
    }
}
