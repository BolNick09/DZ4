using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Manager : Employee
    {
        string _fieldActivity;
        public Manager (string firstName, string lastName, DateTime birthDate, double salary, string activity) 
            : base (firstName, lastName, birthDate, salary)
        {
            _fieldActivity = activity;
        }
        public void ShowManager()
        {
            Console.WriteLine($"Manager work field: {_fieldActivity}");
        }

    }
}
