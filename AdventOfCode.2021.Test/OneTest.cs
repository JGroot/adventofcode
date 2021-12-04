using AdventOfCode._2021.Services;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using Xunit;

namespace AdventOfCode._2021.Test
{
    public class OneTest
    {
        [Theory, MemberData(nameof(SeaFloor))]
        public void AnalyzeSeaFloorTest(List<int> depths, int answer)
        {
            var oneService = new OneService();
            var result = oneService.AnalyzeSeaFloor(depths);

            result.Should().Be(answer);
        }

        [Theory, MemberData(nameof(SeaFloorSliding))]
        public void AnalyzeSeaFloorTestSliding(List<int> depths, int scale, int answer)
        {
            var oneService = new OneService();
            var result = oneService.AnalyzeSeaFloorSlidingScale(depths, scale);

            result.Should().Be(answer);
        }

        public static IEnumerable<object[]> SeaFloor =>
            new List<object[]>
            {              
                new object[] { List1(), 7 },
                new object[] { List2(), 8 },
                new object[] { List3(), 1681 },
            };

        public static IEnumerable<object[]> SeaFloorSliding =>
           new List<object[]>
           {
                new object[] { List1(), 3, 5 },
                new object[] { List2(), 3, 5 },
                new object[] { List3(), 3, 1704 },
           };


        private static List<int> List1()
            => new()
            {
                199,
                200,
                208,
                210,
                200,
                207,
                240,
                269,
                260,
                263
            };

        private static List<int> List2()
            => new()
            {
                173,
                179,
                200,
                210,
                226,
                229,
                220,
                221,
                228,
                233
            };

        private static List<int> List3()
        {
            var path = AppContext.BaseDirectory + @"Data\DayOneSeaDepth.json";
            var data = JsonSerializer.Deserialize<Depth>(File.ReadAllText(path));
            return data.Depths.ToList();
        }
    }

    public class Depth
    {
        public int[] Depths { get; set; }
    }
}
