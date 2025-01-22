using OOPs_Concept;

internal class Pen{
    string _brand = "";
    string _model = "" ;

     public string Brand { get => _brand; set => _brand = value; }
    public string Model { get => _model; set => _model = value; }

   public  Pen(string brand, string model)
    {
        Brand = brand;
        Model = model;

        Console.WriteLine($"Pen {brand} is created with model {model}");
        
    }

   
}