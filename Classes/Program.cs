using System.Reflection;

namespace Classes
{
    public class Car
    {
        public Car() { }
        public string make;
        public string model;
        public int year;

    }




    public class Program
    {
        static void Main(string[] args)
        {
            //    CCreate a class named Car - make sure it is public
            //    In the Car class:
            //    Create a Make property of type string that is public
            //    Create a Model property of type string that is public
            //    Create a Year property of type int that is public
            //    In the Main method:
            //    Create a new instance of the Car class
            //    Set values in the properties for the object
            //    Print the values of each property to the Console
            //    

            var car = new Car() { make = "Nissan", model = "Murano", year = 2006};
            Console.WriteLine($"{car.year} {car.make} {car.model}");

        }
    }
}
