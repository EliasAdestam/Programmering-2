using System.Windows.Forms;

namespace Horse_Race
{
    public class Horse
    {
        // komma åt och sätta PictureBox
        public PictureBox PictureBox { get; set; }

        // sätta hästens namn
        public string Name { get; set; }

        // lagrar startpositionen
        private int startPosition;

        // Konstruktor för horseobjektet med PictureBox och namn
        public Horse(PictureBox pictureBox, string name)
        {
            PictureBox = pictureBox;
            Name = name;
            startPosition = pictureBox.Left;
        }

        // metod för att flytta hästen en random sträcka
        public void Move(int distance)
        {
            PictureBox.Left += distance;
        }

        // metod för att kontrollera om hästen har nått mållinjen
        public bool HasFinished(int finishLine)
        {
            return PictureBox.Left + PictureBox.Width >= finishLine;
        }
    }
}
