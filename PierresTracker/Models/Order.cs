using System;
using System.Collections.Generic;

namespace Tracker.Models
{
  public class Order
  {
    public string Title { get; set; }
    public string Description { get; set; }
    private static List<Order> _instances = new List<Order>{ };
    public int Id{ get; }
    private static int _Price = 10;
    public static int Price
    {
      get{ return _Price;}
      set {_Price = value; }
    }
    
    private static DateTime _CurrentDate = DateTime.Today;
    public static DateTime CurrentDate
    {
      get { return _CurrentDate;}
      set { _CurrentDate = DateTime.Today;}
    }

    public Order(string title, string description)
    {
      Title = title;
      Description = description;
      _instances.Add(this);
      Id = _instances.Count;
      _CurrentDate = CurrentDate;
      _Price = Price;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static List<Order> GetAll()
    {
      return _instances;
    }
    public static Order Find(int searchId)
    {
      return _instances[searchId-1];
    }
    public static DateTime GetDate()
    {
      return _CurrentDate;
    }
    public static int GetPrice()
    {
      return _Price;
    }
  }
}