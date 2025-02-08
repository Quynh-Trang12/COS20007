using SwinAdventure;
namespace TestBag
{
    public class Tests
    {
        private Bag _TestBag;
        private Item _TestSword;
        private Item _TestBall;

        [SetUp]
        public void Setup()
        {
            _TestBag = new Bag(new string[] { "bag" }, "bag", "This is a bag");
            _TestSword = new Item(new string[] { "sword" }, "bronze sword", "This is a bronze sword");
            _TestBall = new Item(new string[] { "ball" }, "tennis ball", "This is a tennis ball");
            _TestBag.Inventory.Put(_TestBall);
            _TestBag.Inventory.Put(_TestSword);
        }

        [Test]
        public void TestBagLocatesItems()
        {
            Assert.IsTrue(_TestBag.Inventory.HasItem("sword"));
            Assert.IsTrue(_TestBag.Inventory.HasItem("ball"));
            Assert.AreEqual(_TestBag.Locate("sword"), _TestSword);          
        }
        [Test]
        public void TestBagLocateItself()
        {
            Assert.AreEqual(_TestBag.Locate("bag"), _TestBag);
        }
        [Test]
        public void TestBagLocatesNothing()
        {
            Assert.IsNull(_TestBag.Locate("bike"));
        }
        [Test]
        public void TestBagFullDescription()
        {
            Assert.AreEqual(_TestBag.FullDescription, $"In the bag you can see: {_TestBag.Inventory.ItemList}");
        }
        [Test]
        public void TestBagInBag()
        {
            Bag b1 = new Bag(new string[] { "b1" }, "b1", "This is b1");
            Bag b2 = new Bag(new string[] { "b2" }, "b2", "This is b2");

            b1.Inventory.Put(b2);

            Assert.AreEqual(b1.Locate("b2"), b2);

            b1.Inventory.Put(_TestSword);           

            Assert.AreEqual(b1.Locate("sword"), _TestSword);
            
            b2.Inventory.Put(_TestBall);

            Assert.IsFalse(b1.Inventory.HasItem("ball"));
        }
    }
}