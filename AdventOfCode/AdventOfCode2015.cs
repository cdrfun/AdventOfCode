using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

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

        public static int Day5Part1(List<string> input)
        {
            string regexpVowel = "[aeiou].*[aeiou].*[aeiou]";
            string regexpDoubleCharacter = "(\\w)\\1";
            string regexForbidden = "ab|cd|pq|xy";

            return input.Where(s => Regex.IsMatch(s, regexpVowel)).Where(s => Regex.IsMatch(s, regexpDoubleCharacter)).Count(s => !Regex.IsMatch(s, regexForbidden));
        }

        public static int Day5Part2(List<string> input)
        {
            string regexpDoubleLetter = "(..).*\\1";
            string regexpRepeatedLetter = "(.).\\1";

            return input.Where(s => Regex.IsMatch(s, regexpDoubleLetter)).Count(s => Regex.IsMatch(s, regexpRepeatedLetter));
        }

        public static int Day6Part1(List<string> input)
        {
            string regex = "(turn on|toggle|turn off)(?:.)(\\d+),(\\d+)(?: through )(\\d+),(\\d+)";
            bool[,] map = new bool[1000, 1000];
            int lightCounter = 0;

            foreach (string s in input)
            {
                Match match = Regex.Match(s, regex);

                string command = match.Groups[1].Value;
                (int x, int y) from = (int.Parse(match.Groups[2].Value), int.Parse(match.Groups[3].Value));
                (int x, int y) to = (int.Parse(match.Groups[4].Value), int.Parse(match.Groups[5].Value));

                for (int x = from.x; x <= to.x; x++)
                for (int y = from.y; y <= to.y; y++)
                    switch (command)
                    {
                        case "turn on":
                            lightCounter += map[x, y] ? 0 : 1;
                            map[x, y] = true;
                            break;
                        case "turn off":
                            lightCounter -= map[x, y] ? 1 : 0;
                            map[x, y] = false;
                            break;
                        case "toggle":
                            map[x, y] = !map[x, y];
                            lightCounter += map[x, y] ? 1 : -1;
                            break;
                        default:
                            throw new ArgumentException("Command not implemented");
                    }
            }

            return lightCounter;
        }

        public static int Day6Part2(List<string> input)
        {
            string regex = "(turn on|toggle|turn off)(?:.)(\\d+),(\\d+)(?: through )(\\d+),(\\d+)";
            int[,] map = new int[1000, 1000];
            int lightCounter = 0;

            foreach (string s in input)
            {
                Match match = Regex.Match(s, regex);

                string command = match.Groups[1].Value;
                (int x, int y) from = (int.Parse(match.Groups[2].Value), int.Parse(match.Groups[3].Value));
                (int x, int y) to = (int.Parse(match.Groups[4].Value), int.Parse(match.Groups[5].Value));

                for (int x = from.x; x <= to.x; x++)
                for (int y = from.y; y <= to.y; y++)
                    switch (command)
                    {
                        case "turn on":
                            map[x, y]++;
                            lightCounter++;
                            break;
                        case "turn off":
                            if (map[x, y] == 0)
                                continue;

                            map[x, y]--;
                            lightCounter--;
                            break;
                        case "toggle":
                            map[x, y] += 2;
                            lightCounter += 2;
                            break;
                        default:
                            throw new ArgumentException("Command not implemented");
                    }
            }

            return lightCounter;
        }

        #endregion

        #endregion
    }
}