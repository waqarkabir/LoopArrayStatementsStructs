using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evs.myConsoleApp
{
    internal class SwitchMain
    {
        static void Main(string[] args)
        {
            bool terminator = false;

            while (!terminator)
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1) Print Table 2) Terminate Program");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Enter table name");
                        int table = Convert.ToInt32(Console.ReadLine());
                        for (int i = 1; i < 11; i++)
                        {
                            Console.WriteLine($"{table} X {i} = {(i) * table}");
                        }
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Program is terminating on request");
                        terminator = true;
                        break;
                    default:
                        Console.WriteLine("Program is terminating on invalid entry");
                        terminator = true;
                        break;
                }
            }
        }
    }
}
