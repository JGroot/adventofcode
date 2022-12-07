namespace Year2022.Test
{
    [TestClass]
    public class Day6Test
    {
        Day6 _day;

        public Day6Test()
        {
            _day = new();
        }

        [TestMethod]
        public void CipherStart1()
        {
            var cipher = File.ReadAllText("Inputs/Day6.txt");

            var result = _day.PacketStartLocation(cipher);

            result.Should().Be(1929);
        }

        [TestMethod]
        public void CipherStart2()
        {
            var cipher = File.ReadAllText("Inputs/Day6.txt");

            var result = _day.PacketStartLocation2(cipher);
            // 3288 too low
            result.Should().Be(1929);
        }
    }
}
