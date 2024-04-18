using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionsAndMore3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> chisla = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            Func<List<int>, int> minfunc = n =>
            {
            int min = n[0];
                foreach (var item in n)
                {
                    if(min > item)
                    {
                        min = item;
                    }
                }
                return min;
            };
            Console.WriteLine(minfunc(chisla));
        }
    }
}
