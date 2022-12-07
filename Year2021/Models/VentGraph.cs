namespace AdventOfCode._2021.Models
{
    public class Coordinates
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int LineCount { get; set; }
    }

    public class Line
    {
        public int BeginX { get; set; }
        public int EndX { get; set; }
        public int BeginY { get; set; }
        public int EndY { get; set; }
    }
}
