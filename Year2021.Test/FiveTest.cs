using Year2021.Services;
using FluentAssertions;
using System.Collections.Generic;
using Xunit;
using Year2021.Models;
using Year2021.Services.Interfaces;

namespace Year2021.Test
{
    public class FiveTest
    {
        private readonly IFiveService _service;
        
        public FiveTest()
        {
            _service = new FiveService();
        }

        [Theory, MemberData(nameof(VentGraph))]
        public void VentGraphPointCountTest(List<Line> lines, int answer)
        {
            var result = _service.VentGraph(lines);

            result.Should().Be(answer);
        }

        [Theory, MemberData(nameof(VentGraphDiagonal))]
        public void VentGraphDiagonalPointCountTest(List<Line> lines, int answer)
        {
            var result = _service.VentGraphDiagonal(lines);

            result.Should().Be(answer);
        }

        public static IEnumerable<object[]> VentGraph
            => new List<object[]>
            {
                new object[] { Data.DayFiveCoords.Example(), 5},
                new object[] { Data.DayFiveCoords.Input(), 4728 }
            };


        public static IEnumerable<object[]> VentGraphDiagonal
          => new List<object[]>
          {
                new object[] { Data.DayFiveCoords.Example(), 12},
                new object[] { Data.DayFiveCoords.Input(), 17717 }
          };
    }
}
