namespace AutoParkSolution.Classes
{
    public class AutoPark
    {
        public string Name { get; set; }
        private List<Car> _cars;

        public AutoPark()
        {
            Name = "АвтоПарк";
            _cars = new List<Car>();
        }

        public AutoPark(string name) : this()
        {
            Name = name;
        }
        
        public AutoPark(List<Car> cars) : this()
        {
            _cars = cars;
        }
        
        public AutoPark(List<Car> cars, string name)
        {
            _cars = cars;
            Name = name;
        }

        public override string ToString()
        {
            string output;
            output = $"\nИмя автопарка: {Name}" +
                     $"\nМашины: ";
            foreach (Car car in _cars)
            {
                output = output + "| " + car.Brand + " ";
            }
            
            
            return output;
        }

        public void AddCar(Car car)
        {
            _cars.Add(car);
        }
    }
}