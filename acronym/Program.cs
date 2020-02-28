using System;

namespace acronym
{
    class Program
    {
        static void Main(string[] args)
        {
            string phrase = GetPhrase();
            string acronym = FindAcronym(phrase);
            System.Console.WriteLine("\n"+ phrase + " (" + acronym +")\n");
        }

        static string GetPhrase()
        {
            string output;

            System.Console.Write("input a phrase: ");
            output = Console.ReadLine();

            return output;
        }

        static string FindAcronym(string phrase)
        {
            string output = "";
            string[] words = phrase.Split(" ");
            
            for(int i=0;i<words.Length;i++) output+= words[i][0];

            output = output.ToUpper();

            return output;
        }
    }
}
