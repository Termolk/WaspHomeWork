namespace AutoParkSolution.Classes
{
    public class Truck : Car
    {
        public int MaximumCapacity { get; set; }
        public string DriversIdenty { get; set; }
        private Dictionary<string, int> _activeCargo;
    
        public Truck() : base()
        {
            _activeCargo = new Dictionary<string, int>();
            MaximumCapacity = 1000;
            DriversIdenty = "Vasya Pupkin";
        }
    
        public Truck(string brand, int capacity, int yearOfProduction, int maximumCapacity, string driversIdenty)
            : base(brand, capacity, yearOfProduction)
        {
            _activeCargo = new Dictionary<string, int>();
            MaximumCapacity = maximumCapacity;
            DriversIdenty = driversIdenty;
        }
        
            
        public void AddActiveCargo(string key, int value)
        {
            _activeCargo.Add(key, value);
        }
    
        public void DelActiveCargo()
        {
            _activeCargo.Clear();
        }
        
        public void PrintActiveCargo()
        {
            if (_activeCargo.Count != 0)
                Console.WriteLine("Текущий груз:");
            else
                Console.WriteLine("Груза нет");
            
            foreach(KeyValuePair<string, int> kvp in _activeCargo )
            {
                Console.WriteLine($"{kvp.Key} | {kvp.Value}");
            }
            Console.WriteLine();
        }
        
        
        public override string ToString()
        {
            return base.ToString() + 
                   $"Максимальная грузоподъемность: {MaximumCapacity}\n" +
                   $"ФИ водителя: {DriversIdenty}\n";
        }
        
    }
}

