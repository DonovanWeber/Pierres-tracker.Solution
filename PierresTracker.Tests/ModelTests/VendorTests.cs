using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tracker.Models;
using System.Collections.Generic;
using System;

namespace Tracker.Tests
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
      Vendor newVendor = new Vendor("Test Cafe", "test description");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
    [TestMethod]
    public void GetTitle_ReturnsTitle_String()
    {
      string vendorName = "Test Cafe";
      Vendor newVendor = new Vendor(vendorName, "test description");
      string result = newVendor.Title;
      Assert.AreEqual(vendorName, result);
    }
    [TestMethod]
    public void GetId_ReturnVendorId_Int()
    {
      string vendorName = "Test Cafe";
      Vendor newVendor = new Vendor(vendorName, "test description");
      int result = newVendor.Id;
      Assert.AreEqual(1, result);
    }
    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      string vendorName1 = "Test Cafe";
      string vendorName2 = "Cafe de Test";
      Vendor newVendor1 = new Vendor(vendorName1, "test description");
      Vendor newVendor2 = new Vendor(vendorName2 , "test description");
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2};
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      string vendorName1 = "Test Cafe";
      string vendorName2 = "Cafe de Test";
      Vendor newVendor1 = new Vendor(vendorName1, "test description");
      Vendor newVendor2 = new Vendor(vendorName2, "test description");
      Vendor result = Vendor.Find(2);
      Assert.AreEqual(newVendor2, result);
    }
    [TestMethod]
    public void AddOrder_AssociatesOrderWithVendor_OrderList()
    {
      string description = "bagels";
      string title = "Test Cafe";
      Order newOrder = new Order(title, description);
      List<Order> newList = new List<Order>{ newOrder };
      Vendor newVendor = new Vendor(title,"test");
      newVendor.AddOrder(newOrder);
      List<Order> result = newVendor.Orders;
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void GetDescription_ReturnDescription_String()
    {
      string vendorName = "Test Cafe";
      string descriptionOfVendor = "A cafe of tests";
      Vendor newVendor = new Vendor(vendorName, descriptionOfVendor);
      newVendor.Description = descriptionOfVendor;
      string result = newVendor.Description;
      Assert.AreEqual(descriptionOfVendor, result);

    }
  }
}  