using SshNet.Security.Cryptography;
using System.Text;

namespace ClassLibrary;

/// <summary>
/// Demo type to test dependabot.
/// </summary>
public class MyHasher
{
    private readonly SHA256 _sha = new();
    private readonly Encoding _encoding = Encoding.ASCII;

    public string Hash(string input)
    {
        var bytes = _encoding.GetBytes(input);
        var hashBytes = _sha.ComputeHash(bytes);
        var hash = Convert.ToBase64String(hashBytes);

        return hash;
    }
}
