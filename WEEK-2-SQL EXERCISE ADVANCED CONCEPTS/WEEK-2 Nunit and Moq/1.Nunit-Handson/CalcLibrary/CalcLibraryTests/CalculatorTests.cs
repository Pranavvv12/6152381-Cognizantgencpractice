using NUnit.Framework;
using CalcLibrary;

namespace CalcLibraryTests
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator calc;

        [SetUp]
        public void Setup()
        {
            calc = new Calculator();
        }

        [TearDown]
        public void Teardown()
        {
            // Clean-up resources if needed
        }

        [Test]
        [TestCase(5, 10, 15)]
        [TestCase(-2, -3, -5)]
        [TestCase(0, 0, 0)]
        public void Add_WhenCalled_ReturnsExpectedResult(int a, int b, int expected)
        {
            int result = calc.Add(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [Ignore("Subtraction logic to be implemented later")]
        public void Subtract_ShouldReturnExpectedValue()
        {
            // This is a placeholder for a future test
        }

        [Test]
        [TestCase(6, 2, 3.0)]
        public void Divide_WhenCalled_ReturnsExpectedValue(int a, int b, double expected)
        {
            double result = calc.Divide(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Divide_ByZero_ThrowsException()
        {
            Assert.Throws<DivideByZeroException>(() => calc.Divide(5, 0));
        }
    }
}
