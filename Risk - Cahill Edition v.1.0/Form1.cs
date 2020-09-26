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
    public partial class frmRisk : Form
    {

        //Good day Mr. Ericson! This is my final project. It has more than 500 lines of code, though basically half of it are for the initialization of the main form. I am able to achieve most of Risk's gameplay features except for the Territory card pictures, and infantry/cavalry/artillery items
        //The program itself is challenge. By the end, I made several custom classes/forms, and I probably made 80% of everything public. The algorithms had gone through several revisions. I guarantee that the program is robust enough, though I can see that are several areas in the code where I can improve efficiency. Haha, I hope I had more time.
        //Current issues: Arrays for picboxes; continents; scrap updateMoves; lblstars to show stars; static buttons and redeem troops
        
        //Lists contain the territory references that belong to each . These will soon be added into the respective Player classes.
        private static List<Territory> genericTerritories = new List<Territory>();
        public static List<Territory> tomasTerritories = new List<Territory>();
        public static List<Territory> ekaterinaTerritories = new List<Territory>();
        public static List<Territory> janusTerritories = new List<Territory>();
        public static List<Territory> lucianTerritories = new List<Territory>();
        public static List<Player> players = new List<Player>();

        public static Random RNG = new Random();
        public static Label lblterritoryInfo = new Label();
        public static Label lblmoves = new Label();
        public static Label lblsentTroops = new Label();
        public static Button btnattackEnemies = new Button();

        //turn variable is in string in order to correspond with a click method in the territory class
        public static string turn = "Tomas";
        public static int newTroops = 3;
        public static int stars;

        //These variables are the basis for sending troops and attackers. I just dumped them as instance variables here in the main form, since transferring these vital information throughout the forms would be tricky.
        public static int defendingTroops;
        public static int sendingTroops;
        public static bool move = false;
        public static bool attack = false;
        public static bool bruteForce = false;
        public static bool nuclearMissile = false;

        public frmRisk()
        {
            InitializeComponent();

            //Static object references
            lblterritoryInfo.Text = "Territory Information:";
            lblterritoryInfo.Size = new Size(180, 100);
            lblterritoryInfo.Font = new Font(FontFamily.GenericSansSerif, 9, FontStyle.Bold);
            lblterritoryInfo.Location = new Point(20, 550);
            this.Controls.Add(lblterritoryInfo);

            lblmoves.Text = "You have 3 troops ready to place";
            lblmoves.Size = new Size(275, 100);
            lblmoves.Font = new Font(FontFamily.GenericSansSerif, 11);
            lblmoves.Location = new Point(1050, 315);
            lblmoves.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(lblmoves);

            lblsentTroops.Location = new Point(1175, 425);
            lblsentTroops.Size = new Size(250, 60);
            lblsentTroops.Font = new Font(FontFamily.GenericSansSerif, 25, FontStyle.Bold);
            lblsentTroops.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(lblsentTroops);

            btnattackEnemies.Location = new Point(1175, 485);
            btnattackEnemies.Size = new Size(150, 30);
            btnattackEnemies.Font = new Font(FontFamily.GenericSansSerif, 9);
            btnattackEnemies.Visible = false;
            btnattackEnemies.Text = "Move/Attack";
            btnattackEnemies.Click += btnattackEnemies_Click;
            this.Controls.Add(btnattackEnemies);

            //Setting up Territory Buttons. This portion would be very long but essential. 
            List<int> adjacentGroup = new List<int> { 0, 1 };
            Territory alaska = new Territory(35, 105, "ALASKA", "North America", adjacentGroup);
            this.Controls.Add(alaska);
            genericTerritories.Add(alaska);
            adjacentGroup = new List<int> { 1, 2};
            Territory northwestTerritory = new Territory(105, 100, "NORTHWEST TERRITORY", "North America", adjacentGroup);
            this.Controls.Add(northwestTerritory);
            genericTerritories.Add(northwestTerritory);
            adjacentGroup = new List<int> { 2, 3, 10 };
            Territory greenland = new Territory(350, 60, "GREENLAND", "North America", adjacentGroup);
            this.Controls.Add(greenland);
            genericTerritories.Add(greenland);
            adjacentGroup = new List<int> { 1, 4 };
            Territory alberta = new Territory(135, 170, "ALBERTA", "North America", adjacentGroup);
            this.Controls.Add(alberta);
            genericTerritories.Add(alberta);
            adjacentGroup = new List<int> { 2, 3, 4, 5 };
            Territory ontario = new Territory(210, 185, "ONTARIO", "North America", adjacentGroup);
            this.Controls.Add(ontario);
            genericTerritories.Add(ontario);
            adjacentGroup = new List<int> { 3, 5 };
            Territory quebec = new Territory(300, 180, "QUEBEC", "North America", adjacentGroup);
            this.Controls.Add(quebec);
            genericTerritories.Add(quebec);
            adjacentGroup = new List<int> { 4, 6 };
            Territory westUS = new Territory(130, 240, "WESTERN\nUNITED STATES", "North America", adjacentGroup);
            this.Controls.Add(westUS);
            genericTerritories.Add(westUS);
            adjacentGroup = new List<int> { 5, 6 };
            Territory eastUS = new Territory(205, 280, "EASTERN\nUNITED STATES", "North America", adjacentGroup);
            this.Controls.Add(eastUS);
            genericTerritories.Add(eastUS);
            adjacentGroup = new List<int> { 6, 7 };
            Territory centralAmerica = new Territory(155, 345, "CENTRAL\nAMERICA", "North America", adjacentGroup);
            this.Controls.Add(centralAmerica);
            genericTerritories.Add(centralAmerica);
            adjacentGroup = new List<int> { 7, 8 };
            Territory venezuela = new Territory(225, 425, "VENEZUELA", "South America", adjacentGroup);
            this.Controls.Add(venezuela);
            genericTerritories.Add(venezuela);
            adjacentGroup = new List<int> { 8, 9 };
            Territory peru = new Territory(270, 530, "PERU", "South America", adjacentGroup);
            this.Controls.Add(peru);
            genericTerritories.Add(peru);
            adjacentGroup = new List<int> { 8, 9, 19 };
            Territory brazil = new Territory(320, 495, "BRAZIL", "South America", adjacentGroup);
            this.Controls.Add(brazil);
            genericTerritories.Add(brazil);
            adjacentGroup = new List<int> { 9 };
            Territory argentina = new Territory(260, 610, "ARGENTINA", "Europe", adjacentGroup);
            this.Controls.Add(argentina);
            genericTerritories.Add(argentina);
            adjacentGroup = new List<int> { 10, 11 };
            Territory iceland = new Territory(470, 140, "ICELAND", "Europe", adjacentGroup);
            this.Controls.Add(iceland);
            genericTerritories.Add(iceland);
            adjacentGroup = new List<int> { 11, 12, 16 };
            Territory scandinavia = new Territory(550, 100, "SCANDINAVIA", "Europe", adjacentGroup);
            this.Controls.Add(scandinavia);
            genericTerritories.Add(scandinavia);
            adjacentGroup = new List<int> { 15, 16, 24, 34 };
            Territory ukraine = new Territory(650, 170, "UKRAINE", "Europe", adjacentGroup);
            this.Controls.Add(ukraine);
            genericTerritories.Add(ukraine);
            adjacentGroup = new List<int> { 11, 12, 13 };
            Territory greatBritain = new Territory(400, 225, "GREAT BRITAIN", "Europe", adjacentGroup);
            this.Controls.Add(greatBritain);
            genericTerritories.Add(greatBritain);
            adjacentGroup = new List<int> { 12, 14, 15 };
            Territory northEurope = new Territory(545, 240, "NORTH\nEUROPE", "Europe", adjacentGroup);
            this.Controls.Add(northEurope);
            genericTerritories.Add(northEurope);
            adjacentGroup = new List<int> { 13, 14, 17 };
            Territory westEurope = new Territory(455, 325, "WEST\nEUROPE", "Europe", adjacentGroup);
            this.Controls.Add(westEurope);
            genericTerritories.Add(westEurope);
            adjacentGroup = new List<int> { 14, 15, 17, 18 };
            Territory southEurope = new Territory(550, 305, "SOUTH\nEUROPE", "Europe", adjacentGroup);
            this.Controls.Add(southEurope);
            genericTerritories.Add(southEurope);
            adjacentGroup = new List<int> { 17, 19, 20, 21 };
            Territory westAfrica = new Territory(485, 480, "WEST AFRICA", "Africa", adjacentGroup);
            this.Controls.Add(westAfrica);
            genericTerritories.Add(westAfrica);
            adjacentGroup = new List<int> { 18, 20, 35 };
            Territory egypt = new Territory(605, 440, "EGYPT", "Africa", adjacentGroup);
            this.Controls.Add(egypt);
            genericTerritories.Add(egypt);
            adjacentGroup = new List<int> { 21, 22 };
            Territory congo = new Territory(590, 570, "CONGO", "Africa", adjacentGroup);
            this.Controls.Add(congo);
            genericTerritories.Add(congo);
            adjacentGroup = new List<int> { 20, 21, 22, 23, 35 };
            Territory eastAfrica = new Territory(650, 520, "EAST\nAFRICA", "Africa", adjacentGroup);
            this.Controls.Add(eastAfrica);
            genericTerritories.Add(eastAfrica);
            adjacentGroup = new List<int> { 22, 23 };
            Territory southAfrica = new Territory(605, 660, "SOUTH\nAFRICA", "Africa", adjacentGroup);
            this.Controls.Add(southAfrica);
            genericTerritories.Add(southAfrica);
            adjacentGroup = new List<int> { 23 };
            Territory madagascar = new Territory(705, 670, "MADAGASCAR", "Africa", adjacentGroup);
            this.Controls.Add(madagascar);
            genericTerritories.Add(madagascar);
            adjacentGroup = new List<int> { 24, 25, 26 };
            Territory ural = new Territory(790, 165, "URAL", "Asia", adjacentGroup);
            this.Controls.Add(ural);
            genericTerritories.Add(ural);
            adjacentGroup = new List<int> { 25, 27, 29 };
            Territory siberia = new Territory(835, 100, "SIBERIA", "Asia", adjacentGroup);
            this.Controls.Add(siberia);
            genericTerritories.Add(siberia);
            adjacentGroup = new List<int> { 29, 30 };
            Territory yakutsk = new Territory(940, 80, "YAKUTSK", "Asia", adjacentGroup);
            this.Controls.Add(yakutsk);
            genericTerritories.Add(yakutsk);
            adjacentGroup = new List<int> { 0, 30, 31, 32 };
            Territory kamchatka = new Territory(1025, 80, "KAMCHATKA", "Asia", adjacentGroup);
            this.Controls.Add(kamchatka);
            genericTerritories.Add(kamchatka);
            adjacentGroup = new List<int> { 27, 29, 30, 31 };
            Territory irkutsk = new Territory(930, 175, "IRKUTSK", "Asia", adjacentGroup);
            this.Controls.Add(irkutsk);
            genericTerritories.Add(irkutsk);
            adjacentGroup = new List<int> { 24, 26, 33 };
            Territory afghanistan = new Territory(755, 270, "AFGHANISTAN", "Asia", adjacentGroup);
            this.Controls.Add(afghanistan);
            genericTerritories.Add(afghanistan);
            adjacentGroup = new List<int> { 27, 28, 31, 32 };
            Territory mongolia = new Territory(920, 255, "MONGOLIA", "Asia", adjacentGroup);
            this.Controls.Add(mongolia);
            genericTerritories.Add(mongolia);
            adjacentGroup = new List<int> { 32 };
            Territory japan = new Territory(1055, 260, "JAPAN", "Asia", adjacentGroup);
            this.Controls.Add(japan);
            genericTerritories.Add(japan);
            adjacentGroup = new List<int> { 25, 26, 28, 36 };
            Territory china = new Territory(905, 330, "CHINA", "Asia", adjacentGroup);
            this.Controls.Add(china);
            genericTerritories.Add(china);
            adjacentGroup = new List<int> { 18, 33, 34, 35 };
            Territory middleEast = new Territory(685, 375, "MIDDLE EAST", "Asia", adjacentGroup);
            this.Controls.Add(middleEast);
            genericTerritories.Add(middleEast);
            adjacentGroup = new List<int> { 24, 33, 36 };
            Territory india = new Territory(830, 390, "INDIA", "Asia", adjacentGroup);
            this.Controls.Add(india);
            genericTerritories.Add(india);
            adjacentGroup = new List<int> { 36, 37 };
            Territory siam = new Territory(930, 425, "SIAM", "Asia", adjacentGroup);
            this.Controls.Add(siam);
            genericTerritories.Add(siam);
            adjacentGroup = new List<int> { 37, 38 };
            Territory indonesia = new Territory(920, 555, "INDONESIA", "Australia", adjacentGroup);
            this.Controls.Add(indonesia);
            genericTerritories.Add(indonesia);
            adjacentGroup = new List<int> { 38, 39 };
            Territory newGuinea = new Territory(1055, 520, "NEW GUINEA", "Australia", adjacentGroup);
            this.Controls.Add(newGuinea);
            genericTerritories.Add(newGuinea);
            adjacentGroup = new List<int> { 39 };
            Territory westAustralia = new Territory(975, 665, "WEST\nAUSTRALIA", "Australia", adjacentGroup);
            this.Controls.Add(westAustralia);
            genericTerritories.Add(westAustralia);
            adjacentGroup = new List<int> { 39 };
            Territory eastAustralia = new Territory(1060, 630, "EAST\nAUSTRALIA", "Australia", adjacentGroup);
            this.Controls.Add(eastAustralia);
            genericTerritories.Add(eastAustralia);

            //Assign random territories to players
            for (int tomasTerr = 0; tomasTerritories.Count() < 11; tomasTerr++)
            {
                int randomTerritory = RNG.Next(genericTerritories.Count());
                tomasTerritories.Add(genericTerritories.ElementAt(randomTerritory));
                genericTerritories.RemoveAt(randomTerritory);
            }
            foreach (Territory terr in tomasTerritories)
            {
                terr.owner = "Tomas";
                terr.BackColor = System.Drawing.Color.CornflowerBlue;
            }
            for (int ekatTerr = 0; ekaterinaTerritories.Count() < 11; ekatTerr++)
            {
                int randomTerritory = RNG.Next(genericTerritories.Count());
                ekaterinaTerritories.Add(genericTerritories.ElementAt(randomTerritory));
                genericTerritories.RemoveAt(randomTerritory);
            }
            foreach (Territory terr in ekaterinaTerritories)
            {
                terr.owner = "Ekaterina";
                terr.BackColor = System.Drawing.Color.Yellow;
            }
            for (int janusTerr = 0; janusTerritories.Count() < 10; janusTerr++)
            {
                int randomTerritory = RNG.Next(genericTerritories.Count());
                janusTerritories.Add(genericTerritories.ElementAt(randomTerritory));
                genericTerritories.RemoveAt(randomTerritory);
            }
            foreach (Territory terr in janusTerritories)
            {
                terr.owner = "Janus";
                terr.BackColor = System.Drawing.Color.Green;
            }
            for (int lucianTerr = 0; lucianTerritories.Count() < 10; lucianTerr++)
            {
                int randomTerritory = RNG.Next(genericTerritories.Count());
                lucianTerritories.Add(genericTerritories.ElementAt(randomTerritory));
                genericTerritories.RemoveAt(randomTerritory);
            }
            foreach (Territory terr in lucianTerritories)
            {
                terr.owner = "Lucian";
                terr.BackColor = System.Drawing.Color.Red;
            }

            //Setting up Players. I've decided to import the territories as a whole list since I've encountered issues in adding the territories one-by-one
            Player tomas = new Player(tomasTerritories);
            players.Add(tomas);
            Player ekaterina = new Player(ekaterinaTerritories);
            players.Add(ekaterina);
            Player janus = new Player(janusTerritories);
            players.Add(janus);
            Player lucian = new Player(lucianTerritories);
            players.Add(lucian);

        }

        //TRIAL BUTTONS: Developer's Tools
        private void btntrialA_Click(object sender, EventArgs e)
        {
            endGame();
        }

        //This method manages the turn number
        private void switchPlayers()
        {
            if (turn == "Tomas")
            {
                turn = "Ekaterina";
                picplayerCrest.BackgroundImage = Image.FromFile("Final Project Resources\\ekaterina.gif");
                lblplayerName.Text = "Ekaterina";
                lblsentTroops.Text = "";
                btnsuperPower.Text = "Nuclear Missile";
                btnsuperPower.Enabled = true;
                int continentBonus = players.ElementAt(1).continentBonus();
                newTroops = players.ElementAt(1).newTroops + continentBonus;
                stars = players.ElementAt(1).Territories.Count;
                updateMoves();
            }
            else if (turn == "Ekaterina")
            {
                turn = "Janus";
                picplayerCrest.BackgroundImage = Image.FromFile("Final Project Resources\\janus.gif");
                lblplayerName.Text = "Janus";
                lblsentTroops.Text = "";
                btnsuperPower.Text = "Propaganda";
                btnsuperPower.Enabled = true;
                int continentBonus = players.ElementAt(2).continentBonus();
                newTroops = players.ElementAt(2).newTroops + continentBonus;
                stars = players.ElementAt(2).Territories.Count;
                updateMoves();
            }
            else if (turn == "Janus")
            {
                turn = "Lucian";
                picplayerCrest.BackgroundImage = Image.FromFile("Final Project Resources\\lucian.gif");
                lblplayerName.Text = "Lucian";
                lblsentTroops.Text = "";
                btnsuperPower.Text = "Snakebite";
                btnsuperPower.Enabled = true;
                int continentBonus = players.ElementAt(3).continentBonus();
                newTroops = players.ElementAt(3).newTroops + continentBonus;
                stars = players.ElementAt(3).Territories.Count;
                updateMoves();
            }
            else
            {
                turn = "Tomas";
                picplayerCrest.BackgroundImage = Image.FromFile("Final Project Resources\\tomas.gif");
                lblplayerName.Text = "Tomas";
                lblsentTroops.Text = "";
                btnsuperPower.Text = "Brute Force";
                int continentBonus = players.ElementAt(0).continentBonus();
                newTroops = players.ElementAt(0).newTroops + continentBonus;
                stars = players.ElementAt(0).Territories.Count;
                updateMoves();
            }
        }

        public static void updateMoves()
        {
            if (newTroops > 0) { lblmoves.Text = "You have " + newTroops + " troops ready to place."; }
            else
            {
                btnattackEnemies.Visible = true;
                lblmoves.Text = "Click Move/Attack to start gathering your troops to relocate or attack. You can only move through your territory once, but you can attack as much as you want.";
            }
        }

        private void btnendTurn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to pass the turn to the next player?\nWARNING: Any unsent troops will not come back to you.", "End Turn", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                switchPlayers();
                MessageBox.Show("It is " + turn + "'s turn. Press OK to proceed.");
            }
        }

        private void btnattackEnemies_Click(object sender, EventArgs e)
        {
            Territory.referenceTerr = true;
            lblmoves.Text = "Select source territory to gather your troops from.";
        }

        public static void endGame()
        {
            frmWin winnerWindow = new frmWin();
            winnerWindow.ShowDialog();
        }

        private void btnredeemTroops_Click(object sender, EventArgs e)
        {
            int stars = 0;
            Player currentPlayer = players.ElementAt(0);
            if (turn == "Ekaterina")
            {
                currentPlayer = players.ElementAt(1);
            }
            else if (turn == "Janus")
            {
                currentPlayer = players.ElementAt(2);
            }
            else if (turn == "Lucian")
            {
                currentPlayer = players.ElementAt(3);
            }
            stars = currentPlayer.numOfStars;
            if (stars > 1)
            {
                if (stars == 10) { newTroops += 30; }
                else if (stars == 9) { newTroops += 25; }
                else if (stars == 8) { newTroops += 21; }
                else if (stars == 7) { newTroops += 17; }
                else if (stars == 6) { newTroops += 13; }
                else if (stars == 5) { newTroops += 10; }
                else if (stars == 4) { newTroops += 7; }
                else if (stars == 3) { newTroops += 4; }
                else { newTroops += 2; }
                currentPlayer.numOfStars = 0;
                updateMoves();
            }
        }

        private void btnsuperPower_Click(object sender, EventArgs e)
        {
            if (turn == "Tomas") //Win any battle regardless of outcome
            {
                bruteForce = true;
                btnsuperPower.Enabled = false;
            }
            else if (turn == "Ekaterina") //Attack enemy Territories, but not necessarily conquer them
            {
                nuclearMissile = true;
                btnsuperPower.Enabled = false;
            }
            else if (turn == "Janus") //Attract more troops to join your forces
            {
                newTroops += 5;
                updateMoves();
                btnsuperPower.Enabled = false;
            }
            else //Move indefinitely
            {
                foreach(Territory terr in players.ElementAt(3).Territories){ terr.movedOnce = false; }
            }
        }

        private void btnhelp_Click(object sender, EventArgs e)
        {
            frmSuperPowerGuide newWindow = new frmSuperPowerGuide();
            newWindow.ShowDialog();
        }

        private void frmRisk_Load(object sender, EventArgs e)
        {

        }
    }

    public class Territory : Button
    {
        public string owner;
        public string name;
        public string continent;
        public List<int> adjacentGroup;
        public int defendTroops;
        public static bool referenceTerr = false; //If referenceTerr is true, the button clicked is the source of the troops. If false, the button clicked is the destination of the troops
        public bool movedOnce = false;
        public Territory(int x, int y, string terrName, string assignedContinent, List<int> adjacentGrp)
        {
            defendTroops = 1;
            name = terrName;
            continent = assignedContinent;
            adjacentGroup = adjacentGrp;
            this.Location = new Point(x, y);
            this.AutoSize = true;
            this.Font = new Font(FontFamily.GenericSansSerif, 8, FontStyle.Bold);
            this.Text = String.Format("{0}: {1}", terrName, defendTroops);
            this.MouseHover += showTerrInfo;
            this.Click += terrClick;
        }


        //TERRITORY EVENT HANDLERS: Contains click and mouse hover events
        private void showTerrInfo(Object sender, EventArgs e)
        {
            frmRisk.lblterritoryInfo.Text = String.Format("Territory Information:\nName: {0}\nContinent: {1}\nOwner: {2}\nDefending Troops: {3}", this.name, this.continent, this.owner, this.defendTroops);
        }

        //terrClick contains every possible task that may happen if the button is clicked, and there's lots of them! It can be used to assign troops, reference source and destination when moving troops, and attack enemy territories
        public void terrClick(Object sender, EventArgs e)
        {
            bool assign = assigningPhase();
            bool myTerr = isMyTerritory();
            bool adjacent = isAdjacent();

            if (myTerr && assign) //If there are newTroops, button clicks are only for assigning to territories
            {
                MessageBox.Show("You added one troop to this territory.");
                this.defendTroops++;
                frmRisk.newTroops--;
                frmRisk.updateMoves();
            }
            else if (!myTerr && assign)
            {
                MessageBox.Show("This is not your territory.");
            }
            else if (referenceTerr && this.defendTroops > 1) //Source. One troop is required to stay in place to maintain territory, so it must have at least 2 troops to enable sending
            {
                DialogResult result = MessageBox.Show("Do you want to remove your troops from this position?", "Move", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    sendTroops();
                    frmRisk.lblmoves.Text = "Now, select your territory to move your troops to, or an enemy territory to attack.";
                    frmRisk.attack = true;
                    if (!movedOnce) { frmRisk.move = true; } // Player can move if he hadn't moved yet
                }
            }
            else if (myTerr && adjacent && frmRisk.move) //Destination. If you click your own territory, troops will be sent to fortify it
            {
                this.defendTroops += frmRisk.sendingTroops;
                frmRisk.move = false;
                movedOnce = true;
                frmRisk.lblsentTroops.Text = "Sent: 0";
            }
            else if (!myTerr && adjacent && frmRisk.attack) //Destination. If you click an enemy territory, troops will engage in a battle
            {
                frmRisk.defendingTroops = this.defendTroops; 
                attack();
                frmRisk.attack = false;
                frmRisk.lblsentTroops.Text = "Sent: 0";
            }
            else if (!myTerr && frmRisk.nuclearMissile)
            {
                this.defendTroops = 1;
                frmRisk.nuclearMissile = false;
            }
            this.Text = String.Format("{0}: {1}", this.name, this.defendTroops);
        }

        public void sendTroops()
        {
            frmRisk.sendingTroops = this.defendTroops;
            frmSendTroops newWindow = new frmSendTroops();
            newWindow.ShowDialog();
            frmRisk.sendingTroops = frmSendTroops.sendingTroops;
            frmRisk.lblsentTroops.Text = "Sent:  " + frmSendTroops.sendingTroops.ToString();
            referenceTerr = false;
            this.defendTroops -= frmRisk.sendingTroops;
        }

        public void attack()
        {
            frmBattle newWindow = new frmBattle();
            newWindow.ShowDialog();
            this.defendTroops = frmBattle.newDefending;
            if (frmBattle.attackersWin || frmRisk.bruteForce) //If the enemy territory is conquered, previous owner loses the territory from its Territories list, while new owner adds it to its Territories list
            {
                Territory conqueredTerr = this;
                Player conqueror = frmRisk.players.ElementAt(0); //For the sake of identification to avoid errors
                if (this.owner == "Tomas") { frmRisk.players.ElementAt(0).Territories.Remove(conqueredTerr); }
                else if (this.owner == "Ekaterina") { frmRisk.players.ElementAt(1).Territories.Remove(conqueredTerr); }
                else if (this.owner == "Janus") { frmRisk.players.ElementAt(2).Territories.Remove(conqueredTerr); }
                else { frmRisk.players.ElementAt(3).Territories.Remove(conqueredTerr);  }
                if (frmRisk.turn == "Tomas")
                {
                    this.owner = "Tomas";
                    this.BackColor = System.Drawing.Color.CornflowerBlue;
                    conqueror = frmRisk.players.ElementAt(0);
                }
                else if (frmRisk.turn == "Ekaterina")
                {
                    this.owner = "Ekaterina";
                    this.BackColor = System.Drawing.Color.Yellow;
                    conqueror = frmRisk.players.ElementAt(1);
                }
                else if (frmRisk.turn == "Janus")
                {
                    this.owner = "Janus";
                    this.BackColor = System.Drawing.Color.Green;
                    conqueror = frmRisk.players.ElementAt(2);
                }
                else
                {
                    this.owner = "Lucian";
                    this.BackColor = System.Drawing.Color.Red;
                    conqueror = frmRisk.players.ElementAt(3);
                }
                conqueror.Territories.Add(conqueredTerr);
                conqueror.numOfStars++;
                if (conqueror.Territories.Count >= 15) { frmRisk.endGame(); }
                frmRisk.bruteForce = false;
            }
        }

        public bool assigningPhase() //Determines if the player should only assign troops for the buttons clicked
        {
            int troops = frmRisk.newTroops;
            if (troops > 0) { return true; }
            else { return false; }
        }

        public bool isMyTerritory() //Determines if the button clicked is the player's own territory
        {
            string currentPlayer = frmRisk.turn;
            if (this.owner == currentPlayer) { return true; }
            return false;
        }

        //This method is the most challenging part of the project. To test the adjacency of the territories, I assigned each of them an adjacent group.
        //This method's algorithm goes through each of the clicked Territory's adjacent groups and compares them through each int inside the adjacentGroup List inside the territory class of a list of territories of the current player! It is very complex, but it's better than going by name.
        public bool isAdjacent() 
        {
            if (frmRisk.turn == "Tomas")
            {
                for (int i = 0; i < this.adjacentGroup.Count; i++)
                {
                    int thisAdjacentGroup = this.adjacentGroup.ElementAt(i);
                    foreach (Territory terr in frmRisk.tomasTerritories)
                    {
                        for (int j = 0; j < terr.adjacentGroup.Count; j++)
                        {
                            int currentAdjacentGroup = terr.adjacentGroup.ElementAt(j);
                            if (thisAdjacentGroup == currentAdjacentGroup){return true;}
                        }
                    }
                }
            }
            if (frmRisk.turn == "Ekaterina")
            {
                for (int i = 0; i < this.adjacentGroup.Count; i++)
                {
                    int thisAdjacentGroup = this.adjacentGroup.ElementAt(i);
                    foreach (Territory terr in frmRisk.ekaterinaTerritories)
                    {
                        for (int j = 0; j < terr.adjacentGroup.Count; j++)
                        {
                            int currentAdjacentGroup = terr.adjacentGroup.ElementAt(j);
                            if (thisAdjacentGroup == currentAdjacentGroup){return true;}
                        }
                    }
                }
            }
            if (frmRisk.turn == "Janus")
            {
                for (int i = 0; i < this.adjacentGroup.Count; i++)
                {
                    int thisAdjacentGroup = this.adjacentGroup.ElementAt(i);
                    foreach (Territory terr in frmRisk.janusTerritories)
                    {
                        for (int j = 0; j < terr.adjacentGroup.Count; j++)
                        {
                            int currentAdjacentGroup = terr.adjacentGroup.ElementAt(j);
                            if (thisAdjacentGroup == currentAdjacentGroup){return true;}

                        }
                    }
                }
            }
            if (frmRisk.turn == "Lucian")
            {
                for (int i = 0; i < this.adjacentGroup.Count; i++)
                {
                    int thisAdjacentGroup = this.adjacentGroup.ElementAt(i);
                    foreach (Territory terr in frmRisk.lucianTerritories)
                    {
                        for (int j = 0; j < terr.adjacentGroup.Count; j++)
                        {
                            int currentAdjacentGroup = terr.adjacentGroup.ElementAt(j);
                            if (thisAdjacentGroup == currentAdjacentGroup){return true;}
                        }
                    }
                }
            }
            return false;
        }
    }

    public class Player
    {
        public int numOfStars;
        public int newTroops;
        public List<Territory> Territories;

        public Player(List<Territory> playerTerritories)
        {
            Territories = playerTerritories;
            newTroops = 3;
            numOfStars = 2; // Used for redeeming troops
        }

        public int continentBonus() // This method calculates bonus troops that will be added by the start of the player's turn. The continent variables act like counters. If they reach a certain number, a continent bonus is granted.
        {
            int continentBonus = 0;
            int nAmerica = 0;
            int sAmerica = 0;
            int africa = 0;
            int europe = 0;
            int asia = 0;
            int australia = 0;
            foreach(Territory terr in Territories)
            {
                if (terr.continent == "North America") { nAmerica++; }
                else if (terr.continent == "South America") { sAmerica++; }
                else if (terr.continent == "Africa") { africa++; }
                else if (terr.continent == "Europe") { europe++; }
                else if (terr.continent == "Asia") { asia++; }
                else { australia++; }
            }
            if (asia == 12) { continentBonus += 7; }
            if (nAmerica == 9) { continentBonus += 5; }
            if (sAmerica == 4) { continentBonus += 2; }
            if (europe == 7) { continentBonus += 5; }
            if (africa == 6) { continentBonus += 3; }
            if (australia == 4) { continentBonus += 2; }
            return continentBonus;
        }

    }
}
