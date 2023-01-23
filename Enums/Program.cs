using Enum.Entities;
using Enum.Entities.Enums;

Order order = new Order
{
    Id = 1080,
    Moment = DateTime.Now,
    Status = OrderStatus.PendingPayment
};

Console.WriteLine(order);

string txt = OrderStatus.PendingPayment.ToString();

OrderStatus os = System.Enum.Parse<OrderStatus>("Delivered");

Console.WriteLine(txt);
Console.WriteLine(os);