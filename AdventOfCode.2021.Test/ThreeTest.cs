using AdventOfCode._2021.Services;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Xunit;
using System.Linq;

namespace AdventOfCode._2021.Test
{
    public class ThreeTest
    {
        private readonly IThreeService _service;

        public ThreeTest()
        {
            _service = new ThreeService();
        }

        [Theory, MemberData(nameof(PowerConsumption))]
        public void PowerCompsumptionTest(List<string> power, int binaryLength, int answer)
        {
            var result = _service.GetPowerConsumption(power, binaryLength);

            result.Should().Be(answer);
        }

        [Theory, MemberData(nameof(LifeSupport))]
        public void LifeSupportTest(List<string> power, int binaryLength, int answer)
        {
            var result = _service.GetLifeSupportRating(power, binaryLength);

            result.Should().Be(answer);
        }

        public static IEnumerable<object[]> PowerConsumption =>
            new List<object[]>
            {
                new object[] {Data.DayThreePower.Example(), 5, 198 },
                new object[] { Data.DayThreePower.PuzzleInput(), 12, 2003336 }
            };

        public static IEnumerable<object[]> LifeSupport =>
           new List<object[]>
           {
                new object[] {Data.DayThreePower.Example(), 5, 230 },
                new object[] { Data.DayThreePower.PuzzleInput(), 12, 1877139 }
           };

       
    }
}
