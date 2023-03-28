using Day_13_GenericProblems;
using System.Reflection.Metadata;
using System;

namespace GenericProblems
{
    class Program
    {
        public static void Main()
        {
            //int[] intArray = { 1, 2, 3, 4 };
            ////double[] doubleArray = { 1.01, 2.02, 3.03, 4.04 };
            ////char[] charArray = { 'H', 'A', 'P', 'P', 'Y'};
            ////Program.toPrint<int>(intArray);
            ////Program.toPrint<double>(doubleArray);
            ////Program.toPrint<char>(charArray);

            //Console.WriteLine("Please enter the First number");

            //int num1 = Convert.ToInt32(Console.ReadLine());


            //Console.WriteLine("Please enter the Second number");

            //int num2 = Convert.ToInt32(Console.ReadLine());


            //Console.WriteLine("Please enter the Third number");

            //int num3 = Convert.ToInt32(Console.ReadLine());
            //**************************************************************************
            //Usecase 1.1
            //int num1 = 4.3;
            //int num2 = 9.6;
            //int num3 = 1.9;
            //FindMaximum obj = new FindMaximum();
            //int value = FindMaximum.FindingMaximum(num1, num2, num3);
            //Console.WriteLine("{0} is the Greater Value", value);
            //******************************************************************************
            //Use case2;-
            //double num1 = 0.8;
            //double num2 = 0.4;
            //double num3 = 1.9;
            //FindFloatMaximum num = new FindFloatMaximum();
            //double value = FindFloatMaximum.FindingFloatMaximum(num1, num2, num3);
            //Console.WriteLine("{0} is the Greater Value", value);
            ////******************************************************************
            //Usecase3:-
            //string word1 = "Peach";
            //string word2 = "Apple";
            //string word3 = "Banana";
            //FindStringMaximum num = new FindStringMaximum();
            //string value = FindStringMaximum.FindingStringMaximum(word1, word2, word3);
            //Console.WriteLine("{0} is the Greater Value", value);
            //**********************************************************************
            //Usecase4:-
            //Console.WriteLine("Please enter the First number");
            //var num1 = Console.ReadLine();
            //Console.WriteLine("Please enter the Second number");
            //var num2 = Console.ReadLine();
            //Console.WriteLine("Please enter the Third number");
            //var num3 = Console.ReadLine();

            ////Refactor-1:-

            //var value = FindMaxUsingGenerics.FindingMaximum( num1,  num2, num3 );
            //Console.WriteLine("{0} is the greater value : " + value);

            //Refactor-2:-

            int num1 = 10, num2 = 20, num3 = 15;
            double dub1 = 1.9, dub2 = 6.3, dub3 = 3.4;
            string char1 = "Apple", char2 = "Banana", char3 = "Peach";

            RefactorUsingGenerics<int> obj = new RefactorUsingGenerics<int>(num1, num2, num3);
            int MaxInt = obj.FindingMaximum<int>();
            Console.WriteLine("Maximum value in integer is: " + MaxInt);

            Console.WriteLine("****************************************");

            RefactorUsingGenerics<double> obj1 = new RefactorUsingGenerics<double>();
            double MaxDouble = obj1.FindingMaximum<double>(dub1, dub2, dub3);
            Console.WriteLine("Maximum value in double is: " + MaxDouble);

            Console.WriteLine("****************************************");

            RefactorUsingGenerics<string> obj2 = new RefactorUsingGenerics<string>();
            string MaxString = obj2.FindingMaximum<string>(char1, char2, char3);
            Console.WriteLine("Maximum value in string is: " + MaxString);

            Console.WriteLine("****************************************");
        }
    }
}
