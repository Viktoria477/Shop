using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;

namespace Laba
{
    delegate void NotifyClient(Order order);
    internal class Order
    {
        public int Id {  get; private set; }
        [MaxLength(40)]
        public string? Email {  get; private set; }
        public List<Item> Items { get; private set; }
        public Order()
        {
            Items = new List<Item>();
        }
        public event NotifyClient OnOrderCreate;
        public void Purchase(string email)
        {
            Email = email;
            ToFile();
            OnOrderCreate?.Invoke(this);
        }
        void ToFile()
        {
            using(StreamWriter sw = new StreamWriter("Check.txt", false, System.Text.Encoding.Default))
            {
                foreach(Item item in Items)
                {
                    sw.WriteLine(item.Show());
                    sw.WriteLine("---------------------");
                }
                sw.WriteLine($"Suma: {Items.Sum(x => x.Price)}");
            }
        }
        void RemoveOrderItems()
        {
            Items.Clear();
        }
    }
}
