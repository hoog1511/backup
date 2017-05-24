using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galgje
{
    class Hangman
    {
        private string word;
        private string result;
        private int maxTurns = 11;
        private int turn;
        private List<char> letterhits = new List<char>();
        private List<char> guessedletters = new List<char>();


        public Hangman(string word, int maxTurns)
        {
            this.word = word;
            this.maxTurns = maxTurns;
            for (int i = 0; i <= word.Length - 1; i++) { letterhits.Add('_'); } // zorgt voor lege letter positie's

        }

        public string GetWordForDisplay()
        {
            result = "";
            foreach (char c in letterhits) // voor elk karakter dat geraden is, 
            {
                result += c;
            }
            return result;
        }

        public int TurnNumber()
        {
            return turn;
        }

        public bool Guess(char guess)
        {
            guessedletters.Add(guess);
            bool hit = false;
            int i = 0;
            while ((i = word.IndexOf(guess, i)) != -1)
            {
                hit = true;
                letterhits[i] = guess;
                i++;
            }
            if (hit)
            {
                return true;
            }
            turn += 1;
            return false;
        }

        public bool HasGuessedLetterBefore(char c)
        {
            foreach (char g in guessedletters)
            {
                if (c == g)
                {
                    turn += 1;
                    return true;
                }
            }
            return false;
        }

        public bool Winner()
        {
            if (result == word)
            {
                return true;
            }
            return false;
        }

        public bool Loser()
        {
            if (turn == maxTurns)
            {
                return true;
            }
            return false;
        }
    }
}
