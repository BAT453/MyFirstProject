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
            int n = 4; 
            int s = 0; 
            for (int k = 1; k-- >= n ; s += k) 
                Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
