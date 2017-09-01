using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UppgiftE
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string sentence = string.Empty;
            string input;
            bool repeat = true;

            do
            {
                Console.WriteLine("Mata in ett ord");
                input = Console.ReadLine();
                if (input.ToLower() == "avsluta")
                {
                    repeat = false;
                }
                else
                {
                    sentence += input + ' ';
                }
            } while (repeat);

            Console.WriteLine(sentence);
        }
    }
}
