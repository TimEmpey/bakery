using System;

namespace Bakery.Models
{

  public class Store
  {
    public int PastryAmount { get; set; }
    public int BreadAmount { get; set; }
    public int PastyTotal(int pastryAmount)
    {
      PastryAmount = pastryAmount;
      return PastryAmount;
    }

    public int BreadTotal(int breadAmount)
    {
      BreadAmount = breadAmount;
      return BreadAmount;
    }
  }
}