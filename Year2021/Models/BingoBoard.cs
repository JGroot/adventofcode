using System.Collections.Generic;

namespace Year2021.Models
{
    public class BingoBoard
    {
        public int BoardId { get; set; }
        public List<BingoSquare> BingoSquares { get; set; }
        public bool IsWin { get; set; }
        public int FinalScore { get; set; }
    }

    public class BingoSquare
    {
        public int Number { get; set; }
        public bool IsDrawn { get; set; }
    }
}
