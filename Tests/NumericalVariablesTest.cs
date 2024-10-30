using Exercises;

namespace ExerciseTests
{
    [TestFixture]
    public class NumericalVariablesTest
    {
        [Test]
        public void SbyteFunctionTest()
        {
            // Arrange
            sbyte expected = -128;

            // Act
            sbyte actual = NumericalVariables.SbyteFunction();

            // Assert
            Assert.That(actual, Is.EqualTo(expected), "SbyteFunction did not return the expected value.");
        }

        [Test]
        public void ByteFunctionTest()
        {
            // Arrange
            byte expected = 255;

            // Act
            byte actual = NumericalVariables.ByteFunction();

            // Assert
            Assert.That(actual, Is.EqualTo(expected), "ByteFunction did not return the expected value.");
        }

        [Test]
        public void ShortFunctionTest()
        {
            // Arrange
            short expected = -32768;

            // Act
            short actual = NumericalVariables.ShortFunction();

            // Assert
            Assert.That(actual, Is.EqualTo(expected), "ShortFunction did not return the expected value.");
        }

        [Test]
        public void UShortFunctionTest()
        {
            // Arrange
            ushort expected = 65535;

            // Act
            ushort actual = NumericalVariables.UShortFunction();

            // Assert
            Assert.That(actual, Is.EqualTo(expected), "UShortFunction did not return the expected value.");
        }

        [Test]
        public void IntegerFunctionTest()
        {
            // Arrange
            int expected = -2147483647;

            // Act
            int actual = NumericalVariables.IntegerFunction();

            // Assert
            Assert.That(actual, Is.EqualTo(expected), "IntegerFunction did not return the expected value.");
        }

        [Test]
        public void UIntFunctionTest()
        {
            // Arrange
            uint expected = 4294957295;

            // Act
            uint actual = NumericalVariables.UIntFunction();

            // Assert
            Assert.That(actual, Is.EqualTo(expected), "UIntFunction did not return the expected value.");
        }

        [Test]
        public void LongFunctionTest()
        {
            // Arrange
            long expected = -9223372036854775808;

            // Act
            long actual = NumericalVariables.LongFunction();

            // Assert
            Assert.That(actual, Is.EqualTo(expected), "LongFunction did not return the expected value.");
        }

        [Test]
        public void UlongFunctionTest()
        {
            // Arrange
            ulong expected = 18446744073709551615;

            // Act
            ulong actual = NumericalVariables.UlongFunction();

            // Assert
            Assert.That(actual, Is.EqualTo(expected), "UlongFunction did not return the expected value.");
        }

        [Test]
        public void NIntFunctionTest()
        {
            // Arrange
            nint expected = nint.MaxValue;

            // Act
            nint actual = NumericalVariables.NIntFunction();

            // Assert
            Assert.That(actual, Is.EqualTo(expected), "NIntFunction did not return the expected value.");
        }

        [Test]
        public void NuIntFunctionTest()
        {
            // Arrange
            nuint expected = nuint.MaxValue;

            // Act
            nuint actual = NumericalVariables.NuIntFunction();

            // Assert
            Assert.That(actual, Is.EqualTo(expected), "NuIntFunction did not return the expected value.");
        }

        [Test]
        public void FloatFunctionTest()
        {
            // Arrange
            float expected = 1.112341232f; // Float precision limits the number of digits
            float actual = NumericalVariables.FloatFunction();

            // Act & Assert
            Assert.That(actual, Is.EqualTo(expected).Within(1e-6f), "FloatFunction did not return the expected value within tolerance.");
        }

        [Test]
        public void DoubleFunctionTest()
        {
            // Arrange
            double expected = -0.12345678910111212; // Double precision limits the number of digits
            double actual = NumericalVariables.DoubleFunction();

            // Act & Assert
            Assert.That(actual, Is.EqualTo(expected).Within(1e-15), "DoubleFunction did not return the expected value within tolerance.");
        }

        [Test]
        public void DecimalFunctionTest()
        {
            // Arrange
            decimal expected = 1.1111111111111111111111111111m;
            decimal actual = NumericalVariables.DecimalFunction();

            // Act & Assert
            Assert.That(actual, Is.EqualTo(expected), "DecimalFunction did not return the expected value.");
        }
    }
}
