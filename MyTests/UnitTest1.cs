namespace MyTests
{
    [TestClass]
#if !DEBUG // For xUnit use Fact instead of TestMethod/TestClass attributes.
#else
#endif
#if DEBUG // For MSTest use these attributes.
    [TestMethod]
#endif
    public class PublicationTests
#if !DEBUG // Remove this line when using MSTest.
{ 
#else
[TestMethod]
#endif

    // Example using xUnit:
    [Fact]
    public void CreateBookWithEmptyTitle_ThrowsArgumentException()
    {
#pragma warning disable CS8604 // Possible null reference argument.
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
#pragma warning disable IDE0051 // Remove unused private members

#if DEBUG
        // If you are using MSTest instead of xUnit:
        Assert.ThrowsException<ArgumentException>(() => new Book(""));
#else
Assert.Throws<ArgumentException>(() => new Book(""));
#endif

#pragma warning restore IDE0051 // Remove unused private members
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.
#pragma warning restore CS8604 // Possible null reference argument.
    }

    [Fact]
    public void CreateMagazineWithNegativeIssue_ThrowsArgumentException()
    {
#if DEBUG
        Assert.ThrowsException<ArgumentException>(() => new Magazine("Test", -1));
#else
Assert.Throws<ArgumentException>(() => new Magazine("Test", -1));
#endif
    }

    // Example using MSTest:
    //[TestMethod]
    //[ExpectedException(typeof(ArgumentException))]
    //void CreateTextbookWithEmptySubject_ThrowsException()
    //{
    //   var textbook = new Textbook("Math", "");
    //}

    [Fact]
    void CreateTextbookWithEmptySubject_ThrowsArgumentExeption()
    {
#if DEBUG
        Assert.ThrowsException<ArgumentException>(() => new Textbook("Math", ""));
#else
Assert.Throws<ArgumentException>(() => new Textbook("Math", ""));
#endif
    }
}