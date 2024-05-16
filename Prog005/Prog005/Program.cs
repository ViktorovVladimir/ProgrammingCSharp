using System;
using System.Xml.Linq;

namespace HelloWorld
{


    /*
    class MyClass
    {
        //--.
        public static void MyMethod()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
        }
    }
    */

    //-- Программа расчёта площади равностороннего треугольника, периметр которого известен

    public class Program
    {
        //--.
        public static void Main()
        {

            //string sPerimetr, sStorona;
            //double rPerimetr, rStorona;
            //double rS;

            //--.
            Console.WriteLine("Please enter Perimetr value");
            //sPerimetr = Console.ReadLine();
            double rPerimetr = Double.Parse( Console.ReadLine() );
            Console.WriteLine("Please enter Storona value");
            //sStorona = Console.ReadLine();
            double rStorona = Double.Parse( Console.ReadLine() );

            //--.
            double rS = Math.Sqrt(rPerimetr * (rPerimetr - rStorona) * (rPerimetr - rStorona) * (rPerimetr - rStorona));

            Console.WriteLine("\tSTORONA \t\tPLOSHAD");
            Console.WriteLine("\t  {0:F2} \t\t {1:F2}", rStorona, rS);
        }
    }
}