using Exercises;

namespace ExerciseTests
{
    [TestFixture]
    public class SyntaxTests
    {
        [Test]
        public void HelloWorldSyntaxTest()
        {
            Assert.That(Syntax.Main(), Is.EqualTo("Hello World!"));
        }
    }
}