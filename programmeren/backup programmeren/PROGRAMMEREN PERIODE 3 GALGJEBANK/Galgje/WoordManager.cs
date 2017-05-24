using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galgje
{
    public class WordManager
    {
        
        internal string GetWord(int v)
        {
            string[] Wordlist = System.IO.File.ReadAllLines(@"C:\Users\larsh\Documents\Visual Studio 2015\Projects\PROGRAMMEREN PERIODE 3 GALGJEBANK\Galgje\woorden\NederlandseWoorden.txt");

            List<string> rightlength = new List<string>();
            foreach (string word in Wordlist)
            {
                if (word.Length == v)
                {
                    rightlength.Add(word);
                }
            }

            Random willekeurig = new Random();
            return rightlength[willekeurig.Next(0, rightlength.Count)];

        }
    }
}
