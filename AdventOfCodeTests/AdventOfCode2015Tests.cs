using System.Collections.Generic;
using AdventOfCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventOfCodeTests
{
    [TestClass]
    public class AdventOfCode2015Tests
    {
        #region methods

        #region public methods

        [TestMethod]
        public void Day1Part1Test()
        {
            // Arrange
            string input1 = "(())";
            string input2 = "()()";
            string input3 = "(((";
            string input4 = "(()(()(";
            string input5 = "))(((((";
            string input6 = "())";
            string input7 = "))(";
            string input8 = ")))";
            string input9 = ")())())";

            // Act
            int result1 = AdventOfCode2015.Day1Part1(input1);
            int result2 = AdventOfCode2015.Day1Part1(input2);
            int result3 = AdventOfCode2015.Day1Part1(input3);
            int result4 = AdventOfCode2015.Day1Part1(input4);
            int result5 = AdventOfCode2015.Day1Part1(input5);
            int result6 = AdventOfCode2015.Day1Part1(input6);
            int result7 = AdventOfCode2015.Day1Part1(input7);
            int result8 = AdventOfCode2015.Day1Part1(input8);
            int result9 = AdventOfCode2015.Day1Part1(input9);

            // Assert
            Assert.AreEqual(0, result1);
            Assert.AreEqual(0, result2);
            Assert.AreEqual(3, result3);
            Assert.AreEqual(3, result4);
            Assert.AreEqual(3, result5);
            Assert.AreEqual(-1, result6);
            Assert.AreEqual(-1, result7);
            Assert.AreEqual(-3, result8);
            Assert.AreEqual(-3, result9);
        }

        [TestMethod]
        public void Day1Part2Test()
        {
            // Arrange
            string input1 = ")";
            string input2 = "()())";

            // Act
            int result1 = AdventOfCode2015.Day1Part2(input1);
            int result2 = AdventOfCode2015.Day1Part2(input2);

            // Assert
            Assert.AreEqual(1, result1);
            Assert.AreEqual(5, result2);
        }

        [TestMethod]
        public void Day2Part1Test()
        {
            // Arrange
            string input1 = "2x3x4";
            string input2 = "1x1x10";

            List<string> input1List = new List<string> {input1};
            List<string> input2List = new List<string> {input2};
            List<string> combinedList = new List<string> {input1, input2};

            // Act
            int result1 = AdventOfCode2015.Day2Part1(input1List);
            int result2 = AdventOfCode2015.Day2Part1(input2List);
            int result3 = AdventOfCode2015.Day2Part1(combinedList);

            // Assert
            Assert.AreEqual(58, result1);
            Assert.AreEqual(43, result2);
            Assert.AreEqual(101, result3);
        }

        [TestMethod]
        public void Day2Part2Test()
        {
            // Arrange
            string input1 = "2x3x4";
            string input2 = "1x1x10";

            List<string> input1List = new List<string> {input1};
            List<string> input2List = new List<string> {input2};
            List<string> combinedList = new List<string> {input1, input2};

            // Act
            int result1 = AdventOfCode2015.Day2Part2(input1List);
            int result2 = AdventOfCode2015.Day2Part2(input2List);
            int result3 = AdventOfCode2015.Day2Part2(combinedList);

            // Assert
            Assert.AreEqual(34, result1);
            Assert.AreEqual(14, result2);
            Assert.AreEqual(48, result3);
        }

        [TestMethod]
        public void Day3Part1Test()
        {
            // Arrange
            string input1 = ">";
            string input2 = "^>v<";
            string input3 = "^v^v^v^v^v";

            // Act
            int result1 = AdventOfCode2015.Day3Part1(input1);
            int result2 = AdventOfCode2015.Day3Part1(input2);
            int result3 = AdventOfCode2015.Day3Part1(input3);

            // Assert
            Assert.AreEqual(2, result1);
            Assert.AreEqual(4, result2);
            Assert.AreEqual(2, result3);
        }

        [TestMethod]
        public void Day3Part2Test()
        {
            // Arrange
            string input1 = "^v";
            string input2 = "^>v<";
            string input3 = "^v^v^v^v^v";

            // Act
            int result1 = AdventOfCode2015.Day3Part2(input1);
            int result2 = AdventOfCode2015.Day3Part2(input2);
            int result3 = AdventOfCode2015.Day3Part2(input3);

            // Assert
            Assert.AreEqual(3, result1);
            Assert.AreEqual(3, result2);
            Assert.AreEqual(11, result3);
        }

        [TestMethod]
        public void Day4Part1Test()
        {
            // Arrange
            string input1 = "abcdef";
            string input2 = "pqrstuv";

            // Act
            int result1 = AdventOfCode2015.Day4(input1, "00-00-0");
            int result2 = AdventOfCode2015.Day4(input2, "00-00-0");

            // Assert
            Assert.AreEqual(609043, result1);
            Assert.AreEqual(1048970, result2);
        }

        #endregion

        #endregion
    }
}