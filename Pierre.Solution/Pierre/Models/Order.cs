using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Pierre.Models
{
  public class Order
  {
    public string Title { get; set; }
    public int Price { get; set; }
    public string Date { get; set; }
    public string Description { get; set; }
    public int Id { get; }
    private static List<Order> _instances = new List<Order> {};

    public Order(string description, string title, int price, string date)
    {
        Title = title;
        Price = price;
        Date = date;
        Description = description;
        _instances.Add(this);
        Id = _instances.Count;
    }
    public static List<Order> GetAll()
    {
      return _instances;
    }
    public static Order Find(int searchId)
    {
      return _instances[searchId-1];
    }
    
  }
}