using System;

namespace Homework6
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Game game = new Game();
            game.Start();
            Question[] QuestionList = null;
            game.PrepareQuestion();
            User user = new User();
            user.UserName = user.UserInputName("Введите свое имя: ");
            game.Rules(user);

            Score score = new Score(0);
            score.UserScore(score.TotalScore);
            score.MaxScore = 102400;
                        
            int i = 0;
                                     
                for (score.TotalScore = 50; score.TotalScore < score.MaxScore; i++)
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
                    if (score.TotalScore == score.MaxScore)
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
                    score.UserScore(score.TotalScore);
                    game.AskAboutContinue();
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

            Console.WriteLine("Спасибо за участие!");
            Console.WriteLine("Игра завершена.");
        }
                
    }
}
