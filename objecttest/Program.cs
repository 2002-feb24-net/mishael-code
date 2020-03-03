using System;

namespace objecttest
{
    class Program
    {
        static void Main(string[] args)
        {
            int candy = GetStock("candy bar");
            
            product candybar = new product();
            candybar.SetDefaultValues();
            candybar.SetValues("banana",candy,11.11);

            int bananas = GetStock("banana");

            product banana = new product();
            banana.SetValues("toast",bananas,5);

            System.Console.WriteLine(candybar+"\n"+banana);
        }

        static int GetStock(string name)
        {
            System.Console.Write("Enter quantity of product \""+name+"\": ");
            string output = "no";
            do output = Console.ReadLine(); while (!IsPosInt(output));
            return int.Parse(output);
        }

        static bool IsPosInt(string x)
        {
            if(x[0]=='-')
            {
                System.Console.WriteLine("invalid: negitive");
                return false;
            }
            bool valid = true;
            for (int i=0;i<x.Length&&valid;i++) valid = x[i]<='9' && x[i]>='0';
            if(!valid) System.Console.WriteLine("invalid: not a number");
            return valid;
        }
    }
}
