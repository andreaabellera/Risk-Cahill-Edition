using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Risk___Cahill_Edition_v._1._0
{
    public partial class frmWin : Form
    {
        public frmWin()
        {
            InitializeComponent();
            setCongratulations();
        }

        private void setCongratulations()
        {
            lblmessage.Text = "Congratulations " + frmRisk.turn + "!\nYou are the world's new dictator.";
            if (frmRisk.turn == "Tomas") { picwinnerCrest.BackgroundImage = Image.FromFile("Final Project Resources\\tomas.gif"); }
            if (frmRisk.turn == "Ekaterina") { picwinnerCrest.BackgroundImage = Image.FromFile("Final Project Resources\\ekaterina.gif"); }
            if (frmRisk.turn == "Janus") { picwinnerCrest.BackgroundImage = Image.FromFile("Final Project Resources\\janus.gif"); }
            if (frmRisk.turn == "Lucian") { picwinnerCrest.BackgroundImage = Image.FromFile("Final Project Resources\\lucian.gif"); }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
