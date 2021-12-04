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
        public void PowerCompsumptionTest(List<int> power, int binaryLength, int answer)
        {
            var result = _service.GetPowerConsumption(power, binaryLength);

            result.Should().Be(answer);
        }

        public static IEnumerable<object[]> PowerConsumption =>
            new List<object[]>
            {
                new object[] {Example(), 5, 198 },
                new object[] {PuzzleInput(), 12, 2003336 }
            };

        private static List<int> Example()
            => new()
            {
                0b_00100,
                0b_11110,
                0b_10110,
                0b_10111,
                0b_10101,
                0b_01111,
                0b_00111,
                0b_11100,
                0b_10000,
                0b_11001,
                0b_00010,
                0b_01010
            };

        private static List<int> PuzzleInput()
            => Data.DayThreePower.PuzzleInput();
        
    }
}
