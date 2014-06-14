/*  
 *  This is the main dialog userface.--Control Panel
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Panel
{
    public partial class controlPanel : Form
    {
        int LocationY = 346;
        public controlPanel()
        {
            InitializeComponent();
            battery.Value = 100;
            pictureBox1.Location = new Point(806, LocationY);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Copyright ©2014 XJTLU\n\nThanks for Z.Q.Jiang, S.Y.Zhao, Y.X.Zhu.");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //Display Motor info
            //Should be amended in the future, change it to decide by the real data
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            if(motorBox.Checked==false)
            {
                motorCondition.Text = "Motor condition: Not Run";
            }
            else
            {
                motorCondition.Text = "Motor condition: Run";
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void controlPanel_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            //build new communicaition dialog
            ComDiag CommDD = new ComDiag();
            CommDD.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //exit the application
            Application.Exit();
        }

        private void buttonF_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Yes");
            battery.Value--;
        }

        private void buttonL_Click(object sender, EventArgs e)
        {
            battery.Value++;
        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yes");
        }

        private void buttonR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yes");
        }

        private void buttonU_Click(object sender, EventArgs e)
        {
           if (LocationY < 347 && LocationY > 169)
           {
               LocationY--;
               pictureBox1.Location = new Point(806, LocationY);
           }
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            if (LocationY < 346 && LocationY > 168)
            {
                LocationY++;
                pictureBox1.Location = new Point(806, LocationY);
            }
        }

        private void controlPanel_KeyDown(object sender, KeyEventArgs e)
        {
            //KeyDown checking
            //ctrl+W
            if (e.KeyCode == Keys.W)
            {
                buttonF.PerformClick(); //perform as the buttonF is clicked
            }
            //ctrl+A
            if (e.KeyCode == Keys.A)
            {
                buttonL.PerformClick();
            }
            //ctrl+S
            if (e.KeyCode == Keys.S)
            {
                buttonB.PerformClick();
            }
            //ctrl+D
            if (e.KeyCode == Keys.D)
            {
                buttonR.PerformClick();
            }
            //ctrl+O
            if (e.KeyCode == Keys.O)
            {
                buttonU.PerformClick();
            }
            //ctrl+P
            if (e.KeyCode == Keys.P)
            {
                buttonD.PerformClick();
            }
        }
    }
}
