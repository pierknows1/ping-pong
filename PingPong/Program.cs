using System;
using PingPong.Models;

namespace PingPong
{

    class Program
    {
        static void Main()
        {
            Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
            Console.WriteLine("Welcome to the Ping Pong app!");
            Console.WriteLine("We'll return a list of numbers and messages based off your inputted number.");
            Console.WriteLine("Enter a number below:");
            string UserNum = Console.ReadLine();

            NumTransform OverallOutput = new NumTransform(int.Parse(UserNum));

            // string numbers = OverallOutput.NumLoop(int.Parse(UserNum));
            string result = OverallOutput.Output(int.Parse(UserNum));
            Console.WriteLine(result);
        }
    }
}