using CSharpFundamentals.Apps.RandomStringNumberDictionary;
using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSharpFundamentals.Apps.PasswordManager
{ 

    public class EncryptionAndDecryption
    {
        // * I want to try to methods in solution
        // * first:  using numbers from 0 to EncryptingAndDecryptingStr.Length - 1
        // * second: using ASCII Value of letters in EncryptingAndDecryptingStr

        // Encrypting matrix 2d matrix
        // calc decrypting matix (Method) return type 2d matrix
        // string with all capiitial letters and small and nums from 0 to 9
        // check the length of the password 
        // what to do if length is odd in encryption
        // what to do if length is odd in decryption

        // lets start 
        private static Dictionary<int, char> EncryptingTable = new() {
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
        private static Dictionary<char, int> DecryptingTable = new() {
            { 'A' , 0 },
            { 'B' , 1 },
            { 'C' , 2 },
            { 'D' , 3 },
            { 'E' , 4 },
            { 'F' , 5 },
            { 'G' , 6 },
            { 'H' , 7 },
            { 'I' , 8 },
            { 'J' , 9 },
            { 'K' , 10 },
            { 'L' , 11 },
            { 'M' , 12 },
            { 'N' , 13 },
            { 'O' , 14 },
            { 'P' , 15 },
            { 'Q' , 16 },
            { 'R' , 17 },
            { 'S' , 18 },
            { 'T' , 19 },
            { 'U' , 20 },
            { 'V' , 21 },
            { 'W' , 22 },
            { 'X' , 23 },
            { 'Y' , 24 },
            { 'Z' , 25 },
            { 'a' , 26 },
            { 'b' , 27 },
            { 'c' , 28 },
            { 'd' , 29 },
            { 'e' , 30 },
            { 'f' , 31 },
            { 'g' , 32 },
            { 'h' , 33 },
            { 'i' , 34 },
            { 'j' , 35 },
            { 'k' , 36 },
            { 'l' , 37 },
            { 'm' , 38 },
            { 'n' , 39 },
            { 'o' , 40 },
            { 'p' , 41 },
            { 'q' , 42 },
            { 'r' , 43 },
            { 's' , 44 },
            { 't' , 45 },
            { 'u' , 46 },
            { 'v' , 47 },
            { 'w' , 48 },
            { 'x' , 49 },
            { 'y' , 50 },
            { 'z' , 51 },
            { '0' , 52 },
            { '1' , 53 },
            { '2' , 54 },
            { '3' , 55 },
            { '4' , 56 },
            { '5' , 57 },
            { '6' , 58 },
            { '7' , 59 },
            { '8' , 60 },
            { '9' , 61 }
        };

        static int[] modArray = {
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
        private static string IncAndDecCharacter = "A";

        private static void CalcEncryptingMatrix()
        {
            for (int i = 0; i < arrayElements.Length; i++)
            {
                var rnd = new Random();
                int value = rnd.Next(1, 200) % 62;
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

            EnryptingMatrixDet = (EncryptingMatrix[0, 0] * EncryptingMatrix[1, 1]) - (EncryptingMatrix[0, 1] * EncryptingMatrix[1, 0]);
            EnryptingMatrixDet = EnryptingMatrixDet % 62;
            if (EnryptingMatrixDet % 2 == 0 || EnryptingMatrixDet % 31 == 0 || EnryptingMatrixDet == 0)
                CalcEncryptingMatrix();
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
            CalcEncryptingMatrix();
            if (password.Length % 2 == 1)
            {
                password += IncAndDecCharacter;
                IsOdd = true;
            }
            var EncryptedPassword = new StringBuilder();
            int iterations = password.Length / 2;

            int count = 0;
            int FirstEle = 0; 
            int LastEle  = 0;
            int EleSum = 0;
            for (int i = 0; i < iterations; i++)
            {
                int[,] arr = new int[2, 1];
                arr[0, 0] = DecryptingTable[password[count]];
                arr[1, 0] = DecryptingTable[password[count++]];
                for (int j = 0; j < 2; j++)
                {
                    for (int k = 0; k < 2; k++)
                    {
                        EleSum += (arr[FirstEle++, LastEle] * EncryptingMatrix[k, j]);
                    }
                    EleSum = EleSum % 62;
                    EncryptedPassword.Append(EncryptingTable[EleSum]);
                    FirstEle = EleSum = 0;
                }
            }
            IncAndDecCharacter = EncryptedPassword.Length.ToString();
            return EncryptedPassword.ToString().Substring(0, EncryptedPassword.Length - 1);
        }

        public static string Decrypt(string password)
        {
            CalcDectyptingMatrix();
            var DecryptedPassword = new StringBuilder();
            if (IsOdd) // password was odd but not is even so we must make it odd once again
            {
                password += IncAndDecCharacter;
            }

            int iterations = password.Length / 2;

            int count = 0;
            int FirstEle = 0;
            int LastEle = 0;
            int EleSum = 0;
            for (int i = 0; i < iterations; i++)
            {
                int[,] arr = new int[2, 1];
                arr[0, 0] = DecryptingTable[password[count]];
                arr[1, 0] = DecryptingTable[password[count++]];
                for (int j = 0; j < 2; j++)
                {
                    for (int k = 0; k < 2; k++)
                    {
                        EleSum += (arr[FirstEle++, LastEle] * DecryptingMatrix[k, j]);
                    }
                    EleSum = EleSum % 62;
                    DecryptedPassword.Append(EncryptingTable[EleSum]);
                    FirstEle = EleSum = 0;
                }
            }

            // last part of the method
            IncAndDecCharacter = "A";
            return DecryptedPassword.ToString().Substring(0, DecryptedPassword.Length - 1);
        }
    }

}
