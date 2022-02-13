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
    public partial class FRM_Menu : Form
    {
        // Methods
        public FRM_Menu()
        {
            InitializeComponent();
        }

        public void OpenCreateTeams(Form form)
        {
            FRM_CreateTeams frm_CreateTeams = new FRM_CreateTeams(form);
            frm_CreateTeams.Show();
            this.Hide();
        }
        public void OpenRules(Form form)
        {
            FRM_Rules frm_Rules = new FRM_Rules(form);
            frm_Rules.Show();
            this.Hide();
        }

        // Events
        private void BTN_Play_Click(object sender, EventArgs e)
        {
            OpenCreateTeams(this);
        }
        private void BTN_Rules_Click(object sender, EventArgs e)
        {
            OpenRules(this);
        }

        private void LBL_Title_Click(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {
                control.Font = new Font(control.Font, FontStyle.Bold);
            }
        }
    }
}

// if reverse is clicked, use reverse font everywhere