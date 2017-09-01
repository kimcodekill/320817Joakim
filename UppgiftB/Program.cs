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

            for (int i =0; i < words.Length; i++)
            {
                string word = words[i];
                int j = i;
                while (j>0 && words[j-1].Length.CompareTo(word.Length) > 0)
                {
                    words[i] = words[j - 1];
                    j = j - 1;
                }
                words[j] = word;
            }

            foreach (string s in words)
            {
                Console.WriteLine(s);
            }

            for (int i = words.Length; i > 0; i--)
                Console.WriteLine(words[i-1]);
        }
    }
}
