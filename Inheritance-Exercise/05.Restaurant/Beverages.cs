﻿using System;
namespace _05.Restaurant
{
	public abstract class Beverage : Product
	{
        public Beverage(string name, decimal price, double milliliters) : base(name, price)
        {
            Milliliters = milliliters;
        }

        public double Milliliters { get; set; }
	}
}

