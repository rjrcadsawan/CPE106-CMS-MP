using System;

namespace CPE106_MachineProblem
{
    public class Script
    {
        string Name;
        string Description;
        int Quantity;
        Double unit_price;
        Double item_price;

        public Script(string name, string description, int quantity, double unit_price)
        {
            this.Name = name;
            this.Description = description;
            this.Quantity = quantity;
            this.unit_price = unit_price;
            this.item_price = unit_price * quantity;
        }

        public void printDetails()
        {
            Console.Write($"{this.Name} {this.Description} {this.Quantity}pcs {this.unit_price}/pc P{this.item_price}");
        }

        public bool similarTo()
        {
            bool result = false;
            return result;

        }
    }
}
