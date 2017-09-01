using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UppgiftF
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int num = r.Next(1, 21);
            int guess;
            bool isWinner = false;

            do
            {
                Console.WriteLine("Gissa ett tal mellan 1-21");
                guess = Convert.ToInt32(Console.ReadLine());

                if (guess == num)
                {
                    isWinner = true;
                    Console.WriteLine("Grattis!");
                }

            } while (!isWinner);
        }
    }
}
