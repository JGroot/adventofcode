namespace Year2022.Test
{
    [TestClass]
    public class Day4Test
    {
        private readonly Day4 _day;
        public Day4Test()
        {
            _day= new Day4();
        }

        [TestMethod]
        public void RedundantPairs()
        {
            var file = File.ReadAllLines("Inputs/Day4.txt");

            var result = _day.TotalRedundantPairs(file);

            result.Should().Be(444);
        }

        [TestMethod]
        public void RedundantPairs2()
        {
            var file = File.ReadAllLines("Inputs/Day4.txt");

            var result = _day.TotalOverlap(file);

            result.Should().Be(801);
        }

    }
}
