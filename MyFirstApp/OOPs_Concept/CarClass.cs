using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

namespace OOPs_Concept;

//internal class can access within same assembly
internal class CarClass
{
 public static int numberOfCars = 0 ;

  //member variable
   private string _brand = "";        //we should use backing fields if you want to overwrite anty data    

    // private bool _isLuxury ;

    // property
    public string? Model { get ; set ; }
    public bool IsLuxury { get ; set ; }

    public string Brand { 
        
        get
        {
            if(IsLuxury)       return _brand + "  Luxury";     
            else   return _brand;
            
        } 
        set 
        {
            if (string.IsNullOrEmpty(value))
            {
                Console.WriteLine("you entered nothing");
                _brand = "DefaultValue";
            }
            else    _brand = value;
        }
    }

    // default constructor
    public CarClass()    {
         // Increment the static field value by one each time a new Car object is created.
        numberOfCars ++;
        
    }

     //custome constructor
    public  CarClass(string model, string brand, bool Isluxury)
    {
        numberOfCars ++;
        Model = model ;
        Brand = brand ;
        Console.WriteLine($"Car {Brand} of model {Model}  has been created");
        IsLuxury= Isluxury;
    }

  //  publicaly expose method
    public void Drive()    {        
        Console.WriteLine($"I am car model {Model} and I'm driving");
    }

     public static void CarMain()
    {
        // Pen ballpen  = new Pen("2A","ballPen");
        // Pen jelPen = new Pen("A21","Jelpen");

        CarClass BMW = new CarClass("i6", "BMW", true);
        BMW.Drive();

        CarClass Audi = new CarClass("A3", "Audi", false);
        Audi.Drive();

        // getting the brand value
        Console.WriteLine($"Brand Value is: {BMW.Brand}");
         Console.WriteLine($"updated Brand Value is: {Audi.Brand}");

        // accessing static fields of carclass
        Console.WriteLine("number of car created:" + CarClass.numberOfCars);

        //  Console.WriteLine("I am in main program");
        Console.ReadLine(); 
    }
}
