namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestBookCreation() 
        {
            Book book = new Book { Title = "C# Programming", Author = "John Smith"};
            Assert.AreEqual("C# Programming", book.Title);
            Assert.AreEqual("John Smith", book.Author);


        }

        [TestMethod]
        public void TestMagazineCreation()
        {
            magazine magazine = new magazine { Title = "Tech Weekly", Author = "John Smith", IssueNumber = 12 };
            Assert.AreEqual("Tech Weekly", magazine.Title);
            Assert.AreEqual(12, magazine.IssueNumber);


        }
    }
}