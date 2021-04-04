using Dedup.Interfaces;
using System;
using System.Security.Cryptography;

namespace Dedup.Core
{
    public class FileHasher : IFileHasher
    {
        public string GetHash(string path)
        {
            using (var md5 = MD5.Create())
            {
                using (var stream = System.IO.File.OpenRead(path))
                {
                    var hash = md5.ComputeHash(stream);
                    var str = BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                    return str;
                }
            }
        }
    }
}
