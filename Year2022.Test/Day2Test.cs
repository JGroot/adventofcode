using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Year2022.Test
{
    [TestClass]
    public class Day2Test
    {
        Day2 _day2;

        public Day2Test()
        {
            _day2 = new Day2();
        }

        [TestMethod]
        public void TotalScoreTest()
        {
            var input = File.ReadAllLines("Inputs/Day2.txt");

            var result = _day2.StrategyOne(input);
            result.Should().Be(10718);
        }

        [TestMethod]
        public void TotalScore2Test()
        {
            var input = File.ReadAllLines("Inputs/Day2.txt");

            var result = _day2.StrategyTwo(input);
            result.Should().Be(14652);
        }
    }
}
