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

// hardcode / 0 = guesser / 1 = wordmaster -> solution: when round starts save the team into a variable, and do every action on that team
// if no lives left something should happend after


namespace ReverseHangmanForms
{
    internal partial class FRM_Game : Form
    {
        // Fields
        List<string> _differentLettersInWord = new List<string>();
        TeamCollection _teamCollection;
        WordClass _wordClass;
        Team _guesser;
        Team _wordMaster;

        // Methods
        public FRM_Game(TeamCollection importTeamCollection)
        {
            InitializeComponent();
            this._teamCollection = importTeamCollection;
        }
        public void Guess(string myLetter, object sender, EventArgs e)
        {
            new Guess(myLetter, _guesser, _wordClass);
            UpdateRemainingLetters();
            UpdateStripes();
            CheckIfDead(_guesser.Lives); // beetje saçma naam? ofzo?
            _guesser.EndOfGuess();
            UpdatePoints();
            CheckIfRoundIsOver(sender, e);
        }
        void StartNextRound(object sender, EventArgs e)
        {
            ResetAllValues();
            SwitchTurns();
            Controls.Clear();
            InitializeComponent();
            FRM_Game_Load(sender, e);
        }
        void ResetAllValues()
        {
            _guesser.ResetGuessCollection();
            _differentLettersInWord.Clear();
        }
        void CheckIfRoundIsOver(object sender, EventArgs e)
        {
            if (_guesser.EndRound)
            {
                _guesser.EndRound = false;
                StartNextRound(sender, e);
            }
        }
        void SwitchTurns()
        {
            if (_teamCollection.GetTeamList()[0].Role == Roles.Wordmaster)
            {
                _teamCollection.GetTeamList()[0].Role = Roles.Guesser;
                _teamCollection.GetTeamList()[1].Role = Roles.Wordmaster;
            }
            else if (_teamCollection.GetTeamList()[0].Role == Roles.Guesser)
            {
                _teamCollection.GetTeamList()[0].Role = Roles.Wordmaster;
                _teamCollection.GetTeamList()[1].Role = Roles.Guesser;
            }
        }
        void CheckIfDead(int lives)
        {
            DisplayLives();
            if (lives == 0)
            {
                MessageBox.Show("No lives left");
            }
        } // not done
        void SetGuesserAndWordMaster()
        {
            if (_teamCollection.GetTeamList()[0].Role == Roles.Guesser)
            {
                _guesser = _teamCollection.GetTeamList()[0];
                _wordMaster = _teamCollection.GetTeamList()[1];
            }
            else
            {
                _wordMaster = _teamCollection.GetTeamList()[0];
                _guesser = _teamCollection.GetTeamList()[1];
            }
        }


        // Methods - Display
        void DisplayWordStripes()
        {
            LBL_Word.Text = _wordClass.CalculateWordStripes();
        }
        void DisplayLives()
        {
            LBL_Lives.Text = "";
            for (int i = 0; i < _guesser.Lives; i++)
            {
                LBL_Lives.Text += "♥";
            }
        }
        void DisplayGoal()
        {
            int goal = _guesser.GuessCollection.CalculateGoal(_differentLettersInWord);
            LBL_Goal.Text = "Goal < " + goal.ToString();
        }

        // Methods - Update
        void UpdateStripes()
        {
            LBL_Word.Text = _wordClass.Stripes;
        }
        void UpdateRemainingLetters()
        {
            int remaingingLetters = 26 - _guesser.GuessCollection.guessedLetters.Count;
            LBL_RemainingLetters.Text = "Remaining Letters: " + remaingingLetters;
        }
        void UpdatePoints()
        {
            LBL_TeamOnePoints.Text = _teamCollection.GetTeamList()[0].Name + ": " + _teamCollection.GetTeamList()[0].Score;
            LBL_TeamTwoPoints.Text = _teamCollection.GetTeamList()[1].Name + ": " + _teamCollection.GetTeamList()[1].Score;
        }
        void UpdateRoleRelatedLabels()
        {
            foreach (Team team in _teamCollection.GetTeamList())
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
            SetGuesserAndWordMaster();
            UpdateRoleRelatedLabels();
            UpdatePoints();
        }
        private void BTN_Submit_Click(object sender, EventArgs e)
        {
            string word = TB_Word.Text.ToUpper();
            _wordClass = new WordClass(word, _guesser.GuessCollection);

            _wordClass.CountDifferentLetters(_wordClass.Word, _differentLettersInWord);
            LB_Test.Items.Clear();
            foreach (var letter in _differentLettersInWord)
            {
                LB_Test.Items.Add(letter);
            }

            if (_differentLettersInWord.Count > 3)
            {
                _guesser.CalculateLives(_differentLettersInWord);
                DisplayGoal();
                DisplayWordStripes();
                DisplayLives();
                _guesser.GuessCollection.SetWord(_wordClass);
                GB_CreateWord.Enabled = false;
                GB_Guess.Enabled = true;
            }
            else
            {
                MessageBox.Show("Woord moet meer dan 3 verschillende letters hebben");
            }
        }
        private void FRM_Game_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        } // Perfect
        private void TB_Word_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BTN_Submit_Click(sender, e);
            }
        }

        // Events - Letter buttons
        private void BTN_A_Click(object sender, EventArgs e)
        {
            BTN_A.Enabled = false;
            string myLetter = "A";
            Guess(myLetter, sender, e);
        }
        private void BTN_B_Click(object sender, EventArgs e)
        {
            BTN_B.Enabled = false;
            string myLetter = "B";
            Guess(myLetter, sender, e);
        }
        private void BTN_C_Click(object sender, EventArgs e)
        {
            BTN_C.Enabled = false;
            string myLetter = "C";
            Guess(myLetter, sender, e);
        }
        private void BTN_D_Click(object sender, EventArgs e)
        {
            BTN_D.Enabled = false;
            string myLetter = "D";
            Guess(myLetter, sender, e);
        }
        private void BTN_E_Click(object sender, EventArgs e)
        {
            BTN_E.Enabled = false;
            string myLetter = "E";
            Guess(myLetter, sender, e);
        }
        private void BTN_F_Click(object sender, EventArgs e)
        {
            BTN_F.Enabled = false;
            string myLetter = "F";
            Guess(myLetter, sender, e);
        }
        private void BTN_G_Click(object sender, EventArgs e)
        {
            BTN_G.Enabled = false;
            string myLetter = "G";
            Guess(myLetter, sender, e);
        }
        private void BTN_H_Click(object sender, EventArgs e)
        {
            BTN_H.Enabled = false;
            string myLetter = "H";
            Guess(myLetter, sender, e);
        }
        private void BTN_I_Click(object sender, EventArgs e)
        {
            BTN_I.Enabled = false;
            string myLetter = "I";
            Guess(myLetter, sender, e);
        }
        private void BTN_J_Click(object sender, EventArgs e)
        {
            BTN_J.Enabled = false;
            string myLetter = "J";
            Guess(myLetter, sender, e);
        }
        private void BTN_K_Click(object sender, EventArgs e)
        {
            BTN_K.Enabled = false;
            string myLetter = "K";
            Guess(myLetter, sender, e);
        }
        private void BTN_L_Click(object sender, EventArgs e)
        {
            BTN_L.Enabled = false;
            string myLetter = "L";
            Guess(myLetter, sender, e);
        }
        private void BTN_M_Click(object sender, EventArgs e)
        {
            BTN_M.Enabled = false;
            string myLetter = "M";
            Guess(myLetter, sender, e);
        }
        private void BTN_N_Click(object sender, EventArgs e)
        {
            BTN_N.Enabled = false;
            string myLetter = "N";
            Guess(myLetter, sender, e);
        }
        private void BTN_O_Click(object sender, EventArgs e)
        {
            BTN_O.Enabled = false;
            string myLetter = "O";
            Guess(myLetter, sender, e);
        }
        private void BTN_P_Click(object sender, EventArgs e)
        {
            BTN_P.Enabled = false;
            string myLetter = "P";
            Guess(myLetter, sender, e);
        }
        private void BTN_Q_Click(object sender, EventArgs e)
        {
            BTN_Q.Enabled = false;
            string myLetter = "Q";
            Guess(myLetter, sender, e);
        }
        private void BTN_R_Click(object sender, EventArgs e)
        {
            BTN_R.Enabled = false;
            string myLetter = "R";
            Guess(myLetter, sender, e);
        }
        private void BTN_S_Click(object sender, EventArgs e)
        {
            BTN_S.Enabled = false;
            string myLetter = "S";
            Guess(myLetter, sender, e);
        }
        private void BTN_T_Click(object sender, EventArgs e)
        {
            BTN_T.Enabled = false;
            string myLetter = "T";
            Guess(myLetter, sender, e);
        }
        private void BTN_U_Click(object sender, EventArgs e)
        {
            BTN_U.Enabled = false;
            string myLetter = "U";
            Guess(myLetter, sender, e);
        }
        private void BTN_V_Click(object sender, EventArgs e)
        {
            BTN_V.Enabled = false;
            string myLetter = "V";
            Guess(myLetter, sender, e);
        }
        private void BTN_W_Click(object sender, EventArgs e)
        {
            BTN_W.Enabled = false;
            string myLetter = "W";
            Guess(myLetter, sender, e);
        }
        private void BTN_X_Click(object sender, EventArgs e)
        {
            BTN_X.Enabled = false;
            string myLetter = "X";
            Guess(myLetter, sender, e);
        }
        private void BTN_Y_Click(object sender, EventArgs e)
        {
            BTN_Y.Enabled = false;
            string myLetter = "Y";
            Guess(myLetter, sender, e);
        }
        private void BTN_Z_Click(object sender, EventArgs e)
        {
            BTN_Z.Enabled = false;
            string myLetter = "Z";
            Guess(myLetter, sender, e);
        }
    }
}

// WOORDEN.ORG
// reverse comic sans ee
