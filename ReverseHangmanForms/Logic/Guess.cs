using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace ReverseHangmanForms.Logic
{
    public class Guess
    {
        // Fields
        Team _guesser;
        WordClass _wordClass;

        // Properties
        public string Letter { get; private set; }

        // Methods
        public Guess(string letter, Team guesser, WordClass wordClass)
        {
            _guesser = guesser;
            _wordClass = wordClass;

            Letter = letter;
            _guesser.GuessCollection.SaveGuess(this);
            GuessIsInWord(_wordClass.CheckIfWordContainsLetter(Letter));
        }

        void PlayRandomFart()
        {
            SoundPlayer soundPlayer = new SoundPlayer(Fart.GetRandomFart());
            soundPlayer.Play();
        }

        void GuessIsInWord(bool guessIsInWord)
        {
            if (guessIsInWord)
            {
                WrongGuess();
            }

            //if (UnderGoal() && _teamCollection.GetTeamList()[0].Lives == 0)
            //{
            //    // Tie
            //}
            //else if (UnderGoal())
            //{
            //    // You won
            //}
        }

        void WrongGuess()
        {
            _guesser.LoseLife();
            PlayRandomFart();
        }
    }
}
