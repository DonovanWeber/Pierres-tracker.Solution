using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tracker.Models;
using System.Collections.Generic;
using System;

namespace Tracker.Tests
{
  [TestClass]
  public class VendorTests //: IDisposable
  {

    // public void Dispose()
    // {
    //   Vendor.ClearAll();
    // }

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
      Assert.AreEqual(vendorName, newVendor);
    }
  }
}  