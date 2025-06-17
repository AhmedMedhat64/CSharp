using CSharpFundamentals.Apps.RandomStringNumberDictionary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSharpFundamentals.Apps.PasswordManager
{
    public class EncryptionAndDecryption
    {
        private static readonly string EncryptingAndDecryptingStr = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        /*
         * I want to try to methods in solution
         * first: using numbers from 0 to EncryptingAndDecryptingStr.Length - 1
         * second: using ASCII Value of letters in EncryptingAndDecryptingStr
         */
        // Encrypting matrix 2d matrix
        // calc decrypting matix (Method) return type 2d matrix
        // string with all capiitial letters and small and nums from 0 to 9
        // check the length of the password 
        // what to do if length is odd in encryption
        // what to do if length is odd in decryption

        // lets start 
        

        private static bool IsOdd = false;

        private static int[,] EncryptingMatrix = new int[2, 2];

        private static void IntializingEncryptingMatrix(int[] arrayElements)
        {
            for (int i = 0; i < arrayElements.Length; i++)
            {
                var rnd = new Random();
                int value = rnd.Next(1, 100);
                arrayElements[i] = value;
            }

            int count = 0;
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    EncryptingMatrix[i,j] = arrayElements[count++];
                }
            }
        }

        private static int[][] calcDectyptingMatrix(int[][] EncryptingMatrix)
        {

        }

        public static string Encrypt(string password)
        {
            if (password.Length % 2 == 1)
            {
                password += 'Z';
                IsOdd = true;
            }
        }

        public static string Decrypt(string password, bool IsOdd)
        {
            var ZIndex = password.IndexOf('Z');
            if (IsOdd) // password was odd but not is even so we must make it odd once again
            {
                password = password.Substring(0, ZIndex);
            }
        }
    }
}
