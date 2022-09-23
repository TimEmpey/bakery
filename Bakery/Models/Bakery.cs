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
    public int PastyTotal(int pastryAmount)
    {
      return PastryAmount;
    }

    public int BreadTotal(int breadAmount)
    {
      return BreadAmount;
    }
  }
}