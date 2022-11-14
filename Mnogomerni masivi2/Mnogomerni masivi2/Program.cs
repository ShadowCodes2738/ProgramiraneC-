using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mnogomerni_masivi2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Redove");
             int row = int.Parse(Console.ReadLine());
             Console.WriteLine("Koloni");
             int coll = int.Parse(Console.ReadLine());
             int[,] matrix = new int[row, coll];

             for (int roww = 0; roww < row; roww++)
             {
                 for (int col = 0; col < coll; col++)
                 {
                     matrix[roww, col] = int.Parse(Console.ReadLine());
                 }
             }
             for (int roww = 0; roww < row; roww++)
             {
                 for (int col = 0; col < coll; col++)

                 {
                     Console.WriteLine(matrix[roww, col] + " ");
                 }
                 Console.WriteLine();
             }*/
            Console.WriteLine("Redove");
            int row = int.Parse(Console.ReadLine());
            Console.WriteLine("Koloni");
            int coll = int.Parse(Console.ReadLine());
           // 1.  / 0.25 / Въвежда в масив[5x7] оборота от продажбите за всеки ден .
            int[,] oborot = new int[5, 7];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < coll; j++)

                {
                    Console.WriteLine("Oborot");
                    oborot[i, j] = int.Parse(Console.ReadLine());
                }
            }
         //   2.  / 0.25 / Извежда в табличен вид оборота от продажбите за 35 дни.
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < coll; j++)
                {
                    Console.Write(oborot[i, j] + " ");
                }
                Console.WriteLine();
            }
            // 5 /1.5/ Намира получените средства само за уикендите / съботи и недели
            Console.WriteLine("Oboroti za weekendite");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 5; j < 7; j++)
                {
                    Console.Write(oborot[i, j] + " ");
                }
                Console.WriteLine("<-Weekends");            
            }
        }
    }
}
