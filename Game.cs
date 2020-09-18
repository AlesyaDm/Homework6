using System;
using System.Collections.Generic;
using System.Text;

namespace Homework6
{
    class Game
    {
        public void Start()
        {
            Dialog dialog = new Dialog();
            dialog.Start();

            User user = new User();
            user.UserName = user.UserInputName("Введите свое имя: ");
            dialog.Rules(user);

            Score score = new Score(0);
            user.UserScore(score);

            
        }
        public void QuestionCicle(Score score, User user, Dialog dialog, Question[] QuestionList)
        {
            int i = 0;

            for (score.TotalScore = 50; i < QuestionList.Length; i++)
            {
                QuestionList[i].ShowQuestion();
                Console.WriteLine("");
                Console.WriteLine("Варианты ответа:");
                foreach (Answer value in QuestionList[i].Answers)
                {
                    value.ShowAnswers();
                }
                user.InputNumber = user.UserInputNumber("Введите номер правильного ответа:");
                Answer UserChoose = QuestionList[i].Answers[user.InputNumber - 1];
                UserChoose.Choose();
                if (UserChoose is CorrectAnswer)
                {

                    score.TotalScore = score.TotalScore * 2;
                    if (i == QuestionList.Length)
                    {
                        Console.WriteLine("Поздравляем! Вы ответили на все вопросы и выиграли главный приз: 100000 BYN!");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Ваш выигрыш: 0 BYN.");
                    break;
                }
                user.UserScore(score);
                dialog.AskAboutContinue();
                string InputSign = user.UserInputSign();
                if (InputSign == "+")
                {

                }
                if (InputSign == "-")
                {
                    Console.WriteLine("Ваш выигрыш: " + score.TotalScore + " BYN");
                    break;

                }


            }
        }
        public void Finish()
        {
            Console.WriteLine("Спасибо за участие!");
            Console.WriteLine("Игра завершена.");
        }

    }
}
