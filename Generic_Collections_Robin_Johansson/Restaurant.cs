using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Collections_Robin_Johansson
{
    internal class Restaurant
    {
        
        private List<MenuItem> Menu = new List<MenuItem>();
        
        private Queue<Order> OrderList = new Queue<Order>();

        public Restaurant()
        {
           
        }

        public void Devider()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\n-------------------------------\n");
            Console.ResetColor();
        }

        // Method that adds a course to the menu:
        public void AddToMenu(MenuItem menuItem)
        {
            Menu.Add(menuItem);
            Console.WriteLine($"{menuItem.Name} har lagts till i menyn.");
        }

        // Method that displays the menu:
        public void ShowMenu()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("MENY:");
            Console.ResetColor();

            foreach (MenuItem course in Menu)
            {
                Console.WriteLine(course.ToString());
            }
            Devider();
        }
        // Method for adding orders to the queue:
        public void CreateOrder(Order order)
        {
            OrderList.Enqueue(order);
            Console.WriteLine($"Beställning nr {order.GetOrderNumber()} har lagts till.");

        }

        // Method that removes the top order in the queue:
        public void HandleOrder()
        {
            var order = OrderList.Peek();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"Order {order.GetOrderNumber()} färdig.\n");
            Console.ResetColor();
            OrderList.Dequeue();

        }

        // Method that displays all current orders:
        public void ShowOrders()
        {
            Console.WriteLine("Aktuella beställningar:\n");
            foreach (var order in OrderList)
            {
                // Method orderinfo in class Order gets all the info about the order
                order.OrderInfo();
            }
            Devider();
        }

        // Method that displays the next order on queue:
        public void ShowNextOrder()
        {
            Console.WriteLine("Nästa order i kön:\n");
            var order = OrderList.Peek();
            order.OrderInfo();
        }

        // Method that displays how many orders are on queue:
        public void ShowOrderCount()
        {
            if (OrderList.Count == 1)
            {
                Console.WriteLine($"Det är {OrderList.Count} order i kön.\n");
            }
            else if (OrderList.Count < 1)
            {
                Console.WriteLine($"Det finns inga ordrar i kön just nu.\n");
            }
            else
            {
                Console.WriteLine($"Det är {OrderList.Count} ordrar i kön.\n");
            }
        }

    }
}
