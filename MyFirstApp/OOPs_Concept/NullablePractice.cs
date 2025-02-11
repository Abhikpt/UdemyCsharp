
namespace MyFirstApp.OOPs_Concept;

class NullablePractice
{


    public static void NullablePracticeMain()
    {

        int? age = null;        // it will through error if not use ? that make it nullable type
        int myAge = 30;
        age=45;
        if(age.HasValue)
        {   

            Console.WriteLine("Age is : " + age.Value);
            int sum = age.Value+ myAge;
            Console.WriteLine("Total Age is : " + sum);

        }
        else
        {
          //   int sum = age.Value+ myAge;       // here it show error
             Console.WriteLine("Age is not specified");
           
        }

    }
    
}