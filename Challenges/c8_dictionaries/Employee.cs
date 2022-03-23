using System;
namespace Challenges.c8_dictionaries
{

    public class Employee
    {

        private string _name;
        private double _salary;

        public Employee() { }

        public Employee(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }

        public string Name { get; set; }
        public double Salary { get; set; }

    }
}
