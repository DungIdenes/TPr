using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            bool b = true;
            Console.WriteLine("Введите число: ");
            a = int.Parse(Console.ReadLine());
            for (int i = 2; i <= a / 2; i++)
            {
                if (a % i == 0)
                {
                    b = false;
                    break;
                }
            }
            if (b == true)
            {

                Console.WriteLine("Число целое!");
            }
            else
            {
                Console.WriteLine("Число не является целым!");
            }
            Console.ReadKey();
        }
    }
}
