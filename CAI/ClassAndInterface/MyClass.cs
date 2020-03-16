using System;
using System.Collections.Generic;
using System.Text;

namespace ClassAndInterface
{
    class MyClass : Interface1
    {
        public int myInt;
        public string myString = "";
        private int myInt2;
        private string myString2 = "";

        public static string mystring3 = "static string";

        public MyClass(int i, string s)
        {
            myInt2 = i;
            myString = s;
        }

        public string getString() { return myString; }

        public void PrintPrivateFields()
        {
            Console.WriteLine($"int = {myInt2} string = {myString2}");
        }

        public void refMethod(ref int x)
        {
            x += 100;
            Console.WriteLine(x);
        }

        public void valueMethod(int x)
        {
            x += 100;
            Console.WriteLine(x);
        }

        public void outMethod(int number, out int outVar)
        {
            Console.WriteLine(number);
            outVar = number + 333;
        }

        public string parrameterArryMthd(string x, params int[] nums)
        {
            for (int i = 0; i < nums.Length; i++) x += " " + nums[i];
            return x;
        }

        public void returnDouble(int x)
        {
            x += x;
            Console.WriteLine(x);
        }
    }
}
