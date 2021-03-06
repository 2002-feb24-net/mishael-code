﻿using RPS.lib;
using System;

namespace RPS.app
{
    class Program
    {
        static void Main(string[] args)
        {
            RPSisors game = new RPSisors(new StratHard());

            while (ask("Do you want to play a round? "))
            {
                game.play();
                System.Console.WriteLine(game.score());
            }
        }

        static bool ask(string question)
        {
            System.Console.WriteLine(question);
            string response;
            do response = Console.ReadLine(); while (!(response == "yes" || response == "y" || response == "no" || response == "n"));
            return response == "yes" || response == "y";
        }
    }
}
