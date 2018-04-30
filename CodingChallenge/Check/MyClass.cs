using System;
namespace Check
{
    public class Test
    {
        public void IsPalindrome(char[] arr) {
            string first = new string(arr);
            Array.Reverse(arr);
            string second = new string(arr);

            first = first.ToLower().Replace(" ", "");
            second = second.ToLower().Replace(" ", "");

            if(first.Equals(second))
                Console.WriteLine("Success");
            else
                Console.WriteLine("Failure");
    }

    }
}
