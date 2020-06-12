using System;
using System.Collections.Generic;
using System.Text;

namespace RocketWar
{
    public static class UserCommands
    {
        public static void Help()
        {
            Console.WriteLine();
            Console.WriteLine("Help - вызывает информацию о всех доступных коммандах");
            Console.WriteLine("Start - запускает начало игры");
            Console.WriteLine("Exit - закрывает игру");
            Console.WriteLine();
        }

        public static void Exit()
        {
            Environment.Exit(0);
        }
    }
}
