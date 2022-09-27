using System;

namespace Bakery.Models
{

  public class Pastry
  {
    public int PastryAmount { get; set; }

    public Pastry(int pastryAmount)
    {
      PastryAmount = pastryAmount;
    }
    public int PastryTotal(int pastryAmount)
    {
      int pastryCost = 0;
      if (PastryAmount <= 2) {
        pastryCost = PastryAmount * 2;
      } else {
        pastryCost = (((PastryAmount - (PastryAmount % 3)) / 3) * 5) + ((PastryAmount % 3) * 2);
      }
      return pastryCost;
    }

    public int Total(int breadCost, int pastryCost)
    {
      int totalPrice = breadCost + pastryCost;
      return totalPrice;
    }
  }
}