using System;
using System.Collections.Generic;
using System.Text;

namespace Homework6
{
    class Question
    {
        public string QuestionText;
        public Answer[] Answers;

        public void ShowQuestion()
        {
            Console.WriteLine("");
            Console.WriteLine("Вопрос:");
            Console.WriteLine(QuestionText);
        }
       
        



    }
}
