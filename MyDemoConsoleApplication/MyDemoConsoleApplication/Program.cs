
// See https://aka.ms/new-console-template for more information

using System;

namespace HelloWorld
{
    class MyClass
    {
        //--.
        public static void MyMethod()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
        }
    }


    public class Program
    {
        //--.
        public static void Main()
        {
            //--.
            MyClass.MyMethod();
            //--.
            Console.WriteLine("Hello, World!");
        }
    }
}