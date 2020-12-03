using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace AdventOfCode
{
    public class AdventOfCode2015
    {
        #region methods

        #region public methods

        public static int Day1Part1(string input)
        {
            int up = input.Count(x => x == '(');
            int down = input.Count(x => x == ')');

            return up - down;
        }

        public static int Day1Part2(string input)
        {
            int floor = 0;

            for (int index = 0; index < input.Length; index++)
            {
                char c = input[index];

                if (c == '(')
                    floor++;

                if (c == ')')
                    floor--;

                if (floor == -1)
                    return index + 1;
            }

            throw new ArgumentException("Santa wil never enter the basement.");
        }

        public static int Day2Part1(List<string> input1List)
        {
            List<int> result = new List<int>();

            foreach (string s in input1List)
            {
                string[] n = s.Split('x');

                int l = int.Parse(n[0]);
                int w = int.Parse(n[1]);
                int h = int.Parse(n[2]);

                List<int> totalList = new List<int> {2 * l * w, 2 * w * h, 2 * h * l};
                result.Add(totalList.Sum() + totalList.Min() / 2);
            }

            if (result == null)
                throw new ArgumentException("Something went wrong...");

            return result.Sum();
        }

        public static int Day2Part2(List<string> input1List)
        {
            List<int> result = new List<int>();

            foreach (string s in input1List)
            {
                List<int> n = s.Split('x').Select(int.Parse).ToList();

                int wrap = n.OrderBy(x => x).ToList().GetRange(0, 2).Sum() * 2;

                int bow = n.Aggregate(1, (current, i) => current * i);

                result.Add(wrap + bow);
            }

            if (result == null)
                throw new ArgumentException("Something went wrong...");

            return result.Sum();
        }

        public static int Day3Part1(string input)
        {
            int x = 0;
            int y = 0;

            Dictionary<(int, int), int> map = new Dictionary<(int, int), int> {{(x, y), 1}};

            foreach (char c in input)
            {
                switch (c)
                {
                    case '^':
                        x++;
                        break;
                    case 'v':
                        x--;
                        break;
                    case '>':
                        y++;
                        break;
                    case '<':
                        y--;
                        break;
                }

                if (map.ContainsKey((x, y)))
                    map[(x, y)]++;
                else
                    map.Add((x, y), 1);
            }

            return map.Count;
        }

        public static int Day3Part2(string input)
        {
            int santaX = 0;
            int santaY = 0;
            int robotX = 0;
            int robotY = 0;

            bool santaWasLastTurn = false;

            Dictionary<(int, int), int> map = new Dictionary<(int, int), int> {{(santaX, santaY), 1}};

            foreach (char c in input)
            {
                int currentX = santaWasLastTurn ? robotX : santaX;
                int currentY = santaWasLastTurn ? robotY : santaY;

                switch (c)
                {
                    case '^':
                        currentX++;
                        break;
                    case 'v':
                        currentX--;
                        break;
                    case '>':
                        currentY++;
                        break;
                    case '<':
                        currentY--;
                        break;
                }

                if (map.ContainsKey((currentX, currentY)))
                    map[(currentX, currentY)]++;
                else
                    map.Add((currentX, currentY), 1);

                if (santaWasLastTurn)
                {
                    robotX = currentX;
                    robotY = currentY;
                }
                else
                {
                    santaX = currentX;
                    santaY = currentY;
                }

                santaWasLastTurn = !santaWasLastTurn;
            }

            return map.Count;
        }

        public static int Day4(string input, string compare)
        {
            MD5 md5Service = MD5.Create();

            for (int i = 0; i < int.MaxValue; i++)
            {
                byte[] hash = md5Service.ComputeHash(Encoding.Default.GetBytes(string.Concat(input, i.ToString())));
                string hashHex = BitConverter.ToString(hash);

                if (hashHex.StartsWith(compare))
                    return i;
            }

            throw new ArgumentException("No fitting number found");
        }

        #endregion

        #endregion
    }
}