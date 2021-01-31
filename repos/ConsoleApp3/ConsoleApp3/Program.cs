using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "6";
            int number = int.Parse(line);
            for (int i = 2; i < number; i++)
            {
                Console.WriteLine(i*4);
            }
        }
    }
}
