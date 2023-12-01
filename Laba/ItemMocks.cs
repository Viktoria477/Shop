using System;
using System.Collections.Generic;
using System.Text;

namespace Laba
{
    internal class ItemMocks
    {
        public static List<Item> GetItems()
        {
            return new List<Item>()
            {
                new WashingMachine("BOSCH WAN28263UA",22059,84.8f,59.8f,55),
                new Beer("Krombacher Pils",626,5000,4.8f),
                new Jacket("Puma Better Polyball Puffer",4499,SizeLetters.S),
                new WashingMachine("INDESIT BTW A51052",11699, 90, 40, 60 ),
                new Beer("Budweiser Budvar",609,5000,5),
                new Jacket("Outventure 123967-Z4",2590,SizeLetters.L)
            };
        }
    }
}
