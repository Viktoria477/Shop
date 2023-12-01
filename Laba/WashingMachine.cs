using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Laba
{
    [Table("WashingMachines")]
    internal class WashingMachine:HomeAppliance
    {
        public WashingMachine():base() 
        {

        }
        public WashingMachine(string name, decimal price, float height, float width, float lenght):base(name,price,height,width,lenght)
        {

        }

        public override string Show()
        {
            return $"Pralka {Name} - {Price}₴\nGabaryty: {Height}cm*{Width}cm*{Lenght}cm";
        }
    }
}
