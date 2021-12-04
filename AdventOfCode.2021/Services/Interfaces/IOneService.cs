using System.Collections.Generic;

namespace AdventOfCode._2021.Services
{
    public interface IOneService
    {
        int AnalyzeSeaFloor(List<int> depths);
        int AnalyzeSeaFloorSlidingScale(List<int> depths, int scale);
    }
}
