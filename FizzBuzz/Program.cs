using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Initiateing FizzBuzz");

            int fizzs = 0;
            int buzzs = 0;
            int fizzbuzzs = 0;
            bool fizz;
            bool buzz;

            for (int i=1;i<=1000;i++)
            {
                fizz = i%3 == 0;
                buzz = i%5 == 0;
                fizzs += fizz&&!buzz?1:0;
                buzzs += !fizz&&buzz?1:0;
                fizzbuzzs += fizz&&buzz?1:0;
                System.Console.Write((!fizz&&!buzz?(i+""):(fizz!=buzz?(fizz?"Fizz":"Buzz"):"FizzBuzz"))+"\t");
                if(i%15 == 0) System.Console.WriteLine();
            }

            System.Console.WriteLine("\nFizz: "/*267*/ + fizzs + "\nBuzz: "/*134*/ + buzzs + "\nFizzBuzz: "/*66*/ + fizzbuzzs);
        }
    }
}
