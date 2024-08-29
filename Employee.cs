using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Employee : Human
    {
        double _salary;

        public Employee(string firstName, string lastName) : base(firstName, lastName) { }

        public Employee(string firstName, string lastName, double salary) : base(firstName, lastName)
        {
            _salary = salary;
        }
        public Employee(string firstName, string lastName, DateTime birthDate, double salary) : base(firstName, lastName, birthDate)
        {
            _salary = salary;
        }
        //public Employee (string firstName, string lastName, double salary)
        //{
        //    this.firstName = firstName;
        //    this.lastName = lastName;
        //    _salary = salary;
        public void print()
        {
            show();
            Console.WriteLine($"Salary: {_salary}");
        }
    }
}
