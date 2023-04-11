namespace UnitTestingOgListOperasjoner.Test
{
    public class StatsTest
    {
        [Test]
        public void TestNoNumbers()
        {
            // arrange
            var stats = new Stats();

            // act

            // assert
            Assert.AreEqual(0, stats.NumberCount);
            Assert.AreEqual(0, stats.Sum);
            Assert.AreEqual(float.NaN, stats.Mean);
        }

        [Test]
        public void TestOneNumber()
        {
            // arrange
            var stats = new Stats();

            // act
            stats.AddNumber(10);

            // assert
            Assert.AreEqual(1, stats.NumberCount);
            Assert.AreEqual(10, stats.Sum);
            Assert.AreEqual(10, stats.Mean, 0.1f);
            //Assert.That(stats.Sum, Is.EqualTo(10));
        }

        [Test]
        public void TestNegativeNumbers()
        {
            // arrange
            var stats = new Stats();

            // act
            stats.AddNumber(-10);
            stats.AddNumber(6);

            // assert
            Assert.AreEqual(2, stats.NumberCount);
            Assert.AreEqual(-4, stats.Sum);
            Assert.AreEqual(-2, stats.Mean, 0.1f);
            //Assert.That(stats.Sum, Is.EqualTo(10));
        }

        //[Test]
        //public void TestBigNumbers()
        //{
        //    // arrange
        //    var stats = new Stats();

        //    // act
        //    stats.AddNumber(int.MaxValue);
        //    stats.AddNumber(int.MaxValue);

        //    // assert
        //    Assert.AreEqual(2, stats.NumberCount);
        //    Assert.AreEqual(10, stats.Sum);
        //    Assert.AreEqual(int.MaxValue, stats.Mean);
        //    //Assert.That(stats.Sum, Is.EqualTo(10));
        //}
    }
}