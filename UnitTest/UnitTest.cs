namespace UnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var result = SpyGame.SpyGame.performJumpFive("I have 500 cards in my 700$ pants");
            //performing test
            Assert.That(result, Is.EqualTo("I have 055 cards in my 355$ pants"));
        }

        [Test]
        public void Test2()
        {
            var result = SpyGame.SpyGame.performJumpFive("There are 211 birds in those 4 cages");
            //performing test
            Assert.That(result, Is.EqualTo("There are 899 birds in those 6 cages"));
        }
    }
}