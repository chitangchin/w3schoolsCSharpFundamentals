using Exercises;

namespace ExerciseTests
{
    [TestFixture]
    public class DisplayVariablesTest
    {
        [Test]
        public void TestingConsoleWriteLine()
        {
            Assert.That(DisplayVariables.ConsoleWriteLine(), Is.EqualTo("This is how you display text on the console window"));
        }
        [Test]
        public void TestingVariableConsoleWriteLine()
        {
            Assert.That(DisplayVariables.VariableConsoleWriteLine(), Is.EqualTo("You can use this in a Console.WriteLine"));
        }
        [Test]
        public void TestConcatConsoleWriteLine()
        {
            Assert.That(DisplayVariables.ConcatConsoleWriteLine(), Is.EqualTo("You can also add together variables of the same type!"));
        }
    }
}
