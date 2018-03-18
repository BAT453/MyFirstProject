using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //4.6 -> last element 4.5
            //4.7 -> last element 4.7
            //5.4 - 9.9 with (9)

            int length = 11;

            for (double i = 4; i < length; i += 0.1)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
