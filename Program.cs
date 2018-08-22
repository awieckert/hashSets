using System;
using System.Collections.Generic;

namespace hashSets
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      HashSet<string> Showroom = new HashSet<string>();
      Showroom.Add("M3");
      Showroom.Add("M5");
      Showroom.Add("Mustang GT500");
      Showroom.Add("Civic");

      Console.WriteLine($"There are {Showroom.Count} cars in your show room");

      HashSet<string> UsedCars = new HashSet<string>();
      UsedCars.Add("1998 Accord");
      UsedCars.Add("1977 Corvette");

      Showroom.UnionWith(UsedCars);
      Showroom.Remove("M5");

      Console.WriteLine($"You now have {Showroom.Count} cars!");

      HashSet<string> JunkYard = new HashSet<string>();
      JunkYard.Add("Corrolla");
      JunkYard.Add("Preus");
      JunkYard.Add("M3");
      JunkYard.Add("Civic");

      HashSet<string> clone = new HashSet<string>(Showroom);
      clone.IntersectWith(JunkYard);

      foreach (string item in clone)
      {
        Console.WriteLine($"This is your clone {item}");
      }
      // Console.WriteLine($"These are in both the showroom and junkyard: {}");

      Showroom.UnionWith(JunkYard);

      foreach (string item in Showroom)
      {
        Console.WriteLine($"You now have this car in your collection: {item}");
      }
    }
  }
}
