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
    public partial class frmBattle : Form
    {

        public static int newDefending;
        public static bool attackersWin;
        int defending;
        int attacking;
        Random RNG = new Random();

        public frmBattle()
        {
            InitializeComponent();
            this.ControlBox = false;
            defending = frmRisk.defendingTroops;
            attacking = frmRisk.sendingTroops;
            lbldefenders.Text = "Defenders: " + defending;
            lblattackers.Text = "Attackers: " + attacking;
        }

        private void btnSpin_Click(object sender, EventArgs e)
        {
            int highestDefend = 1;
            int highestAttack = 1;
            List<int> defendNums = new List<int>();
            List<int> attackNums = new List<int>();
            int secondDefend = 1;
            int secondAttack = 1;
            for (int i = 0; i < defending - 1 || i < 1; i++)
            {
                if (i == 0)
                {
                    int defend1 = RNG.Next(1, 7);
                    picdefend1.BackgroundImage = Image.FromFile(String.Format("Final Project Resources\\dice{0}.png", defend1));
                    defendNums.Add(defend1);
                }
                else if (i == 1)
                {
                    int defend2 = RNG.Next(1, 7);
                    picdefend2.BackgroundImage = Image.FromFile(String.Format("Final Project Resources\\dice{0}.png", defend2));
                    defendNums.Add(defend2);
                }



            }


            for (int i = 0; i < attacking - 1 || i < 2; i++)
            {
                if (i == 0)
                {
                    int attack1 = RNG.Next(1, 7);
                    picattack1.BackgroundImage = Image.FromFile(String.Format("Final Project Resources\\dicered{0}.png", attack1));
                    attackNums.Add(attack1);
                }
                if (i == 1)
                {
                    int attack2 = RNG.Next(1, 7);
                    picattack2.BackgroundImage = Image.FromFile(String.Format("Final Project Resources\\dicered{0}.png", attack2));
                    attackNums.Add(attack2);
                }
                if (i == 2)
                {
                    int attack3 = RNG.Next(1, 7);
                    picattack3.BackgroundImage = Image.FromFile(String.Format("Final Project Resources\\dicered{0}.png", attack3));
                    attackNums.Add(attack3);
                }

            }


            defendNums.Sort();
            attackNums.Sort();
            highestDefend = defendNums.ElementAt(defendNums.Count - 1);
            highestAttack = attackNums.ElementAt(attackNums.Count - 1);
            if (highestDefend >= highestAttack)
            {
                lblverdict.Text = "Attackers lose";
                attacking--;
                lblattackers.Text = "Attackers: " + attacking;
            }
            else
            {
                lblverdict.Text = "Defenders lose";
                defending--;
                lbldefenders.Text = "Defenders: " + defending;
            }

            if (defending > 1) //A second battle happens if there are more than one defenders
            {
                secondDefend = defendNums.ElementAt(defendNums.Count - 2);
                secondAttack = attackNums.ElementAt(attackNums.Count - 2);
                if (secondDefend >= secondAttack)
                {
                    lblverdict.Text += "\nAttackers lose";
                    attacking--;
                    lblattackers.Text = "Attackers: " + attacking;
                }
                else
                {
                    lblverdict.Text += "\nDefenders lose";
                    defending--;
                    lbldefenders.Text = "Defenders: " + defending;
                }
            }

            if (defending <= 0)
            {
                attackersWin = true;
                newDefending = attacking;
                this.Close();
            }

            if (attacking <= 0)
            {
                attackersWin = false;
                newDefending = defending;
                this.Close();
            }

        }

    }

}