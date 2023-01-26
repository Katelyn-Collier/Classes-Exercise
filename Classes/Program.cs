namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "Toyota";
            myCar.Model = "Corolla";
            myCar.Color = "Silver";
            myCar.Year = 2021;

            var secondCar = new Car()
            {
                Make = "Ford",
                Model = "Mustang",
                Color = "White",
                Year = 1997
            };

            var thirdCar = new Car("Jeep", "Wrangler", "Black", 2017);

            var carList = new List<Car>() { myCar, secondCar, thirdCar};

            foreach (var vehicle in carList)
            {
                Console.WriteLine($"{vehicle.Make} {vehicle.Model} {vehicle.Color} {vehicle.Year}");
            }

        }
    }
}
