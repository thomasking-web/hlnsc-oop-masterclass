// Notice how we do not need to do `using` for the `Person` class - it is in the same namespace as the `Program` class.
using System.Security.Cryptography;

namespace cs
{
  class Program
  {
    static void Main(string[] args)
    {
      Person person = new("John Doe", 30, "Student");

      // print the person object
      Console.WriteLine(person.ToString());

      // update the person object
      person.SetName("Jane Doe");
      person.SetAge(25);
      person.SetEmploymentStatus("Unemployed");

      // print the updated person object
      Console.WriteLine(person.ToString());

      // Cryptography example
      string text = "Hello, World!";
      // Generate a random AES key from the Cryptography library
      using (var rng = RandomNumberGenerator.Create())
      {
        byte[] key = new byte[256 / 8]; // Convert bit size to byte size
        rng.GetBytes(key); // Fill the array with cryptographically secure random bytes
        string keyAsString = Convert.ToBase64String(key);

        // Encrypt the text
        byte[] encryptedBytes = Crypto.Encrypt(text, keyAsString);
        string encryptedTextBase64 = Convert.ToBase64String(encryptedBytes);
        Console.WriteLine($"Encrypted text: {encryptedTextBase64}");

        // Decrypt the text
        byte[] encryptedBytesFromBase64 = Convert.FromBase64String(encryptedTextBase64);
        string decryptedText = Crypto.Decrypt(encryptedBytesFromBase64, keyAsString);
        Console.WriteLine($"Decrypted text: {decryptedText}");
      }
    }
  }
}