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
            Console.ForegroundColor = ConsoleColor.DarkYellow;
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
        }

        //public void HandleOrder(Order order)
        //{
        //    OrderList.Dequeue(order);

        //}

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

        public void ShowNextOrder()
        {
            Console.WriteLine(OrderList.Peek());
        }

        public void ShowOrderCount()
        {
            Console.WriteLine(OrderList.Count);
        }

    }
}
