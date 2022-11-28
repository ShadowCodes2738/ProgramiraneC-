using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spisaci
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> spisak = new List<int>();
            Console.WriteLine("Broi na vuvejdane");
            int n = int.Parse(Console.ReadLine());
            //vuvejdane v spisak edin po drug
           for(int i = 0; i< n; i++)
            {
                spisak.Add(int.Parse(Console.ReadLine()));
            }
            //izvejdane
            Console.WriteLine("Vuvedenite chisla sa");
            for (int i = 0; i < n; i++)
            {
                // Console.WriteLine(spisak[i]);
                //Console.WriteLine("spisak[{0}]={1}");
                Console.WriteLine("spisak[{0}]={1}",i,spisak[i]);
            }
            //izvejdane na sva elementa
            Console.WriteLine("spisak[1]=" + spisak[2]);
            //izvejdane na posledniq element
            Console.WriteLine("spisak[{0}]={1}",spisak.Count-1,spisak[spisak.Count-1]);
        }
    }
}
