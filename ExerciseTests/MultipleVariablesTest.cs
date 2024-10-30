using Exercises;

namespace ExerciseTests
{
    [TestFixture]
    public class MultipleVariablesTest
    {
        [Test]
        public void TestingMultiVariable()
        {
            Assert.That(MultipleVariables.MultiVariableInt(), Is.EqualTo(31));
        }
    }
}
