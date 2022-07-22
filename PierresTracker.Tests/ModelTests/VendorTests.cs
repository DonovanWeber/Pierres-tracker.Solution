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
      Vendor newVendor = new Vendor("Test Cafe");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
    [TestMethod]
    public void GetTitle_ReturnsTitle_String()
    {
      string vendorName = "Test Cafe";
      Vendor newVendor = new Vendor(vendorName);
      string result = newVendor.Title;
      Assert.AreEqual(vendorName, result);
    }
    [TestMethod]
    public void GetId_ReturnVendorId_Int()
    {
      string vendorName = "Test Cafe";
      Vendor newVendor = new Vendor(vendorName);
      int result = newVendor.Id;
      Assert.AreEqual(1, result);
    }
    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      string vendorName1 = "Test Cafe";
      string vendorName2 = "Cafe de Test";
      Vendor newVendor1 = new Vendor(vendorName1);
      Vendor newVendor2 = new Vendor(vendorName2);

      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2};

      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
  }
}  