﻿namespace MyApp // Note: actual namespace depends on the project name.
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            HashSet<string> usernames = new HashSet<string>();
            for (int i = 0; i < n; i++)
            {
                usernames.Add(Console.ReadLine());
            }
            foreach (var item in usernames)
            {
                Console.WriteLine(item);
            }
        }
    }
}
