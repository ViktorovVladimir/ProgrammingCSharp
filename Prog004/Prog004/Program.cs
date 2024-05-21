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

            try
            {
                int k = i / j;
                Console.WriteLine("An exception was throw: {0} by {1} is {2}", i, j, k);
            }
            catch(Exception e)
            {
                Console.WriteLine("An exception as throw: {0}", e.Message);
            }
        }
    }
}