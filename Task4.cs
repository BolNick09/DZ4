using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class PseudoTextGenerator
    {
        private Random random;
        private int maxVowels;//гласные
        private int maxConsonants;//согласные
        private int maxLength;

        public PseudoTextGenerator(int maxVowels, int maxConsonants, int maxLength)
        {
            this.random = new Random();
            this.maxVowels = maxVowels;
            this.maxConsonants = maxConsonants;
            this.maxLength = maxLength;
        }

        public string Generate()
        {
            StringBuilder sb = new StringBuilder();
            
            int numVowels = random.Next(1, maxVowels + 1);
            int numConsonants = random.Next(1, maxConsonants + 1);
            int wordLength = random.Next(1, maxLength + 1);
            
            for (int i = 0; i < numVowels; i++)            
                sb.Append(GetRandomVowel());
            
            for (int i = 0; i < numConsonants; i++)            
                sb.Append(GetRandomConsonant());            

            // Перетасовать буквы в слове
            char[] chars = sb.ToString().ToCharArray();
            Shuffle(chars);
            sb.Clear();
            sb.Append(chars);

            // Ограничить длину слова
            if (sb.Length > wordLength)            
                sb.Remove(wordLength, sb.Length - wordLength);
            

            return sb.ToString();
        }

        private char GetRandomVowel()
        {
            int index = random.Next(0, 5);
            return "aeiou".ToCharArray()[index];
        }

        private char GetRandomConsonant()
        {
            int index = random.Next(0, 21);
            return "bcdfghjklmnpqrstvwxyz".ToCharArray()[index];
        }

        private void Shuffle(char[] chars)
        {
            for (int i = 0; i < chars.Length; i++)
            {
                int randomIndex = random.Next(i, chars.Length);
                char temp = chars[i];
                chars[i] = chars[randomIndex];
                chars[randomIndex] = temp;
            }
        }
        public string GenerateSentence(int numWords)
        {
            StringBuilder sb = new StringBuilder();
            
            for (int i = 0; i < numWords; i++)
            {
                sb.Append(Generate() + " ");
            }
            
            sb.Remove(sb.Length - 1, 1);
            
            sb[0] = char.ToUpper(sb[0]);
            sb.Append(".");

            return sb.ToString();
        }
    }
}
