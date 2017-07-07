using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRYOOP
{
    class Class1
    {
        //field
        public static String s_Name = "Mike";
    }

    class Global //property
    {
        private static string _globalVar = "Waw";
        public static string GlobalVar
        {
            get { return _globalVar; }
            set { _globalVar = value; }
        }
    }
        

    class SimpleMath  //class
    {
        public int AddTwoNumbers(int number1, int number2)
        {
            return number1 + number2;
        }

        public int SquareANumber(int number)
        {
            return number * number;
        }
    }

    public class Person
    {
        // Field
        public string name;
        // Constructor that takes no arguments.
        public Person()
        {
            name = "unknown";
        }
        // Constructor that takes one argument.
        public Person(string nm)
        {
            name = nm;
        }
        // Method
        public void SetName(string newName)
        {
            name = newName;
        }
    }

    public class Personv2
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Personv2(string name, int age)
        {
            Name = name;
            Age = age;
        }
        //Other properties, methods, events...
    }

    public struct Personv3
    {
        //struct
        public string Name;
        public int Age;
        public Personv3(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

    public static class TemperatureConverter
    {
        //When you declare a class as static:
        //It is allowed to have only static members,
        //It cannot be instantiated(it has no public constructor), and
        //It cannot be inherited(it's sealed).

        //Static no need to declare NEW //Cannot be instantiated.
        public static double CelsiusToFahrenheit(string temperatureCelsius)
        {
            // Convert argument to double for calculations.
            double celsius = Double.Parse(temperatureCelsius);

            // Convert Celsius to Fahrenheit.
            double fahrenheit = (celsius * 9 / 5) + 32;

            return fahrenheit;
        }

        public static double FahrenheitToCelsius(string temperatureFahrenheit)
        {
            // Convert argument to double for calculations.
            double fahrenheit = Double.Parse(temperatureFahrenheit);

            // Convert Fahrenheit to Celsius.
            double celsius = (fahrenheit - 32) * 5 / 9;

            return celsius;
        }
    }

}
