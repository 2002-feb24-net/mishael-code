using RPS.lib;
using System;

namespace RPS.app
{
    class StratEazy : Strategy
    {
        private static Random r = new Random();

        int Strategy.Play(int playerChoice)
        {
            bool win = r.Next(2) == 0;
            if (win)
            {
                switch (playerChoice)
                {
                    case 1: return 3;
                    case 2: return 1;
                    case 3: return 2;
                    default: break;
                }
            }

            bool cWin = r.Next(2) == 0;

            switch (playerChoice)
            {
                case 1: return cWin ? 2 : 1;
                case 2: return cWin ? 3 : 2;
                case 3: return cWin ? 1 : 3;
                default: return 0;
            }
        }
    }
}
