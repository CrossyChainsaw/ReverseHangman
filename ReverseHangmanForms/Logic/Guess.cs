using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace ReverseHangmanForms.Logic
{
    internal class Guess
    {
        // Fields
        TeamCollection _teamCollection;
        GuessCollection _guessCollection;
        WordClass _wordClass;

        // Properties
        public string Letter { get; private set; }

        // Methods
        public Guess(string letter, GuessCollection guessCollection, TeamCollection teamCollection, WordClass wordClass)
        {
            _teamCollection = teamCollection;
            _guessCollection = guessCollection;
            _wordClass = wordClass;

            Letter = letter;
            guessCollection.AddGuess(this);
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
            _teamCollection.GetTeamList()[0].LoseLife();
            PlayRandomFart();
        }

        bool UnderGoal()
        {
            return (26 - _guessCollection.guessedLetters.Count < _guessCollection.Goal);
        }
    }
}
