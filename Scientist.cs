using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Scientist : Employee
    {
        string _qual;
        public Scientist(string firstName, string lastName, DateTime birthDate, double salary, string qual)
            : base(firstName, lastName, birthDate, salary)
        {
            _qual = qual;
        }

        public void ShowScientist()
        {
            Console.WriteLine($"Scientist qualification: {_qual}");
        }
    }
}
