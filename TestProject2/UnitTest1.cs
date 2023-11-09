namespace TestProject2
{
    public class Tests
    {
        [SetUp]
        public void Init()
        {
            Console.WriteLine("Setup Method");
        }
        [Test]
        [Order(2)]
        public void ABCD()
        {
            Console.WriteLine("Test 1 Method");
            Assert.AreEqual(1, 1);
            Assert.AreNotEqual(29, 39);


        }
        [Test]
        [Order(1)]
        public void EFGH()
        {
            Console.WriteLine("Test 2 Method");
            Assert.AreEqual(1, 1);
            Assert.AreNotEqual(29, 39);


        }
        [Test]
        [Order(0)]
        [Ignore("Code not ready")]
        public void IJKLM()
        {
            Console.WriteLine("Method 3");
        }
        [TearDown]
        public void Close()
        {
            Console.WriteLine("Close Method");
        }
       
        
    }
}