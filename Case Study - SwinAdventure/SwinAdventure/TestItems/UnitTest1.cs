using SwinAdventure;
namespace TestItems
{
    public class Tests
    {
        private Item _TestItem;

        [SetUp]
        public void Setup()
        {
            _TestItem = new Item(new string[] { "sword" }, "bronze sword", "This is a bronze sword");
        }

        [Test]
        public void TestItemIsIdentifiable()
        {
            Assert.IsTrue(_TestItem.AreYou("sword"));
        }
        [Test]
        public void TestShortDescription()
        {
            Assert.AreEqual(_TestItem.ShortDescription, "a bronze sword (sword)");
        }
        [Test]
        public void TestFullDescription()
        {
            Assert.AreEqual(_TestItem.FullDescription, "This is a bronze sword");
        }
    }
}