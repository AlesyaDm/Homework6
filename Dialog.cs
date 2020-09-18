using System;
using System.Collections.Generic;
using System.Text;

namespace Homework6
{
    class Dialog
    {
        public void Start()
        {
            Console.WriteLine("Добро пожаловать в игру \"Кто хочет стать миллионером\"!");
        }

        public void Rules(User user)
        {
            Console.WriteLine(user.UserName + ", чтобы выиграть главный приз, вам предстоит ответить на 11 вопросов. " +
                "В каждом вопросе 4 варианта ответа, один из которых является верным. " +
                "Первый правильный ответ принесет вам 100 BYN. За каждый последующий правильный ответ сумма выигрыша удваивается. При неверном ответе игра завершается, " +
                "а сумма выигрыша сгорает. После каждого верного ответа вы можете остановить игру и забрать текущий выигрыш.");
        }
        public void AskAboutContinue()
        {
            Console.WriteLine("");
            Console.WriteLine("Вы  можете забрать деньги сейчас или продолжить игру.");
            Console.WriteLine("Введите +, если хотите продолжить игру.");
            Console.WriteLine("Введите -, если хотите забрать выигрыш и завершить игру.");
        }
        
    }
}
