using System;
using Bakery.Models;

namespace Bakery
{
  public class Program
  {
    public static void Main()
    {
      bool userWantsToExit = false;

      while(!userWantsToExit)
      {

        Console.WriteLine("\n" + "Welcome to Empey's Bakery" + "\n");
        Console.WriteLine("We sell pastries and bread");
        Console.WriteLine("Pastries are $2 - Promo: Buy 3 for $5");
        Console.WriteLine("Bread is $5 - Promo: Buy 2 get 1 free" + "\n");
        Console.WriteLine("How many pastries would you like?");
        string stringPastryAmount = Console.ReadLine();
        int pastryAmount = int.Parse(stringPastryAmount);
        Console.WriteLine("How many loafs of bread would you like?");
        string stringBreadAmount = Console.ReadLine();
        int breadAmount = int.Parse(stringBreadAmount);
        if (pastryAmount > 0 || breadAmount > 0){
          Store newStore = new Store (pastryAmount, breadAmount);
          int pastryPrice = newStore.PastryTotal(pastryAmount);
          int breadPrice = newStore.BreadTotal(breadAmount);
          // int total = pastryPrice + breadPrice;
          Console.WriteLine("Your total will be: $" + newStore.Total(breadPrice, pastryPrice));
        }
        Console.WriteLine("\n" + "------------------------" + "\n");
      }
    }
  }
}