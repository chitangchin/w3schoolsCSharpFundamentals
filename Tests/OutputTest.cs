using Exercises;

namespace ExerciseTests
{
    [TestFixture]
    public class OutputTest
    {
        [Test]
        public void OutputTests()
        {
            Assert.That(Output.Main(), Is.EqualTo("Hello World!"));
        }
    }
}
