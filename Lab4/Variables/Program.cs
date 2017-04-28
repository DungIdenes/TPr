using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
          //  Testing ts = new Testing(5, 10, "Точка1");

            ts.SimpleVars();
        }
    }
    class Testing
    {
        public void SimpleVars()
        {
            int x, s;
            int у = 0, u = 77;
            float w1 = 0f, w2 = 5.5f, w3 = w1 + w2 + 125.25f; //Пропущенна запятая
            int z = new int();
          //  int v = new int(77);
            x = u + y;
            if (x > 5) s = 4;
            for (x = 1; x < 5; x++) s = 5;
            Console.WriteLine("s= {0}", s);
        }
        public void ScopeVar(int x)
        {
            //int x=0;
            int у = 77; string s = name;
            if (s == "Точка1")
            {
                int u = 5; int v = u + y; x += 1;
                Console.WriteLine("y= {0}; u={1}; v ={ 2}; x ={ 3}", у, u, v, x);
            }
            else
            {
                int u = 7; int v = u + y;
                Console.WriteLine("y= {0}; u={1}; v={2}", у, u, v);
            }
            Console.WriteLine("y= {0}; u={1}; v={2}", y, u, v);
            //static int Count = 1; - недопустим для эелмека

            Console.WriteLine("x= {0}; sum ={1}", x, sum);
            int i; long sum = 0;
            for (i = 1; i < x; i++)
            {
                float у = 7.7f;
                sum += i;
            }
            Console.WriteLine("x= {0}; sum ={1}", x, sum);

        }
        public void Constants()

        {

            const int SmallSize = 38, LargeSize = 58;
            const int MidSize = (SmallSize + LargeSize) / 2;
            const double pi = 3.141593;
            LargeSize = 60;
            Console.WriteLine("MidSize= {0}; pi={1}", MidSize, pi);
        }
    }
    }