using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Homework6
{
    class Game
    {
        public void Start(Score score, Question question, User user)
        {
            Dialog.Start();
            user.InputSign = User.UserInputSign();
            if (user.InputSign == "-")
            {
               Load("F:/SaveVisualStudio/game.txt", score, question);
            }
            if (user.InputSign == "+")
            {
                NewGame(score);
            }
        }
       
        private void NewGame(Score score)
        {

            User user = new User();
            user.UserName = User.UserInputName("Введите свое имя: ");
            Dialog.Rules(user);
            Console.WriteLine("Текущий счет: 0 BYN");
         }
        public void QuestionCicle(Score score, User user, Question[] QuestionList, Question question)
        {
           
            while (question.QuestionNumber <= QuestionList.Length)
            {
                AskQuestion(QuestionList, question);
                user.InputNumber = User.UserInputNumber("Введите номер правильного ответа:");
                Answer UserChoose = QuestionList[question.QuestionNumber-1].Answers[user.InputNumber - 1];
                UserChoose.Choose();
                if (UserChoose is CorrectAnswer)                {

                    score.TotalScore = score.TotalScore * 2;
                    question.QuestionNumber++;
                    if (question.QuestionNumber > QuestionList.Length)
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
                User.UserScore(score);
                Dialog.AskAboutContinue();
                user.InputSign = User.UserInputSign();
                if (user.InputSign == "+")
                {

                }
                if (user.InputSign == "-")
                {
                    Console.WriteLine("Ваш выигрыш: " + score.TotalScore + " BYN");
                    break;
                 }
                if (user.InputSign == "*")
                {
                    Save("F:/SaveVisualStudio/game.txt", score, question);
                    break;
                }


            }
        }
        private void Save(string filepath, Score score, Question question)
        {
            FileInfo myFile = new FileInfo(filepath);
            if (myFile.Exists)
            {
                myFile.Delete();
            }
            FileStream myFileStream = myFile.OpenWrite();
            using (StreamWriter myStreamWriter = new StreamWriter(myFileStream, Encoding.UTF8))
            {
                try
                {
                    myStreamWriter.WriteLine(score.TotalScore);
                    myStreamWriter.WriteLine(question.QuestionNumber + 1);
                }
                catch (Exception ex)
                {

                }
            }
        }
        private void Load(string filepath, Score score, Question question)
        {
            FileInfo myFile = new FileInfo(filepath);
            if (!myFile.Exists)
            {
                throw new FileNotFoundException(filepath);
            }
            FileStream myFileStream = myFile.OpenRead();
            using (StreamReader myStreamReader = new StreamReader(myFileStream, Encoding.UTF8))
            {
                try
                {
                    score.TotalScore = int.Parse(myStreamReader.ReadLine());
                    question.QuestionNumber = int.Parse(myStreamReader.ReadLine());
                }
                catch (Exception ex)
                {

                }
            }
                       
         }
        public static void Finish()
        {
            Console.WriteLine("Спасибо за участие!");
            Console.WriteLine("Игра завершена.");
        }
        private static void AskQuestion(Question[] QuestionList, Question question)
        {
            QuestionList[question.QuestionNumber-1].ShowQuestion();
            Console.WriteLine("");
            Console.WriteLine("Варианты ответа:");
            foreach (Answer value in QuestionList[question.QuestionNumber-1].Answers)
            {
                value.ShowAnswers();
            }
        }

    }
}
