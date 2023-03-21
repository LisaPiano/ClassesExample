using ClassesExample;
class Program

{
    static void Main(string[] args)
    {
        Car myCar = new Car();
        {
            myCar.Make = "Toyota";
            myCar.Model = "Highlander";
            myCar.Year = 2013;
        }

        Car mazda = new Car();
        {
            mazda.Make = "Mazda";
            mazda.Model = "CX-5";
            mazda.Year = 2013;
        }

        Car jeep = new Car();
        {
            jeep.Make = "Jeep";
            jeep.Model = "Cherokee";
            jeep.Year = 2008;
        }


        var carList = new List<Car>() {myCar, mazda, jeep };
        foreach (var car in carList) 
        {
            Console.WriteLine($"{car.Make}, {car.Model}, {car.Year}");
        }
    }
}
