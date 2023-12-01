using System;
using System.Collections.Generic;
using System.Text;

namespace Laba
{
    internal abstract class Alcohol:Item
    {
        public int Volume {  get; protected set;}
        public float? Strength { get; protected set; }
        public Alcohol() : base() 
        {
            Volume = 0;
        }
        public Alcohol(string name, decimal price , int volume, float strength) : base(name, price)
        {
            Volume = volume;
            Strength = strength;
        }
    }
}
