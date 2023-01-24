using Section9ExerciseEnum.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section9ExerciseEnum.Entities
{
    class Order
    {
        public DateTime Date { get; set; } = DateTime.Now;
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

        public Order()
        { }

        public Order(Client client)
        {
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            OrderItems.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            OrderItems.Remove(item);
        }

        public double Total()
        {
            double sum = 0;
            foreach (OrderItem item in OrderItems)
            {
                sum += item.SubTotal();
            }

            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            Console.WriteLine("");
            sb.AppendLine("ORDER SUMMARY:");
            sb.AppendLine("Order Moment: " + Date);
            sb.AppendLine("Order Status: " + OrderStatus.Processing);
            sb.AppendLine("Client: " + Client.Name + " " + Client.BirthDate +
                " - " + Client.Email);
            sb.AppendLine("Order Items:");

            foreach(OrderItem orderItem in OrderItems)
            {
                sb.AppendLine(" " +orderItem.Product.Name + ", " +
                    orderItem.Product.Price.ToString("C") + " " +
                   "Quantity: " + orderItem.Quantity + ", " +
                   "Subtotal: " + orderItem.SubTotal().ToString("C") + " ");
            }

            Console.WriteLine("");
            sb.AppendLine("Total Price: " + Total().ToString("C"));

            return sb.ToString();
        }
    }
}
