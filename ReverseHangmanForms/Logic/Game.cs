using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Remove this
using System.Media;
using System.IO;

namespace ReverseHangmanForms.Logic
{
    class Game
    {
        // Fields
        static Random _rnd = new Random();

        // Methods - Public
        public static string GetStripes(string word)
        {
            string stripes = "";
            foreach (char letter in word)
            {
                stripes += "_ ";
            }
            return stripes;
        }

        public static string GetLives(List<string> differentLetters, double livesNumber)
        {
            string livesText = "";
            for (int i = 0; i < livesNumber; i++)
            {
                livesText += "♥";
            }
            return livesText;
        }

        public static Stream GetRandomFart()
        {
            List<Stream> fartList = new List<Stream>();
            AddAllFarts(fartList);
            int randomFartIndex = _rnd.Next(0, fartList.Count);
            return fartList[randomFartIndex];
        }

        // Methods - Private
        private static void AddAllFarts(List<Stream> fartList)
        {
            fartList.Add(Properties.Resources.fart_01);
            fartList.Add(Properties.Resources.fart_02);
            fartList.Add(Properties.Resources.fart_03);
            fartList.Add(Properties.Resources.fart_04);
            fartList.Add(Properties.Resources.fart_05);
            fartList.Add(Properties.Resources.fart_06);
            fartList.Add(Properties.Resources.fart_07);
            fartList.Add(Properties.Resources.fart_08);
            fartList.Add(Properties.Resources.fart_09);
        }
    }
}
