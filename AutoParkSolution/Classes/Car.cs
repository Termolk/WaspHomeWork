namespace AutoParkSolution.Classes
{
    public class Car
    {
        public string Brand { get; set; }
        public int Capacity { get; set; }
        public int YearOfProduction { get; set; }

        public Car()
        {
            Brand = "Undefined";
            Capacity = 100;
            YearOfProduction = 2004;
        }
        
        public Car(string brand, int capacity, int yearOfProduction)
        {
            Brand = brand;
            Capacity = capacity;
            YearOfProduction = yearOfProduction;
        }

        public override string ToString()
        {
            return $"Название класса: {GetType()}\n" +
                   $"Марка машины: {Brand}\n" +
                   $"Мощность машины: {Capacity}\n" +
                   $"Год производства: {YearOfProduction}\n";
        }
    }
}