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
    public partial class FRM_Rules : Form
    {
        // Fields
        public Form FRM_Menu;

        // Methods
        public FRM_Rules(Form FRM_Menu)
        {
            InitializeComponent();
            this.FRM_Menu = FRM_Menu;
        }

        // Events
        private void FRM_Rules_FormClosed(object sender, FormClosedEventArgs e)
        {
            FRM_Menu.Show();
        }
    }
}
