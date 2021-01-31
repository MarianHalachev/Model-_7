using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <=a; i++)
            {
                Console.WriteLine("*");
                for (int k = 1; k <=i; k++)
                {
                    Console.Write("*");
                }
      
            }
            Console.WriteLine();

        }
    }
}
