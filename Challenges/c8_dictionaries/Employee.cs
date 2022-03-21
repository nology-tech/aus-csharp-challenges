using System;
namespace Challenges.c8_dictionaries
{

    public class Employee
    {

        private string name;
        private double salary;

        public Employee() { }

        public Employee(string name, double salary)
        {
            this.name = name;
            this.salary = salary;
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public double GetSalary()
        {
            return salary;
        }

        public void SetSalary(double salary)
        {
            this.salary = salary;
        }

}
}
