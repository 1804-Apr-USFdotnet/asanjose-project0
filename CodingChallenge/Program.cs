using System;
using Check;
namespace CodingChallenge
{
    class MainClass 
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Type in a Palindrome");
            Test test = new Test();
            string result = Console.ReadLine();
            char[] arr = result.ToCharArray();
            test.IsPalindrome(arr);

        
     }
    }
}
