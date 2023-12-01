using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Laba
{
    [Table("Beers")]
    internal class Beer:Alcohol
    {
        public Beer() : base()
        {

        }
        public Beer(string name, decimal price, int volume, float strength):base(name, price, volume, strength)
        {

        }
        public override string Show()
        {
            return $"Pyvo {Name} - {Price}₴\nMicnist`: {Strength}%\nOb`yem: {Volume}ml";
        }
    }
}
