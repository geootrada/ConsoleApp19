using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberAttempts = 3;
            string password = "123456";
            string secretMessage = "Карта сокровищ";
            string userInput;

            for (int i = 0; i < numberAttempts; i++)
            {
                Console.WriteLine("Введите пароль: ");
                userInput = Console.ReadLine();

                if (userInput == password)
                {
                    Console.WriteLine(secretMessage);
                    break;
                }
                else
                {
                    Console.WriteLine("Вы ввели неверный пароль.\nУ вас осталось попыток "+ (numberAttempts - (i+1)));
                }
            }
        }
    }
}
