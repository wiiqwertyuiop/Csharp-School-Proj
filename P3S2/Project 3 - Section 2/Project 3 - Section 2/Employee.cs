using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_3___Section_2 {

    class Employee {

        private string _name;
        private int _idnumber;
        private string _department;
        private string _position;

        private List<string> _employeeList = new List<string>();

        public Employee() {
            _name = "";
            _department = "";
            _position = "";
            _idnumber = 0;

            _employeeList.Add("Name | " + " ID Number | " + " Department | " + " Position");

        }

        public void NewEmployee(string Name, int IDNumber, string Department, string Position) {

            _name = Name;
            _department = Department;
            _position = Position;
            _idnumber = IDNumber;

            StoreToList();
        }

        public void NewEmployee(string Name, int IDNumber) {

            _name = Name;
            _department = "";
            _position = "";
            _idnumber = IDNumber;

            StoreToList();
        }

        public void StoreToList() {
            _employeeList.Add(_name + " |  " + _idnumber + " |  " + _department + " |  " + _position);
        }

        public int EmployeeListCount() {
            return _employeeList.Count;
        }

        public void EmployeeListClear() {
            _employeeList.Clear();
            _employeeList.Add("Name | " + " ID Number | " + " Department | " + " Position");
        }

        public string EmployeeList(int a) {
            return _employeeList[a];
        }
        
        //
        // Class properties
        //

        public string Name {

            get {
                return _name;
            }

            set {
                _name = value;
            }
        }

        public int IDNumber {

            get {
                return _idnumber;
            }

            set {
                _idnumber = value;
            }
        }

        public string Position {

            get {
                return _position;
            }

            set {
                _position = value;
            }
        }

        public string Department {

            get {
                return _department;
            }

            set {
                _department = value;
            }
        }

    }
}
