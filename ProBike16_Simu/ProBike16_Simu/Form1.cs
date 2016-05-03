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
