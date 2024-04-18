using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionsAndMore2
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> dumaPrint = n => Console.WriteLine(n);
            List<string> dumi = Console.ReadLine().Split(' ').ToList();
            foreach (var name in dumi)
            {
                dumaPrint(name);
            }
        }
    }
}
