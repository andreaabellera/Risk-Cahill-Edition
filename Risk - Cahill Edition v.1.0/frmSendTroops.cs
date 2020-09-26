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


    public partial class frmSendTroops : Form
    {
        public int troopsFromTerritory;
        public static int sendingTroops;

        public frmSendTroops()
        {
            InitializeComponent();
            this.ControlBox = false; //Once decided, no turning back. This form can't be exited.
            numsendingTroops.Minimum = 1;
            troopsFromTerritory = frmRisk.sendingTroops;
            numsendingTroops.Maximum = troopsFromTerritory - 1;
            
        }

        private void numsendingTroops_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                sendingTroops = Convert.ToInt32(numsendingTroops.Value);
                this.Close();
            }
        }
    }
}
