using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace VRPLancher.Sources
{
    static class Cryptography
    {
        public static string getFolderHash(HashAlgorithm hashAlgorithm, string folerPath, string filesFilter, SearchOption searchOption)
        {
            List<string> files = Directory.GetFiles(folerPath, filesFilter, SearchOption.AllDirectories).OrderBy(p => p).ToList();

            HashAlgorithm algorithm = hashAlgorithm;
            for (int iteration = 0; iteration < files.Count; iteration++)
            {
                string file = files[iteration];

                string relativePath = file.Substring(folerPath.Length + 1);
                byte[] pathBytes = Encoding.UTF8.GetBytes(relativePath.ToLower());
                algorithm.TransformBlock(pathBytes, 0, pathBytes.Length, pathBytes, 0);

                byte[] contentBytes = File.ReadAllBytes(file);
                if (iteration == files.Count - 1)
                    algorithm.TransformFinalBlock(contentBytes, 0, contentBytes.Length);
                else
                    algorithm.TransformBlock(contentBytes, 0, contentBytes.Length, contentBytes, 0);
            }
            try { var value = BitConverter.ToString(algorithm.Hash).Replace("-", "").ToLower(); }
            catch (Exception) { return "no files"; }

            return BitConverter.ToString(algorithm.Hash).Replace("-", "").ToLower();
        }
        public static string getFolderHashSHA1(string folerPath, string filesFilter, SearchOption searchOption)
        {
            List<string> files = Directory.GetFiles(folerPath, filesFilter, SearchOption.AllDirectories).OrderBy(p => p).ToList();

            SHA1 sha1 = SHA1.Create();
            for (int iteration = 0; iteration < files.Count; iteration++)
            {
                string file = files[iteration];

                string relativePath = file.Substring(folerPath.Length + 1);
                byte[] pathBytes = Encoding.UTF8.GetBytes(relativePath.ToLower());
                sha1.TransformBlock(pathBytes, 0, pathBytes.Length, pathBytes, 0);

                byte[] contentBytes = File.ReadAllBytes(file);
                if (iteration == files.Count - 1)
                    sha1.TransformFinalBlock(contentBytes, 0, contentBytes.Length);
                else
                    sha1.TransformBlock(contentBytes, 0, contentBytes.Length, contentBytes, 0);
            }
            try { var value = BitConverter.ToString(sha1.Hash).Replace("-", "").ToLower(); }
            catch (Exception) { return "no files"; }

            return BitConverter.ToString(sha1.Hash).Replace("-", "").ToLower();
        }

        public static string getFileHash(HashAlgorithm hashAlgorithm, byte[] file) {
            return BitConverter.ToString(hashAlgorithm.ComputeHash(file));
        }

        public static string getFileHash(HashAlgorithm hashAlgorithm, Stream inputStream) {
            return BitConverter.ToString(hashAlgorithm.ComputeHash(inputStream));
        }

        public static string getStringHash(HashAlgorithm hashAlgorithm, string input) {
            return BitConverter.ToString(hashAlgorithm.ComputeHash(Encoding.UTF8.GetBytes(input)));
        }

        public static string getStringHash(HashAlgorithm hashAlgorithm, string input, Encoding encoding)
        {
            return BitConverter.ToString(hashAlgorithm.ComputeHash(encoding.GetBytes(input)));
        }
    }
}
