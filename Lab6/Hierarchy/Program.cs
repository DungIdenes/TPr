using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{
    public class Test
    {
        private int Mark;
        private string Questions;
        private int Duration;
    }
    public class Vuprobyvannya : Test
    {
        private int Mark;
        private string Questions;
        private int Duration;
    }
    public class Isput : Vuprobyvannya
    {
        private int Mark;
        private string Questions;
        private int Duration;
    }
    public class VupysknuyIsput : Isput
    {
        private int Mark;
        private string Questions;
        private int Duration;
    }
    public class MainClass
    {
        static void Main(string[] args)
        {

        }

    }
    
}
