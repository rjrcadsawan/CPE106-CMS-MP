using System;
using System.Collections.Generic;
using System.Text;

namespace MPGuiVersion
{
    internal class Item
    {
        public string itemName;
        public int Quantity;
        public float UnitPrice;
        public string Description;

        public string Product { get => itemName; set => itemName = value; }

        public int Ammount { get => Quantity; set => Quantity = value; }

        public float Price { get => UnitPrice; set => UnitPrice = value; }

        public string Summary { get => Description; set => Description = value; }
    }
}