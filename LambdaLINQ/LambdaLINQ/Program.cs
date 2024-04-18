using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] masiv = new int[n];
            for (int i = 0; i < n; i++)
            {
                masiv[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Sum:"+masiv.Sum());
            Console.WriteLine("Min:" + masiv.Min());
            Console.WriteLine("Max:" + masiv.Max());
            Console.WriteLine("Avarage:" + masiv.Average());

        }
    }
}
