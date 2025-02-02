public class Rectangle{

    // will be constant for all object of class
    public const int NumberOfCorent = 4;

    // will be change for all object of class
    public readonly string Color;



    public Rectangle(string color)
    {
        Color = color;   
    }

    public double width {get ;set;}
    public double length {get;set;}

    public double Aarea => width*length;

    public void DisplayDetails()
    {
             
        Console.WriteLine($"rectang details is\n width: {width} length: {length} color: {Color}  number of corner: {NumberOfCorent}");
        
    }



   public static void  RectangleMain()
    {
        Rectangle rct1 = new Rectangle("black");
        Rectangle rct2 = new Rectangle("Red");

        rct1.DisplayDetails();
        rct2.DisplayDetails();


    }

}