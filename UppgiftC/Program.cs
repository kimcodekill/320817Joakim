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

            /*  Hade velat använda list här
             *  
             *  List<string> newWords = new List<string>();
             *  
             *  foreach (string s in words)
             *      if (!newWords.Contains(s)
             *          newWords.Add(s);
             *  
             *  int[] wordCount = new int[newWords.Count]
             *  foreach (string s in newWords)
             *  {
             *      int count = 0;
             *      foreach (string d in words)
             *          if (s = d)
             *              count++;
             *      wordCount[newWords.IndexOf(s)] = count;
             *  }
             *  
             */
            string newWordsString = string.Empty;
            foreach (string s in words)
            {
                if (!newWordsString.Contains(s))
                {
                    newWordsString += s + '.';
                }
            }

            string[] newWords = newWordsString.Split('.');

            //foreach (string s in newWords)
            //    Console.WriteLine(s + " (" + wordCount[newWords.IndexOf(s)] + ')');
        }
    }
}
