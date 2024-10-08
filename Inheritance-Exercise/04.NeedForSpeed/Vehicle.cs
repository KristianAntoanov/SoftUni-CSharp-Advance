﻿using System;
namespace _04.NeedForSpeed
{
    public class Vehicle
    {
        private const double DefaultFuelConsumption = 1.25;

        public Vehicle(int horsePower, double fuel)
        {
            Fuel = fuel;
            HorsePower = horsePower;
        }

        public virtual double FuelConsumption => DefaultFuelConsumption;
        public double Fuel { get; set; }
        public int HorsePower { get; set; }

        public virtual void Drive(double kilometers) => Fuel -= kilometers* FuelConsumption;
    }
}

