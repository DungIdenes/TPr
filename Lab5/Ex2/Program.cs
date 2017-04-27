using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            double s, a, c;
            Console.WriteLine("Киев - 044");
            Console.WriteLine("Харьков - 056");
            Console.WriteLine("Полтава - 052");
            Console.WriteLine("Львов - 046");
            Console.WriteLine();
            Console.Write("Введите код города: ");
             a = double.Parse(Console.ReadLine());
            Console.Write("Введите количество минут: ");
             c = double.Parse(Console.ReadLine());

            if (a == 044)
            {
                s = c * 2.2;
                Console.WriteLine(s + " грн");
            }
            else
            {
                if (a == 056)
                {
                    s = c * 1;
                    Console.WriteLine(s + " грн");
                }
                else
                {
                    if (a == 052)
                    {
                        s = c * 1.2;
                        Console.WriteLine(s + " грн");
                    }
                    else
                    {
                        if (a == 046)
                        {
                            s = c * 1.4;
                            Console.WriteLine(s + " грн");
                        }
                        else
                        {
                            Console.WriteLine(" Неправильный код города");
                        }
                    }
                }
            }
            Console.ReadLine();
        }
    }
}