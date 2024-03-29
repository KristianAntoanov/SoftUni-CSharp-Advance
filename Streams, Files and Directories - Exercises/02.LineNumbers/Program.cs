﻿namespace LineNumbers
{
    using System;
    using System.Text;

    public class LineNumbers
    {
        static void Main()
        {
            string inputFilePath = @"../../../text.txt";
            string outputFilePath = @"../../../output.txt";

            ProcessLines(inputFilePath, outputFilePath);
        }

        public static void ProcessLines(string inputFilePath, string outputFilePath)
        {
            StringBuilder sb = new StringBuilder();

            string[] lines = File.ReadAllLines(inputFilePath);

            for (int i = 0; i < lines.Length; i++)
            {
                int letterCount = lines[i].Count(x => char.IsLetter(x));
                int symbolsCount = lines[i].Count(x => char.IsPunctuation(x));
                sb.AppendLine($"Line {i + 1}: {lines[i]} ({letterCount})({symbolsCount})");
            }
            File.WriteAllText(outputFilePath, sb.ToString());
        }
    }
}
