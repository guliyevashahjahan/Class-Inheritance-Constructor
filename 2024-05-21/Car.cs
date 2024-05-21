using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_05_21
{
    public class Car
    {
        public Car(string brand,string model, double currentFuel,double fuelPerKm,double millage)
        {
            this.Brand = brand;
            this.Model = model;
            this.CurrentFuel = currentFuel;
            this.FuelPerKm = fuelPerKm;
            this.Millage = millage;
        }
        public string Brand { get; set; }
        public string Model { get; set; }
        public double CurrentFuel { get; set; }
        public double FuelPerKm { get; set; }
        public double Millage { get; set; }
        public void Drive(int km)
        {
            double neededFuel = km * this.FuelPerKm; 
            if (neededFuel > this.CurrentFuel) 
            {
                Console.WriteLine("Go to the gas station :/");
            }
            else
            {
                this.Millage += km;
                CurrentFuel -= neededFuel;
            }
        }
    }
}