using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UppgiftC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mata in en mening.");
            string[] words = Console.ReadLine().Split(' ');
            string[] newWords;
            
            do
            {
                int i = 0;
                string newWordsString = string.Empty;
                foreach (string s in words)
                {
                    if (!newWordsString.Contains(s))
                    {
                        newWordsString += s + ' ';
                    }
                }
            }
        }
    }
}
