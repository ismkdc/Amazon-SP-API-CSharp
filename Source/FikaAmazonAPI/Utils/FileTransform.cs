using System;
using System.IO;
using System.IO.Compression;
using System.Security.Cryptography;

namespace FikaAmazonAPI.Utils
{
    public class FileTransform
    {
        public static string DecryptString(byte[] key, byte[] iv, byte[] cipherText)
        {
            var buffer = cipherText;

            using (var aes = Aes.Create())
            {
                aes.Key = key;
                aes.IV = iv;
                var decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                using (var memoryStream = new MemoryStream(buffer))
                {
                    using (var cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read))
                    {
                        using (var streamReader = new StreamReader(cryptoStream))
                        {
                            return streamReader.ReadToEnd();
                        }
                    }
                }
            }
        }


        public static string Decompress(string fileName)
        {
            var fileInfo = new FileInfo(fileName);

            using (var originalFileStream = fileInfo.OpenRead())
            {
                var currentFileName = fileInfo.FullName;
                var newFileName = currentFileName.Remove(currentFileName.Length - fileInfo.Extension.Length);

                using (var decompressedFileStream = File.Create(newFileName))
                {
                    using (var decompressionStream = new GZipStream(originalFileStream, CompressionMode.Decompress))
                    {
                        decompressionStream.CopyTo(decompressedFileStream);
                        Console.WriteLine($"Decompressed: {fileInfo.Name}");
                    }

                    return decompressedFileStream.Name;
                }
            }
        }
    }
}