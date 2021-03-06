﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode
{
    public class Program
    {
        #region methods

        #region private methods

        private static void Main()
        {
            Solution2015();
            Solution2020();

            Console.ReadKey();
        }

        private static void Solution2015()
        {
            Console.WriteLine("Advent Of Code 2015 Solutions");

            string inputDay1 = File.ReadAllText("resources\\2015\\inputDay1");
            List<string> inputDay2 = File.ReadAllLines("resources\\2015\\inputDay2").ToList();
            string inputDay3 = File.ReadAllText("resources\\2015\\inputDay3");
            string inputDay4 = "yzbqklnj";
            List<string> inputDay5 = File.ReadAllLines("resources\\2015\\inputDay5").ToList();
            List<string> inputDay6 = File.ReadAllLines("resources\\2015\\inputDay6").ToList();
            List<string> inputDay7 = File.ReadAllLines("resources\\2015\\inputDay7").ToList();

            Console.WriteLine($"Day 1 Part 1: {AdventOfCode2015.Day1Part1(inputDay1)}");
            Console.WriteLine($"Day 1 Part 2: {AdventOfCode2015.Day1Part2(inputDay1)}");
            Console.WriteLine($"Day 2 Part 1: {AdventOfCode2015.Day2Part1(inputDay2)}");
            Console.WriteLine($"Day 2 Part 2: {AdventOfCode2015.Day2Part2(inputDay2)}");
            Console.WriteLine($"Day 3 Part 1: {AdventOfCode2015.Day3Part1(inputDay3)}");
            Console.WriteLine($"Day 3 Part 2: {AdventOfCode2015.Day3Part2(inputDay3)}");
            //Console.WriteLine($"Day 4 Part 1: {AdventOfCode2015.Day4(inputDay4, "00-00-0")}");   // Works, but slow, so disabled
            //Console.WriteLine($"Day 4 Part 2: {AdventOfCode2015.Day4(inputDay4, "00-00-00")}");  // Works, but slow, so disabled
            Console.WriteLine($"Day 5 Part 1: {AdventOfCode2015.Day5Part1(inputDay5)}");
            Console.WriteLine($"Day 5 Part 2: {AdventOfCode2015.Day5Part2(inputDay5)}");
            Console.WriteLine($"Day 6 Part 1: {AdventOfCode2015.Day6Part1(inputDay6)}");
            Console.WriteLine($"Day 6 Part 2: {AdventOfCode2015.Day6Part2(inputDay6)}");
            //Console.WriteLine($"Day 7 Part 1: {AdventOfCode2015.Day7Part1(inputDay7)["a"]}");
        }

        private static void Solution2020()
        {
            List<int> inputDay1 = File.ReadAllLines("resources\\2020\\inputDay1").Select(int.Parse).ToList();
            List<string> inputDay2 = File.ReadAllLines("resources\\2020\\inputDay2").ToList();
            List<string> inputDay3 = File.ReadAllLines("resources\\2020\\inputDay3").ToList();
            List<(int increaseX, int increaseY)> inputParameterDay3Part1 = new List<(int increaseX, int increaseY)> {(1, 3)};

            List<(int increaseX, int increaseY)> inputParameterDay3Part2 = new List<(int increaseX, int increaseY)>
            {
                (1, 1),
                (1, 3),
                (1, 5),
                (1, 7),
                (2, 1)
            };

            List<string> inputDay4 = File.ReadAllLines("resources\\2020\\inputDay4").ToList();
            List<string> inputDay5 = File.ReadAllLines("resources\\2020\\inputDay5").ToList();

            Console.WriteLine("Advent Of Code 2020 Solutions");
            Console.WriteLine($"Day 1 Part 1: {AdventOfCode2020.Day1Part1(inputDay1)}");
            Console.WriteLine($"Day 1 Part 2: {AdventOfCode2020.Day1Part2(inputDay1)}");
            Console.WriteLine($"Day 2 Part 1: {AdventOfCode2020.Day2Part1(inputDay2)}");
            Console.WriteLine($"Day 2 Part 2: {AdventOfCode2020.Day2Part2(inputDay2)}");
            Console.WriteLine($"Day 3 Part 1: {AdventOfCode2020.Day3(inputDay3, inputParameterDay3Part1)}");
            Console.WriteLine($"Day 3 Part 2: {AdventOfCode2020.Day3(inputDay3, inputParameterDay3Part2)}");
            Console.WriteLine($"Day 4 Part 1: {AdventOfCode2020.Day4Part1(inputDay4)}");
            Console.WriteLine($"Day 4 Part 2: {AdventOfCode2020.Day4Part2(inputDay4)}");
            Console.WriteLine($"Day 5 Part 1: {AdventOfCode2020.Day5Part1(inputDay5)}");
            Console.WriteLine($"Day 5 Part 2: {AdventOfCode2020.Day5Part2(inputDay5)}");
        }

        #endregion

        #endregion
    }
}