using System.Collections.Generic;

namespace Year2021.Services.Interfaces
{
    public interface IOneService
    {
        int AnalyzeSeaFloor(List<int> depths);
        int AnalyzeSeaFloorSlidingScale(List<int> depths, int scale);
    }
}
