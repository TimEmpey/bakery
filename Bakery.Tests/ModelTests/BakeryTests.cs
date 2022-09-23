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
      Store newStore = new Store();
      Assert.AreEqual(typeof(Store), newStore.GetType());
    }
  }
}
