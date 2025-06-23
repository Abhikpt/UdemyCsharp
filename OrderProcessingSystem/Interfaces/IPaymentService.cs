using OrderProcessingSystem.Models;

namespace OrderProcessingSystem.Interfaces;

public interface IPaymentService
{
    void Pay(Order order);
    // void ProcessPayment(Payment payment);
    // Payment GetPaymentById(int paymentId);
    // IEnumerable<Payment> GetAllPayments();
    // void UpdatePayment(Payment payment);
    // void CancelPayment(int paymentId);
}