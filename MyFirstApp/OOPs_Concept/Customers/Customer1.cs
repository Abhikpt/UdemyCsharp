
namespace OOPs_Concept.Customer1;

public class Customer1
{
    public  string Name {get; set;}
    public string? Address { get; set; }
    public string? ContactNumber { get; set; }

// default constructor
public Customer1()
{
    Name = "new Customer1";
    Address = "unknown";
    ContactNumber = "NA";    
}

// custom constructor
    public Customer1(string name, string address,string contact)
    {
        Name = name;
        Address = address;
        ContactNumber = contact;
        
    }

// custom constructor
    public Customer1(string name)
    {
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


     public static void Customer1Main()
    {

        // custom constructor
        Console.WriteLine("---------working with custome constructor-------");
        Customer1 Alesk = new Customer1("aleak krn");
        Customer1 Magnet = new Customer1("Magent jnk ", "123 left street", "3843843948");
        Console.WriteLine("Details of the Customer1 for first obj is: " + Alesk.Name);
        Console.WriteLine($"details of second Customer1 is: Name-{Magnet.Name} , address - {Magnet.Address}, Contact- {Magnet.ContactNumber}");
        

        // Default constructor example
        Console.WriteLine("---------working with default constructor-------");
        Customer1 Def = new Customer1();
        Console.WriteLine($"details of default Customer1 is: Name-{Def.Name} , address - {Def.Address}, Contact- {Def.ContactNumber}");
        // set the Customer1 value
        Def.Name = "Andera"; Def.ContactNumber = "2845737402"; Def.Address = "121 block c";
        Console.WriteLine($"details of added Customer1 is: Name-{Def.Name} , address - {Def.Address}, Contact- {Def.ContactNumber}");



        // working with methods 
        Console.WriteLine("---------working with parameter-------");
        Def.SetDetails("Dane Saf", "12 candor park", "3432317890");
        Console.WriteLine($"details of added Customer1 is: Name-{Def.Name} , address - {Def.Address}, Contact- {Def.ContactNumber}");
        Console.WriteLine($"details of second Customer1 is: Name-{Magnet.Name} , address - {Magnet.Address}, Contact- {Magnet.ContactNumber}");


        // default / option paramter example
        Console.WriteLine("---------default / option paramter example-------");
        Def.SetDetailsDefault("Dane D");
        Console.WriteLine($"details of added Customer1 is: Name-{Def.Name} , address - {Def.Address}, Contact- {Def.ContactNumber}");
        Def.SetDetailsDefault("Dane S","12 block A");
        Console.WriteLine($"details of added Customer1 is: Name-{Def.Name} , address - {Def.Address}, Contact- {Def.ContactNumber}");

       
    }

}

