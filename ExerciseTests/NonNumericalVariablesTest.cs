using Exercises;

namespace ExerciseTests
{
    [TestFixture]
    public class NonNumericalVariablesTest
    {
        [Test]
        public void CharTest()
        {
            Assert.That(NonNumericalVariables.CharFunction(), Is.EqualTo('a'));
        }
        [Test]
        public void StringTest()
        {
            Assert.That(NonNumericalVariables.StringFunction(), Is.EqualTo("Hello World!"));
        }
        [Test]
        public void BoolTest()
        {
            Assert.That(NonNumericalVariables.BoolFunction(), Is.False);
        }
    }
}
