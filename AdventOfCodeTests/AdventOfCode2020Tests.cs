using System;
using System.Collections.Generic;
using System.Linq;
using AdventOfCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventOfCodeTests
{
    [TestClass]
    public class AdventOfCode2020Tests
    {
        #region methods

        #region public methods

        [TestMethod]
        public void Day1Part1Test()
        {
            // Arrange
            List<int> input = new List<int>
            {
                1721,
                979,
                366,
                299,
                675,
                1456
            };

            // Act
            double result = AdventOfCode2020.Day1Part1(input);

            // Assert
            Assert.AreEqual(result, 514579);
        }

        [TestMethod]
        public void Day1Part2Test()
        {
            // Arrange
            List<int> input = new List<int>
            {
                1721,
                979,
                366,
                299,
                675,
                1456
            };

            // Act
            double result = AdventOfCode2020.Day1Part2(input);

            // Assert
            Assert.AreEqual(241861950, result);
        }

        [TestMethod]
        public void Day2Part1Test()
        {
            // Arrange
            List<string> input = new List<string> {"1-3 a: abcde", "1-3 b: cdefg", "2-9 c: ccccccccc"};

            // Act
            int result = AdventOfCode2020.Day2Part1(input);

            // Assert
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void Day2Part2Test()
        {
            // Arrange
            List<string> input = new List<string> {"1-3 a: abcde", "1-3 b: cdefg", "2-9 c: ccccccccc"};

            // Act
            int result = AdventOfCode2020.Day2Part2(input);

            // Assert
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void Day3Part1Test()
        {
            // Arrange
            string textInput = "..##.......\r\n#...#...#..\r\n.#....#..#.\r\n..#.#...#.#\r\n.#...##..#.\r\n..#.##.....\r\n.#.#.#....#\r\n.#........#\r\n#.##...#...\r\n#...##....#\r\n.#..#...#.#";
            List<string> input = textInput.Split(new[] {"\r\n"}, StringSplitOptions.None).ToList();
            List<(int increaseX, int increaseY)> inputParameter1 = new List<(int increaseX, int increaseY)> {(1, 3)};

            List<(int increaseX, int increaseY)> inputParameter2 = new List<(int increaseX, int increaseY)>
            {
                (1, 1),
                (1, 3),
                (1, 5),
                (1, 7),
                (2, 1)
            };

            // Act
            long result1 = AdventOfCode2020.Day3(input, inputParameter1);
            long result2 = AdventOfCode2020.Day3(input, inputParameter2);

            // Assert
            Assert.AreEqual(7, result1);
            Assert.AreEqual(336, result2);
        }

        #endregion

        #endregion
    }
}