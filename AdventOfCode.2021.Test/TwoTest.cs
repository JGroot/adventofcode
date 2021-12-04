using AdventOfCode._2021.Enums;
using AdventOfCode._2021.Models;
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
    public class TwoTest
    {
        ITwoService _service;
        public TwoTest()
        {
            _service = new TwoService();
        }

        [Theory, MemberData(nameof(Navigation))]
        public void CalculatePositionTest(List<Navigation> navigations, int answer)
        {
            var result = _service.CalculatePosition(navigations);

            result.Should().Be(answer);
        }

        [Theory, MemberData(nameof(NavigationAim))]
        public void CalculatePositionWithAimTest(List<Navigation> navigations, int answer)
        {
            var result = _service.CalculatePositionWithAim(navigations);

            result.Should().Be(answer);
        }

        public static IEnumerable<object[]> Navigation =>
           new List<object[]>
           {
               new object[] { PuzzleInput(), 1868935 },
               new object[] { Example(), 150 }
           };

        public static IEnumerable<object[]> NavigationAim =>
          new List<object[]>
          {
               new object[] { PuzzleInput(), 1965970888 },
               new object[] { Example(), 900 }
          };

        private static List<Navigation> Example()
           => new()
           {
               new Navigation { Direction = Direction.Forward, Distance = 5 },
               new Navigation { Direction = Direction.Down, Distance = 5 },
               new Navigation { Direction = Direction.Forward, Distance = 8 },
               new Navigation { Direction = Direction.Up, Distance = 3 },
               new Navigation { Direction = Direction.Down, Distance = 8 },
               new Navigation { Direction = Direction.Forward, Distance = 2 },
           };


        private static List<Navigation> PuzzleInput()
        {
            var path = AppContext.BaseDirectory + @"Data\DayTwoNavigation.json";
            var data = JsonSerializer.Deserialize<NavigationJson>(File.ReadAllText(path));

            var navigation = data.Navigation.Select(x => new Navigation()
            {
                Direction =  (Direction)Enum.Parse(typeof(Direction), x.Direction, true),
                Distance = x.Distance
            }).ToList();

            return navigation;
        }
    }

    public class NavigationJson
    {
        public NavigationDto[] Navigation { get; set; }
    }

    public class NavigationDto
    {
        public string Direction { get; set; }
        public int Distance { get; set; }
    }
}
