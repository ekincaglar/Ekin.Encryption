using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.IO;

namespace Ekin.Encryption
{
    public static class Extensions
    {
        public static string Encrypt(this string str, string Key)
        {
            return AESThenHMAC.SimpleEncryptWithPassword(str, Key);
        }

        public static string Decrypt(this string str, string Key)
        {
            return AESThenHMAC.SimpleDecryptWithPassword(str, Key);
        }
    }
}