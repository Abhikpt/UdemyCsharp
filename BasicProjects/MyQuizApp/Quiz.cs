
namespace MyQuizApp;
//display quesion on screen
public class Quiz
{
    private Questions[] questions;
    public Quiz(Questions[] questions)
    {
       this.questions = questions;        
    }


    public void DisplayQuestions( Questions questions)
    {   Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("===============================================================");
        Console.WriteLine("||                       Questions                           ||");
        Console.WriteLine("===============================================================");
        Console.ResetColor();
        
        // main logic or code
        Console.WriteLine(questions.QuestionText);
        for(int i = 0; i< questions.Options.Length ; i++)
        {
            Console.WriteLine($" {i+1} - {questions.Options[i]}");
        }

        // validate the ans
        if(GetUserChoice() == questions.CorrectOptionIndex)
        {
            Console.WriteLine("  Correct option");
        }
        else 
        Console.WriteLine("   Wrong option");
    }


    public int GetUserChoice()
    {
        Console.Write("Enter your Answer/choice: ");
        string input = Console.ReadLine();
        int choice = 0;

        while(!int.TryParse(input, out choice) || choice <1 || choice > 4)
        {
            Console.WriteLine("Invalid choice. Enter the number between 1 and 4");
            input = Console.ReadLine();
        }

        return choice-1;   // in actual option index will be 1 less

    }


    public static void QuizMainProgram()
    {
            Questions[] questions = new Questions[]
            {
               new Questions(
                    "What the capital of Germany?",
                    new string[] {"Paris", "Berlin", "London", "Madrid"},
                    1
                )
            };

            Quiz myQuiz = new Quiz(questions);
            myQuiz.DisplayQuestions(questions[0]);
            Console.ReadLine();

    }
    
    
}

