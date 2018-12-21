using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_3___Section_3 {
    public partial class P3S3Form : Form {
        public P3S3Form() {
            InitializeComponent();
        }

        /* Person->Customer Generator
         *         by
         *  Christian Chernock
         * 
         * Generators a customer object after form data is entered. No data validation is programmed, so it is assumed correct data is entered.
         * Customer number and whether or not he/she is on the mailing list are random.
         * 
         */

        private void ExitButton_Click(object sender, EventArgs e) {

            if (MessageBox.Show("Are you sure you want to exit the application?", "Close Application",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                Application.Exit();
            }

        }

        private void CreateButton_Click(object sender, EventArgs e) {

            Customer NewPerson = new Customer();

            NewPerson.Name = NameBox.Text;
            NewPerson.Address = AddrBox.Text;
            NewPerson.Telephone = TeleBox.Text;

            MessageBox.Show("Name:\n" + NewPerson.Name + "\n\n"
                + "Address:\n" + NewPerson.Address + "\n\n"
                + "Telephone:\n" + NewPerson.Telephone + "\n\n"
                + "Customer Number:\n" + NewPerson.CustomerNumber + "\n\n"
                + "Subcribed to mailing list?:\n" + NewPerson.Subcribed);
        }

    }
}
