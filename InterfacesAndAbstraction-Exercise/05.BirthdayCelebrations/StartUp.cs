﻿namespace MilitaryElite
{
    using System;
    using BirthdayCelebrations;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            IEngine engine = new Engine();
            engine.Run();
        }
    }
}