using System;

namespace String_Manipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            String str1, str2, str3, str4, str5;
            Console.WriteLine("Enter the string");
            str1 = Console.ReadLine();
            str2 = str1.Replace(" ", "_");
            Console.WriteLine("The srting after replacing:" + str2);
            str3 = str1.TrimStart();
            Console.WriteLine("The srting after removing leading space:" + str3);
            str4 = str1.TrimEnd(' ');
            Console.WriteLine("The srting after removing Trailing space:" + str4);
            str5 = str1.Replace("a","A");
            Console.WriteLine("The srting after converting a to A :" + str5);
            Console.ReadLine();


        }
    }
}
