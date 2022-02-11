using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseHangmanForms.Logic
{
    internal class GuessCollection
    {
        // Fields
        public List<string> guessedLetters = new List<string>();

        // Properties
        public int Goal { get; private set; }

        // Methods
        public void AddGuess(Guess guess)
        {
            guessedLetters.Add(guess.Letter);
        }
        
        public int CalculateGoal(List<string> differentLetters)
        {
            return differentLetters.Count * 2;
        }
    }
}
