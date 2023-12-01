using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Laba
{
    internal abstract class Item
    {   
        public int Id { get; protected set; }
        public string Name { get; protected set; }

        public decimal Price { get; protected set; }
        public List<Order> Orders { get; protected set; }
        public Item() 
        {
            Name = string.Empty;
            Price = new decimal(0);
            Orders = new List<Order>();
        }
        public Item(string name, decimal price)
        {
            Name = name;
            Price = price;
            Orders = new List<Order>();
        }
        public abstract string Show();
    }
}
