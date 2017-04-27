using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            double s, a;
            Console.Write("Стоимость покупки: ");
            a = float.Parse(Console.ReadLine());
            if (a < 100)
            {
                Console.WriteLine(a);
            }
            else
            {
                if (a >= 100 && a < 250)
                {
                    s = a / 100 * 10;
                    a = a - s;
                    Console.WriteLine("Стоимость покупки с 10% скидкой: "+ a);
                }
                else
                {
                    if (a >= 250 && a < 500)
                    {
                        s = a / 100 * 15;
                        a = a - s;
                        Console.WriteLine("Стоимость покупки с 15% скидкой: " + a);
                    }
                    else
                    {
                        if (a >= 500)
                        {
                            s = a / 100 * 20;
                            a = a - s;
                            Console.WriteLine("Стоимость покупки с 20% скидкой: " + a);
                        }
                        else
                        {
                            Console.WriteLine("Ошибка в цене!");
                        }
                    }
                }
            }
            Console.ReadLine();
        }
    }
}