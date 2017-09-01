using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UppgiftB
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mata in en mening.");
            string sentence = Console.ReadLine();

            string[] words = sentence.Split(' ');
            string[] wordsSorted = new string[words.Length];

            Array.Sort(words);

            foreach (string s in words)
                Console.WriteLine(s);

            Array.Reverse(words);

            foreach (string s in words)
                Console.WriteLine(s);
        }
    }
}
