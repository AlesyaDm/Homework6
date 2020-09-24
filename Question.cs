using System;
using System.Collections.Generic;
using System.Text;

namespace Homework6
{
    class Question
    {
        public Question(int number)
        {
            this.QuestionNumber = number;
        }
        public string QuestionText;
        public Answer[] Answers;
        public int QuestionNumber; 

        public void ShowQuestion()
        {
            Console.WriteLine("");
            Console.WriteLine("Вопрос:");
            Console.WriteLine(QuestionText);
        }
       
        



    }
}
