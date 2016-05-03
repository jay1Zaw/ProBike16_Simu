using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProBike16_Simu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Sell_Click(object sender, EventArgs e)
        {
            Sell_panel.Visible = true;
        }

        private void PPS_Click(object sender, EventArgs e)
        {

        }

        private void Purchase_Click(object sender, EventArgs e)
        {

        }

        private void ManagementSummery_Click(object sender, EventArgs e)
        {

        }

        private void Settings_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void startseiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sell_panel.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Sell_panel.Visible = false;
        }

        private void pPSToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void einkaufToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void zusammenfassungManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void einstellungenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void p1_box_ValueChanged(object sender, EventArgs e)
        {

        }

        private void p2_box_ValueChanged(object sender, EventArgs e)
        {

        }

        private void p3_box_ValueChanged(object sender, EventArgs e)
        {

        }

        private void p1_a_box_ValueChanged(object sender, EventArgs e)
        {

        }

        private void p2_a_box_ValueChanged(object sender, EventArgs e)
        {

        }

        private void p3_a_box_ValueChanged(object sender, EventArgs e)
        {

        }

        private void p1_b_box_ValueChanged(object sender, EventArgs e)
        {

        }

        private void p3_b_box_ValueChanged(object sender, EventArgs e)
        {

        }

        private void p1_c_box_ValueChanged(object sender, EventArgs e)
        {

        }

        private void p2_c_box_ValueChanged(object sender, EventArgs e)
        {

        }

        private void p3_c_box_ValueChanged(object sender, EventArgs e)
        {

        }

        private void deutschToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (deutschToolStripMenuItem.Checked == true)     //in deutsch, switch to default language
            {
                deutschToolStripMenuItem.Checked = false;
                englishToolStripMenuItem.Checked = true;     //default language
            }
            else            //current language is not deutsch, switch deutsch
            {
                deutschToolStripMenuItem.Checked = true;
                englishToolStripMenuItem.Checked = false;
            }
            //switch language
            //switch_language();



        }

        /*private void switch_language()
        {
            if (deutschToolStripMenuItem.Checked == true)         //in deutsch
            {
                cul = CultureInfo.CreateSpecificCulture("vi");    //create culture for vietnamese
            }
            else  //in english
            {
                cul = CultureInfo.CreateSpecificCulture("en");    //create culture for english}
            }*/
    }
}
