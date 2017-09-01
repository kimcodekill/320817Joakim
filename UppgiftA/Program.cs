using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UppgiftA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mata in en mening.");
            string sentence = Console.ReadLine();

            string[] words = sentence.Split(' ');
            Console.WriteLine(words.Length);

            foreach (string s in words)
                Console.WriteLine(s + " (" + s.Length + ')');
        }
    }
}
