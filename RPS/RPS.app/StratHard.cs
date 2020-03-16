using RPS.lib;
using System;

namespace RPS.app
{
    class StratHard : Strategy
    {
        private static Random r = new Random();

        int Strategy.Play(int playerChoice)
        {
            bool win = r.Next(2) == 0;
            if(win)
            {
                switch (playerChoice)
                {
                    case 1: return 2;
                    case 2: return 3;
                    case 3: return 1;
                    default: break;
                }
            }
            
            bool pWin = r.Next(2) == 0;

            switch (playerChoice)
            {
                case 1: return pWin?3:1;
                case 2: return pWin?1:2;
                case 3: return pWin?2:3;
                default: return 0;
            }
        }
    }
}
