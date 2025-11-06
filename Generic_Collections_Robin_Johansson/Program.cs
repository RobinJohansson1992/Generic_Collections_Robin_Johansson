namespace Generic_Collections_Robin_Johansson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var restaurantPumpkin = new Restaurant();
            
            // Create menu-items:
            var course1 = new MenuItem(1, "Hamburgare", 120 );
            var course2 = new MenuItem(2, "Pizza", 130 );
            var course3 = new MenuItem(3, "Köttbullar", 150 );
            var course4 = new MenuItem(4, "Schnitzel", 180 );

            

            // Add menu-items to the menu:
            restaurantPumpkin.AddToMenu(course1);
            restaurantPumpkin.AddToMenu(course2);
            restaurantPumpkin.AddToMenu(course3);
            restaurantPumpkin.AddToMenu(course4);

            restaurantPumpkin.ShowMenu();

            // Create orders:
            var order1 = new Order([ course1, course2 ], 14);
            var order2 = new Order([ course3, course1, course4 ], 22);

            // Add orders to the order-queue:
            restaurantPumpkin.CreateOrder(order1);
            restaurantPumpkin.CreateOrder(order2);

            // Display current orders on queue:
            restaurantPumpkin.ShowOrders();

        }
    }
}
