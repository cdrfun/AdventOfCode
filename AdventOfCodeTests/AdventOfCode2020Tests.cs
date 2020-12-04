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
        public void Day3Test()
        {
            // Arrange
            string textInput = "..##.......\r\n#...#...#..\r\n.#....#..#.\r\n..#.#...#.#\r\n.#...##..#.\r\n..#.##.....\r\n.#.#.#....#\r\n.#........#\r\n#.##...#...\r\n#...##....#\r\n.#..#...#.#";
            List<string> input = textInput.Split(new[] {"\r\n"}, StringSplitOptions.None).ToList();
            List<(int increaseX, int increaseY)> inputParameterPart1 = new List<(int increaseX, int increaseY)> {(1, 3)};

            List<(int increaseX, int increaseY)> inputParameterPart2 = new List<(int increaseX, int increaseY)>
            {
                (1, 1),
                (1, 3),
                (1, 5),
                (1, 7),
                (2, 1)
            };

            // Act
            long resultPart1 = AdventOfCode2020.Day3(input, inputParameterPart1);
            long resultPart2 = AdventOfCode2020.Day3(input, inputParameterPart2);

            // Assert
            Assert.AreEqual(7, resultPart1);
            Assert.AreEqual(336, resultPart2);
        }

        [TestMethod]
        public void Day4Part1Test()
        {
            // Arrange
            string textInput = @"ecl:gry pid:860033327 eyr:2020 hcl:#fffffd
byr:1937 iyr:2017 cid:147 hgt:183cm

iyr:2013 ecl:amb cid:350 eyr:2023 pid:028048884
hcl:#cfa07d byr:1929

hcl:#ae17e1 iyr:2013
eyr:2024
ecl:brn pid:760753108 byr:1931
hgt:179cm

hcl:#cfa07d eyr:2025 pid:166559648
iyr:2011 ecl:brn hgt:59in

iyr:2013 ecl:amb cid:350 eyr:2023 pid:028048884
hcl:#cfa07d byr:1929";

            List<string> input = textInput.Split(new[] {"\r\n"}, StringSplitOptions.None).ToList();

            // Act
            int result1 = AdventOfCode2020.Day4Part1(input);

            // Assert
            Assert.AreEqual(2, result1);
        }
        [TestMethod]
        public void Day4Part2Test()
        {
            // Arrange
            string textInputValid = @"pid:087499704 hgt:74in ecl:grn iyr:2012 eyr:2030 byr:1980
hcl:#623a2f

eyr:2029 ecl:blu cid:129 byr:1989
iyr:2014 pid:896056539 hcl:#a97842 hgt:165cm

hcl:#888785
hgt:164cm byr:2001 iyr:2015 cid:88
pid:545766238 ecl:hzl
eyr:2022

iyr:2010 hgt:158cm hcl:#b6652a ecl:blu byr:1944 eyr:2021 pid:093154719";

            string textInputInvalid = @"eyr:1972 cid:100
hcl:#18171d ecl:amb hgt:170 pid:186cm iyr:2018 byr:1926

iyr:2019
hcl:#602927 eyr:1967 hgt:170cm
ecl:grn pid:012533040 byr:1946

hcl:dab227 iyr:2012
ecl:brn hgt:182cm pid:021572410 eyr:2020 byr:1992 cid:277

hgt:59cm ecl:zzz
eyr:2038 hcl:74454a iyr:2023
pid:3556412378 byr:2007";

            string textInputComplete = @"eyr:1972 cid:100
hcl:#18171d ecl:amb hgt:170 pid:186cm iyr:2018 byr:1926

iyr:2019
hcl:#602927 eyr:1967 hgt:170cm
ecl:grn pid:012533040 byr:1946

hcl:dab227 iyr:2012
ecl:brn hgt:182cm pid:021572410 eyr:2020 byr:1992 cid:277

hgt:59cm ecl:zzz
eyr:2038 hcl:74454a iyr:2023
pid:3556412378 byr:2007

pid:087499704 hgt:74in ecl:grn iyr:2012 eyr:2030 byr:1980
hcl:#623a2f

eyr:2029 ecl:blu cid:129 byr:1989
iyr:2014 pid:896056539 hcl:#a97842 hgt:165cm

hcl:#888785
hgt:164cm byr:2001 iyr:2015 cid:88
pid:545766238 ecl:hzl
eyr:2022

iyr:2010 hgt:158cm hcl:#b6652a ecl:blu byr:1944 eyr:2021 pid:093154719";

            List<string> inputValid = textInputValid.Split(new[] {"\r\n"}, StringSplitOptions.None).ToList();
            List<string> inputInvalid = textInputInvalid.Split(new[] {"\r\n"}, StringSplitOptions.None).ToList();
            List<string> inputComplete = textInputComplete.Split(new[] {"\r\n"}, StringSplitOptions.None).ToList();

            // Act
            int resultValid = AdventOfCode2020.Day4Part2(inputValid);
            int resultInvalid = AdventOfCode2020.Day4Part2(inputInvalid);
            int resultComplete = AdventOfCode2020.Day4Part2(inputComplete);

            // Assert
            Assert.AreEqual(4, resultValid, $"{nameof(resultValid)}");
            Assert.AreEqual(0, resultInvalid, $"{nameof(resultInvalid)}");
            Assert.AreEqual(4, resultComplete, $"{nameof(resultComplete)}");
        }

        #endregion

        #endregion
    }
}