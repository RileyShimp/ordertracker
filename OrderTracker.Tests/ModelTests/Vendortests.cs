using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderTracker.Models;
using System.Collections.Generic;
using System;

namespace OrderTracker.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {

    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test name","test description");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = "Test name";
      Vendor newVendor = new Vendor(name, "test description");

      string result = newVendor.Name;

      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string description = "Test description";
      Vendor newVendor = new Vendor("test name", description);

      string result = newVendor.Description;

      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      string name = "Test name";
      string description = "Test description";
      Vendor newVendor = new Vendor(name, description);

      int result = newVendor.Id;

      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      string name01 = "James";
      string name02 = "Nick";
      Vendor newVendor1 = new Vendor(name01, "test");
      Vendor newVendor2 = new Vendor(name02, "test");
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };

      List<Vendor> result = Vendor.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }

      [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      string name01 = "James";
      string name02 = "Nick";
      Vendor newVendor1 = new Vendor(name01, "test");
      Vendor newVendor2 = new Vendor(name02, "test");

      Vendor result = Vendor.Find(2);

      Assert.AreEqual(newVendor2, result);
    }

    [TestMethod]
  public void AddOrder_AssociatesOrderWithVendor_OrderList()
  {
    Order newOrder = new Order("test", "test", "test", 12);
    List<Order> newList = new List<Order> { newOrder };
    string name = "James";
    Vendor newVendor = new Vendor(name, "test");
    newVendor.AddOrder(newOrder);

    List<Order> result = newVendor.Orders;

    CollectionAssert.AreEqual(newList, result);
  }
  }
}