
using System.Security.Cryptography;

public class EmployeeTest{
    string EmployeeName{get;set;}
    int EmployeeAge {get;set;}
    public void MethodWithOptionalParameter(string nam = "DefaultN", int age = 99)
    {   
        EmployeeName = nam;
        EmployeeAge = age;

    }
    public void GetEmployeDetails()
    {
        Console.WriteLine(EmployeeName + " has age : " + EmployeeAge);
    }
    public static void MethodPracticeMain()
    {
        EmployeeTest emp1 = new EmployeeTest();

        emp1.MethodWithOptionalParameter();  // call method with optional parameter
        emp1.GetEmployeDetails();
        emp1.MethodWithOptionalParameter(age: 35, nam: "Abhishek");   // call method with name parameter
         emp1.GetEmployeDetails();

    }
}



public class AreaCalculator{

    double length {get;set;}
    double width{get;set;}

    // computed property
    // read-only
    public double GetArea
    {
        get{ return length*width;} 
    }
}


   