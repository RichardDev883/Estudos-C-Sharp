using ExercicioFinalSecao10.Entities;
using ExercicioFinalSecao10.Entities.Enums;
using System.Globalization;

namespace ExercicioFinalSecao10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Client Data
            Console.WriteLine("Enter cliente data: ");
            Console.Write("Name: ");
            string clientName = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth Date (MM/DD/YYYY): ");
            DateTime birthday = DateTime.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Client client = new Client(clientName, email, birthday);

            //Oder Data
            Console.WriteLine("Enter the order data: ");
            Console.Write("Status (PENDING_PAYMENT/PROCESSING/SHIPPED/DELIVERED) : ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Order order = new Order(DateTime.Now, status, client); 

            //Definition of the amount of Items
            Console.WriteLine("How many items to this order? ");
            int n= int.Parse(Console.ReadLine());

            for(int i=1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data");
                Console.Write("Product Name: ");
                string productName = Console.ReadLine();
                Console.Write("Product Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Product product = new Product(productName, price);

                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem(quantity, price, product);

                order.Items.Add(orderItem);
            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(order);
        }
    }
}