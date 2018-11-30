using System;


namespace EmployeeClass
{
    class Employee
    {
        //Declare Fields
        private string _name;
        private Int32 _idnumber;
        private string _department;
        private string _position;

        //Default Constructor
        public Employee()
        {
            _name = "";
            _idnumber = 0;
            _department = "";
            _position = "";
        }

        //Constructor passing name and idnumber
        public Employee(string name, Int32 idnumber)
        {
            _name = name;
            _idnumber = idnumber;
            _department = "";
            _position = "";
        }

        //Constructor passing all arguments
        public Employee(string name, Int32 idnumber, string department, string position)
        {
            _name = name;
            _idnumber = idnumber;
            _department = department;
            _position = position;
        }

        //Getters and Setters
        public string Name { get; set; }

        public Int32 IdNumber { get; set; }

        public string Department { get; set; }

        public string Position { get; set; }

    }
}
