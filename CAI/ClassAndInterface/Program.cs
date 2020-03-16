using System;

namespace ClassAndInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            MyClass clas = new MyClass(5,"bnanana");
            Console.WriteLine(clas.myInt);

            MyClass clas2 = new MyClass(3,"twotooto");
            Console.WriteLine(clas2.myString);

            Console.WriteLine(MyClass.mystring3);

            int y = 2;
            Console.WriteLine(y);
            clas.refMethod(ref y);
            Console.WriteLine(y);

            int z = 2;
            Console.WriteLine(z);
            clas.valueMethod(z);
            Console.WriteLine(z);

            int a = 2;
            int b = 7;
            Console.WriteLine($"{a},{b}");
            clas.outMethod(a,out b);
            Console.WriteLine($"{a},{b}");

            Console.WriteLine(clas.parrameterArryMthd("stuff :",3,5,7,7,5,3,4,7));
        }
    }
}
