using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace AdventOfCode
{
    public class AdventOfCode2020
    {
        #region methods

        #region public methods

        public static double Day1Part1(List<int> puzzleInput)
        {
            for (int index1 = 0; index1 < puzzleInput.Count; index1++)
            {
                int i = puzzleInput[index1];
                List<int> subList1 = puzzleInput.GetRange(index1 + 1, puzzleInput.Count - index1 - 1);

                foreach (int b in subList1.Where(b => b + i == 2020))
                    return b * i;
            }

            throw new ArgumentException("Input List doesn't contain any valid input.");
        }
        public static double Day1Part2(List<int> puzzleInput)
        {
            for (int index1 = 0; index1 < puzzleInput.Count; index1++)
            {
                int i = puzzleInput[index1];
                List<int> subList1 = puzzleInput.GetRange(index1 + 1, puzzleInput.Count - index1 - 1);

                for (int index2 = 0; index2 < subList1.Count; index2++)
                {
                    int j = subList1[index2];
                    List<int> subList2 = subList1.GetRange(index2 + 1, subList1.Count - index2 - 1);

                    foreach (int b in subList2.Where(b => b + j + i == 2020))
                        return b * i * j;
                }
            }

            throw new ArgumentException("Input List doesn't contain any valid input.");
        }

        public static int Day2Part1(List<string> input)
        {
            int result = 0;
            string regex = "(\\d+)(-)(\\d+)(.)(\\S)(..)(\\w+)";

            foreach (string s in input)
            {
                Match matches = Regex.Match(s, regex);
                int countFrom = int.Parse(matches.Groups[1].Value);
                int countTo = int.Parse(matches.Groups[3].Value);
                char character = matches.Groups[5].Value[0];
                string password = matches.Groups[7].Value;

                int characterCount = password.Count(x => x == character);

                if (characterCount >= countFrom && characterCount <= countTo)
                    result++;
            }

            return result;
        }

        public static int Day2Part2(List<string> input)
        {
            int result = 0;
            string regex = "(\\d+)(-)(\\d+)(.)(\\S)(..)(\\w+)";

            foreach (string s in input)
            {
                Match matches = Regex.Match(s, regex);
                int position1 = int.Parse(matches.Groups[1].Value);
                int position2 = int.Parse(matches.Groups[3].Value);
                char character = matches.Groups[5].Value[0];
                string password = matches.Groups[7].Value;

                try
                {
                    bool firstFind = password[position1 - 1] == character;
                    bool secondFind = password[position2 - 1] == character;

                    if (firstFind != secondFind)
                        result++;
                }
                catch
                {
                    // ignored
                }
            }

            return result;
        }

        public static long Day3(List<string> input, List<(int increaseX, int increaseY)> increaseParameter)
        {
            int maxY = input.Max(s => s.Length);

            long result = 1;

            foreach ((int increaseX, int increaseY) in increaseParameter)
            {
                int currentY = 0 - increaseY;
                int treeCount = 0;

                for (int currentX = 0; currentX < input.Count; currentX += increaseX)
                {
                    string s = input[currentX];
                    currentY += increaseY;

                    if (currentY >= maxY)
                        currentY -= maxY;

                    if (s[currentY] == '#')
                        treeCount++;
                }

                result *= treeCount;
            }

            return result;
        }

        #endregion

        #endregion
    }
}