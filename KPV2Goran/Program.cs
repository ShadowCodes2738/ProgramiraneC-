using System;

namespace KPV2Goran
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vuvedete dve dvuichni chisla:");
            string chislo1 = Console.ReadLine();
            string chislo2 = Console.ReadLine();
            Console.Write("Vuvedete znak:");
            string znak = Console.ReadLine();
           int chislo11 = Convert.ToInt16(chislo1);
           int chislo22 = Convert.ToInt16(chislo2); 
           int znak1 = Convert.ToInt16(znak);
            if (znak == "+")
            {
                int sum = chislo11 + chislo22;
                int sum2 = Convert.ToInt16(sum);
                Console.WriteLine("Poluchihte=" + sum2);
            }
            else if (znak == "-")
            {
                int sum = chislo11 - chislo22;
                int sum2 = Convert.ToInt16(sum);
                Console.WriteLine("Poluchihte="+sum2);
            }

             else if (znak == "x")
            {
                int sum = chislo11 * chislo22;
                int sum2 = Convert.ToInt16(sum);
                Console.WriteLine("Poluchihte=" + sum2);

            }
            else if (znak == "/")
            {
                int sum = chislo11 / chislo22;
                int sum2 = Convert.ToInt16(sum);
                Console.WriteLine("Poluchihte=" + sum2);

            }
        }
    }
}
