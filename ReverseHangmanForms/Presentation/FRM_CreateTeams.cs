using ReverseHangmanForms.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReverseHangmanForms
{
    public partial class FRM_CreateTeams : Form
    {

        // Fields
        TeamCollection _teamCollection = new TeamCollection();
        Random _rnd = new Random();
        public Form FRM_Menu;

        // Methods
        public FRM_CreateTeams(Form FRM_Menu)
        {
            InitializeComponent();
            this.FRM_Menu = FRM_Menu;
        }
        bool AreTeamnamesFilledIn()
        {
            return TB_TeamOne.Text.Length > 0 && TB_TeamTwo.Text.Length > 0;
        }
        void CreateTeams()
        {
            Team team1 = new Team(TB_TeamOne.Text, new GuessCollection());
            Team team2 = new Team(TB_TeamTwo.Text, new GuessCollection());
            _teamCollection.AddTeam(team1);
            _teamCollection.AddTeam(team2);
        }
        void GiveTeamsRandomRoles()
        {
            int randomNumber = _rnd.Next(0, 2);
            if (randomNumber == 0)
            {
                _teamCollection.GetTeamList()[0].Role = Roles.Wordmaster;
                _teamCollection.GetTeamList()[1].Role = Roles.Guesser;
            }
            else
            {
                _teamCollection.GetTeamList()[0].Role = Roles.Guesser;
                _teamCollection.GetTeamList()[1].Role = Roles.Wordmaster;
            }
            //_teamCollection.GetTeamList()[0].Role = Roles.Guesser;
            //_teamCollection.GetTeamList()[1].Role = Roles.Wordmaster;
        }
        void OpenGameForm()
        {
            FRM_Game frm_Game = new FRM_Game(_teamCollection);
            frm_Game.Show();
            this.Hide();
        }

        // Events
        private void FRM_CreateTeams_Load(object sender, EventArgs e)
        {
            TB_TeamOne.Text = Team.CreateRandomTeamName();
            TB_TeamTwo.Text = Team.CreateRandomTeamName();
        }
        private void BTN_Start_Click(object sender, EventArgs e)
        {
            if (AreTeamnamesFilledIn())
            {
                CreateTeams();
                GiveTeamsRandomRoles();
                OpenGameForm();
            }
            else
            {
                MessageBox.Show("Teamnames not filled in");
            }
        }
        private void FRM_CreateTeams_FormClosed(object sender, FormClosedEventArgs e)
        {
            FRM_Menu.Show();
        }

    }
}
