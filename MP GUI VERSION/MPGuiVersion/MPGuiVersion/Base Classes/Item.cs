using System;
using System.Collections.Generic;
using System.Text;

namespace MPGuiVersion
{
    public class Item
    {
        private int itemID;
        private string itemName;
        private int quantity;
        private float unitPrice;
        private float totalPrice;
        private string description;

        public int ItemID { get => itemID; set => itemID = value; }
        public string ItemName { get => itemName; set => itemName = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public float UnitPrice { get => unitPrice; set => unitPrice = value; }
        public float TotalPrice { get => (unitPrice * quantity); set => totalPrice = value; }
        public string Description { get => description; set => description = value; }
    }
}