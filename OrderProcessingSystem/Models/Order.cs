namespace OrderProcessingSystem.Models;
public class Order
{
    public string ProductName { get; set; }
    public double Price { get; set; }

    public int OrderId { get; set; }
    // public DateTime OrderDate { get; set; }
    // public string CustomerName { get; set; }
    // public string ShippingAddress { get; set; }
    // public List<OrderItem> Items { get; set; } = new List<OrderItem>();
    // public decimal TotalAmount { get; set; }
    // public string Status { get; set; } // e.g., Pending, Shipped, Delivered, Cancelled


}