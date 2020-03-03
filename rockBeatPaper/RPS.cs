using System;

namespace rockBeatPaper
{
    class RPS
    {
        private int points = 0;
        private int cpoints = 0;
        private int ties = 0;
        private static Random r = new Random();

        public void play()
        {
            int player = askPlay();
            int computer = comPlay();

            if (player == computer) ties++;
            else if ((player == 1 && computer == 3) || (player == 2 && computer == 1) || (player == 3 && computer == 2)) points++;
            else cpoints++;

            System.Console.WriteLine("Player: " + intToPlay(player) + " Computer: " + intToPlay(computer));
        }

        public string score()
        {
            int rounds = points + cpoints + ties;
            return ("Rounds: " + rounds + "\tPlayer: " + points + "\tComputer: " + cpoints + "\tTies: " + ties);
        }

        private static int askPlay()
        {
            string play;
            System.Console.Write("Enter (R)ock, (P)aper, or (S)isors: ");
            do play = Console.ReadLine(); while (PlayToInt(play) == 0);
            return PlayToInt(play);
        }

        private static int comPlay()
        {
            return r.Next(1, 4);
        }

        private static string intToPlay(int x)
        {
            if (x == 1) return "Rock";
            if (x == 2) return "Paper";
            if (x == 3) return "Sisors";
            return "invalid";
        }

        private static int PlayToInt(string x)
        {
            int y = 0;
            switch (x)
            {
                case "Rock":
                case "rock":
                case "r":
                case "R":
                    y = 1;
                    break;
                case "Paper":
                case "paper":
                case "p":
                case "P":
                    y = 2;
                    break;
                case "Sisors":
                case "sisors":
                case "s":
                case "S":
                    y = 3;
                    break;
                default:
                    System.Console.WriteLine("invalid input");
                    y = 0;
                    break;
            }
            return y;
        }
    }
}