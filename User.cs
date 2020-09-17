using System;
using System.Collections.Generic;
using System.Text;

namespace Homework6
{
    class User
    {
        public string UserName;
        public int InputNumber;

        public string UserInputName(string text)
        {
            Console.WriteLine(text);
            string UserName = Console.ReadLine();
            return UserName;
        }
        public int UserInputNumber(string text)
        {
            Console.WriteLine(text);
            string number = Console.ReadLine();
            try
            {
                int InputNumber = int.Parse(number);
                if (InputNumber < 5 && InputNumber > 0)
                {
                    return InputNumber;
                }
                else
                {
                    Console.WriteLine("Можно вводить только числа 1, 2, 3, 4");
                    return UserInputNumber(text);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Можно вводить только числа 1, 2, 3, 4");
                return UserInputNumber(text);
            }
        }
        public string UserInputSign()
            {
                string InputSign = Console.ReadLine();
            if (InputSign == "+" || InputSign == "-")
            {
                return InputSign;
            }
            else 
            {
                Console.WriteLine("Можно ввести либо +, либо -");
                return UserInputSign();
            }
            }
        
    }
}