using System.Collections.Generic;
using Year2021.Models;

namespace Year2021.Services.Interfaces
{
    public interface IFiveService
    {
        public int VentGraph(List<Line> lines);
        public int VentGraphDiagonal(List<Line> lines);
    }
}
