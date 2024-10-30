using Exercises;

namespace ExerciseTests
{
    [TestFixture]
    public class ConstantsTest
    {
        [Test]
        public void TestingConstantFunction()
        {
            Assert.That(Constants.ConstantFunction(), Is.EqualTo(10));
        }
    }
}
