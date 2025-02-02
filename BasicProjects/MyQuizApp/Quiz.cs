
using System.Drawing;

namespace MyQuizApp;
//display quesion on screen
public class Quiz
{
    private Questions[] questions;
    private int _score ;
    public Quiz(Questions[] questions)
    {
       this.questions = questions; 
       _score= 0;      
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

        // commented as using in start quiz // validate the ans
        // if(GetUserChoice() == questions.CorrectOptionIndex)
        // {
        //     Console.WriteLine("  Correct option");
        // }
        // else 
        // Console.WriteLine("   Wrong option");
    }


    public int GetUserChoice()
    {
        Console.Write("Enter your Answer/choice: ");
        string? input = Console.ReadLine();
        int choice = 0;

        while(!int.TryParse(input, out choice) || choice <1 || choice > 4)
        {
            Console.WriteLine("Invalid choice. Enter the number between 1 and 4");
            input = Console.ReadLine();
        }

        return choice-1;   // in actual option index will be 1 less

    }

    public void StartQuiz()
    {
        Console.WriteLine("Welcome to the Quiz.");
        int questionNumber = 1;

        foreach(var question in questions)
        {
            Console.WriteLine($"Question: {questionNumber++}");
            DisplayQuestions(question);
            int choice = GetUserChoice();

            if( question.IsCorrectOption(choice))
            {
                Console.WriteLine("Correct options");
                _score++;
            }
            else
            Console.WriteLine($"Incorrect. Correct answer is {question.Options[question.CorrectOptionIndex]}");
            
        }
        DisplayResults();

    }

    private void DisplayResults()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("================================================");
        Console.WriteLine("||                    Result                  ||");
        Console.WriteLine("================================================");
         Console.ResetColor();
        Console.WriteLine($"You scored: {_score} out of {questions.Length}");

        double percentage = (double) (_score/questions.Length );

        if(percentage >= 0.8)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Exceleant!!, you achieve {percentage}");
        }

        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"keep practicing!!, you achieve {percentage}");
        }
        Console.ResetColor();



    }


    public static void QuizMainProgram()
    {
            Questions[] questions = new Questions[]
            {
               new Questions(
                    "What the capital of Germany?",      //your questions
                    new string[] {"Paris", "Berlin", "London", "Madrid"},   //your options 0-3
                    1                // you correct answer Berlin
                ),

                new Questions(
                    "which one  is not a principle of Object-Oriented Programming?",
                    new string[] {"Encapsulation", "Inheritance", "Compilation","Polymorphism"},
                    2
                ),
                  new Questions(
                    "What is 3+2?",
                    new string[] {"2", "3", "5","4"},
                    2
                ),

            
            };

            Quiz myQuiz = new Quiz(questions);
            myQuiz.StartQuiz();
           // using optimize method now// myQuiz.DisplayQuestions(questions[0]);
            Console.ReadLine();

    }
    
    
}

