using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld
{
    class CMessageBox
    {
        public static void Show(String str)
        {
            MessageBox.Show(str);
        }
    };
    class App 
    {
        public static void Main()
        {
            CMessageBox.Show("Hello, World!");
        }
    }
}
