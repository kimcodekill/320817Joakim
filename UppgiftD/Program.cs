using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UppgiftD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mata in en mening.");
            string sentence = Console.ReadLine();
            string newSentence = string.Empty;

            foreach (char c in sentence)
            {
                if (c != ' ')
                {
                    if (!newSentence.Contains(c))
                        newSentence += c;                        
                }
            }

            int[] charCount = new int[newSentence.Length];

            foreach (char c in newSentence)
            {
                int count = 0;
                foreach (char v in sentence)
                    if (c == v)
                        count++;
                charCount[newSentence.IndexOf(c)] = count;
            }

            foreach (char c in newSentence)
                Console.WriteLine(c + " (" + charCount[newSentence.IndexOf(c)] + ')');
        }
    }
}
