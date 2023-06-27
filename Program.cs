using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task__3_ternary_operator_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 2;
            int userNumber;
            Console.WriteLine("Введите число: ");
            userNumber = int.Parse(Console.ReadLine());

            while (n <= userNumber - 1) 
            {
                Console.WriteLine(userNumber % n == 0 ? "Число является составным." :userNumber == 2? "Число является простым.":"Число является простым");
                break;
            }
            Console.ReadKey();
            
        }
    }
}
