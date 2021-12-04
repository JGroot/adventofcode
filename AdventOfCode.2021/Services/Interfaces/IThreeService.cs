using System.Collections.Generic;

namespace AdventOfCode._2021.Services
{
    public interface IThreeService
    {
        int GetPowerConsumption(List<string> power, int binaryLength);
        int GetLifeSupportRating(List<string> power, int binaryLength);
    }
}
