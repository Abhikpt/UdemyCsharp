using  OrderProcessingSystem.Interfaces;
using OrderProcessingSystem.Models;

namespace OrderProcessingSystem.Services;
public class OrderService : IOrderService
{
    private readonly ILogger _logger;
    private readonly IPaymentService _paymentService;

    public OrderService(ILogger logger, IPaymentService paymentService)
    {
        _logger = logger;
        _paymentService = paymentService;
    }

    public void ProcessOrder(Order order)
    {
        // Validate order
        if (order == null)
        {
            _logger.LogError("Order cannot be null.");
            throw new ArgumentNullException(nameof(order));
        }

        // Process payment
        _paymentService.Pay(order);

        // Log order processing
        _logger.LogInfo($"Order {order.OrderId} processed successfully.");
    }

    public void PlaceOrder(Order order)
    {
        // Logic to place the order
        _logger.LogInfo($"Order {order.OrderId} placed successfully.");
    }

    public Order GetOrderById(int orderId)
    {
        // Logic to retrieve an order by ID
        return new Order(); // Placeholder for actual implementation
    }

    public IEnumerable<Order> GetAllOrders()
    {
        // Logic to retrieve all orders
        return new List<Order>(); // Placeholder for actual implementation
    }

    public void UpdateOrder(Order order)
    {
        // Logic to update an existing order
        _logger.LogInfo($"Order {order.OrderId} updated successfully.");
    }

    public void CancelOrder(int orderId)
    {
        // Logic to cancel an order
        _logger.LogInfo($"Order {orderId} cancelled successfully.");
    }
}