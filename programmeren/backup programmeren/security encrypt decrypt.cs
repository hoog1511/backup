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
        static UTF8Encoding utf8 = new UTF8Encoding();

        static TripleDES CreateDES(string key)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            TripleDES des = new TripleDESCryptoServiceProvider();
            des.Key = md5.ComputeHash(utf8.GetBytes(key));
            des.Mode = CipherMode.ECB;
            des.Padding = PaddingMode.PKCS7;
            return des;
        }
        static void Main()
        {
            Console.WriteLine("ENTER KEY");
            string key = Console.ReadLine();
            TripleDES des = CreateDES(key);
            //encrypt
            Console.WriteLine("ENCRYPT (e) OR DECRYPT (d)?");
            string answer = Console.ReadLine();
            if (answer == "e")
            {
                Console.WriteLine("Type in your string");
                ICryptoTransform ct = des.CreateEncryptor();
                byte[] input = utf8.GetBytes(Console.ReadLine());
                byte[] encrypted = ct.TransformFinalBlock(input, 0, input.Length);
                Console.WriteLine(Convert.ToBase64String(encrypted));
            }
            //decrypt
            else if (answer == "d")
            {
                Console.WriteLine("Type in your string");
                string CypherText = Console.ReadLine();
                byte[] b = Convert.FromBase64String(CypherText);
                ICryptoTransform ct = des.CreateDecryptor();
                byte[] input = ct.TransformFinalBlock(b, 0, b.Length);
                string decrypted = utf8.GetString(input);
                Console.WriteLine(decrypted);
            }
            else { Console.WriteLine("GEEN OPTIE."); }
            Console.ReadLine();
        }
    }
}
