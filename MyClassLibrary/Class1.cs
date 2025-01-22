namespace MyClassLibrary;

public class Product
{
    public int productID { get; set; }  
    public string productName  { get; set; }  
    public double productPrice { get; set; }  
    public int quantityInStock { get; set; }

}


public class DomesticProduct : Product
{

}
