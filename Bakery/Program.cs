using System;
using Bakery.Models;

namespace Bakery
{
  public class Program
  {
    public static void Main()
    {

      Console.WriteLine("\n" + "Welcome to Empey's Bakery" + "\n");

      bool userWantsToExit = false;

      while(!userWantsToExit)
      {
        Console.WriteLine("Inventory" + "\n" + "Pastries: $2 - Bread: $5" + "\n");
        Console.WriteLine("Promos" + "\n" + "-------" + "\n" + "Bread: buy 2 get 1 free" + "\n" + "Pastries: 3 for $5" + "\n");
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
          Console.WriteLine("------------------------");
          Console.WriteLine("Cart" + "\n" + "Pastries - " + pastryAmount + "\n" + "Bread - " + breadAmount);
          Console.WriteLine("Your total will be: $" + newStore.Total(breadPrice, pastryPrice));
        } else {
          Console.WriteLine("\n" + "Error" + "\n" + "Theres nothing in your cart");
        }
        Console.WriteLine("\n" + "------------------------" + "\n");
        Console.WriteLine("Would you like to shop some more? (YES / NO)" + "\n");
        string response = Console.ReadLine().ToUpper();
        if (response == "YES"){
          userWantsToExit = false;
          Console.WriteLine("------------------------");
        } else {
          Console.WriteLine("\n" + "Have a nice day!");
          userWantsToExit = true;
        }
      }
    }
  }
}