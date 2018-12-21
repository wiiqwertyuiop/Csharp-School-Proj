using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_3___Section_3 {
    class Customer : Person {

        private int _customerNumb;
        private bool _mailing;

        // New customer
        public Customer() { 

            Random rand = new Random();

            _customerNumb = (rand.Next(100000)+100000); // Make a random number that doesn't matter
            _mailing = (rand.Next(2) == 0); // Random bool
        }

        // Check if we are subscribed
        public string Subcribed { 
            get {
                if (_mailing) {
                    return "Yes";
                } else {
                    return "No";
                }
            }
        }

        // Propeties
        public int CustomerNumber {
            get {
                return _customerNumb;
            }
            set {
                _customerNumb = value;
            }
        }

        public bool Mailing {
            get {
                return _mailing;
            }
            set {
                _mailing = value;
            }
        }

    }
}
