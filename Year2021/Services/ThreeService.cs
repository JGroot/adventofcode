using System;
using System.Collections.Generic;
using System.Linq;
using Year2021.Services.Interfaces;

namespace Year2021.Services
{
    public class ThreeService : IThreeService
    {
        public int GetPowerConsumption(List<string> power, int binaryLength)
        {
            var mostCommon = string.Empty;
            var leastCommon = string.Empty;

            for (var i = 0; i < binaryLength; i++)
            {
                var column = power.Select(x => Convert.ToInt32(x[i].ToString()));
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

        public int GetLifeSupportRating(List<string> power, int binaryLength)
        {
            var oxygenTotal = Calculate(power, binaryLength, "1", "0");
            var co2Total = Calculate(power, binaryLength, "0", "1");
            var lifeSupport = oxygenTotal * co2Total;
            return lifeSupport;
        }

        private static int Calculate(List<string> power, int binaryLength, string high, string low)
        {
            for (var i = 0; i < binaryLength; i++)
            {
                if (power.Count > 1)
                {
                    var column = power.Select(x => Convert.ToInt32(x[i].ToString()));
                    var ones = column.Sum();
                    var zeros = column.Count() - ones;

                    if (ones >= zeros)
                    {
                        power = power.Where(x => x[i].ToString().Contains(high)).ToList();
                    }
                    else
                    {
                        power = power.Where(x => x[i].ToString().Contains(low)).ToList();
                    }
                }
            }
            return Convert.ToInt32(power.FirstOrDefault(), 2);
        }
    }
}
