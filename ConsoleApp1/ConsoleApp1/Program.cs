using System;
using System.Diagnostics;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! Udrescu CatalinS");
            string myString = "Hello";
            string myNextStrinh = "Worlfd";

            string a = "a";
            string b = "b";
            string c = "c";

            string random = "B";

            int rezultleft = string.Compare(a, b);
            int rezultlright = string.Compare(c, b);
            int rezultequal = string.Compare(random, b, false);


            //Concat

            myString = myString + "world"; // + concateneaza
            string helloWorld = myString + " " + myNextStrinh;

            Stopwatch stopWatch = Stopwatch.StartNew();
         
            for (int i = 0; i < 100000; i++)
            {
                myString += i; //  myString = myString + 1
            }

            stopWatch.Stop();
            Console.WriteLine(stopWatch.Elapsed);

            Stopwatch stopWatch1 = Stopwatch.StartNew();

            StringBuilder builder = new StringBuilder();
            builder.Append(myString);
            for (int i = 0; i < 100000; i++)
            {
                builder.Append(i);
            }

            stopWatch1.Stop();
            Console.WriteLine(stopWatch1.Elapsed);



        }
    }
}
