using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Number
    {
        private int value;
        public Number()
        {
            Random rnd = new Random();
            value = rnd.Next(100);
        }
        public int Value
        {
            get { return this.value; }
            set { this.value = value; }
        }
        public void print()
        {
            Console.WriteLine(this.Value.ToString());
        }

    }

    public class EvenNumber : Number
    {
        public EvenNumber() : base()
        {
            if (this.Value % 2 != 0)
            {
                this.Value++;
            }
        }
    }
    public class OddNumber : Number
    {
        public OddNumber() : base()
        {
            if (this.Value % 2 == 0)
            {
                this.Value++;
            }
        }
    }

    public class FibNumber : Number
    {
        public FibNumber() : base()
        {
            int a = 0;
            int b = 1;
            int c = 0;

            do
            {
                c = a + b;
                a = b;
                b = c;
            }
            while (c <= this.Value);
            this.Value = c;
        }
    }
}
