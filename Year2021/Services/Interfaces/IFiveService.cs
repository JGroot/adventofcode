using AdventOfCode._2021.Models;
using System.Collections.Generic;

namespace AdventOfCode._2021.Services
{
    public interface IFiveService
    {
        public int VentGraph(List<Line> lines);
        public int VentGraphDiagonal(List<Line> lines);
    }
}
