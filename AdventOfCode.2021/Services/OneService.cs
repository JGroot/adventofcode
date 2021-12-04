using System.Collections.Generic;

namespace AdventOfCode._2021.Services
{
    public class OneService : IOneService
    {
        public OneService() { }

        public int AnalyzeSeaFloor(List<int> depths)
        {
            var largerMeasurementCount = 0;

            for (var i = 0; i < depths.Count; i++)
            {
                if (i > 0 && depths[i] > depths[i - 1])
                {
                    largerMeasurementCount++;
                }
            }

            return largerMeasurementCount;
        }

        public int AnalyzeSeaFloorSlidingScale(List<int> depths, int scale)
        {
            var largerMeasurementCount = 0;

            for (var i = 0; i < depths.Count; i++)
            {
                if (i >= scale)
                {
                    //refactor to use scale
                    var previousSlide = depths[i - 1] + depths[i - 2] + depths[i - 3];
                    var currentSlide = depths[i] + depths[i - 1] + depths[i - 2];

                    if (currentSlide > previousSlide)
                    {
                        largerMeasurementCount++;
                    }
                }
            }
            return largerMeasurementCount;
        }
    }
}
