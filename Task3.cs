using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class GuessNumber
    {
        private int min;
        private int max;
        private int target;
        private int iterations;

        public GuessNumber(int min, int max)
        {
            this.min = min;
            this.max = max;
        }

        public void SetTarget(int target)
        {
            this.target = target;
        }

        public int Guess()
        {
            iterations = 0;
            int guess = (min + max) / 2;

            while (guess != target)
            {
                iterations++;

                if (guess < target)                
                    min = guess + 1;                
                else                
                    max = guess - 1;               

                guess = (min + max) / 2;
            }

            return iterations;
        }

        public int GetIterations()
        {
            return iterations;
        }
    }
}
