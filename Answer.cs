using System;
using System.Collections.Generic;
using System.Text;

namespace Homework6
{
    abstract class Answer

    {
        public Answer(string AnswerText)
        {
            this.AnswerText = AnswerText;
        }
        public string AnswerText;
       
        public abstract void ShowAnswers();
        
        public abstract void Choose();
        
    }
}
