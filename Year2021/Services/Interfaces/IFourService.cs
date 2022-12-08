using System.Collections.Generic;
using Year2021.Models;

namespace Year2021.Services.Interfaces
{
    public interface IFourService
    {
        int GetBingoWinner(List<BingoBoard> boards, List<int> draws);
        int GetBingoLoser(List<BingoBoard> boards, List<int> draws);
    }
}
