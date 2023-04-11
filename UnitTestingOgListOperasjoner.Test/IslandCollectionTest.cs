using UnitTestingOgListOperasjoner.Islands;

namespace UnitTestingOgListOperasjoner.Test
{
    internal class IslandCollectionTest
    {
        [Test]
        public void TestGetIslandWithLongestName()
        {
            // arrange
            var islandCollection = new IslandCollection();

            // act
            var island = islandCollection.GetIslandWithLongestName();

            // assert
            Assert.AreEqual("Prince of Wales Island (Alaska)", island.Name);
        }

        [Test]
        public void TestGetAboveMinimum()
        {
            // arrange
            var islandCollection = new IslandCollection();

            // act
            var islands= islandCollection.GetIslandsAboveMinimum(600000);

            // assert
            Assert.AreEqual(3, islands.Count);
        }

        [Test]
        public void TestGetIslandsWithMoreThanOneCountry()
        {
            // arrange
            var islandCollection = new IslandCollection();

            // act
            var islands = islandCollection.GetIslandsByCountryCount(2);

            // assert
            Assert.AreEqual(8, islands.Count);
        }

        [Test]
        public void TestGetTop10()
        {

        }

        [Test]
        public void TestGetSorted()
        {

        }
    }
}
