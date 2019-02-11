using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickAscii
{
    class Program
    {
        static void Main(string[] args)
        {
            QuickAscii();
        }
        static void QuickAscii()
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter choice:");
                    string choice = Console.ReadLine().ToLower();
                    if (choice == "chtonum"||choice=="chn")
                    {
                        chtonum();
                    }
                    else if (choice == "numtoch"||choice=="nch")
                    {
                        numtoch();
                    }
                    else
                    {
                        Error();
                    }
                }
                catch (Exception)
                {
                    Error();
                }
            }
        }

        static void chtonum()
        {
            Console.Write("Enter Symbol:");
            char letter = char.Parse(Console.ReadLine());
            ushort converted = (ushort)letter;
            Console.WriteLine($"The Symbol {letter} is:" + converted);
            Console.WriteLine(" ");
        }

        static void numtoch()
        {
            Console.Write("Enter number:");
            ushort num = ushort.Parse(Console.ReadLine());
            char converted = (char)num;
            Console.WriteLine($"The Ascii symbol of {num} is:"+converted);
            Console.WriteLine(" ");
        }

        static void Error()
        {
            Console.WriteLine("Error");
            Console.WriteLine(" ");
        }
    }
}
