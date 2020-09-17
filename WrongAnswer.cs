using System;
using System.Collections.Generic;
using System.Text;

namespace Homework6
{
    class WrongAnswer : Answer
    {
        public WrongAnswer(string AnswerText) : base(AnswerText)
        {
        }
        public override void Choose()
        {
            Console.WriteLine("К сожалению, ответ неверный.");
        }
        public override void ShowAnswers()
        {
            Console.WriteLine(AnswerText);
        }
    }
}
