namespace Year2022.Test
{
    [TestClass]
    public class Day5Test
    {
        Day5 _day;


        public Day5Test()
        {
            _day = new Day5();
        }

        [TestMethod]
        public void StackValidation()
        {
            var dict = GetStacks();

            var top = dict[2].Peek();

            top.Should().Be('H');
        }

        [TestMethod]
        public void StackTop()
        {
            var dict = GetStacks();
            var file = File.ReadAllLines("Inputs/Day5.txt");

            var result = _day.Organize(file, dict);

            result.Should().Be("TWSGQHNHL");
        }

        [TestMethod]
        public void StackOrganize2()
        {
            //var dict = GetStacksSample();
            var dict = GetStacks();
            var file = File.ReadAllLines("Inputs/Day5.txt");

            var result = _day.Organize2(file, dict);

            result.Should().Be("JNRSCDWPP");
        }
        
        private Dictionary<int,Stack<char>> GetStacksSample()
        {
            Dictionary<int, Stack<char>> dict = new();
            Stack<char> stack1 = new();
            stack1.Push('Z');
            stack1.Push('N');

            Stack<char> stack2 = new();
            stack2.Push('M');
            stack2.Push('C');
            stack2.Push('D');

            Stack<char> stack3 = new();
            stack3.Push('P');

            dict.Add(1, stack1);
            dict.Add(2, stack2);
            dict.Add(3, stack3);

            return dict;
        }
        private Dictionary<int,Stack<char>> GetStacks()
        {
            Dictionary<int, Stack<char>> dict = new();
            Stack<char> stack1 = new();
            stack1.Push('L');
            stack1.Push('N');
            stack1.Push('W');
            stack1.Push('T');
            stack1.Push('D');

            Stack<char> stack2 = new();
            stack2.Push('C');
            stack2.Push('P');
            stack2.Push('H');

            Stack<char> stack3 = new();
            stack3.Push('W');
            stack3.Push('P');
            stack3.Push('H');
            stack3.Push('N');
            stack3.Push('D');
            stack3.Push('G');
            stack3.Push('M');
            stack3.Push('J');

            Stack<char> stack4 = new();
            stack4.Push('C');
            stack4.Push('W');
            stack4.Push('S');
            stack4.Push('N');
            stack4.Push('T');
            stack4.Push('Q');
            stack4.Push('L');

            Stack<char> stack5 = new();
            stack5.Push('P');
            stack5.Push('H');
            stack5.Push('C');
            stack5.Push('N');

            Stack<char> stack6 = new();
            stack6.Push('T');
            stack6.Push('H');
            stack6.Push('N');
            stack6.Push('D');
            stack6.Push('M');
            stack6.Push('W');
            stack6.Push('Q');
            stack6.Push('B');

            Stack<char> stack7 = new();
            stack7.Push('M');
            stack7.Push('B');
            stack7.Push('R');
            stack7.Push('J');
            stack7.Push('G');
            stack7.Push('S');
            stack7.Push('L');
            
            Stack<char> stack8 = new();
            stack8.Push('Z');
            stack8.Push('N');
            stack8.Push('W');
            stack8.Push('G');
            stack8.Push('V');
            stack8.Push('B');
            stack8.Push('R');
            stack8.Push('T');

            Stack<char> stack9 = new();
            stack9.Push('W');
            stack9.Push('G');
            stack9.Push('D');
            stack9.Push('N');
            stack9.Push('P');
            stack9.Push('L');

            dict.Add(1, stack1);
            dict.Add(2, stack2);
            dict.Add(3, stack3);
            dict.Add(4, stack4);
            dict.Add(5, stack5);
            dict.Add(6, stack6);
            dict.Add(7, stack7);
            dict.Add(8, stack8);
            dict.Add(9, stack9);

            return dict;
            
        }
    }
}
