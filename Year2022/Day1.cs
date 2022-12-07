namespace Year2022
{
    public class Day1
    {
        public int TotalCalories(string[] calories)
        {
            int eachTotal = 0;
            int total = 0;
            foreach (var cal in calories)
            {
                if (string.IsNullOrWhiteSpace(cal))
                {
                    if (eachTotal > total)
                    {
                        total = eachTotal;
                    }
                    eachTotal = 0;
                }
                else
                {
                    eachTotal += int.Parse(cal);
                }
            }
            return total;
        }

        public int TotalTopThree(string[] calories)
        {
            var runningTotal = 0;
            List<int> total = new();

            foreach (var cal in calories)
            {
                if (string.IsNullOrWhiteSpace(cal))
                {
                    total.Add(runningTotal);
                    runningTotal = 0;
                }
                else
                {
                    runningTotal += int.Parse(cal);

                }
            }

            return total.OrderByDescending(x => x).Take(3).Sum();
        }
    }
}
