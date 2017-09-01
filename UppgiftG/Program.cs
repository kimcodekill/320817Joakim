using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UppgiftG
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mata in en mening");
            string sentence = Console.ReadLine();

            
            foreach(char c in sentence)
            {
                switch (c)
                {
                    case 'a':
                        sentence = sentence.Replace(c, '@');
                        break;
                    case 'b':
                        sentence = sentence.Replace(c, '8');
                        break;
                    case 'c':
                        sentence = sentence.Replace(c, '(');
                        break;
                    case 'd':
                        sentence = sentence.Replace(c.ToString(), "|>");
                        break;
                    case 'e':
                        sentence = sentence.Replace(c, '3');
                        break;
                    case 'f':
                        sentence = sentence.Replace(c.ToString(), "|=");
                        break;
                    case 'g':
                        sentence = sentence.Replace(c, '6');
                        break;
                    case 'h':
                        sentence = sentence.Replace(c, '#');
                        break;
                    case 'i':
                        sentence = sentence.Replace(c, '!');
                        break;
                    case 'j':
                        sentence = sentence.Replace(c.ToString(), "_|");
                        break;
                    case 'k':
                        sentence = sentence.Replace(c.ToString(), "|<");
                        break;
                    case 'l':
                        sentence = sentence.Replace(c, '1');
                        break;
                    case 'm':
                        sentence = sentence.Replace(c.ToString(), "|\\/|");
                        break;
                    case 'n':
                        sentence = sentence.Replace(c.ToString(), "|\\|");
                        break;
                    case 'o':
                        sentence = sentence.Replace(c.ToString(), "()");
                        break;
                    case 'p':
                        sentence = sentence.Replace(c.ToString(), "|D");
                        break;
                    case 'q':
                        sentence = sentence.Replace(c.ToString(), "(,)");
                        break;
                    case 'r':
                        sentence = sentence.Replace(c.ToString(), "|2");
                        break;
                    case 's':
                        sentence = sentence.Replace(c, '5');
                        break;
                    case 't':
                        sentence = sentence.Replace(c, '7');
                        break;
                    case 'u':
                        sentence = sentence.Replace(c.ToString(), "|_|");
                        break;
                    case 'v':
                        sentence = sentence.Replace(c.ToString(), "\\/");
                        break;
                    case 'w':
                        sentence = sentence.Replace(c.ToString(), "\\/\\/");
                        break;
                    case 'x':
                        sentence = sentence.Replace(c.ToString(), "}{");
                        break;
                    case 'y':
                        sentence = sentence.Replace(c.ToString(), "'/");
                        break;
                    case 'z':
                        sentence = sentence.Replace(c.ToString(), "(\\)");
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine(sentence);
        }
    }
}