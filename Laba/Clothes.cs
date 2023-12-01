using System;
using System.Collections.Generic;
using System.Text;

namespace Laba
{
    enum SizeLetters
    {
        XS,
        S,
        M,
        L,
        XL
    }
    internal abstract class Clothes:Item
    {
        public SizeLetters Size { get; protected set; }
        public Clothes():base() 
        {
            Size = new SizeLetters();
        }
        public Clothes(string name, decimal price, SizeLetters size):base(name, price)
        {
            Size = size;
        }
    }
}
