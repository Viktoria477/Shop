using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Laba
{
    [Table("Jackets")]
    internal class Jacket:Clothes
    {
        public Jacket() : base()
        {

        }
        public Jacket(string name, decimal price, SizeLetters size):base(name, price, size)
        {
            
        }        
        public override string Show()
        {
            return $"Kurtka {Name} - {Price}₴\nRozmir: {Size}";
        }
    }
}
