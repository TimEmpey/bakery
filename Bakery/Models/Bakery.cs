using System;

namespace Bakery.Models
{

  public class Store
  {
    public int PastryAmount { get; set; }
    public int BreadAmount { get; set; }

    public Store(int pastryAmount, int breadAmount)
    {
      PastryAmount = pastryAmount;
      BreadAmount = breadAmount;
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

    public int BreadTotal(int breadAmount)
    {
      int breadCost = 0;
      if (BreadAmount <= 2) {
        breadCost = BreadAmount * 5;
      } else {
        breadCost = (((BreadAmount - (BreadAmount % 3)) * 5) * 2/3) + ((BreadAmount % 3) * 5);
      }
      return breadCost;
    }

    public int Total(int breadCost, int pastryCost)
    {
      int totalPrice = breadCost + pastryCost;
      return totalPrice;
    }
  }
}