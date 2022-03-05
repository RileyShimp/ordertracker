using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using OrderTracker.Models;
using System;

namespace OrderTracker.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {

    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("test", "test", "test", 2);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string description = "Seven loaves of bread.";

      Order newOrder = new Order("test", description, "test", 2);
      string result = newOrder.Description;

      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void GetTitle_ReturnsTitle_String()
    {
      string title = "Bread Order";

      Order newOrder = new Order(title, "test", "test", 2);
      string result = newOrder.Title;

      Assert.AreEqual(title, result);
    }

    [TestMethod]
    public void GetPrice_ReturnsPrice_Int()
    {
      int price = 10;

      Order newOrder = new Order("test", "test", "test", price);
      int result = newOrder.Price;

      Assert.AreEqual(price, result);
    }

    [TestMethod]
    public void GetDate_ReturnsDate_String()
    {
      string date = "January 2nd";

      Order newOrder = new Order("test", "test", date, 1);
      string result = newOrder.Date;

      Assert.AreEqual(date, result);
    }

    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      string description = "Seven loaves of bread.";
      Order newOrder = new Order("test", description, "test", 2);

      string updatedDescription = "Three pastries.";
      newOrder.Description = updatedDescription;
      string result = newOrder.Description;

      Assert.AreEqual(updatedDescription, result);
    }

    [TestMethod]
    public void SetTitle_SetTitle_String()
    {
      string title = "Bread Order";
      Order newOrder = new Order(title, "test", "test", 2);

      string updatedTitle = "Cake Order";
      newOrder.Title = updatedTitle;
      string result = newOrder.Title;

      Assert.AreEqual(updatedTitle, result);
    }

    [TestMethod]
    public void SetDate_SetDate_String()
    {
      string date = "June 7th";
      Order newOrder = new Order("test", "test", date, 2);

      string updatedDate = "July 8th";
      newOrder.Date = updatedDate;
      string result = newOrder.Date;

      Assert.AreEqual(updatedDate, result);
    }

    [TestMethod]
    public void SetPrice_SetPrice_Int()
    {
      int price = 12;
      Order newOrder = new Order("test", "test", "test", price);

      int updatedPrice = 20;
      newOrder.Price = updatedPrice;
      int result = newOrder.Price;

      Assert.AreEqual(updatedPrice, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      List<Order> newList = new List<Order> { };

      List<Order> result = Order.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsItems_OrderList()
    {
      string description01 = "Seven loaves of bread.";
      string description02 = "Three pastries";
      Order newOrder1 = new Order("test", description01, "test", 2);
      Order newOrder2 = new Order("test", description02, "test", 2);
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };

      List<Order> result = Order.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetId_OrderInstantiateWithAnIdAndGetterReturns_Int()
    {
      string description = "Seven loaves of bread.";
      Order newOrder = new Order("test", description, "test", 2);

      int result = newOrder.Id;

      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectOrder_Order()
    {
      string description01 = "Seven loaves of bread.";
      string description02 = "Three pastries.";
      Order newOrder1 = new Order("test", description01, "test", 2);
      Order newOrder2 = new Order("test", description02, "test", 2);

      Order result = Order.Find(2);

      Assert.AreEqual(newOrder2, result);
    }
  }
}