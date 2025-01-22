using System.Security.Cryptography.X509Certificates;

public class StaticKeyword
{

    private class TestStatic{
        static int objectCount=0;

        public TestStatic()
        {
            objectCount++;
            
        }
        public void GetCountofObject()
        {
            Console.WriteLine("Total created object for this class is: "+ objectCount);
        }

        public static void PrintMyMessage(String message)
        {
            Console.WriteLine("Message for u: "+ message);
        }


    }

    public static void StaticKeywordMain()
    {
        TestStatic obj = new TestStatic();
        obj.GetCountofObject();
        TestStatic.PrintMyMessage("this is static method");
    }
}