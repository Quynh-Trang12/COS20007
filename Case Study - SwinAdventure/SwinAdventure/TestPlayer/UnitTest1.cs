using SwinAdventure;
using System.Numerics;

namespace TestPlayer
{
    public class Tests
    {
        private Player _TestPlayer;
        private Item _TestSword;
        private Item _TestBall;

        [SetUp]
        public void Setup()
        {
            _TestPlayer = new Player("bob", "the cool guy");
            _TestSword = new Item(new string[] { "sword" }, "bronze sword", "This is a bronze sword");
            _TestBall = new Item(new string[] { "ball" }, "tennis ball", "This is a tennis ball");
            _TestPlayer.Inventory.Put(_TestSword);
            _TestPlayer.Inventory.Put(_TestBall);
        }

        [Test]
        public void TestPlayerIsIdentifiable()
        {
            Assert.IsTrue(_TestPlayer.AreYou("me") && _TestPlayer.AreYou("inventory"));
        }
        [Test]
        public void TestPlayerLocatesItems()
        {
            Assert.AreEqual(_TestPlayer.Locate("ball"), _TestBall);
        }

        [Test]
        public void TestPlayerLocateItself()
        {
            Assert.AreEqual(_TestPlayer.Locate("me"), _TestPlayer);
        }

        [Test]
        public void PlayerLocatesNothing()
        {
            Assert.AreEqual(_TestPlayer.Locate("bike"), null);
        }
        [Test]
        public void PlayerFullDescription()
        {
            Assert.AreEqual(_TestPlayer.FullDescription, $"You are bob, the cool guy. You are carrying: a bronze sword (sword)\na tennis ball (ball)\n");
        }
 
    }
}