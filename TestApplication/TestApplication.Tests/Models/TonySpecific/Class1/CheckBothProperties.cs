namespace TestApplication.Tests.Models.TonySpecific.Class1
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Class1 = TestApplication.Models.TonySpecific.Class1;

    [TestClass]
    public class CheckBothProperties
    {
        [TestMethod]
        public void MyPropertyGreaterThanZero_NewPropertyOver100_ShouldReturnFalse()
        {
            // ARRANGE
            var classUnderTest = new Class1() { MyProperty = 3, NewProperty = 110 };

            // ACT
            var actual = classUnderTest.CheckBothProperties();

            // ASSERT
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void MyPropertyLessThanZero_NewPropertyOver100_ShouldReturnFalse()
        {
            // ARRANGE
            var classUnderTest = new Class1() { MyProperty = -5, NewProperty = 110 };

            // ACT
            var actual = classUnderTest.CheckBothProperties();

            // ASSERT
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void MyPropertyLessThanZero_NewPropertyUnder100_ShouldReturnFalse()
        {
            // ARRANGE
            var classUnderTest = new Class1() { MyProperty = -5, NewProperty = 11 };

            // ACT
            var actual = classUnderTest.CheckBothProperties();

            // ASSERT
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void MyPropertyGreaterThanZero_NewPropertyUnder100_ShouldReturnTrue()
        {
            // ARRANGE
            var classUnderTest = new Class1() { MyProperty = 5, NewProperty = 11 };

            // ACT
            var actual = classUnderTest.CheckBothProperties();

            // ASSERT
            Assert.IsTrue(actual);
        }
    }
}