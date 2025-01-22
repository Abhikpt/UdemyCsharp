
namespace OOPs_Concept.Customer1;

public class Customer
{
    //static field to hold nextID available
    private static int nextID = 0 ;

    //read-only  instance field initialize from sonstructor
    private readonly int _id;

    // backing-fields for write only property
    private string _password ;

    // write-only property
    private string Password {set 
                {_password = value;}
    }

    //read only (get) property to expost ID outside
    public int ID { get {return _id;}   }
    public  string Name {get; set;}
    public string? Address { get; set; }
    public string? ContactNumber { get; set; }

// default constructor
public Customer()
{   
    _id = nextID++;
    Name = "DefaultCust";
    Address = "unknown";
    ContactNumber = "NA";    
}

// custom constructor
    public Customer(string name, string address,string contact)
    {
        _id = nextID++;    //created to set key for customer
        Name = name;
        Address = address;
        ContactNumber = contact;
        
    }

// custom constructor
    public Customer(string name)
    {
        _id = nextID++;
        Name = name;
        
    }

    // methods 
    public void SetDetails(string name, string address,string contact)
    {
        Name = name;
        Address = address;
        ContactNumber = contact;
        
    }


    // method with default/optional parameter
     public void SetDetailsDefault(string name, string address = "NOTset", string contact = "Not Set")
    {
        Name = name;
        Address = address;
      //  ContactNumber = contact;
        
    }


    public void GetDetails()
    {
        Console.WriteLine($"Customer details is:\nName -> {Name} and id -> {_id}");
    }

    public void GetSecured()
    {
         Console.WriteLine($"Customer details is:\nName -> {Name} and id -> {_id} and password is: {_password}");
    }



     public static void CustomerMain()
    {

        Customer DefaultCust = new Customer();
        Customer Alen = new Customer("Alena krn");
        Customer Magnet = new Customer("Magent jnk ", "123 left street", "3843843948");        
        DefaultCust.GetDetails();
        Alen.GetDetails();
        Magnet.GetDetails();
     
        //read only property
         Console.WriteLine("Magnet has id : "+ Magnet.ID);   //accessing/exposing id seperately 

        //write-oly property
        Magnet.Password = "test2343";
        Magnet.GetSecured();
    }

}

