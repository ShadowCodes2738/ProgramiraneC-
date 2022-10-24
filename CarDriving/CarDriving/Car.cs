using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDriving
{
    class Car
    {
        private string number;
        private double fuel;
        private double fuelKm;
        private double km;

        public string Number
        {
            get
            {
                return number;
            }
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length > 8)
                {
                    throw new ArgumentException("Number length cant be greater than 8 symbols");
                }
                else
                {
                    number = value;
                }
            }
        }
        public double Fuel
        {
            get
            {
                return fuel;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Fuel must be a positive number");
                }
                else
                {
                    fuel = value;
                }
            }
        }
        public double FuelKm
        {
            get
            {
                return fuelKm;
            }
            set
            {
                if (value < 3)
                {
                    throw new ArgumentException("fuelKm must be greater than 3");
                }
                else
                {
                    fuelKm = value;
                }
            }
        }
        public double Km
        {
            get
            {
                return km;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("km must be a positive number");
                }
                else
                {
                    km = value;
                }
            }
        }
        public Car(string number, double fuel, double fuelkm, double km)
        {
            this.Number = number;
            this.Fuel = fuel;
            this.FuelKm = fuelkm;
            this.Km = km;
        }
        public Car() : this("xxxxxxxx", 10, 10, 10)
        { }
        public void Drive(double runkm)
        {
            km += runkm;
            fuel -= (fuelKm / 100) * runkm;
        }
        public bool CanDrive(double needkm)
        {
            double maxkm = fuel * 100 / fuelKm;
            if (maxkm >= needkm)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}

    

