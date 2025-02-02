
using System.Globalization;
using MyClassLibrary;

namespace BasicProjects.Collection;

class WorkingWithLists
{
    

    public static void NumberList()
    {
         // declarining and initalizing the list
        List<int> numbers = new List<int> {12,34,23,24,4,7,5,9,2,3,4,5,6,11};

        // adding the list values
        numbers.Add(2);
        numbers.Add(4);
        numbers.Add(1);

        Console.WriteLine("\nAfter add List has values:");
          foreach(int number in numbers)
        {
            Console.Write(number + " ");
        }

        //  removing the first occurance of values
        bool isDeletedSuccessfull = numbers.Remove(4);        
        Console.WriteLine("\nPrint the number after removing value 4");
        Console.Write(String.Join(" ", numbers.ToArray()));

        Console.WriteLine("\nAfter Removing all 4 list is: ");
        while(isDeletedSuccessfull)
        {
            isDeletedSuccessfull = numbers.Remove(4);    // delete all 4, in last it will through false
        }
        Console.Write(String.Join(" ", numbers.ToArray()));
        

        // removing the value at indexed based
        numbers.RemoveAt(1);
        Console.WriteLine("\nPrint the number after removing index 1 value");
        IEnumerator<int> enumerator = numbers.GetEnumerator();  // print using enumerator
        while(enumerator.MoveNext())
        {
            Console.Write(enumerator.Current + " ");
        } 


       // sorting the list 
        numbers.Sort();
        Console.WriteLine("\nAfter sorting List values:");
        foreach(int number in numbers)
        {
            Console.Write(number + " ");
        }         

        // create and print list with some condition
        Predicate<int> predicate = x=> x>=15;
        List<int> number2 = numbers.FindAll(predicate);
        Console.WriteLine("\nAll number 15 and higher in List is");
        number2.ForEach(nm => Console.Write(nm + " ")); 


        // check some element exist
        bool hasLargernumber = numbers.Any(x => x>25);
        if(hasLargernumber)
        Console.WriteLine("\nList Has large number greater than 25");
        else
        Console.WriteLine("\nList Has no large number greater than 25");
       
    }


    

    public static void StringList()
    {   
        //Declaring a list and  initalizing
        List<string> words =  ["Mango", "Bananas", "Graps", "Orange", "Manago", "Apple" ];

        Console.WriteLine("\nString List has items: " );
        foreach(string word in words)
        {
            Console.Write(word + " ");
        }
                 
    }


    public static void ObjectList()
    {   
        //declare the list with complext value , can access object property as the are public
       List<Student> students = new List<Student>
       {
            new Student { StudentID =1 , StudenaName ="RajKashyap" , Fees = 545.56},
            new Student {StudentID =2, StudenaName ="Amit", Fees = 123.54},
            new Student {StudentID =3, StudenaName = "Udit", Fees =342.45}
       };

        //add items to the list
       students.Add(new Student {StudentID=4, StudenaName="Abhishek", Fees=454.54});


       Console.WriteLine($"\nStudent details are: ");
       //iterate through list
       foreach (Student item in students)
       {
            Console.WriteLine($"StudentID : {item.StudentID} StudentName: {item.StudenaName} Fees: {item.Fees} ");
       }


       List<Student> discountedStudent = students.Where(s => s.Fees <=200).ToList();
        Console.WriteLine($"\nStudent details have discount fees are: ");
       //iterate through list
       foreach (Student item in discountedStudent)
       {
            Console.WriteLine($"StudentID : {item.StudentID} StudentName: {item.StudenaName} Fees: {item.Fees} ");
       }


    }


    public static void ListMainMethod()
    {
       NumberList();
       Console.WriteLine("\n------------------------------------------------------");     
       StringList();
       Console.WriteLine("\n------------------------------------------------------");     
       ObjectList();
       Console.WriteLine("\n------------------------------------------------------");     

    }

}



class Student{


    public int StudentID { get; set; } 
    public String StudenaName { get; set; } = "" ;       // added default value
    public double Fees { get; set; }

   
}