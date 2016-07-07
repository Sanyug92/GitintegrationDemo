﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitIntegrationDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //PrintHello();
            //Console.WriteLine(ReturnGoodBye());
            //PrintGreeting(GetGreeting());

            var myCar  = new Car()
            {
                Make = "Pontiac",
                Model = "Grand Prix GXP",
                InitialCost = 30000,
                TotalPaid = 29999.99,
                TopSpeed = 160,
                Convertible = false,
                Country = "Japan",
                Mileage = 145000,
                YearBought = 2013,
                CurrentYear = 2016,
            };

            var sanyuCar = new Car()
            {
                Make = "BMW",
                Model = "335i",
                InitialCost = 20000,
                TotalPaid = 19000,
                TopSpeed = 260,
                Convertible = false,
                Country = "Germany",
                Mileage = 145000,
                YearBought = 2013,
                CurrentYear = 2016,
    };

            myCar.PrintCarData();
            myCar.IsCarPaid();
            myCar.YearsOfOwnership();
            sanyuCar.PrintCarData();
            sanyuCar.IsCarPaid();
            sanyuCar.YearsOfOwnership();

            //PrintCarData();
            
            var myBike = new Bicycle()
            {
                Make = "Mongoose",
                Color = "Red",
                WheelCount = 2,
                SissyBar = false,
                Horn = false
            };

            myBike.PrintBicycleData();

            Console.ReadKey();
        }

        static void PrintHello()
        {
            //Print something out to the console using a Function
            Console.Write("Hello ");
            Console.WriteLine("Hello");
            Console.WriteLine("Hello");
        }

        static string ReturnGoodBye()
        {
            return "Good Bye";
        }

        static string GetGreeting()
        {
            Console.Write("Please enter a custom greeting: ");
            return Console.ReadLine();
        }

        static void PrintGreeting(string greeting)
        {
            Console.WriteLine("The following greeting has been sent: " + greeting);
        }
    }   
}
