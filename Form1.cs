using System;
using System.Windows.Forms;

namespace Horse_Race
{
    public partial class Form1 : Form
    {
        // instanser av horse-klassen
        private Horse horse1;
        private Horse horse2;
        private Horse horse3;
        private Horse horse4;

        // slumpgenerator för hästarna
        private Random rnd = new Random();

        // Konstruktor för Form1
        public Form1()
        {
            InitializeComponent();
            InitializeHorses();
        }

        // Metod för att initiera hästarna
        private void InitializeHorses()
        {
            horse1 = new Horse(pictureBox1, "Horse 1");
            horse2 = new Horse(pictureBox2, "Horse 2");
            horse3 = new Horse(pictureBox3, "Horse 3");
            horse4 = new Horse(pictureBox4, "Horse 4");
        }

        // start-knappen
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true; // starta timern och racet
        }

        // Händelsehanterare för timer-tick
        private void timer1_Tick(object sender, EventArgs e)
        {
            int finishLine = label5.Left; // Målets position

            // flytta hästarna och kontrollera om någon har vunnit
            MoveHorse(horse1, finishLine);
            MoveHorse(horse2, finishLine);
            MoveHorse(horse3, finishLine);
            MoveHorse(horse4, finishLine);
        }

        // metod för att flytta en häst och kontrollera om den har vunnit
        private void MoveHorse(Horse horse, int finishLine)
        {
            horse.Move(rnd.Next(5, 16)); // hastighet slumpgenerator
            if (horse.HasFinished(finishLine))
            {
                timer1.Enabled = false; // stoppa timern och racet om någon vunnit
                MessageBox.Show($"{horse.Name} vann!"); // meddelande om vinnare
            }
        }
    }
}
