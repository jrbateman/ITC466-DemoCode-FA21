using System;

namespace Encapsulation
{

    /*
     *  Encapsulation
     *  https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/
     *
        Encapsulation is sometimes referred to as the first pillar or principle of object-oriented programming. 
        According to the principle of encapsulation, a class or struct can specify how accessible each of its members 
        is to code outside of the class or struct. 
        Methods and variables that are not intended to be used from outside of the class or assembly 
        can be hidden to limit the potential for coding errors or malicious exploits.

        Used to hide the implementation details of a class/method

        propfull tab tab full implemented property
        
        prop tab tab auto implements property but throws out encapulation.  No private variable

     *
     */

   class Program
        {
            static void Main(string[] args)
            {
                var car = new Car() { MyProperty = 7 };
                car.Display();
                Console.ReadLine();
            }
        }

        class Car
        {
            private int myVar;

            public int MyProperty
            {
                get
                {
                    // Only reveal this to 
                    // users with certain rights
                    // in the system.
                    // if (User.Role = "Admin")
                    return myVar;
                }
                set
                {
                    // Does this value make sense?
                    // if (value < 0 or > 2000)
                    myVar = value;
                }
            }


            public void Display()
            {
                var value = CreateDisplay();
                Console.WriteLine(value);
            }

            private string CreateDisplay()
            {
                return $"Car: {myVar}";
            }

            //public int MyOtherProperty { get; set; }


        }
    }

