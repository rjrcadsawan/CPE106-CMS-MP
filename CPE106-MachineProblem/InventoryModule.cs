using System;
using System.Collections.Generic;

namespace CPE106_MachineProblem
{
    public class InventoryModule
    {
        string text = "";
        List<Item> ItemList = new List<Item>();
        int choice = 99;
        public void Operations()
        {
            while (choice != 0)
            {
                
                Console.Clear();
                text = "Inventory Module\n";
                text += "[1] Add Item\n";
                text += "[2] Remove Item\n";
                text += "[3] Search Item\n";
                text += "[4] Print Summary of Items\n";
                text += "[0] Main Menu";
                Console.WriteLine(text); 
                choice = Convert.ToInt32(Console.ReadLine());
                this.evaluate(choice);
            }
            
        }

        void evaluate(int choice)
        {
            switch (choice)
            {
                case 1:
                    this.addItem();
                    break;
                case 2:
                    this.removeItem();
                    break;
                case 3:
                    this.searchItem();
                    break;
                case 4:
                    this.printItemList();
                    break;
            }   
        }

        public void addItem()
        {
            Console.WriteLine("Add an Item");
            Console.WriteLine("Item Name: ");
            string Item_Name = Console.ReadLine();
            Console.WriteLine("Item Description: ");
            string Item_Description = Console.ReadLine();
            Console.WriteLine("Item Quantity: ");
            int Item_Quantity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Unit Price: ");
            Double Item_Unit_Price = Convert.ToDouble(Console.ReadLine());

            Item newItem = new Item(Item_Name, Item_Description, Item_Quantity, Item_Unit_Price);
            ItemList.Add(newItem);


            Console.WriteLine("Press Any Key to Continue. . .");
            Console.ReadKey();

        }

        public void removeItem()
        {
            this.printItemList();
            Console.WriteLine("Enter the Index of the item to be deleted");
            ItemList.RemoveAt(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("Press Any Key to Continue. . .");
            Console.ReadKey();

        }

        public void printItemList()
        {
            int iterator = 0;
            foreach(Item X in ItemList)
            {
                Console.Write(iterator + "->");
                X.printDetails();
                iterator++;
                Console.Write("\n");
            }

            Console.WriteLine("Press Any Key to Continue. . .");
            Console.ReadKey();
        }

        public void searchItem()
        {
            Console.WriteLine("Specify the details of the item that you want to search");
            Console.WriteLine("Item Name: ");
            string Item_Name = Console.ReadLine();
            Console.WriteLine("Item Description: ");
            string Item_Description = Console.ReadLine();
            Console.WriteLine("Item Quantity: ");
            int Item_Quantity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Unit Price: ");
            Double Item_Unit_Price = Convert.ToDouble(Console.ReadLine());

            Item searchItem = new Item(Item_Name, Item_Description, Item_Quantity, Item_Unit_Price);
            if (ItemList.Contains(searchItem))
            {
                int index = ItemList.IndexOf(searchItem);
                Console.WriteLine($"Item Foudn at {index} ");
            }


            Console.WriteLine("Press Any Key to Continue. . .");
            Console.ReadKey();
        }
    }
}