using System;
using System.Collections.Generic;

namespace CafeBillingSystem
{
    class program
    {
        static List<Item> menu;
        static List<Item> order;

        static void Main(string[] args)
        {
            menu = new List<Item>()
            {
                new Item("Coffee", 2.5),
                new Item("Tea", 2),
                new Item("Sandwich", 5),
                new Item("Cake", 4.5)
            };
            order = new List<Item>();

            bool isOrdering = true;
            while (isOrdering)
            {
                Console.WriteLine("=== MENU ===");
                DisplayMenu();

                Console.WriteLine("\nEnter the item number to order (0 to exit):");
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 0)
                {
                    isOrdering = false;
                }
                else if (choice >= 1 && choice <= menu.Count)
                {
                    Item selectedItem = menu[choice - 1];
                    order.Add(selectedItem);
                    Console.WriteLine($"{selectedItem.Name} added to the order.");
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                }

                Console.WriteLine();
            }

            Console.WriteLine("\n=== ORDER DETAILS ===");
            DisplayOrder();

            double totalAmount = CalculateTotalAmount();
            Console.WriteLine($"\nTotal Amount: ${totalAmount}");

            Console.WriteLine("\nThank you for using the cafe billing system!");
        }

        static void DisplayMenu()
        {
            for (int i = 0; i < menu.Count; i++)
            {
                Item item = menu[i];
                Console.WriteLine($"{i+ 1}. {item.Name} (${item.Price})");
            }
        }

        static void DisplayOrder()
        {
            if (order.Count == 0)
            {
                Console.WriteLine("No items in the order.");
            }
            else 
            {
                for (int i = 0; i < order.Count; i++)
                {
                    Item item = order[i];
                    Console.WriteLine($"{i+ 1}. {item.Name} (${item,Price})");
                }
            }
        }

        static double CalculateTotalAmount()
        {
            double total = 0;
            foreach (Item item in order)
            {
                total += item.Price;
            }
            return total;
        }
    }

    class Item
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Item (strin name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}