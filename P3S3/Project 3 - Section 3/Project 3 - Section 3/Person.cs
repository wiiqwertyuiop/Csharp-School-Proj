using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_3___Section_3 {
    class Person {

        private string _name;
        private string _address;
        private string _telephone;

        public Person() {
            _name = "";
            _address = "";
            _telephone = "";
        }

        // Properties
        public string Name {
            get {
                return _name;
            }
            set {
                _name = value;
            }
        }

        public string Address {
            get {
                return _address;
            }
            set {
                _address = value;
            }
        }

        public string Telephone {
            get {
                return _telephone;
            }
            set {
                _telephone = value;
            }
        }
    }
}
