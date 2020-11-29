using System;
using System.Net;

namespace Polymorphism

{
    /*
     https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/polymorphism

     * Polymorphism is often referred to as the third pillar of object-oriented programming,
     * after encapsulation and inheritance. Polymorphism is a Greek word that means "many-shaped"
     * and it has two distinct aspects:

        1- At run time, objects of a derived class may be treated as objects of a base class 
        in places such as method parameters and collections or arrays. 
        When this polymorphism occurs, the object's declared type is no longer identical to its run-time type.

        2- Base classes may define and implement virtual methods, 
        and derived classes can override them, which means they provide their own definition and implementation. 
        At run-time, when client code calls the method, the CLR looks up the run-time type of the object, 
        and invokes that override of the virtual method. In your source code you can call a method on a base class, and cause a derived class's version of the method to be executed.
    
        Allows you to call the same method on different objects
     *
     *
     */

    class Program
    {
        static void Main(string[] args)
        {
            var car = new Automobile { Make = "Ford", Model = "Tauras", Year = 2020 };
            //car.Display();
            Print(car);

            var suv = new Suv { Make = "Ford", Model = "Expedition", Year = 2019 };
            suv.DriveMechanism = "4 Wheel Drive";
            //suv.Display();
            Print(suv);
            Console.ReadLine();
        }

        private static void Print(Automobile auto)
        {
            auto.Display();

        }
    }

    public class Automobile
    {
        // Here I'm foregoing the benefit of 
        // encapsulation ... I may not need it
        // most of the time.
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }


        public virtual void Display()
        {
            Console.WriteLine($"Car: {Make} {Model} {Year}");
        }
    }

    public class Suv : Automobile
    {
        public string DriveMechanism { get; set; }

       
        public override void Display()
        {
            Console.WriteLine($"SUV: {Make} {Model} {Year} {DriveMechanism}");
        }
    }
}
