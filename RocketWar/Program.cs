using System;
using System.Collections.Generic;

namespace RocketWar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вступительная часть
            Console.WriteLine("Добро пожаловать в не очень увлекательную игру Rocket War. " +
                "Вам предстоит улучшать базу, строить ракеты и самое главное - мешать врагу делать тоже самое!");
            Console.WriteLine();
            string userInput = null;
            while (userInput != "" && userInput != "start")
            {
                Console.WriteLine("Введите Help чтобы узнать возможные команды.");
                Console.WriteLine("Нажмите Enter или введите Start для начала игры.");
                Console.WriteLine("Введите Exit чтобы выйти из игры.");
                Console.WriteLine();
                userInput = Console.ReadLine().ToLower();
                switch (userInput)
                {
                    case "start":
                        break;
                    case "help":
                        UserCommands.Help();
                        continue;
                    case "exit":
                        UserCommands.Exit();
                        break;
                    default:
                        Console.WriteLine("Введена неверная комманада, выберите другую.");
                        continue;
                }
            }
            Console.Clear();

            //Основная часть
            
            var StrategicMissiles = new List<StrategicMissile>();
            var TacticalMissiles = new List<TacticalMissile>();

            while (userInput != "exit")
            {
                userInput = Console.ReadLine().ToLower();
                switch(userInput)
                {
                    case "help":
                        UserCommands.Help();
                        continue;
                    case "exit":
                        UserCommands.Exit();
                        break;
                    default:
                        Console.WriteLine("Введена неверная комманада, выберите другую.");
                        continue;
                }
            }

            UserCommands.Exit();  
        }
    }
}
