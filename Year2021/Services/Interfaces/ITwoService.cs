using AdventOfCode._2021.Models;
using System.Collections.Generic;

namespace AdventOfCode._2021.Services
{
    public interface ITwoService
    {
        int CalculatePosition(List<Navigation> navigations);
        int CalculatePositionWithAim(List<Navigation> navigations);
    }
}
