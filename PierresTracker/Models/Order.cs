using System;
using System.Collections.Generic;

namespace Tracker.Models
{
  public class Order
  {
    public string Description { get; set; }
    
    public Order(string description)
    {
      Description = description;
    }

  
  }
}