using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDriving
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("PP2149AB", 20, 8, 21000);
            Console.Write("Input need km");
            double needkm = Double.Parse(Console.ReadLine());
            if (car.CanDrive(needkm))
            {
                car.Drive(needkm);
                Console.WriteLine("You Drove {0}k:", needkm);
            }
            else
            {
                Console.WriteLine("You can not drive:");
            }
        }
    }
}
