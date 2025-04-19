using SwinAdventure;
namespace TestIdentifiableObj
{
    public class Tests
    {
        private IdentifiableObject _Object;
        private IdentifiableObject _EmptyObject;


        [SetUp]
        public void Setup()
        {
            _Object = new IdentifiableObject(new string[] { "fred", "bob" });
            _EmptyObject = new IdentifiableObject(new string[] { });

        }

        [Test]
        public void TestAreYou()
        {
            Assert.IsTrue(_Object.AreYou("bob"));
            Assert.IsTrue(_Object.AreYou("fred"));
        }

        [Test]
        public void TestNotAreYou()
        {
            Assert.IsFalse(_Object.AreYou("wilma"));
        }
        [Test]
        public void TestCaseSensetive()
        {
            Assert.IsTrue(_Object.AreYou("FReD"));
            Assert.IsTrue(_Object.AreYou("bOB"));
        }
        [Test]
        public void TestFirstID()
        {
            Assert.AreEqual("fred", _Object.FirstId);
        }
        [Test]
        public void TestFirstIDWithNoIDs()
        {
            Assert.AreEqual("", _EmptyObject.FirstId);
        }
        [Test]
        public void TestAddId()
        {
            _Object.AddIdentifier("wilma");
            Assert.IsTrue(_Object.AreYou("Wilma"));
            Assert.IsTrue(_Object.AreYou("fred"));
            Assert.IsTrue(_Object.AreYou("bob"));

        }
    }
}