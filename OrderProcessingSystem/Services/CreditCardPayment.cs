using  OrderProcessingSystem.Interfaces;
using OrderProcessingSystem.Models;
public class CreditCardPayment : IPaymentService
{
    private readonly ILogger _logger;

    public void Pay(Order order)
    {
        // Logic to process credit card payment
        Console.WriteLine($"Processing credit card payment for order: {order.ProductName}, Amount: {order.Price}");
    

    }

    // public void ProcessPayment(Payment payment)
    // {
    //     // Logic to process the payment
    //     _logger.LogInfo($"Processing payment with ID: {payment.Id}");
    // }

    // public Payment GetPaymentById(int paymentId)
    // {
    //     // Logic to retrieve a payment by ID
    //     _logger.LogInfo($"Retrieving payment with ID: {paymentId}");
    //     return new Payment { Id = paymentId, Amount = 100.00 }; // Example return
    // }

    // public IEnumerable<Payment> GetAllPayments()
    // {
    //     // Logic to retrieve all payments
    //     _logger.LogInfo("Retrieving all payments.");
    //     return new List<Payment>(); // Example return
    // }

    // public void UpdatePayment(Payment payment)
    // {
    //     // Logic to update a payment
    //     _logger.LogInfo($"Updating payment with ID: {payment.Id}");
    // }

    // public void CancelPayment(int paymentId)
    // {
    //     // Logic to cancel a payment
    //     _logger.LogInfo($"Cancelling payment with ID: {paymentId}");
    // }
}

