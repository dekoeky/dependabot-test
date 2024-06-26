using SshNet.Security.Cryptography;
using System.Text;

namespace ClassLibrary;

/// <summary>
/// Demo type to test dependabot.
/// </summary>
public class MyHasher
{
    public static readonly SHA256 Sha = new();
    private static readonly Encoding Encoding = Encoding.ASCII;

    public string Hash(string input)
    {
        var bytes = Encoding.GetBytes(input);
        var hashBytes = Sha.ComputeHash(bytes);
        var hash = Convert.ToBase64String(hashBytes);

        return hash;
    }
}
