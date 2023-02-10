using System;
using static Lab_10._02._2023.Program;

namespace Lab_10._02._2023
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            Console.Write("Please enter the password: ");
            user.Password = Console.ReadLine();


        }

    }
}
