using System;
using OrderProcessingSystem.Interfaces;
using OrderProcessingSystem.Models;
using OrderProcessingSystem.Services;

namespace OrderProcessingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, User!");

            IPaymentService paymentService = new CreditCardPayment();
            ILogger logger = new ConsoleLogger();
            IOrderService orderService = new OrderService(logger,paymentService);

            var order = new Order
            {
                OrderId = 1,
                ProductName = "Laptop",
                Price = 1200.00
            };
            orderService.ProcessOrder(order);
        }
    }
}
