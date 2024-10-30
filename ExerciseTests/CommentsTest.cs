using Exercises;

namespace ExerciseTests
{
    [TestFixture]
    public class CommentsTest
    {
        [Test]
        public void TestingCommentVisibility()
        {
            Assert.That(Comments.Main(), Is.EqualTo("This string was written at 7:49pm on 10/29/2024"));
        }
    }
}
