using System;
using System.Collections.Generic;

namespace PersonList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            people.Add(new Person("Jimmy",34));
            people.Add(new Person("Timmy",52));
            people.Add(new Person("Billy",12));
            people.Add(new Person("Bob",7));
            people.Add(new Person("Ross",95));
            people.Add(new Person("Jimmy",34));

            System.Console.WriteLine(printNames(people));
            System.Console.WriteLine(hasDuplicate(people));
            sortByName(people);
            System.Console.WriteLine(printNames(people));

        }

        static bool hasDuplicate(List<Person> x)
        {
            bool output = false;

            for (int i=1;i<x.Count;i++) for (int k=0;k<i;k++) output = output || (x[i].ToString() == x[k].ToString());

            return output;
        }

        static string printNames(List<Person> x)
        {
            string output = "";

            for (int i=0;i<x.Count;i++) output += x[i] + ", ";

            return output.Substring(0,output.Length-2);
        }

        //an insertion sort begins with the first element as a sotrted list and adds following elements
        //to that list in sorted order untill the whole list is sorted

        //a bubble sort runs through the list checking each value to see if it is in sorted order with the next
        //if it isnt the items are swaped, resulting in the greater values floating to the top which gives the sort its name

        static void sortByName(List<Person> x)
        {
            for (int i=1;i<x.Count;i++)
            {
                int k = i;
                while(k>0&&string.Compare(x[k].ToString(),x[k-1].ToString())<0)
                {
                    Person temp = x[k];
                    x[k] = x[k-1];
                    x[k-1] = temp;
                    k--;
                }
            }
        }
    }
}
