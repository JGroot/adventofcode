﻿namespace Year2022
{
    public class Day5
    {
        public string Organize(string[] input, Dictionary<int, Stack<char>> crates)
        {
            foreach(var row in input)
            {
                var arr = row.Split(" ");

                int move = int.Parse(arr[1]);
                int from = int.Parse(arr[3]);
                int to = int.Parse(arr[5]);

                for (int i = 0; i < move; i++)
                {
                    var temp = crates[from].Pop();
                    crates[to].Push(temp);
                }
            }

            var result = string.Empty;

            foreach(var key in crates)
            {
                result += key.Value.Pop();
            }

            return result;
        }
    }
}
