using System;
using AutoParkSolution.Classes;

namespace AutoParkSolution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AutoPark autoPark = new AutoPark("WaspAcademyCompanyMegaUltraXorosh");
            
            Car tr1 = new Truck();
            Truck tr2 = new Truck("Cyber Track", 7000, 2077, 30000, "Fucking Samurai");

            PassengerCar ps1 = new PassengerCar();
            Car ps2 = new PassengerCar("Mazda", 120, 2002, 5);
            
            autoPark.AddCar(ps2);
            autoPark.AddCar(tr1);
            autoPark.AddCar(ps1);
            autoPark.AddCar(tr2);

            Console.WriteLine(autoPark);





        }
    }
}