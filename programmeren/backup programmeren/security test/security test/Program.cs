using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace security_test
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] encrypted;
            //Hash functions map binary strings of an arbitrary length to small binary strings of a fixed length. 
            //A cryptographic hash function has the property that it is computationally infeasible to find two distinct inputs that hash to the same value; 
            //that is, hashes of two sets of data should match if the corresponding data also matches. 
            //Small changes to the data result in large, unpredictable changes in the hash.
            MD5CryptoServiceProvider mD5 = new MD5CryptoServiceProvider();

            //UTF-8 is a Unicode encoding that represents each code point as a sequence of one to four bytes. 
            //Unlike the UTF-16 and UTF-32 encodings, the UTF-8 encoding does not require "endianness"; 
            //the encoding scheme is the same regardless of whether the processor is big-endian or little-endian. 
            UTF8Encoding utf8 = new UTF8Encoding();

            //This algorithm supports key lengths from 128 bits to 192 bits in increments of 64 bits.
            TripleDESCryptoServiceProvider tDES = new TripleDESCryptoServiceProvider();

            Console.WriteLine("ENTER KEY");
            tDES.Key = mD5.ComputeHash(utf8.GetBytes(Console.ReadLine()));
            tDES.Mode = CipherMode.ECB;
            tDES.Padding = PaddingMode.PKCS7;
            ICryptoTransform trans = tDES.CreateEncryptor();
            ICryptoTransform dtrans = tDES.CreateDecryptor();
            //encrypt
            Console.WriteLine("ENCRYPT (e) OR DECRYPT (d)?");
            string answer = Console.ReadLine();
            if (answer == "e")
            {
                Console.WriteLine("Type in your string");
                string temp = Console.ReadLine();
                encrypted = trans.TransformFinalBlock(utf8.GetBytes(temp), 0, utf8.GetBytes(temp).Length);
                Console.WriteLine(BitConverter.ToString(encrypted));

                Console.WriteLine("DO YOU WANT TO DECRYPT IT AGAIN? YES(y) NO(n)");
                answer = Console.ReadLine();
                if (answer == "y")
                {
                    Console.WriteLine(utf8.GetString(dtrans.TransformFinalBlock(encrypted, 0, encrypted.Length)));
                }
                else if (answer == "n")
                {
                    Console.WriteLine("THANK YOU FOR USING OUR PROGRAM.");
                }
            }
            //decrypt
            //vb decrypt: DD-80-2C-44-AD-00-CA-D4
            //convertfrombastestrin64()??
            else if (answer == "d")
            {
                Console.WriteLine("Type in your string");
                string temp = Console.ReadLine();
                //PROBLEEM
                encrypted = utf8.GetBytes(temp);
                Console.WriteLine(utf8.GetString(dtrans.TransformFinalBlock(encrypted, 0, encrypted.Length)));
            }
            Console.ReadLine();
        }
    }
}
