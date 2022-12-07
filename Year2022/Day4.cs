namespace Year2022
{
    public class Day4
    {
        public int TotalRedundantPairs(string[] input)
        {
            int total = 0;
            foreach (var row in input)
            {
                var pair = row.Split(',');

                var dashIndex = pair[0].IndexOf('-');
                var x1 = pair[0].Substring(0, dashIndex);
                var y1 = pair[0].Substring(dashIndex+1);

                dashIndex = pair[1].IndexOf("-");
                var x2 = pair[1].Substring(0, dashIndex);
                var y2 = pair[1].Substring(dashIndex+1);

                //as int 1
                int intx1 = int.Parse(x1);
                int inty1 = int.Parse(y1);

                //as int 2
                int intx2 = int.Parse(x2);
                int inty2 = int.Parse(y2);

                // string 1 
                var firstPair = string.Empty;
                for (int i = 0; i <= inty1-intx1; i++)
                {
                    var number = intx1 + i;
                    firstPair += "-" + number.ToString() + "-";
                }

                var secondPair = string.Empty;
                for (int i = 0; i <= inty2-intx2; i++)
                {
                    var number = intx2 + i;
                    secondPair += "-" + number.ToString() + "-";
                }

                if (firstPair.Contains(secondPair) || secondPair.Contains(firstPair))
                {
                    total++;
                }
            }
            return total;
        }

        public int TotalOverlap(string[] input)
        {
            var total = 0;

            foreach (var row in input)
            {
                var pair = row.Split(',');

                var dashIndex = pair[0].IndexOf('-');
                var x1 = int.Parse(pair[0].Substring(0, dashIndex));
                var y1 = int.Parse(pair[0].Substring(dashIndex + 1));

                dashIndex = pair[1].IndexOf("-");
                var x2 = int.Parse(pair[1].Substring(0, dashIndex));
                var y2 = int.Parse(pair[1].Substring(dashIndex + 1));

                List<int> firstPair = new();
                for (int i = 0; i <= y1 - x1; i++)
                {
                    var number = x1 + i;
                    firstPair.Add(number);
                }

                List<int> secondPair = new();
                for (int i = 0; i <= y2 - x2; i++)
                {
                    var number = x2 + i;
                    secondPair.Add(number);
                }

                if (firstPair.Count >= secondPair.Count)
                {
                    foreach(var item in firstPair)
                    {
                        var exists = secondPair.Where(x => x == item);
                        if (exists.Any())
                        {
                            total++;
                            break;
                        }
                    }
                }
                else
                {
                    foreach (var item in secondPair)
                    {
                        var exists = firstPair.Where(x => x == item);
                        if (exists.Any())
                        {
                            total++;
                            break;
                        }
                    }
                }
            }


            return total;
        }
    }
}
