
namespace MyFirstApp.Collections;


class DictionaryPractice
{


    public static void ComplexDictionary()
    {
        // key - value
            // Declaring and initializing a Dictionary
            Dictionary<int, Employee> employees = new Dictionary<int, Employee>();

            employees.Add(1, new Employee("John Does", 35, 100000));
            employees.Add(2, new Employee("John Smith", 25, 200000));
            employees.Add(3, new Employee("John Karle", 45, 80000));
            employees.Add(4, new Employee("John Disoza", 15, 50000));

            foreach (var item in employees)
            {
                Console.WriteLine($"ID: {item.Key} named: {item.Value.Name} " +
                    $"earns {item.Value.Salary}" +
                    $" and is {item.Value.Age} years old!");
            }

            Console.ReadKey();

    }

    public static void BasicDictionary()
    {
          //declaring and initializing dictionary
        Dictionary<int,string> employees = new Dictionary<int, string>();

        //adding items in dictionary
        employees.Add(101,"John Doe");
        employees.Add(102,"Anderea wilson");
        employees.Add(103,"Tanya tooley");         
        employees.Add(104, "Bob Smith");
        employees.Add(105, "Rob Smith");
        employees.Add(106, "Flob Smith");
        employees.Add(107, "Dob Smith");

        //accessing individual items in a dictionary
        string Name = employees[102];
        Console.WriteLine("Emaployee Name: {0}", Name);

        // Aaccessing all items in a dictionary
        foreach(KeyValuePair<int,string> employee in employees)
        {
            Console.WriteLine($"Employee ID: {employee.Key}, Employee Name: {employee.Value}");
        }

        // updating employee details
        employees[102] = "Abhishek Singh";

     
        // remove an item from a dictionary
            employees.Remove(101);
        
         Console.WriteLine("After removing 101 and updating 102 Dictionary items is: ");
         foreach(KeyValuePair<int,string> employee in employees)
        {
            Console.WriteLine($"Employee ID: {employee.Key}, Employee Name: {employee.Value}");
        }


        
        // check the key before adding
            if (!employees.ContainsKey(104))
            {
                employees.Add(104, "Mike Jike");
            }

            bool added = employees.TryAdd(102, "Michal Brims");
            if (!added)
            {
                Console.WriteLine("Employee with the id of 102 already exists");
            }

            /*
            int counter = 101;

            while (employees.ContainsKey(counter))
            {
                counter++;
            }
            employees.Add(counter, "Jesus Christ");
            */
             foreach(KeyValuePair<int,string> employee in employees)
        {
            Console.WriteLine($"Employee ID: {employee.Key}, Employee Name: {employee.Value}");
        }

    }

    
    public static void DictionaryMainMethod()
    {
      //  BasicDictionary();
        ComplexDictionary();


    }
}