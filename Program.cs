using System;

namespace Homework6
{
    class Program
    {
        static void Main(string[] args)
        {
            Question question1 = new Question();
            question1.QuestionText = "Дважды два";
            question1.Answers = new Answer[4];
            question1.Answers[0] = new WrongAnswer("1. 1");
            question1.Answers[1] = new WrongAnswer("2. 2");
            question1.Answers[2] = new WrongAnswer("3. 3");
            question1.Answers[3] = new CorrectAnswer("4. 4");
            Question question2 = new Question();
            question2.QuestionText = "Столица Беларуси";
            question2.Answers = new Answer[4];
            question2.Answers[0] = new WrongAnswer("1. Лондон");
            question2.Answers[1] = new CorrectAnswer("2. Минск");
            question2.Answers[2] = new WrongAnswer("3. Токио");
            question2.Answers[3] = new WrongAnswer("4. Москва");
            Question question3 = new Question();
            question3.QuestionText = "Рожденный ползать летать не...";
            question3.Answers = new Answer[4];
            question3.Answers[0] = new CorrectAnswer("1. может");
            question3.Answers[1] = new WrongAnswer("2. хочет");
            question3.Answers[2] = new WrongAnswer("3. будет");
            question3.Answers[3] = new WrongAnswer("4. любит");
            Question question4 = new Question();
            question4.QuestionText = "Кого приобретает человек, который толком ничего о покупке не знает?";
            question4.Answers = new Answer[4];
            question4.Answers[0] = new WrongAnswer("1. Тигра в клетке");
            question4.Answers[1] = new CorrectAnswer("2. Кота в мешке");
            question4.Answers[2] = new WrongAnswer("3. Пса в будке");
            question4.Answers[3] = new WrongAnswer("4. Карася в аквариуме");
            Question question5 = new Question();
            question5.QuestionText = "Что необходимо для прогулки на гондоле?";
            question5.Answers = new Answer[4];
            question5.Answers[0] = new WrongAnswer("1. Крылья");
            question5.Answers[1] = new WrongAnswer("2. Бензин");
            question5.Answers[2] = new WrongAnswer("3. Педали");
            question5.Answers[3] = new CorrectAnswer("4. Весло");
            Question question6 = new Question();
            question6.QuestionText = "Как звали космического пирата из книги Кира Булычева?";
            question6.Answers = new Answer[4];
            question6.Answers[0] = new WrongAnswer("1. Кот");
            question6.Answers[1] = new WrongAnswer("2. Свин");
            question6.Answers[2] = new CorrectAnswer("3. Крыс");
            question6.Answers[3] = new WrongAnswer("4. Ворон");
            Question question7 = new Question();
            question7.QuestionText = "Чем подают сигналы судьи во время конкура?";
            question7.Answers = new Answer[4];
            question7.Answers[0] = new WrongAnswer("1. Свистком");
            question7.Answers[1] = new WrongAnswer("2. Сиреной");
            question7.Answers[2] = new CorrectAnswer("3. Колоколом");
            question7.Answers[3] = new WrongAnswer("4. Пистолетом");
            Question question8 = new Question();
            question8.QuestionText = "Исследование чего принесло трем ученым Нобелевскую премию " +
                "по физиологии и медицине за 2017 год?";
            question8.Answers = new Answer[4];
            question8.Answers[0] = new WrongAnswer("1. Циркуляции крови");
            question8.Answers[1] = new CorrectAnswer("2. Циркадных ритмов");
            question8.Answers[2] = new WrongAnswer("3. Циркониевых зубных протезов");
            question8.Answers[3] = new WrongAnswer("4. Песен цикад");
            Question question9 = new Question();
            question9.QuestionText = "Кого или что изучает герпетолог?";
            question9.Answers = new Answer[4];
            question9.Answers[0] = new WrongAnswer("1. Бабочек");
            question9.Answers[1] = new WrongAnswer("2. Лекарственные травы");
            question9.Answers[2] = new CorrectAnswer("3. Черепах");
            question9.Answers[3] = new WrongAnswer("4. Герпес");
            Question question10 = new Question();
            question10.QuestionText = "Чья фамилия стала названием блюда карпаччо?";
            question10.Answers = new Answer[4];
            question10.Answers[0] = new CorrectAnswer("1. Художника");
            question10.Answers[1] = new WrongAnswer("2. Повара");
            question10.Answers[2] = new WrongAnswer("3. Врача");
            question10.Answers[3] = new WrongAnswer("4. Космонавта");
            Question question11 = new Question();
            question11.QuestionText = "Какая страна не омывается морем?";
            question11.Answers = new Answer[4];
            question11.Answers[0] = new WrongAnswer("1. Албания");
            question11.Answers[1] = new CorrectAnswer("2. Сербия");
            question11.Answers[2] = new WrongAnswer("3. Черногория");
            question11.Answers[3] = new WrongAnswer("4. Румыния");
            Question[] QuestionList = new Question[11];
            QuestionList[0] = question1;
            QuestionList[1] = question2;
            QuestionList[2] = question3;
            QuestionList[3] = question4;
            QuestionList[4] = question5;
            QuestionList[5] = question6;
            QuestionList[6] = question7;
            QuestionList[7] = question8;
            QuestionList[8] = question9;
            QuestionList[9] = question10;
            QuestionList[10] = question11;

            Game game = new Game();
            Score score = new Score(0);
            User user = new User();
            Dialog dialog = new Dialog();

            game.Start();
            game.QuestionCicle(score, user, dialog, QuestionList);
            game.Finish();
        }
                
    }
}
