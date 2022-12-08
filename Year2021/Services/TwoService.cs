using System.Collections.Generic;
using System.Linq;
using Year2021.Models;
using Year2021.Services.Interfaces;

namespace Year2021.Services
{
    public class TwoService : ITwoService
    {
        public int CalculatePosition(List<Navigation> navigations)
        {
            var horizontalSum = navigations.Where(x => x.Direction == Enums.Direction.Forward)
                .Sum(x => x.Distance);

            var upSum = navigations.Where(x => x.Direction == Enums.Direction.Up)
                .Sum(x => x.Distance);

            var downSum = navigations.Where(x => x.Direction == Enums.Direction.Down)
                .Sum(x => x.Distance);

            return horizontalSum * (downSum - upSum);
        }

        public int CalculatePositionWithAim(List<Navigation> navigations)
        {
            var horizontal = 0;
            var depth = 0;
            var aim = 0;

            foreach (var nav in navigations)
            {
                if (nav.Direction == Enums.Direction.Forward)
                {
                    horizontal += nav.Distance;
                    depth += aim * nav.Distance;
                }
                else if (nav.Direction == Enums.Direction.Down)
                {
                    aim += nav.Distance;
                }
                else if (nav.Direction == Enums.Direction.Up)
                {
                    aim -= nav.Distance;
                }
            }

            var result = horizontal * depth;
            return result;
        }
    }
}
