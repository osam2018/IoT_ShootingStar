using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlTower
{
    public partial class ControlTower : Form
    {
        private bool isWaiting = true;
        private int waitingTime = 10;
        private int waitingCount = 0;
        private int shootingCount = 0;
        private int maxShootingCount = 20;

        public ControlTower() => InitializeComponent();

        private void ControlTower_Load(object sender, EventArgs e)
        {
            shootingTimer.Interval = 1000;
        }

        private void shootingTimer_Tick(object sender, EventArgs e)
        {
            if (isWaiting)
            {
                waitingCount++;
                if (waitingCount > waitingTime)
                {
                    isWaiting = false;
                }
            }
            else
            {
                shootingCount++;
                if (shootingCount >= 20)
                {
                    shootingStatusLbl.ForeColor = Color.Green;
                    shootingStatusLbl.Text = "사격 완료";
                    shootingTimer.Enabled = false;
                    shootingStatusImgGreen.Visible = true;
                    shootingStatusImgRed.Visible = false;
                }
                shootingCountLbl.Text = shootingCount + " / " + maxShootingCount;
            }
        }
    }
}
