﻿using System;
namespace Animals
{
    public class Tomcat : Cat
    {
        private const string Sound = "MEOW";
        private const string TomcatGender = "Female";
        public Tomcat(string name, int age) : base(name, age, TomcatGender)
        {

        }
        public override string ProduceSound() => Sound;
    }
}

