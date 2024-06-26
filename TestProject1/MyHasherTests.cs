using ClassLibrary;
using Renci.SshNet;
using SshNet.Security.Cryptography;

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

    [DataTestMethod]
    [DataRow(typeof(SshClient), "2016.0.0")]
    [DataRow(typeof(SHA256), "1.3.0")]
    public void MaxVersion(Type type, string versionString)
    {
        //Arrange
        var expectedMax = Version.Parse(versionString);

        //Act
        var version = type.Assembly.GetName().Version;

        //Assert
        Assert.IsNotNull(version);
        Assert.IsTrue(version.Major <= expectedMax.Major);
        Console.WriteLine(version);
    }
}