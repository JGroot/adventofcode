using System.Collections.Generic;

namespace AdventOfCode._2021.Services
{
    public interface IThreeService
    {
        int GetPowerConsumption(List<int> power, int binaryLength);
    }
}
