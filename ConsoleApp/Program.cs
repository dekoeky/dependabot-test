
using ClassLibrary;

var hasher = new MyHasher();

while (true)
{
    Console.WriteLine();
    Console.WriteLine("Enter some text to be hashed and press enter...");
    var input = Console.ReadLine();

    if (input is null) continue;
    if (input.ToLower() == "exit") break;

    var hash = hasher.Hash(input);
    Console.WriteLine($"Hash: {hash}");
}