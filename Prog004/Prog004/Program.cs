using System;

namespace DivideItNameSpace
{
    public class DivideIt
    {
        //--.
        public static void Main()
        {
            do
            {
                try
                {
                    //--.
                    Console.WriteLine("Please enter FIRST value: ");
                    string temp = Console.ReadLine();
                    int i = Int32.Parse(temp);
                    Console.WriteLine("Please enter SECOND value: ");
                    temp = Console.ReadLine();
                    int j = Int32.Parse(temp);

                    int k = i / j;
                    Console.WriteLine("{0} by {1} is {2}", i, j, k);

                    break;
                }
                catch (FormatException e)
                {
                    Console.WriteLine("An format exception was thrown: {0}", e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine("An exception as throw: {0}", e.Message);
                }

            }while(true);
        }
    }
}