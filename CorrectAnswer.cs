using System;
using System.Collections.Generic;
using System.Text;

namespace Homework6
{
    class CorrectAnswer : Answer
    {
        public CorrectAnswer (string AnswerText) : base(AnswerText)
        {
            
        }
        public override void Choose()
        {
            Console.WriteLine("Верно!");
        }

        public override void ShowAnswers()
        {
            
            Console.WriteLine(AnswerText);
        }
    }
}
