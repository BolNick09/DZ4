using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Human
    {
        int _id;
        protected string firstName;//защищенное поле
        protected string lastName;
        DateTime _birthDate;

        public Human (string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
        public Human(string firstName, string lastName, DateTime dateTime)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            _birthDate = dateTime;
        }

        public void show()
        {
            Console.WriteLine($"Last name: {lastName}\nFirst name: {firstName}\nBirth date: {_birthDate.ToShortDateString()}");
        }
    }
}
