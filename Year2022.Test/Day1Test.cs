namespace Year2022.Test
{
    [TestClass]
    public class Day1Test
    {
        
        [TestMethod]
        public void TestMethod1()
        {
            Day1 day1 = new();
            var calories = File.ReadAllLines("Inputs/Day1.txt");

            var result = day1.TotalCalories(calories);

            Console.WriteLine(result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Day1 day1 = new();

            var calories = File.ReadAllLines("Inputs/Day1.txt");

            var result = day1.TotalTopThree(calories);

            Console.WriteLine(result);
        }
    }
}