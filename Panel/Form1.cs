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
        public controlPanel()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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

        }

        private void controlPanel_Key_Down(object sender, KeyEventArgs e)
        {
            //ctrl+F
            if(e.KeyCode==Keys.W&&e.Control)
            {
                buttonF.PerformClick();
            }
        }
    }
}
