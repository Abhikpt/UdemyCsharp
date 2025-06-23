using OrderProcessingSystem.Models;

namespace OrderProcessingSystem.Interfaces;

public interface IOrderService
{
    void ProcessOrder(Order order);
    // void PlaceOrder(Order order);
    // Order GetOrderById(int orderId);
    // IEnumerable<Order> GetAllOrders();
    // void UpdateOrder(Order order);
    // void CancelOrder(int orderId);
}