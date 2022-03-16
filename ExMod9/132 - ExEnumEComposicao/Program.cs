using System;
using System.Globalization;
using _132___ExEnumEComposicao.Entities;
using _132___ExEnumEComposicao.Entities.Enums;

namespace _132___ExEnumEComposicao {
    class Program {
        static void Main(string[] args) {
            
            string name, email;
            int nItems, quantity;
            double price;
            DateTime birthDate, moment;
            OrderStatus status;
            OrderItem item = new OrderItem();
            
            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            name = Console.ReadLine();
            Console.Write("Email: ");
            email = Console.ReadLine();
            Console.Write("Birth Date (DD/MM/YYYY): ");
            birthDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter order data:");
            moment = DateTime.Now;
            Console.Write("Status: ");
            status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client c1 = new Client(name, email, birthDate);
            Order os = new Order(moment, status, c1);


            Console.Write("How many items to this order? ");
            nItems = int.Parse(Console.ReadLine());


            for (int i = 1; i <= nItems; i++) {
                Console.WriteLine($"Enter #{i} order data:");
                Console.Write("Product name: ");
                name = Console.ReadLine();
                Console.Write("Product price: ");
                price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                quantity = int.Parse(Console.ReadLine());

                Products product = new Products(name, price);
                item = new OrderItem(quantity, price, product);
                
                os.AddItem(item);

            }
            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(os);
            






        }
    }
}
