using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIST16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> cart = new List<string>();
            bool running = true;

            while (running)
            {
                Console.WriteLine("\nShopping Cart Menu:");
                Console.WriteLine("1. Add item");
                Console.WriteLine("2. Remove item");
                Console.WriteLine("3. View cart");
                Console.WriteLine("4. Clear cart");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Write("Enter item to add: ");
                        string addItem = Console.ReadLine();
                        cart.Add(addItem);
                        Console.WriteLine($"'{addItem}' added to cart.");
                        break;

                    case "2":
                        if (cart.Count == 0)
                        {
                            Console.WriteLine("Cart is empty.");
                            break;
                        }
                        Console.Write("Enter item to remove: ");
                        string removeItem = Console.ReadLine();
                        if (cart.Remove(removeItem))
                            Console.WriteLine($"'{removeItem}' removed from cart.");
                        else
                            Console.WriteLine($"'{removeItem}' not found in cart.");
                        break;

                    case "3":
                        if (cart.Count == 0)
                            Console.WriteLine("Cart is empty.");
                        else
                        {
                            Console.WriteLine("Items in cart:");
                            foreach (var item in cart)
                                Console.WriteLine("- " + item);
                        }
                        break;

                    case "4":
                        cart.Clear();
                        Console.WriteLine("Cart cleared.");
                        break;

                    case "5":
                        running = false;
                        Console.WriteLine("Exiting...");
                        break;

                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        break;
                }
            }
        }
    }
}