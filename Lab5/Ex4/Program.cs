using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] MyArr = new int[7];

            Console.WriteLine("Введите элементы масива: ");
            for (int i = 0; i < MyArr.Length; i++)
            { 
                MyArr[i] = Convert.ToInt32(Console.ReadLine());
            }

            int min = int.MaxValue;
            for (int k = 0; k < MyArr.Length ; k++)
            {
                if (MyArr[k] < min)
                { 
                    min = MyArr[k];
                }
            }
            Console.WriteLine("Наименьший элемент массива: " + min);
            Console.ReadLine();
        }      
    }
}
