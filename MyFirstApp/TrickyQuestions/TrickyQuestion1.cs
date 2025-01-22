
namespace CSHARPCONCEPTS.TrickyQuestions;

public class TrickyQuestions1
{   
    public static void TrickyQuestionsMain()
    {
         for(int i = 0 ; i< 10; i++)
        Console.WriteLine(RandomNumberGenerator(1,56)); 

        Console.WriteLine("Generated random string is:- " +RandomStringGenerator(6));        

    }


    // random number generator
    public static double RandomNumberGenerator(int minValue = 0 , int maxValue  = 0)
    {
        Random random = new Random();
        if(maxValue == 0 && minValue == 0)
        // create random number without any restriction
        return random.NextDouble();        

        else if (minValue ==0 && maxValue != 0)
        // create random number below the maxnumber
        return random.Next(maxValue); 

        else
        // created  number between min and max
        return random.Next(minValue,maxValue);         

    }
    
    public static string RandomStringGenerator(int length)
    {
        Random rand =  new Random();
        string charToBeUse = "ABCDEFGHIJKLMNOPQRSTUVWXYZ!@#$%^&*()1234567890";
        Char [] resultChar = new char[charToBeUse.Length];

        for(int i = 0 ; i< length ; i++)
        {
            // taking character from give string by using randmon number, value will less to length
            resultChar[i] = charToBeUse[rand.Next(charToBeUse.Length)];
        }  
        return  new string(resultChar);
    }

}