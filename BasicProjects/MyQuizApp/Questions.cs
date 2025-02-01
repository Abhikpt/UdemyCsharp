
// To display individual questions
public  class Questions
{
        public string QuestionText  { get; set; }
        public string[] Options { get; set; }
        public int CorrectOptionIndex { get; set; }

  
        public Questions(string questionsText, string[] options, int correctOptionIndex)
        {
            
                QuestionText = questionsText;
                Options = options;
                CorrectOptionIndex = correctOptionIndex;
        }


        public bool IsCorrectOption(int choice)
        {
            return CorrectOptionIndex == choice;
        }




}

