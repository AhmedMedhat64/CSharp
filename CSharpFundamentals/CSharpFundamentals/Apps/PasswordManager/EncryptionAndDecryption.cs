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

        // * I want to try to methods in solution
        // * first: using numbers from 0 to EncryptingAndDecryptingStr.Length - 1
        // * second: using ASCII Value of letters in EncryptingAndDecryptingStr

        // Encrypting matrix 2d matrix
        // calc decrypting matix (Method) return type 2d matrix
        // string with all capiitial letters and small and nums from 0 to 9
        // check the length of the password 
        // what to do if length is odd in encryption
        // what to do if length is odd in decryption

        // lets start 
        private static readonly string EncryptingAndDecryptingStr = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        private static Dictionary<int, char> EncryptionTable = new() {
            { 0 , 'A' },
            { 1 , 'B' },
            { 2 , 'C' },
            { 3 , 'D' },
            { 4 , 'E' },
            { 5 , 'F' },
            { 6 , 'G' },
            { 7 , 'H' },
            { 8 , 'I' },
            { 9 , 'J' },
            { 10 , 'K' },
            { 11 , 'L' },
            { 12 , 'M' },
            { 13 , 'N' },
            { 14 , 'O' },
            { 15 , 'P' },
            { 16 , 'Q' },
            { 17 , 'R' },
            { 18 , 'S' },
            { 19 , 'T' },
            { 20 , 'U' },
            { 21 , 'V' },
            { 22 , 'W' },
            { 23 , 'X' },
            { 24 , 'Y' },
            { 25 , 'Z' },
            { 26 , 'a' },
            { 27 , 'b' },
            { 28 , 'c' },
            { 29 , 'd' },
            { 30 , 'e' },
            { 31 , 'f' },
            { 32 , 'g' },
            { 33 , 'h' },
            { 34 , 'i' },
            { 35 , 'j' },
            { 36 , 'k' },
            { 37 , 'l' },
            { 38 , 'm' },
            { 39 , 'n' },
            { 40 , 'o' },
            { 41 , 'p' },
            { 42 , 'q' },
            { 43 , 'r' },
            { 44 , 's' },
            { 45 , 't' },
            { 46 , 'u' },
            { 47 , 'v' },
            { 48 , 'w' },
            { 49 , 'x' },
            { 50 , 'y' },
            { 51 , 'z' },
            { 52 , '0' },
            { 53 , '1' },
            { 54 , '2' },
            { 55 , '3' },
            { 56 , '4' },
            { 57 , '5' },
            { 58 , '6' },
            { 59 , '7' },
            { 60 , '8' },
            { 61 , '9' }
        };

        static int[]  modArray = {
            1, 3, 5, 7, 11, 13, 17, 19,
            21, 23, 25, 27, 31, 33, 35, 37,
            39, 41, 43, 45, 47, 49, 53, 55,
            57, 59, 61
        };

        // The array with their corresponding modular inverses (mod 62)
        static int[] modInverseArray = {
            1, 21, 25, 9, 17, 43, 11, 49,
            3, 27, 5, 23, 2, 47, 53, 57,
            47, 45, 13, 55, 39, 19, 35, 45,
            37, 59, 61
        };

        private static bool IsOdd = false;
        private static int[] arrayElements = new int[4];
        private static int[,] EncryptingMatrix = new int[2, 2];
        private static int[,] DecryptingMatrix = new int[2, 2];
        private static int DecryptingMatrixCoefficient = 1;
        private static int EnryptingMatrixDet = 1;

        private static void IntializingEncryptingMatrix()
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

            EnryptingMatrixDet = (EncryptingMatrix[0, 0] * EncryptingMatrix[1, 1]) - (EncryptingMatrix[0, 1] * EncryptingMatrix[2, 2]);
            EnryptingMatrixDet = EnryptingMatrixDet % 62;
            if (EnryptingMatrixDet % 2 == 0 || EnryptingMatrixDet % 31 == 0 || EnryptingMatrixDet == 0)
                IntializingEncryptingMatrix();
            else
            {
                for (int i = 0; i < modArray.Length; i++)
                {
                    if (modArray[i] == EnryptingMatrixDet)
                    {
                        DecryptingMatrixCoefficient = modInverseArray[i];
                        break;
                    }
                }
            }
        }

        private static void CalcDectyptingMatrix()
        {
            int count = 3;
            for (int i = 1; i >= 0; i--)
            {
                for (int j = 1; j >= 0; j--)
                {
                    if (count == 2 || count == 1)
                        DecryptingMatrix[i, j] = -arrayElements[count--] * DecryptingMatrixCoefficient;
                    else 
                        DecryptingMatrix[i, j] =  arrayElements[count--] * DecryptingMatrixCoefficient; 
                }
            }
        }

        public static string Encrypt(string password)
        {
            IntializingEncryptingMatrix();
            int[,] arr = new int[2, 1];
            var EncryptedPassword = new StringBuilder();
            if (password.Length % 2 == 1)
            {
                password += 'A';
                IsOdd = true;
            }


        }

        public static string Decrypt(string password)
        {
            CalcDectyptingMatrix();
            // last part of the method
            var ZIndex = password.IndexOf('A');
            if (IsOdd) // password was odd but not is even so we must make it odd once again
            {
                password = password.Substring(0, ZIndex);
            }
        }
    }

}
