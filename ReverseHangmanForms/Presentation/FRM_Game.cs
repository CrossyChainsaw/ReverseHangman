using ReverseHangmanForms.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReverseHangmanForms
{
    public partial class FRM_Game : Form
    {
        // Fields
        List<string> differentLettersInWord = new List<string>();
        List<string> guessedLetters = new List<string>();
        public TeamCollection teamCollection;
        Random rnd = new Random();
        string stripes = "_ x ?";
        string word = "";
        double lives;

        // Methods
        public FRM_Game(TeamCollection importTeamCollection)
        {
            InitializeComponent();
            this.teamCollection = importTeamCollection;
        }

        public void HandleGuess(string myLetter)
        {
            guessedLetters.Add(myLetter);
            stripes = "";
            bool guessIsInWord = CheckIfWordContainsLetter(myLetter);
            GuessIsInWord(guessIsInWord);
            UpdateStripes();
            UpdateRemainingLetters();
            CheckIfDead(lives);
            //end game
        }
        void CountDifferentLetters(string word, List<string> differentLetters)
        {
            for (int i = 0; i < word.Length; i++)
            {
                string letter = word.Substring(i, 1).ToUpper();

                if (i == 0) // first time dont check since its empty
                {
                    differentLetters.Add(letter);
                    LB_Test.Items.Add(letter);
                }
                else
                {
                    if (!differentLetters.Contains(letter))
                    {
                        differentLetters.Add(letter);
                        LB_Test.Items.Add(letter);
                    }
                }
            }
        }
        void DisplayLives(List<string> differentLetters)
        {
            lives = Math.Floor(differentLetters.Count / 2.0) + 1;
            LBL_Lives.Text = Game.GetLives(differentLetters, lives);
        }
        void DisplayStripes(string word)
        {
            LBL_Word.Text = Game.GetStripes(word);
        }
        void DeclareGoal(List<string> differentLetters)
        {
            LBL_Goal.Text = "Goal < " + differentLetters.Count * 2;
        }
        void PlayRandomFart()
        {
            SoundPlayer soundPlayer = new SoundPlayer(Game.GetRandomFart());
            soundPlayer.Play();
        }
        void WrongGuess()
        {
            lives = lives - 1;
            PlayRandomFart();
        }
        bool UnderGoal()
        {
            return (26 - guessedLetters.Count < differentLettersInWord.Count * 2);
        }
        void AddGuessedLettersToWord(int i, int j)
        {
            if (guessedLetters[j] == word.Substring(i, 1).ToUpper())
            {
                stripes += guessedLetters[j] + " ";
            }
        }
        bool CheckIfWordContainsLetter(string myLetter)
        {
            bool guessIsInWord = false;
            for (int i = 0; i < word.Length; i++)
            {
                if (word.Substring(i, 1).ToUpper() == myLetter)
                {
                    stripes += myLetter + " ";
                    guessIsInWord = true;
                }
                else if (guessedLetters.Contains(word.Substring(i, 1).ToUpper()))
                {
                    for (int j = 0; j < guessedLetters.Count; j++)
                    {
                        AddGuessedLettersToWord(i, j);
                    }
                }
                else
                {
                    stripes += "_ ";
                }
            }
            return guessIsInWord;
        }
        void GuessIsInWord(bool guessIsInWord)
        {
            if (guessIsInWord)
            {
                WrongGuess();
            }
            if (UnderGoal() && lives == 0)
            {
                MessageBox.Show("Tie");
            }
            else if (UnderGoal())
            {
                MessageBox.Show("You won");
            }
        }
        void GiveTeamsRandomRoles()
        {
            int randomNumber = rnd.Next(0, 2);
            if (randomNumber == 0)
            {
                teamCollection.GetTeamList()[0].Role = Roles.Wordmaster;
                teamCollection.GetTeamList()[1].Role = Roles.Guesser;
            }
            else
            {
                teamCollection.GetTeamList()[0].Role = Roles.Guesser;
                teamCollection.GetTeamList()[1].Role = Roles.Wordmaster;
            }
        }
        void CheckIfDead(double lives)
        {
            DisplayLives();
            if (lives == 0)
            {
                MessageBox.Show("No lives left");
            }
        }
        void DisplayLives()
        {
            LBL_Lives.Text = "";
            for (int i = 0; i < lives; i++)
            {
                LBL_Lives.Text += "♥";
            }
        }

        // Methods - Update
        void UpdateStripes()
        {
            LBL_Word.Text = stripes;
        }
        void UpdateRemainingLetters()
        {
            int remaingingLetters = 26 - guessedLetters.Count;
            LBL_RemainingLetters.Text = "Remaining Letters: " + remaingingLetters;
        }
        void UpdatePoints()
        {
            LBL_TeamOnePoints.Text = teamCollection.GetTeamList()[0].Name + ": " + teamCollection.GetTeamList()[0].Score;
            LBL_TeamTwoPoints.Text = teamCollection.GetTeamList()[1].Name + ": " + teamCollection.GetTeamList()[1].Score;
        }
        void UpdateRoleRelatedLabels()
        {
            foreach (Team team in teamCollection.GetTeamList())
            {
                if (team.Role == Roles.Wordmaster)
                {
                    LBL_Wordmaster.Text = "Wordmaster: " + team.Name;
                    LBL_TeamEnterWord.Text = team.Name + " enter a word";
                }
                else if (team.Role == Roles.Guesser)
                {
                    LBL_Guesser.Text = "Guesser: " + team.Name;
                }
            }
        }

        // Events
        private void FRM_Game_Load(object sender, EventArgs e)
        {
            GiveTeamsRandomRoles();
            UpdateRoleRelatedLabels();
            UpdatePoints();
        }
        private void BTN_Submit_Click(object sender, EventArgs e)
        {
            word = TB_Word.Text;

            CountDifferentLetters(word, differentLettersInWord);
            if (differentLettersInWord.Count > 3)
            {
                DeclareGoal(differentLettersInWord);
                DisplayStripes(word);
                DisplayLives(differentLettersInWord);
                GB_CreateWord.Enabled = false;
                GB_Guess.Enabled = true;
            }
            else
            {
                MessageBox.Show("Woord moet meer dan 3 verschillende letters hebben");
            }
        }
        private void TB_Word_TextChanged(object sender, EventArgs e)
        {
            // alleen letters
        } // Unfinished
        private void FRM_Game_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        // Letter buttons
        private void BTN_A_Click(object sender, EventArgs e)
        {
            BTN_A.Enabled = false;
            string myLetter = "A";
            HandleGuess(myLetter);
        }
        private void BTN_B_Click(object sender, EventArgs e)
        {
            BTN_B.Enabled = false;
            string myLetter = "B";
            HandleGuess(myLetter);
        }
        private void BTN_C_Click(object sender, EventArgs e)
        {
            BTN_C.Enabled = false;
            string myLetter = "C";
            HandleGuess(myLetter);
        }
        private void BTN_D_Click(object sender, EventArgs e)
        {
            BTN_D.Enabled = false;
            string myLetter = "D";
            HandleGuess(myLetter);
        }
        private void BTN_E_Click(object sender, EventArgs e)
        {
            BTN_E.Enabled = false;
            string myLetter = "E";
            HandleGuess(myLetter);
        }
        private void BTN_F_Click(object sender, EventArgs e)
        {
            BTN_F.Enabled = false;
            string myLetter = "F";
            HandleGuess(myLetter);
        }
        private void BTN_G_Click(object sender, EventArgs e)
        {
            BTN_G.Enabled = false;
            string myLetter = "G";
            HandleGuess(myLetter);
        }
        private void BTN_H_Click(object sender, EventArgs e)
        {
            BTN_H.Enabled = false;
            string myLetter = "H";
            HandleGuess(myLetter);
        }
        private void BTN_I_Click(object sender, EventArgs e)
        {
            BTN_I.Enabled = false;
            string myLetter = "I";
            HandleGuess(myLetter);
        }
        private void BTN_J_Click(object sender, EventArgs e)
        {
            BTN_J.Enabled = false;
            string myLetter = "J";
            HandleGuess(myLetter);
        }
        private void BTN_K_Click(object sender, EventArgs e)
        {
            BTN_K.Enabled = false;
            string myLetter = "K";
            HandleGuess(myLetter);
        }
        private void BTN_L_Click(object sender, EventArgs e)
        {
            BTN_L.Enabled = false;
            string myLetter = "L";
            HandleGuess(myLetter);
        }
        private void BTN_M_Click(object sender, EventArgs e)
        {
            BTN_M.Enabled = false;
            string myLetter = "M";
            HandleGuess(myLetter);
        }
        private void BTN_N_Click(object sender, EventArgs e)
        {
            BTN_N.Enabled = false;
            string myLetter = "N";
            HandleGuess(myLetter);
        }
        private void BTN_O_Click(object sender, EventArgs e)
        {
            BTN_O.Enabled = false;
            string myLetter = "O";
            HandleGuess(myLetter);
        }
        private void BTN_P_Click(object sender, EventArgs e)
        {
            BTN_P.Enabled = false;
            string myLetter = "P";
            HandleGuess(myLetter);
        }
        private void BTN_Q_Click(object sender, EventArgs e)
        {
            BTN_Q.Enabled = false;
            string myLetter = "Q";
            HandleGuess(myLetter);
        }
        private void BTN_R_Click(object sender, EventArgs e)
        {
            BTN_R.Enabled = false;
            string myLetter = "R";
            HandleGuess(myLetter);
        }
        private void BTN_S_Click(object sender, EventArgs e)
        {
            BTN_S.Enabled = false;
            string myLetter = "S";
            HandleGuess(myLetter);
        }
        private void BTN_T_Click(object sender, EventArgs e)
        {
            BTN_T.Enabled = false;
            string myLetter = "T";
            HandleGuess(myLetter);
        }
        private void BTN_U_Click(object sender, EventArgs e)
        {
            BTN_U.Enabled = false;
            string myLetter = "U";
            HandleGuess(myLetter);
        }
        private void BTN_V_Click(object sender, EventArgs e)
        {
            BTN_V.Enabled = false;
            string myLetter = "V";
            HandleGuess(myLetter);
        }
        private void BTN_W_Click(object sender, EventArgs e)
        {
            BTN_W.Enabled = false;
            string myLetter = "W";
            HandleGuess(myLetter);
        }
        private void BTN_X_Click(object sender, EventArgs e)
        {
            BTN_X.Enabled = false;
            string myLetter = "X";
            HandleGuess(myLetter);
        }
        private void BTN_Y_Click(object sender, EventArgs e)
        {
            BTN_Y.Enabled = false;
            string myLetter = "Y";
            HandleGuess(myLetter);
        }
        private void BTN_Z_Click(object sender, EventArgs e)
        {
            BTN_Z.Enabled = false;
            string myLetter = "Z";
            HandleGuess(myLetter);
        }
    }
}

// WOORDEN.ORG
// reverse comic sans ee
