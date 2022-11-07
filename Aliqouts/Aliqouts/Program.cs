using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aliqouts
{
    class Program
    {
        static void Main(string[] args)
        {
            AliqoutN x = new AliqoutN(5);
            x.SumN(10);
            Console.WriteLine(x.P);
            x.SumN(7);
        }
    }
}
