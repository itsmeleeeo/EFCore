using System;
using System.Linq;
using static System.Console;
using Microsoft.EntityFrameworkCore;
using CarApp.Domain;
using CarApp.Data;

namespace ConsoleApp1
{
    internal class Program
    {
            private static CarContext context = new CarContext();

            private static void Main(string[] args)
            {
                context.Database.EnsureCreated();
                GetCars("Before Adding");
                AddCars();
                GetCars("After Adding");
                InsertMultipleCars();
                Write("Press Any Key...");
                ReadKey();
            }

            private static void AddCars()
            {
                var query = context.cars;

                foreach (var car in query)
                {
                    WriteLine(car.Model);
                }
            }

            private static void GetCars(string text)
            {
                var cars = context.cars.ToList();
                WriteLine($"{text}: Car count is {cars.Count}");
            }

            private static void InsertMultipleCars()
            {
                var cars = new Car { Year = 2017, Model = "Civic", Color = "Gray" };
                var cars2 = new Car { Year = 2010, Model = "Corolla", Color = "Black" };

                context.cars.AddRange(cars);
                context.SaveChanges();
            }
        }
    }