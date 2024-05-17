using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Horse_Race
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //För att definera pictureBox.Left
        int startHorse1, startHorse2, startHorse3, startHorse4;

        //Startar racet eftersom allt är kopplat till Timern.
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
        //Race koden
        private void timer1_Tick(object sender, EventArgs e)
        {
            //definerar bredden på hästarna
            int widthHorse1 = pictureBox1.Width;
            int widthHorse2 = pictureBox2.Width;
            int widthHorse3 = pictureBox3.Width;
            int widthHorse4 = pictureBox4.Width;
            //Definerar finish till mållinjen
            int finish = label5.Left;
            //Ger farten till alla sprites
            pictureBox1.Left = pictureBox1.Left + rnd.Next(5, 16);
            pictureBox2.Left = pictureBox2.Left + rnd.Next(5, 16);
            pictureBox3.Left = pictureBox3.Left + rnd.Next(5, 16);
            pictureBox4.Left = pictureBox4.Left + rnd.Next(5, 16);
            //Målgångsbetingelser
            if(widthHorse1+pictureBox1.Left>=finish)
            {
                timer1.Enabled=false;
            }
            if(widthHorse2+pictureBox2.Left>=finish)
            {
                timer1.Enabled=false;
            }
            if(widthHorse3+pictureBox3.Left>=finish)
            {
                timer1.Enabled=false;
            }
            if(widthHorse4+pictureBox4.Left>=finish)
            {
                timer1.Enabled=false;
            }

        }
        //Definerar rnd som Random
        Random rnd = new Random();
        //Laddar in hästarna
        private void Form1_Load(object sender, EventArgs e)
        {
            startHorse1 = pictureBox1.Left;
            startHorse2 = pictureBox2.Left;
            startHorse3 = pictureBox3.Left;
            startHorse4 = pictureBox4.Left;
        }
    }
}
