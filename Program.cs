using System;

namespace sattestfinal
{
    class Program
    {
        static void Main(string[] args)
        {
            //ข้อ3
            string number;
            do
            {
                number = Console.ReadLine();
            }
            while (number == "End");

            string text = Console.ReadLine();
            int min, max;
            int sum;
            if (text == "FindMax")
            {
                Console.WriteLine("{0}", Math.max(text));
            }
            else if (text == "FindMin")
            {

            }
            else if (text == "FindMead")
            {
                Console.WriteLine("{0}", sum / number );
            }
            Console.ReadLine();



        }
    }
}
