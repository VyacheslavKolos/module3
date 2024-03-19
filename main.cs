using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

class Car
{
    public string Brand { get; set; }
    public string Number { get; set; }
    public int Year { get; set; }
    public decimal Price { get; set; }

    public Car(string brand, string number, int year, decimal price)
    {
        Brand = brand;
        Number = number;
        Year = year;
        Price = price;
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Car> cars = new List<Car>
        {
            new Car("Toyota", "ABC123", 2020, 25000),
            new Car("Honda", "DEF456", 2018, 20000),
            new Car("Ford", "GHI789", 2019, 22000),
        };

        IEnumerable<string> numbers = cars.AsParallel().Select(car => car.Number);

        foreach (string number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}
