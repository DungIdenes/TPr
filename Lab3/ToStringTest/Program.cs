using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToString
{
    class String
    {
        private string s = "Денис";
        private int ux = 20;
        private double s1 = 0, dy=18637;
        
        public void ToStringTest()
        {
            Convert.ToString(ux);
            Convert.ToString(s1);
            Convert.ToString(dy);
        }
        public void WhoIsWho()
        {
            Console.WriteLine("Имя: " + s);
            Console.WriteLine("Возраст: " + ux);
            Console.WriteLine("Моя зарплата: " + s1);
            Console.WriteLine("Желаемая зарплата: " + dy);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            String obj = new String();
            obj.ToStringTest();
            obj.WhoIsWho();
            Console.ReadLine();

        }
    }
}

