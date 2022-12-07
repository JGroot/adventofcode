namespace Year2022
{
    public class Day3
    {
        public int PriorityElves(string[] input)
        {
            List<char> priorities = new();

            foreach (var row in input)
            {
                var half = row.Length / 2;
                var p1 = row.Substring(0, half);
                var p2 = row.Substring(half, half);

                for (int i = 0; i <= half - 1; i++)
                {
                    var letter = p1[i];
                    if (p2.Contains(letter))
                    {
                        priorities.Add(letter);
                        break;
                    }
                }
            }

            var lower = priorities.Where(x => char.IsLower(x)).Select(x => (int)x - 96).Sum();
            var upper = priorities.Where(x => char.IsUpper(x)).Select(x => (int)x - 38).Sum();

            return lower + upper;
        }

        public int PriorityElvesTwo(string[] input)
        {
            int total = 0;
            List<char> priorities = new();

            for (int i = 0; i < input.Length; i += 3)
            {
                var sum1 = input[i].Length;
                var sum2 = input[i + 1].Length;
                var sum3 = input[i + 2].Length;

                var row1 = input[i];
                var row2 = input[i + 1];
                var row3 = input[i + 2];

                if (sum1 >= sum2 && sum1 >= sum3)
                {
                    for (int j = 0; j < row1.Length + 1; j++)
                    {
                        var letter = row1[j];
                        if (row2.Contains(letter) && row3.Contains(letter))
                        {
                            priorities.Add(letter);
                            break;
                        }
                    }
                }
                else if (sum2 >= sum1 && sum2 >= sum3)
                {
                    for (int j = 0; j < row2.Length + 1; j++)
                    {
                        var letter = row2[j];
                        if (row1.Contains(letter) && row3.Contains(letter))
                        {
                            priorities.Add(letter);
                            break;
                        }
                    }
                }
                else
                {
                    for (int j = 0; j < row3.Length + 1; j++)
                    {
                        var letter = row3[j];
                        if (row1.Contains(letter) && row2.Contains(letter))
                        {
                            priorities.Add(letter);
                            break;
                        }
                    }
                }
            }
            var lower = priorities.Where(x => char.IsLower(x)).Select(x => (int)x - 96).Sum();
            var upper = priorities.Where(x => char.IsUpper(x)).Select(x => (int)x - 38).Sum();

            total = lower + upper;
            return total;
        }

        //private string? GetMatch(string[] baseRow, string[] rowA, string[] rowB)
        //{
        //    for (int j = 0; j < baseRow.Length + 1; j++)
        //    {
        //        var letter = baseRow[j];
        //        if (rowA.Contains(letter) && rowA.Contains(letter))
        //        {
        //            return letter;
        //        }
        //    }
        //    return null;
        //}
    }
}
