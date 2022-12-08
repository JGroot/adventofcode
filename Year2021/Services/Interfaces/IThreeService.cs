using System.Collections.Generic;

namespace Year2021.Services.Interfaces
{
    public interface IThreeService
    {
        int GetPowerConsumption(List<string> power, int binaryLength);
        int GetLifeSupportRating(List<string> power, int binaryLength);
    }
}
