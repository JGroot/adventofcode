namespace Year2022
{
    public class Day6
    {
        public int PacketStartLocation(string cipher)
        {
            for (var i = 0; i < cipher.Length; i++)
            {
                var seen = false;
                
                List<char> letters = new();
                for (var j = 0; j < 4; j++)
                {
                    letters.Add(cipher[i + j]);
                }

                foreach(var letter in letters)
                {
                    var group = letters.Where(x => x == letter);
                    if (group.Count() > 1)
                    {
                        seen = true;
                    }
                    if (seen)
                        break;
                }
                
                if (!seen)
                {
                    return i + 4;
                }
            }
            return 0;
        }

        public int PacketStartLocation2(string cipher)
        {
            for (var i = 0; i < cipher.Length; i++)
            {
                var seen = false;

                List<char> letters = new();
                for (var j = 0; j < 14; j++)
                {
                    letters.Add(cipher[i + j]);
                }

                foreach (var letter in letters)
                {
                    var group = letters.Where(x => x == letter);
                    if (group.Count() > 1)
                    {
                        seen = true;
                    }
                    if (seen)
                        break;
                }

                if (!seen)
                {
                    return i + 14;
                }
            }
            return 0;
        }
    }
}
