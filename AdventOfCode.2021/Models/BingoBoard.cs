using System.Collections.Generic;

namespace AdventOfCode._2021.Models
{
    public class BingoBoard
    {
        public List<BingoSquare> BingoSquares { get; set; }
    }

    public class BingoSquare
    {
        public int Number { get; set; }
        public bool isDrawn { get; set; }
    }
}
