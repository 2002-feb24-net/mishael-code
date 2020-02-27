using System;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("enter list of ints:");
            string input = Console.ReadLine();
            int[] inArray = InputToArray(input);
            PrintArray(inArray);
            while (inArray.Length > 0)
            {
                char option = Ask();
                inArray = Preform(option, inArray);
                PrintArray(inArray);
            }
        }

        static int[] InputToArray(string input)
        {
            string[] array = input.Split(" ");
            int[] output = new int[array.Length];
            for (int i = 0; i < array.Length; i++) output[i] = int.Parse(array[i]);
            return output;
        }

        static void PrintArray(int[] output)
        {
            string printing = "";
            for (int i = 0; i < output.Length; i++) printing+= output[i] + ( i == output.Length-1 ? "" : " ");
            System.Console.WriteLine(printing);
        }

        static char Ask()
        {
            System.Console.WriteLine("which opperation would you like to preform:\nA.Shift left\nB.Shift right\nC.Double\nD.Eaqualise\nQ.Quit");
            char selection = Console.ReadLine()[0];
            return selection;
        }

        static int[] Preform(char selection, int[] x)
        {
            int temp = 0;
            switch (selection)
            {
                case 'a': case 'A':
                for (int i = 1; i < x.Length; i++)
                {
                    temp = x[i];
                    x[i] = x[i-1];
                    x[i-1] = temp;
                }
                break;
                case 'b': case 'B':
                for (int i = x.Length-2; i >= 0; i--)
                {
                    temp = x[i];
                    x[i] = x[i+1];
                    x[i+1] = temp;
                }
                break;
                case 'c': case 'C':
                for (int i=0;i<x.Length;i++) x[i]*=2;
                break;
                case 'd': case 'D':
                x = Equalise(x);
                break;
                default:
                x = new int[0];
                break;
            }
            return x;
        }
        
        static int[] Equalise(int[] x)
        {
            int[] y = x;

            for (int i = 1; i < x.Length-1; i++) y[i] = (x[i-1]+x[i+1])/2;

            if(x.Length > 1 && x.Length%2==1)
            {
                y[0] = (x[1]+x[x.Length-1])/2;
                y[x.Length-1] = (x[0]+x[x.Length-2])/2;
            }
            
            return y;
        }
    }
}
