
using System.Collections;

namespace MyFirstApp.BasicProjects;

class HasstablePractice
{






    public static void HastableMainProgram()
    {
        // create table for student
        Hashtable studentTable = new Hashtable();

        // create student objects
        Student std1 = new Student(1,"Ramesh",96);
        Student std2 = new Student(2,"Nikhil",86);
        Student std3 = new Student(3,"Abhishek",75);
        Student std4 = new Student(4,"Naresh",90);


        // assigning the key and value to table
        studentTable.Add(std1.ID, std1);
        studentTable.Add(std2.ID, std2);
        studentTable.Add(std3.ID, std3);
        studentTable.Add(std4.ID, std4);


        // retrive the individual value of student
        Student storedStudent1 = (Student) studentTable[std1.ID];

        Console.WriteLine("individual student ID: {0}, Name: {1}, GPA: {2}", storedStudent1.ID,storedStudent1.Name,storedStudent1.GPA);


        Console.WriteLine("\nAll Student details are:");
        // retriving the all value from studenttable
        foreach(DictionaryEntry entry in studentTable)
        {
            Student temp = (Student) entry.Value;            // should have to typecase to define object type in dictionary

            Console.WriteLine("ID: {0}, Name: {1}, GPA: {2}", temp.ID,temp.Name,temp.GPA);
 
        }

        Console.WriteLine("\nAll Student details are:");

         // retriving the all value from studenttable
        foreach(Student temp in studentTable.Values)
        {  
            Console.WriteLine("ID: {0}, Name: {1}, GPA: {2}", temp.ID,temp.Name,temp.GPA);
        }






        


    }
    
}


