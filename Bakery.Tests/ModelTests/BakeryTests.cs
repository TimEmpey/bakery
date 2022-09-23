using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class ItemTests
  {

    [TestMethod]
    public void StoreConstructor_CreatesInstanceOfStore_Store()
    {
      Store newStore = new Store(1, 1);
      Assert.AreEqual(typeof(Store), newStore.GetType());
    }

    [TestMethod]
    public void GetPastryAndBreadAmount_ReturnsTotalAmount_Int()
    {
      // Arrange
        int pastryAmount = 4;
        int breadAmount = 4;
        Store newStore = new Store(pastryAmount, breadAmount);
      // Act
        int resultPastry = newStore.PastryAmount;
        int resultBread = newStore.BreadAmount;
        int result = pastryAmount + breadAmount;
      // Assert
        Assert.AreEqual(pastryAmount + breadAmount, result);
    }

    [TestMethod]
    public void GetPastryPriceAndBreadPrice_ReturnTotalPrice_Int()
    {
      // Arrange
        int pastryAmount = 4;
        int breadAmount = 4;
        Store newStore = new Store(pastryAmount, breadAmount);
      // Act
        int pastryPrice = newStore.PastryTotal(pastryAmount);
        int breadPrice = newStore.BreadTotal(breadAmount);
        int total = pastryPrice + breadPrice;
      // Assert
        Assert.AreEqual(total, pastryPrice + breadPrice);
    }
  }
}
