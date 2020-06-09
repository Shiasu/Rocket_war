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
            string userInput = null;
            while (userInput != "" && userInput != "start")
            {
                Console.WriteLine("Введите Help чтобы узнать возможные команды.");
                Console.WriteLine("Нажмите Enter или введите Start для начала игры.");
                Console.WriteLine("Введите Exit чтобы выйти из игры.");
                userInput = Console.ReadLine().ToLower();
                if (userInput == "help") UserCommands.Help();
            }
            Console.Clear();

            //Основная часть
            
            var StrategicMissiles = new List<StrategicMissile>();
            var TacticalMissiles = new List<TacticalMissile>();

            while (userInput != "exit")
            {
            }

            UserCommands.Exit();

            TacticalMissile misA = new TacticalMissile(true);
            misA.RocketBuilder(100);
            misA.RocketLauncher(15);
            misA.RadiusCalculator(14);
            misA.DamageCalculator(15);

            StrategicMissile misB = new StrategicMissile(false);
            misB.RocketBuilder(12);
            misB.RocketLauncher(10);
            misB.RadiusCalculator(14);
            misB.DamageCalculator(15);

            
        }
    }
}
