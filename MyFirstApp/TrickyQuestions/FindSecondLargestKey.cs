class FindSecondLargestKey
{



    public static void  FindSecondLargestKeyMain()
    {

        Dictionary<string,int> hasmap = new Dictionary<string, int>()
        {
             
            { "Alice", 50 },
            { "Bob", 80 },
            { "Charlie", 90 },
            { "David", 60 },
            { "Eve", 70 }
        };

        var sortedDIctionary = hasmap.OrderByDescending(kvp => kvp.Value).ToList();

        Console.WriteLine("Key {0}, value: {1}", sortedDIctionary[1].Key,sortedDIctionary[1].Value);

        foreach(var v in sortedDIctionary)
        {

        }
        
    }
    
}