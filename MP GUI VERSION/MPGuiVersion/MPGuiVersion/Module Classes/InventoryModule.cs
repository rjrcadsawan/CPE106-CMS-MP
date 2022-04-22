using System;
using System.Collections.Generic;
using System.Text;

namespace MPGuiVersion
{
    static class InventoryModule
    {

        static void addItem(string itemName, int quantity, float unitPrice, string desc)
        {
            Item  B = new Item();
            B.itemName = itemName;
            B.Quantity = quantity;
            B.UnitPrice= unitPrice;
            B.Description = desc;
           
        }
        static void deleteItem()
        {
            

        }
        static void modifyItem()
        {
           

        }

        static void summaryofItem()
        {
            var sumitems = new List<string>();
            sumitems.Add("");
            Console.WriteLine(string.Join(", ", sumitems));
            //Hindi suree 
        }

    }
}
