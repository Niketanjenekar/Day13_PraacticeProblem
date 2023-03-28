using Day_13_GenericProblems;

namespace GenericProblems
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, 4 };
            //double[] doubleArray = { 1.01, 2.02, 3.03, 4.04 };
            //char[] charArray = { 'H', 'A', 'P', 'P', 'Y'};
            //Program.toPrint<int>(intArray);
            //Program.toPrint<double>(doubleArray);
            //Program.toPrint<char>(charArray);

            Console.WriteLine("Please enter the First number");

            int num1 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Please enter the Second number");

            int num2 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Please enter the Third number");

            int num3 = Convert.ToInt32(Console.ReadLine());
            FindMaximum obj = new FindMaximum();
            int value = FindMaximum.FindingMaximum(num1, num2, num3);
            Console.WriteLine("{0} is the Greater Value", value);
        }
    }
}
