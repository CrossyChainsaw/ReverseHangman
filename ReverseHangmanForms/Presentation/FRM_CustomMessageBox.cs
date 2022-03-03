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

namespace ReverseHangmanForms.Presentation
{
    public partial class FRM_CustomMessageBox : Form
    {
        // Fields
        TeamCollection _teamCollection;
        string _teamName1;
        string _teamName2;

        // Methods
        public FRM_CustomMessageBox(Team team)
        {
            //InitializeComponent();
            //_teamCollection = teamCollection;
            //_teamName1 = _teamCollection.GetTeamList()[0].Name;
            //_teamName2 = _teamCollection.GetTeamList()[1].Name;
        }

        private void FRM_CustomMessageBox_Load(object sender, EventArgs e)
        {
            BTN_TeamName1.Text = _teamName1;
            BTN_TeamName2.Text = _teamName2;
        }

        private void BTN_TeamName1_Click(object sender, EventArgs e)
        {
            _teamCollection.GetTeamList()[0].WonTieBreaker = true;
            this.Close();
        }

        private void BTN_TeamName2_Click(object sender, EventArgs e)
        {
            _teamCollection.GetTeamList()[1].WonTieBreaker = true;
            this.Close();
        }
    }
}
