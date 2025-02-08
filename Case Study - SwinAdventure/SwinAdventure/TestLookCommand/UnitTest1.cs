using SwinAdventure;
namespace TestLookCommand
{
    public class Tests
    {
        private Look_Command Look;
        private Player TestPlayer;
        private Bag TestBag;
        private Item TestSword;
        private Item TestGem;
        private Item TestShovel;       

        [SetUp]
        public void Setup()
        {
            Look = new Look_Command();
            TestPlayer = new Player("bob","the player");
            TestBag = new Bag(new string[] { "bag" }, "a bag", "this is a bag");
            TestSword = new Item(new string[] { "sword" }, "bronze sword", "this is a brozne sword");
            TestGem = new Item(new string[] { "gem" }, "red gem", "this is a red gem");
            TestShovel = new Item(new string[] { "shovel" }, "small shovel", "this is a small shovel");

            TestPlayer.Inventory.Put(TestGem);
            TestPlayer.Inventory.Put(TestBag);
            TestBag.Inventory.Put(TestSword);
            TestBag.Inventory.Put(TestShovel);
        }

        [Test]
        public void TestLookAtMe()
        {
            Assert.AreEqual(Look.Execute(TestPlayer, new string[] { "look","at","me"}),TestPlayer.FullDescription);            
        }
        [Test]
        public void TestLookAtGem()
        {
            Assert.AreEqual(Look.Execute(TestPlayer, new string[] { "look", "at", "gem" }), TestGem.FullDescription);
        }
        [Test]
        public void TestLookAtUnk()
        {
            Assert.AreEqual(Look.Execute(TestPlayer, new string[] { "look", "at", "unk", "in", "inventory" }), "I can't find the unk");
        }
        [Test]
        public void TestLookAtGemInMe()
        {
            Assert.AreEqual(Look.Execute(TestPlayer, new string[] { "look", "at", "gem", "in", "inventory" }), TestGem.FullDescription);
        }
        [Test]
        public void TestLookAtGemInBag()
        {
            TestBag.Inventory.Put(TestGem);
            Assert.AreEqual(Look.Execute(TestPlayer, new string[] { "look", "at", "gem", "in", "bag" }), TestGem.FullDescription);
        }
        [Test]
        public void TestLookatGemInNoBag()
        {
            TestPlayer.Inventory.Take("bag");
            Assert.AreEqual(Look.Execute(TestPlayer, new string[] { "look", "at", "gem", "in", "bag" }), "I can't find the bag");
        }
        [Test]
        public void TestLookAtNoGemInBag()
        {
            TestPlayer.Inventory.Take("gem");
            Assert.AreEqual(Look.Execute(TestPlayer, new string[] { "look", "at", "gem" }), "I can't find the gem");
        }
        [Test]
        public void TestInvalidLook()
        {
            Assert.AreEqual(Look.Execute(TestPlayer, new string[] { "look"}), "I don't know how to look like that");

            Assert.AreEqual(Look.Execute(TestPlayer, new string[] { "feel", "at", "gem", "in", "bag" }), "Error in look input");

            Assert.AreEqual(Look.Execute(TestPlayer, new string[] { "look", "around", "gem", "or", "bag" }), "What do you want to look at?");

            Assert.AreEqual(Look.Execute(TestPlayer, new string[] { "look", "at", "gem", "before","bag" }), "What do you want to look in?");
        }
    }
}