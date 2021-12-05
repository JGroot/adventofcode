using AdventOfCode._2021.Models;
using System.Collections.Generic;

namespace AdventOfCode._2021.Services
{
    public interface IFourService
    {
        int GetBingoWinner(List<BingoBoard> boards, List<int> draws);
    }
}
