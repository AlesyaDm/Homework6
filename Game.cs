using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Homework6
{
    class Game
    {
        public void Start(User user, Score score, Question question)
        {
            Dialog.Start();
            string InputSign = user.UserInputSign();
            if (InputSign == "+")
            {
               
                Load("F:/SaveVisualStudio/game.txt", score, question);
            }
            if (InputSign == "-")
            {
                NewGame(score);
            }
        }
       
        private void NewGame(Score score)
        {

            User user = new User();
            user.UserName = user.UserInputName("Введите свое имя: ");
            Dialog.Rules(user);
            user.UserScore(score);
         }
        public void QuestionCicle(Score score, User user, Question[] QuestionList, Question question)
        {
           
            while (question.QuestionNumber < QuestionList.Length)
            {
                QuestionList[question.QuestionNumber].ShowQuestion();
                Console.WriteLine("");
                Console.WriteLine("Варианты ответа:");
                foreach (Answer value in QuestionList[question.QuestionNumber].Answers)
                {
                    value.ShowAnswers();
                }
                user.InputNumber = user.UserInputNumber("Введите номер правильного ответа:");
                Answer UserChoose = QuestionList[question.QuestionNumber].Answers[user.InputNumber - 1];
                UserChoose.Choose();
                if (UserChoose is CorrectAnswer)                {

                    score.TotalScore = score.TotalScore * 2;
                    question.QuestionNumber++;
                    if (question.QuestionNumber == QuestionList.Length)
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
                Dialog.AskAboutContinue();
                string InputSign = user.UserInputSign();
                if (InputSign == "+")
                {

                }
                if (InputSign == "-")
                {
                    Console.WriteLine("Ваш выигрыш: " + score.TotalScore + " BYN");
                    break;
                 }
                if (InputSign == "*")
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
            StreamWriter myStreamWriter = new StreamWriter(myFileStream, Encoding.UTF8);
            myStreamWriter.WriteLine(score.TotalScore);
            myStreamWriter.WriteLine(question.QuestionNumber + 1);
            myStreamWriter.Flush();
            myStreamWriter.Close();
        }
        private void Load(string filepath, Score score, Question question)
        {
            FileInfo myFile = new FileInfo(filepath);
            if (!myFile.Exists)
            {
                throw new FileNotFoundException(filepath);
            }
            FileStream myFileStream = myFile.OpenRead();
            StreamReader myStreamReader = new StreamReader(myFileStream, Encoding.UTF8);
            score.TotalScore = int.Parse(myStreamReader.ReadLine());
            question.QuestionNumber = int.Parse(myStreamReader.ReadLine());
            myStreamReader.Close();
         }
        public static void Finish()
        {
            Console.WriteLine("Спасибо за участие!");
            Console.WriteLine("Игра завершена.");
        }

    }
}
