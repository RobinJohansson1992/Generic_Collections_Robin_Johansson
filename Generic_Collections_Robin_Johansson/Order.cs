using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Generic_Collections_Robin_Johansson
{
    internal class Order
    {
        static int orderIdCounter = 1;
        private int _orderId;
        private List<MenuItem> _orderItems;
        private int _tableNumber;

        public Order(List<MenuItem> orderItems, int tableNumber)
        {
            _orderId = orderIdCounter;
            orderIdCounter++;
            _orderItems = orderItems;
            _tableNumber = tableNumber;
        }

        // Method that writes out all the info about an order:
        public void OrderInfo()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"Order {_orderId}:");
            Console.ResetColor();

            foreach(var course in _orderItems)
            {
                Console.WriteLine($"1 st {course.Name}");
            }

            Console.WriteLine($"Summa: {TotalPrice()} kr");
            Console.WriteLine($"Till bord nr {_tableNumber}\n");
            
        }

        // Method that adds the total price of an order:
        public decimal TotalPrice()
        {
            decimal total = 0;
            foreach (var order in _orderItems)
            {
                total += order.Price;
            }
            return total;
        }

        public int GetOrderNumber()
        {
            return _orderId;
        }
    }
}
