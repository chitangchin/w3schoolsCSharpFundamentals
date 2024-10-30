using Exercises;

namespace ExerciseTests
{
    [TestFixture]
    public class IdentifiersTest
    {
        [Test]
        public void TestingIdentifiersMethod()
        {
            Assert.That(Identifiers.IdentifyPractice(), Is.EqualTo(2));
        }
    }
}
