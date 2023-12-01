using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Laba
{
    internal abstract class HomeAppliance:Item
    {
        public float Height {  get; protected set; }
        public float Width { get; protected set; }
        public float Lenght {  get; protected set; }
        public HomeAppliance() : base()
        {
            Height = 0;
            Width = 0;
            Lenght = 0;
        }
        public HomeAppliance(string name, decimal price, float height, float width, float lenght):base(name,price)
        {
            Height = height;
            Width = width;
            Lenght = lenght;
        }
    }
}
