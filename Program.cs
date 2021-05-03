using System;
using System.Collections.Generic;

namespace CarDealership
{
  class Program
  {
    static void Main(string[] args)
    {
      Car volkswagen = new Car();
      volkswagen.MakeModel = "1974 Volkswagen Thing";
      volkswagen.Price = 1100;
      volkswagen.Miles = 368792;

      Car yugo = new Car();
      yugo.MakeModel = "1980 Yugo Koral";
      yugo.Price = 700;
      yugo.Miles = 56000;

      Car ford = new Car();
      ford.MakeModel = "1988 Ford Country Squire";
      ford.Price = 1400;
      ford.Miles = 239001;

      Car amc = new Car();
      amc.MakeModel = "1976 AMC Pacer";
      amc.Price = 400;
      amc.Miles = 198000;

      List<Car> Cars = new List<Car>() { volkswagen, yugo, ford, amc };

      foreach (Car automobile in Cars)
      {
        Console.WriteLine(automobile.MakeModel);
      }
    }
  }
}
