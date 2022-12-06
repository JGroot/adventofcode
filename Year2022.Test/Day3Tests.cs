namespace Year2022.Test
{
    [TestClass]
    public class Day3Tests
    {
        Day3 _day3;

        public Day3Tests()
        {
            _day3 = new Day3(); 
        }

        [TestMethod]
        public void Day3Test()
        {
            var input = File.ReadAllLines("Inputs/Day3.txt");

            var result = _day3.PriorityElves(input);
            result.Should().Be(8185);
        }

        [TestMethod]
        public void Day3Test2()
        {
            var input = File.ReadAllLines("Inputs/Day3.txt");

            var result = _day3.PriorityElvesTwo(input);
            result.Should().Be(2817);
        }
    }
}
