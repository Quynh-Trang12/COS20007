using SwinAdventure;
namespace TestInventory
{
    public class Tests
    {
        private Item _TestSword;
        private Inventory _TestInventory;
        private Item _TestBall;


        [SetUp]
        public void Setup()
        {
            _TestSword = new Item(new string[] { "sword" }, "bronze sword", "This is a bronze sword");
            _TestBall = new Item(new string[] { "ball" }, "tennis ball", "This is a tennis ball");
            _TestInventory = new Inventory();
            _TestInventory.Put(_TestSword);
            _TestInventory.Put(_TestBall);
        }

        [Test]
        public void TestFindItem()
        {
            Assert.NotNull(_TestInventory);
            Assert.IsTrue(_TestInventory.HasItem("sword"));
            Assert.IsTrue(_TestInventory.HasItem("ball"));
        }

        [Test]
        public void NoItemFind()
        {
            Assert.IsFalse(_TestInventory.HasItem("chicken"));
        }

        [Test]
        public void FetchItem()
        {
            Assert.AreEqual(_TestInventory.Fetch("sword"), _TestSword);
            Assert.AreEqual(_TestInventory.Fetch("ball"), _TestBall);
        }

        [Test]
        public void TakeItem()
        {
            Assert.AreEqual(_TestInventory.Take("sword"), _TestSword);
        }

        [Test]
        public void TestItemList()
        {
            Assert.AreEqual($"a bronze sword (sword)\na tennis ball (ball)\n", _TestInventory.ItemList);
        }
    }
}