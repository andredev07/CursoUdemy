using Section9ExerciseEnum.Entities;
using Section9ExerciseEnum.Entities.Enums;
using System.Globalization;

Console.WriteLine("Enter cliente data:");
Console.Write("Name: ");
string name = Console.ReadLine();

Console.Write("Email: ");
string email = Console.ReadLine();

Console.Write("Birth date (DD/MM/YYYY): ");
DateTime birthDate = DateTime.Parse(Console.ReadLine());


Client client = new Client(name, email, birthDate);
Order order = new Order(client);

Console.WriteLine("");
Console.WriteLine("Enter order data:");
Console.WriteLine("Status: " + OrderStatus.Processing);

Console.Write("How many items to this order? ");
int n = int.Parse(Console.ReadLine());


for (int i = 1; i <= n; i++)
{
    Console.WriteLine("");
    Console.WriteLine($"Enter #{i} item data:");
    Console.Write("Product name: ");
    string nameProduct = Console.ReadLine();

    Console.Write("Product price: ");
    double priceProduct = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Console.Write("Quantity: ");
    int quantity = int.Parse(Console.ReadLine());
    Console.WriteLine("");

    Product product = new Product(nameProduct, priceProduct);
    OrderItem orderItem = new OrderItem(quantity, priceProduct, product);
    order.AddItem(orderItem);
}

Console.WriteLine(order);