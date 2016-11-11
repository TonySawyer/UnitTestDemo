namespace TestApplication.Tests.Models.TonySpecific.Class1
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Class1 = TestApplication.Models.TonySpecific.Class1;

    [TestClass]
    public class CheckMyProperty
    {
        [TestMethod]
        public void MyPropertyGreaterThanZero_ShouldReturnTrue()
        {
            // ARRANGE
            var classUnderTest = new Class1() { MyProperty = 5 };

            // ACT
            var actual = classUnderTest.CheckMyProperty();

            // ASSERT
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void MyPropertyLessThanZero_ShouldReturnTrue()
        {
            // ARRANGE
            var classUnderTest = new Class1() { MyProperty = -5 };

            // ACT
            var actual = classUnderTest.CheckMyProperty();

            // ASSERT
            Assert.IsFalse(actual);
        }
    }
}