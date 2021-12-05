using AdventOfCode._2021.Models;
using AdventOfCode._2021.Services;
using FluentAssertions;
using System.Collections.Generic;
using Xunit;

namespace AdventOfCode._2021.Test
{
    public class FourTest
    {
        private readonly IFourService _service;

        public FourTest()
        {
            _service = new FourService();
        }

        [Theory, MemberData(nameof(BingoWinner))]
        public void BingoWinnerTest(List<BingoBoard> board, List<int> draws, int answer)
        {
            var result = _service.GetBingoWinner(board, draws);

            result.Should().Be(answer); 
        }

        public static IEnumerable<object[]> BingoWinner()
            => new List<object[]>
            {
                new object[] { Data.DayFourBingoBoards.ExampleBoards(), Data.DayFourBingoBoards.ExampleDraws(), 4512 }, //passes
                new object[] { Data.DayFourBingoBoards.PuzzleInputBoards(), Data.DayFourBingoBoards.PuzzleInputDraws(), 000 } //not passing yet (answer unknown)
            };
    }
}
