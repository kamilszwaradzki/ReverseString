using System;

namespace ReverseString
{
    class Program
    {
        public static string Reverse( string s )
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse( charArray );
            return new string( charArray );
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Reverse("Hello World!"));
        }
    }
}
