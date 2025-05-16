using System;
interface IPrice {
    double GetPrice();
}
class Car : IPrice { public double Price;
    public string? Name;
    public double GetPrice(){ return this.Price; }
    public string? GetName() { return  this.Name; }
}
class Program
{
    static void Main(string[] args)
    {
        Car car = new Car();
        car.Price = 10000;
        car.Name = "Toyota";
        Console.WriteLine(
            $"Car Name: {car.GetName()}\n" +
            $"Car Price: {car.GetPrice()}");
    }
}