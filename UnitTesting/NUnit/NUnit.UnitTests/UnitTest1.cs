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
        [SetUp]
        public void Setup()
        {
        }

        //Naming conventions <TestedMethod>_<Scenario>_<ExeptectedResult>
        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}