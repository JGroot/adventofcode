using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode._2021.Services
{
    public class ThreeService : IThreeService
    {
        public int GetPowerConsumption(List<int> power, int binaryLength)
        {
            var powerStrings = power.Select(x => Convert.ToString(x, 2).PadLeft(binaryLength, '0')).ToList();
            var mostCommon = string.Empty;
            var leastCommon = string.Empty;

            for (var i = 0; i < binaryLength; i++)
            {
                var column = powerStrings.Select(x =>  Convert.ToInt32(x[i].ToString()));
                var ones = column.Sum();
                var zeros = column.Count() - ones;

                if (ones > zeros)
                {
                    mostCommon = $"{mostCommon}1";
                    leastCommon = $"{leastCommon}0";
                }
                else
                {
                    mostCommon = $"{mostCommon}0";
                    leastCommon = $"{leastCommon}1";
                }
            }

            var gamma = Convert.ToInt32(mostCommon, 2);
            var epsilon = Convert.ToInt32(leastCommon, 2);
            return gamma * epsilon;
        }
    }
}
