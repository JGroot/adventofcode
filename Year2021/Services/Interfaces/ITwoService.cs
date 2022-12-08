using System.Collections.Generic;
using Year2021.Models;

namespace Year2021.Services.Interfaces
{
    public interface ITwoService
    {
        int CalculatePosition(List<Navigation> navigations);
        int CalculatePositionWithAim(List<Navigation> navigations);
    }
}
