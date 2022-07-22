
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tracker.Models;
using System.Collections.Generic;
using System;

namespace Tracker.Tests
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
      Order newOrder = new Order("test cafe", "test bagels");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string description = "Bagels and croissant";
      Order newOrder = new Order("test cafe", description);
      string result = newOrder.Description;
      Assert.AreEqual(description, result);
    }
    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      string description = "bagels";
      Order newOrder = new Order("test cafe", description);
      string newDescription = "croissants";
      newOrder.Description = newDescription;
      string result = newOrder.Description;
      Assert.AreEqual(newDescription, result);
    }
    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      List<Order> newList = new List<Order>{ };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void GetAll_ReturnsOrders_OrderList()
    {
      string description01 = "Bagels";
      string description02 = "Croissants";
      Order newOrder1 = new Order("test cafe", description01);
      Order newOrder2 = new Order("test cafe", description02);
      List<Order> newList = new List<Order> { newOrder1, newOrder2};
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void FindId_ReturnsCorrectOrder_Order()
    {
      string description01 = "Bagels";
      string description02 = "Croissants";
      Order newOrder1 = new Order("test cafe", description01);
      Order newOrder2 = new Order("test cafe", description02);

      Order foundOrder = Order.Find(2);

      Assert.AreEqual(newOrder2, foundOrder);
    }
    [TestMethod]
    public void GetDate_ReturnCurrentDate_DateTime()
    {
    string title = "Order from test cafe";
    string description = "bagels";
    Order newOrder = new Order(title, description);
    DateTime currentDate = DateTime.Today;
    DateTime foundDate = newOrder.CurrentDate;
    Assert.AreEqual(currentDate, foundDate);

    }
  }

  
}  