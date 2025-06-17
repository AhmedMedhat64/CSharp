using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals.Apps.PasswordManager
{ 
    public class EncryptionUtility
    {
        private static readonly string _originalChars = @"ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789({<]!#$%&*+-/=?@\|_[>})";
        private static readonly string _altChars =      @"ztNJP!bMp)Ds[/EnG=&(0Riq*Hf6]\VL%aY5AIZx9@4v_1d<BmFyTlw2CS>o{eK}?g#87UQh+jr|OcuX-Wk$3";

        public static string Encrypt(string password)
        {
            var sb = new StringBuilder();
            foreach (char ch in password) 
            {
                var charIndex = _originalChars.IndexOf(ch);
                sb.Append(_altChars[charIndex]);
            }
            return sb.ToString();
        }

        public static string Decrypt(string password)
        {
            var sb = new StringBuilder();
            foreach (char ch in password)
            {
                var charIndex = _altChars.IndexOf(ch);
                sb.Append(_originalChars[charIndex]);
            }
            return sb.ToString();
        }
    }
}
