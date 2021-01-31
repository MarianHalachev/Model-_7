using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
                Console.Write("Enter grade: ");
                double ocenka = double.Parse(Console.ReadLine());
                if (ocenka >= 5.50 && ocenka <= 6.00)
                {
                    Console.WriteLine($"Excellent! {ocenka}");
                }
                else if (ocenka <= 5.49 && ocenka >= 4.50)
                {
                    Console.WriteLine($"Very good! {ocenka}");
                }

                else if (ocenka <= 4.49 && ocenka >= 3.50)
                {
                    Console.WriteLine($"Good! {ocenka}");
                }

                else if (ocenka <= 3.49 && ocenka >= 3.00)
                {
                    Console.WriteLine($"Average! {ocenka}");
                }

                else if (ocenka < 3.00)
                {
                    Console.WriteLine($"Poor! {ocenka}");
                }
            
        }
    }
}
