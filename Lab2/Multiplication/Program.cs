using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplication
{
    class Program
    {
       public static void Main()
        {
            double a;
            double b;
            Console.WriteLine("Введите первое число для умножения");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число для умножения");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Произведение этих чисел: " + (a * b).ToString ());
            Console.ReadKey();
            
        }
    }
}
