using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spisaci_zad1
{
    class Program
    {
        public static List<string> Union(List<string> Mywish, List<string> Parentwish)
        {
            List<string> union = new List<string>();
            union.AddRange(Mywish);
            foreach (var item in Parentwish)
            {
                if (!union.Contains(item))
                {
                    union.Add(item);
                }
            }

            return union;
        }

        public static List<string> Intersect(List<string> Mywish, List<string> Parentwish)
        {
            List<string> intersect = new List<string>();         
            foreach (var item in Mywish)
            {
                if (Parentwish.Contains(item))
                {
                    intersect.Add(item);
                }
            }

            return intersect;
        }
        static void Main(string[] args)
            {
                List<string> Mywish = new List<string>();
                List<string> Parentwish = new List<string>();
                string answer;
                do
                {
                    Console.Write("Vuvedi tvoeto jelanie:");
                    string jelanie = Console.ReadLine();
                    Mywish.Add(jelanie);
                    Console.Write("Iskate li da dobavite oshte jelaniq yes/no:");
                    answer = Console.ReadLine();

                }
                while (answer == "yes");
                Console.WriteLine("");
                string answer2;
                do
                {
                    Console.Write("Vuvedi jelaniqta na roditelite ti:");
                    string jelanie2 = Console.ReadLine();
                    Parentwish.Add(jelanie2);
                    Console.Write("Iskate li da dobavite oshte jelaniq yes/no:");
                    answer2 = Console.ReadLine();
                }
                while (answer2 == "yes");
                Console.WriteLine("");

            List<string> wishes = Union(Mywish, Parentwish);
            Console.WriteLine("Jelaniqta vi sa:");
            foreach (var i in wishes)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("");
            List<string> samewish = Intersect(Mywish, Parentwish);
            Console.WriteLine("Sushtite jelaniq sa:");
            foreach (var i in samewish)
            {
                Console.Write(i + " ");
            }
        }
    }
    }

