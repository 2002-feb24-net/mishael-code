using RPS.lib;
using System;

namespace RPS.app
{
    class StratMed : Strategy
    {
        private static Random r = new Random();

        int Strategy.Play(int playerChoice)
        {
            return r.Next(1, 4);
        }
    }
}
