using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseHangmanForms.Logic
{
    public class Team
    {
        // Fields
        static Random _rnd = new Random();

        // Properties
        public string Name { get; private set; }
        public int Score { get; private set; }
        public int Lives { get; private set; }
        public Roles Role { get; set; }

        // Methods
        public Team(string name)
        {
            Name = name;
        }

        public static string CreateRandomTeamName()
        {
            string randomTeamName = "";
            randomTeamName += AddRandomAdjective(_rnd);
            randomTeamName += AddBlankSpace();
            randomTeamName += AddRandomNoun(_rnd);
            return randomTeamName;
        }

        static string AddRandomAdjective(Random rnd)
        {
            Array values = Enum.GetValues(typeof(Adjectives));
            string randomAdjective = "" + (Adjectives)values.GetValue(rnd.Next(values.Length));
            return randomAdjective;
        }

        static string AddBlankSpace()
        {
            string blankSpace = " ";
            return blankSpace;
        }

        static string AddRandomNoun(Random rnd)
        {
            Array values = Enum.GetValues(typeof(Nouns));
            string randomNoun = "" + (Nouns)values.GetValue(rnd.Next(values.Length));
            return randomNoun;
        }

        public void LoseLife()
        {
            Lives--;
        }

        public void CalculateLives(List<string> differentLetters)
        {
            Lives = Convert.ToInt32(Math.Floor(differentLetters.Count / 2.0) + 1);
        }

    }
}
