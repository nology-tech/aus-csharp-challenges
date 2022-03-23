using System;
namespace Challenges.c9_forEach_and_linq
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
