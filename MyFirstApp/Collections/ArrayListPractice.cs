
using System.Collections;

namespace MyFirstApp.BasicProjects;


class ArrayListPractice
{    

     public static void CreateAndDisplayArrayList()
     {
        //declaring arraylist with undefined amount of object
    ArrayList arrayList = new ArrayList();

    //declaring arraylist with defined amount of object
     ArrayList arrayList2 = new ArrayList(100);
     double sum =0 ;

     arrayList.Add(25);
     arrayList.Add("Hello");
     arrayList.Add(10);
     arrayList.Add(50);
     arrayList.Add(12.23);
     arrayList.Add(200);
     arrayList.Add(10);

     //delete element with specific value
     arrayList.Remove(10);

     //delete element with specific index
     arrayList.RemoveAt(4);

     Console.WriteLine($"\nArrayList length is: {arrayList.Count}");

     foreach(object obj in arrayList)
     {
        if(obj is int)
        {
            sum +=  Convert.ToDouble(obj) ;
        }

        else if(obj is string)
        {
            Console.WriteLine(obj);
        }
        else if(obj is double)
        {
            sum += (double) obj;
        }
       
     }
      Console.WriteLine(sum); 

     }

}

/*
output:
ArrayList length is: 5
Hello
97.23
*/