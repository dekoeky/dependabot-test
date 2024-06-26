using ClassLibrary;

namespace TestProject1;

/// <summary>
/// <see cref="MyHasher"/> related tests.
/// </summary>
[TestClass]
public class MyHasherTests
{
    [TestMethod]
    public void Hash()
    {
        //Arrange
        var input = "Hello World";
        var hasher = new MyHasher();
        Console.WriteLine($"Input: {input}");

        //Act
        var hash = hasher.Hash(input);
        Console.WriteLine($"Hash: {hash}");

        //Assert
        Assert.IsFalse(string.IsNullOrEmpty(hash));
        Assert.IsFalse(string.IsNullOrWhiteSpace(hash));
    }
}