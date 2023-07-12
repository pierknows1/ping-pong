using System;
using Palindrome.Models;

namespace Palindrome
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(@" 
 ███████████       ████ ███              █████                                      
░░███░░░░░███     ░░███░░░              ░░███                                       
 ░███    ░████████ ░███████████████   ███████████████ ██████ █████████████   ██████ 
 ░█████████░░░░░███░██░░██░░███░░███ ███░░██░░███░░█████░░██░░███░░███░░███ ███░░███
 ░███░░░░░░ ███████░███░███░███ ░███░███ ░███░███ ░░░███ ░███░███ ░███ ░███░███████ 
 ░███      ███░░███░███░███░███ ░███░███ ░███░███   ░███ ░███░███ ░███ ░███░███░░░  
 █████    ░░███████████████████ ████░░████████████  ░░██████ █████░███ ████░░██████ 
░░░░░      ░░░░░░░░░░░░░░░░░░░ ░░░░░ ░░░░░░░░░░░░    ░░░░░░ ░░░░░ ░░░ ░░░░░ ░░░░░░  
");
            Console.WriteLine("This app will do the ol' switcheroo to whatever word you enter and will reverse it!");
            Console.WriteLine("Using NO Reverse method");
            Console.WriteLine("Enter a Word below:");
            string UserNum = Console.ReadLine();
            ReverseWord TestReverseWord = new ReverseWord();
            string result = TestReverseWord.TestReverseWord(UserNum);
            Console.WriteLine(" ");
            Console.WriteLine(result);
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            // Reverse method
            Console.WriteLine("Using a reverse method connected to an array");
            Console.WriteLine("Enter a Word below:");
            string word = Console.ReadLine();
            ReverseWordTest TestReverseWord2 = new ReverseWordTest();
            char[] result2 = TestReverseWord2.TestReverse(word);
            Console.WriteLine(" ");
            Console.WriteLine(result2);

        }
    }   
}
