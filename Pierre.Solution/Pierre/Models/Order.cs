using System.Collections.Generic;

namespace Pierre.Models
{
    public class Order
    {
        private static List<Order> _instances = new List<Orde> {};
        public string Name { get; set; }
        public int Id { get; }
        public List<Vendor> Vendors { get; set; }
   
        public Order(string orderName)
        {   
            Name = orderName;
            _instances.Add(this);
            Id = _instances.Count;
            Vendor = new List<Vendor> {};
        }

        public static List<Category> GetAll()
        {
            return _instances;
        }
         public static Category Find(int searchId)
        {
            return _instances[searchId-1];
        }
         public void AddItem(Item item)
        {
            Items.Add(item);
        }
    }       
}