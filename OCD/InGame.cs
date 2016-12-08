using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OCD
{
    public partial class InGame : Form
    {
        MainMenu parent;
        int userID;


        public InGame()
        {
            InitializeComponent();
        }

        public InGame(MainMenu Parent, int userID, String message, Color color)
        {
            InitializeComponent();
            parent = Parent;
            lbErrorOrMessage.Text = message;
            lbErrorOrMessage.BackColor = color;
            this.userID = userID;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            userID = 0;
            this.Close();
            parent.Visible = true;
        }
    }
}
