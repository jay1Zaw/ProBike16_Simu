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
            panel_Sell.Visible = true;
            //panel_Sell.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel_Sell.Visible = false;
            //panel_Sell.Enabled = false;
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            panel_Sell.Visible = false;
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

        private void p1_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void p2_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void p3_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void p1_a_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void p2_a_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void p3_a_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void p1_b_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void p2_b_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void p3_b_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void p1_c_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void p2_c_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void p3_c_textBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
