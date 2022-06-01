using System;

namespace methodszEXCERSIZE100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("What is your name?");
            //var personName = Console.ReadLine();

            //Console.WriteLine("whats your favorite color");
            //var favClr = Console.ReadLine();

            ////          <name>
            ////
            ////          <color>
            ////

            //Console.WriteLine(personName + "favorite sport  is" + favClr);




            //MadLib();
            Console.WriteLine(Add(6, 7));
            Console.WriteLine(AddParams(6, 7));
            Console.WriteLine(Sub(6, 90));
        }
        public static int AddParams(params int[] nums)
        {
            var sum = 0;

            foreach (var num in nums)
            {
                sum += num;
            }

            return sum;

        }

        public static int Add(int num1, int num2)

        {

            return num1 + num2;


        }

        public static int Sub(int num1, int num2)
        {
            return num1 - num2;


        }
    }
}
