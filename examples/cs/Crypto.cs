using System.Security.Cryptography;
using System.Text;

public class Crypto
{

  public static byte[] Encrypt(string plainText, string key)
  {
    byte[] encryptedBytesWithIv;
    using (Aes aes = Aes.Create())
    {
      // Hash the key to ensure it's 256 bits long
      aes.Key = SHA256.HashData(Encoding.UTF8.GetBytes(key));
      aes.GenerateIV();

      ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);
      byte[] plainBytes = Encoding.UTF8.GetBytes(plainText);

      using var encryptedStream = new MemoryStream();
      using (var cryptoStream = new CryptoStream(encryptedStream, encryptor, CryptoStreamMode.Write))
      {
        cryptoStream.Write(plainBytes, 0, plainBytes.Length);
        cryptoStream.FlushFinalBlock();
      }

      // Prepend the IV to the encrypted data
      byte[] encryptedBytes = encryptedStream.ToArray();
      encryptedBytesWithIv = new byte[aes.IV.Length + encryptedBytes.Length];
      Array.Copy(aes.IV, 0, encryptedBytesWithIv, 0, aes.IV.Length);
      Array.Copy(encryptedBytes, 0, encryptedBytesWithIv, aes.IV.Length, encryptedBytes.Length);
    }

    return encryptedBytesWithIv;
  }

  public static string Decrypt(byte[] encryptedDataWithIv, string key)
  {
    // Assuming the first 16 bytes are the IV
    byte[] iv = new byte[16];
    Array.Copy(encryptedDataWithIv, 0, iv, 0, iv.Length);

    // The rest is the encrypted data
    byte[] encryptedBytes = new byte[encryptedDataWithIv.Length - iv.Length];
    Array.Copy(encryptedDataWithIv, iv.Length, encryptedBytes, 0, encryptedBytes.Length);

    byte[] decryptedBytes;

    using (Aes aes = Aes.Create())
    {
      // Hash the key to ensure it's 256 bits long
      aes.Key = SHA256.HashData(Encoding.UTF8.GetBytes(key));
      aes.IV = iv; // Use the extracted IV

      ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

      using var decryptedStream = new MemoryStream();
      using (var cryptoStream = new CryptoStream(decryptedStream, decryptor, CryptoStreamMode.Write))
      {
        cryptoStream.Write(encryptedBytes, 0, encryptedBytes.Length);
        cryptoStream.FlushFinalBlock();
      }

      decryptedBytes = decryptedStream.ToArray();
    }

    return Encoding.UTF8.GetString(decryptedBytes);
  }
}