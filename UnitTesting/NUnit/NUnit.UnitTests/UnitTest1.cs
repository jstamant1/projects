using NUnit.Framework;

namespace NUnit.UnitTests
{
    //Methods have to be simple
    //there should not be any logic in the tests
    //Every test should be isolated
    //Should not be too general

    //Naming convention <TestedClass>
    [TestFixture]
    public class Tests
    {
        //Always ran before every test
        [SetUp]
        public void Setup()
        {
        }

        //Naming conventions <TestedMethod>_<Scenario>_<ExeptectedResult>
        [Test]

        //If we don'twant to run a test the proper way is to use "ignore" so we don't forget to uncomment the test later on
        [Ignore("<Reason>")]

        //It's also possible to run the same test multiple time with different parameters
        [TestCase(1, 1, 1)]
        [TestCase(2, 3, 2)]
        [TestCase(3, 3, 3)]
        [TestCase(4, 4, 4)]
        public void Test1(int a, int b, int expectedValue)
        {
            //Arrange

            //Act

            //Assert

            //Can have multiple "Assert"
            Assert.Pass();
        }
    }
}