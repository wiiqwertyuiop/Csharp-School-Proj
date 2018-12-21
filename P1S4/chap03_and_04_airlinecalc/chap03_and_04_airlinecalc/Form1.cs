using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chap03_and_04_airlinecalc
{
    /*
     * Author: Christian Chernock
     * Date: 2/17/2018
     * 
     * Plane flight ticket calculator. Calculates total amount of tickets purchased, as well as the price, post and pre, all discounts and PA tax.
     */
     
    public partial class CISAirways : Form
    {
        public CISAirways()
        {
            InitializeComponent();
        }

        decimal AdultTicketCost = 500;
        decimal TeenTicketCost = 325;
        decimal ChildrenTicketCost = 175;

        decimal TotalCost = 0;

        const decimal TaxRate = 0.06m;

        private void CalculateBttn_Click(object sender, EventArgs e)
        {
            int ATicketCount = 0;
            int TTicketCount = 0;
            int CTicketCount = 0;


            if (!int.TryParse(AdultTicketCount.Text, out ATicketCount)) {
                MessageBox.Show("Be sure Adult ticket count is a valid interger number.", "Data entry error...", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                AdultTicketCount.Focus();
                AdultTicketCount.SelectAll();
                return;
            }

            if (!int.TryParse(TeenTicketCount.Text, out TTicketCount))
            {
                MessageBox.Show("Be sure Teen ticket count is a valid interger number.", "Data entry error...",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                TeenTicketCount.Focus();
                TeenTicketCount.SelectAll();
                return;
            }

            if (!int.TryParse(ChildrenTicketCount.Text, out CTicketCount))
            {
                MessageBox.Show("Be sure Child ticket count is a valid interger number.", "Data entry error...",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                ChildrenTicketCount.Focus();
                ChildrenTicketCount.SelectAll();
                return;
            }

            decimal Discount = 0;

            TotalTicketCount.Text = (ATicketCount + TTicketCount + CTicketCount).ToString();

            TotalCost = ((AdultTicketCost * ATicketCount) + (TeenTicketCost * TTicketCount) + (ChildrenTicketCost * CTicketCount));

            Pre_discountCost.Text = TotalCost.ToString("c");

            if (AAABox.Checked == true) {
                Discount += .10m;
            }

            if (SamsClubBox.Checked == true) {
                Discount += 0.12m;
            }

            if (WeekendBox.Checked == true) {
                Discount += 0.20m;
            }

            TotalCost -= (TotalCost * Discount);
            TotalCost += (TotalCost * TaxRate);

            Post_discountCost.Text = TotalCost.ToString("c");

        }

        private void ExitBttn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit the application?", "Close Application", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                if (TotalCost <= 999.99m) {
                    MessageBox.Show("Your Final Total was: " + Post_discountCost.Text + "\r\nThis amount qualifies for 'A-100' frequent flier miles.", "", MessageBoxButtons.OK);

                } else if (TotalCost <= 1499.99m) {
                    MessageBox.Show("Your Final Total was: " + Post_discountCost.Text + "\r\nThis amount qualifies for 'B-500' frequent flier miles.", "", MessageBoxButtons.OK);

                } else if (TotalCost <= 2499.99m) {
                    MessageBox.Show("Your Final Total was: " + Post_discountCost.Text + "\r\nThis amount qualifies for 'C-750' frequent flier miles.", "", MessageBoxButtons.OK);

                } else {
                    MessageBox.Show("Your Final Total was: " + Post_discountCost.Text + "\r\nUnkown Post-discount Cost. Please Contact the IT Department for more details.", "", MessageBoxButtons.OK);
                }

                this.Close();
            }
        }

        private void CISAirways_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (MessageBox.Show("Are you sure you want to exit the application?", "Close Application", MessageBoxButtons.YesNo) == DialogResult.No)
            //{
            //    e.Cancel = true;
            //}
        }

        //private void CISAirways_Load(object sender, EventArgs e)
        //{
        //    DateLabel.Text = DateTime.Today.ToString("MM/dd/yyyy");

        //    AdultTicketCount.Focus();
        //}

        private void ResetBttn_Click(object sender, EventArgs e)
        {
            AdultTicketCount.Text = "0";
            TeenTicketCount.Text = "0";
            ChildrenTicketCount.Text = "0";

            AAABox.Checked = false;
            SamsClubBox.Checked = false;
            WeekendBox.Checked = false;

            FirstClassBttn.Checked = true;

            //FirstClassAdult.Text = "$500.00";
            //FirstClassTeen.Text = "$325.00";
            //FirstClassChild.Text = "$175.00";

            //CoachAdult.Text = "$375.00";
            //CoachTeen.Text = "$280.00";
            //CoachChild.Text = "$80.00";

            TotalTicketCount.Text = "0";
            Pre_discountCost.Text = "$0.00";
            Post_discountCost.Text = "$0.00";

            TotalCost = 0;

            DateLabel.Text = DateTime.Today.ToString("MM/dd/yyyy");

            AdultTicketCount.Focus();
            AdultTicketCount.SelectAll();
        }

        private void FirstClassBttn_CheckedChanged(object sender, EventArgs e)
        {
            AdultTicketCost = 500;
            TeenTicketCost = 325;
            ChildrenTicketCost = 175;
        }

        private void CoachBttn_CheckedChanged(object sender, EventArgs e)
        {
            AdultTicketCost = 375;
            TeenTicketCost = 280;
            ChildrenTicketCost = 80;
        }
    }
}
