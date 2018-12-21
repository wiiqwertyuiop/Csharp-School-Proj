using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_1___Section_3
{
    /* Author: Christian Chernock
     * Date: 2/16/18 
 
     * This program calculates a persons BMI (Body Mass Index) using the infromation (weight and height) entered by the user
     * BMI is calculated using this formula:
     * BMI = weight × 703 ÷ height2
     
     * It also tells you the BMI category you fall under
     
    */

    public partial class BMICalculator : Form
    {
        public BMICalculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OutputTextBox.Text = "Ready!";
        }

        private void CalcButton_Click(object sender, EventArgs e)
        {

            try {
                double LBS = double.Parse(LBSBox.Text);
                double INS = double.Parse(INSBox.Text);

                if (INS > 21.6) {

                    double BMI = (LBS * 703) / (INS*INS);

                    String BMICategories = "Underweight";

                    if (BMI >= 30) {
                        BMICategories = "Obesity";
                    } else if (BMI >= 25.5) {
                        BMICategories = "Overweight";
                    } else if (BMI >= 18.5) {
                        BMICategories = "Normal Weight";
                    }

                    OutputTextBox.Text = "Your BMI: " + BMI.ToString("n2") + "\r\n" + "BMI Cataegory: " + BMICategories;

                } else {
                    OutputTextBox.Text = "Invalid height entered!";
                }

            } catch
            {
                OutputTextBox.Text = "Invalid data entered!";
            }
          
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            LBSBox.Text = String.Empty;
            INSBox.Text = String.Empty;
            OutputTextBox.Text = "Entries have been reset!";
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit the application?", "Close Application", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                this.Close();
            }

        }

        private void BMICalculator_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (MessageBox.Show("Are you sure you want to exit the application?", "Close Application", MessageBoxButtons.YesNo) == DialogResult.No)
            //{
            //    e.Cancel = true;
            //}
        }
    }
}
