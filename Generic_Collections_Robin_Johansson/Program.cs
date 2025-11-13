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

            // Devider that makes the console look nicer
            restaurantPumpkin.Devider();

            // Displays the menu:
            restaurantPumpkin.ShowMenu();

            restaurantPumpkin.Devider();

            // Create orders:
            var order1 = new Order([ course1, course2 ], 14);
            var order2 = new Order([ course3, course1, course4 ], 22);
            var order3 = new Order([course2, course2, course1, course4,], 3);

            // Add orders to the order-queue:
            restaurantPumpkin.CreateOrder(order1);
            restaurantPumpkin.CreateOrder(order2);
            restaurantPumpkin.CreateOrder(order3);

            restaurantPumpkin.Devider();

            // Display current orders on queue:
            restaurantPumpkin.ShowOrders();
            restaurantPumpkin.Devider();

            // Displays how many orders there are on queue:
            restaurantPumpkin.ShowOrderCount();

            // Displays the next order on queue:
            restaurantPumpkin.ShowNextOrder();

            // Removes the first order on queue:
            restaurantPumpkin.HandleOrder();

            restaurantPumpkin.ShowOrderCount();

            restaurantPumpkin.Devider();

            var order4 = new Order([course1, course2, course3], 15);
            restaurantPumpkin.CreateOrder(order4);

            restaurantPumpkin.ShowOrderCount();
            restaurantPumpkin.HandleOrder();
            restaurantPumpkin.HandleOrder();
            restaurantPumpkin.ShowOrderCount();

            restaurantPumpkin.Devider();

            restaurantPumpkin.ShowNextOrder();
            restaurantPumpkin.HandleOrder();
            restaurantPumpkin.ShowOrderCount();



        }


    }
}
