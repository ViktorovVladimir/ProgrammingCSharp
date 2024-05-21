using System;

namespace DivideItNameSpace
{
    public class DivideIt
    {
        //--.
        public static void Main()
        {
            //--.
            Console.WriteLine("Please enter FIRST value: ");
            string temp = Console.ReadLine();
            int i = Int32.Parse(temp);
            Console.WriteLine("Please enter SECOND value: ");
            temp = Console.ReadLine();
            int j = Int32.Parse(temp);
        }
    }
}