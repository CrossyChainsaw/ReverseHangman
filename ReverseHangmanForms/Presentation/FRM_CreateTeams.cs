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
        TeamCollection teamCollection = new TeamCollection();
        public Form FRM_Menu;

        // Methods
        public FRM_CreateTeams(Form FRM_Menu)
        {
            InitializeComponent();
            this.FRM_Menu = FRM_Menu;
        }
        public bool AreTeamnamesFilledIn()
        {
            return TB_TeamOne.Text.Length > 0 && TB_TeamTwo.Text.Length > 0;
        }
        public void CreateTeams()
        {
            Team team1 = new Team(TB_TeamOne.Text);
            Team team2 = new Team(TB_TeamTwo.Text);
            teamCollection.AddTeam(team1);
            teamCollection.AddTeam(team2);
        }
        public void OpenGameForm()
        {
            FRM_Game frm_Game = new FRM_Game(teamCollection);
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
            if (TB_TeamOne.Text.Length > 0 && TB_TeamTwo.Text.Length > 0)
            {
                CreateTeams();
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
