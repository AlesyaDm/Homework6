using System;
using System.Collections.Generic;
using System.Text;

namespace Homework6
{
    class Score
    {
        public Score(int totalscore)
        { this.TotalScore = totalscore; }

        public int TotalScore;
        public int MaxScore;
        public void UserScore(int TotalScore)
        { Console.WriteLine("Текущий счет: " + TotalScore + " BYN"); }

    }
}
