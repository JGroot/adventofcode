using AdventOfCode._2021.Models;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode._2021.Services
{
    public class FourService : IFourService
    {
        public int GetBingoWinner(List<BingoBoard> boards, List<int> draws)
        {
            List<int> drawn = new();
            foreach (var draw in draws)
            {
                drawn.Add(draw);
                if (drawn.Count > 5)
                {
                    var updated = boards.Select(x => x.BingoSquares
                                                .Select(y => new BingoSquare()
                                                {
                                                    Number = y.Number,
                                                    isDrawn = drawn.Contains(y.Number)
                                                }).ToList());

                    foreach (var board in updated)
                    {
                        for (var i = 0; i < 5; i++)
                        {
                            bool rowWin = !(board.Skip(i).Take(5).Any(x => x.isDrawn == false));

                            List<BingoSquare> column = new()
                            {
                                board.ElementAt(i),
                                board.ElementAt(i + (5 * 1)),
                                board.ElementAt(i + (5 * 2)),
                                board.ElementAt(i + (5 * 3)),
                                board.ElementAt(i + (5 * 4))
                            };
                            bool columnWin = !(column.Any(x => x.isDrawn == false));

                            if (rowWin || columnWin)
                            {
                                var sum = board.Where(x => x.isDrawn == false).Sum(x => x.Number);
                                var finalScore = sum * draw;
                                return finalScore;
                            }
                        }
                    }
                }
            }

            return 0;
        }
    }
}
