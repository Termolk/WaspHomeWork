namespace AutoParkSolution.Classes
{
    public class PassengerCar : Car
    {
        public int NumberOfPassengers { get; set; }

        private Dictionary<string, int> _repairBook;

        public PassengerCar() : base()
        {
            _repairBook = new Dictionary<string, int>();
            NumberOfPassengers = 1;
        }

        public PassengerCar(string brand, int capacity, int yearOfProduction, int numberOfPassengers)
            : base(brand, capacity, yearOfProduction)
        {
            _repairBook = new Dictionary<string, int>();
            NumberOfPassengers = numberOfPassengers;
        }
        
        public int GetYearInRepairBook(string detail)
        {
            return _repairBook[detail];
        }
        
        public void AddRepairBook(string key, int value)
        {
            _repairBook.Add(key, value);
        }

        public void PrintRepairBook()
        {
            Console.WriteLine("Вся ремонтная книга: Деталь | Год");
            
            foreach(KeyValuePair<string, int> kvp in _repairBook )
            {
                Console.WriteLine($"{kvp.Key} | {kvp.Value}");
            }

            Console.WriteLine();
        }

        public override string ToString()
        {
            return base.ToString() + 
                   $"Количество пассажиров: {NumberOfPassengers}\n";
        }
    }
}

