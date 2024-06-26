﻿using System;
using System.Text;

namespace SoftUniParking
{
	public class Car 
	{
		private string make;
		private string model;
		private int horsePower;
		private string registrationNumber;


		public Car(string make, string model, int horsePower, string registrationNumber)
		{
			Make = make;
			Model = model;
			HorsePower = horsePower;
			RegistrationNumber = registrationNumber;
		}


		public string Make
        {
			get { return make; }
			set { make = value; }
		}
		public string Model
		{
			get { return model; }
			set { model = value; }
		}
		public int HorsePower
        {
			get { return horsePower; }
			set { horsePower = value; }
		}
		public string RegistrationNumber
        {
			get { return registrationNumber; }
			set { registrationNumber = value; }
		}

        public override string ToString()
        {
			StringBuilder sb = new StringBuilder();

			sb.AppendLine($"Make: {Make}");
			sb.AppendLine($"Model: {Model}");
			sb.AppendLine($"HorsePower: {HorsePower}");
			sb.AppendLine($"RegistrationNumber: {RegistrationNumber}");

			return sb.ToString().TrimEnd();
        }
    }
}

