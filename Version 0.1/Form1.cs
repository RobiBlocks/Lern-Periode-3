using System.Security.Cryptography;

namespace ScherSteinPapier
{
    public partial class Form1 : Form
    {
        int benutzerWahl;
        int gegnerWahl;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSchere_Click(object sender, EventArgs e)
        {
            EingabeButtonsVerschwinden();
            labelBenutzerWahl.Visible = true;
            labelBenutzerWahl.Text = "Du hast Schere gew�hlt!";
            GegnerW�hlt();
            benutzerWahl = 1;
            GewinnVergleich();
            buttonBeenden.Visible = true;
        }

        private void buttonStein_Click(object sender, EventArgs e)
        {
            EingabeButtonsVerschwinden();
            labelBenutzerWahl.Visible = true;
            labelBenutzerWahl.Text = "Du hast Stein gew�hlt!";
            benutzerWahl = 2;
            GegnerW�hlt();
            GewinnVergleich();
            buttonBeenden.Visible = true;
        }

        private void buttonPapier_Click(object sender, EventArgs e)
        {
            EingabeButtonsVerschwinden();
            labelBenutzerWahl.Visible = true;
            labelBenutzerWahl.Text = "Du hast Papier gew�hlt!";
            benutzerWahl = 3;
            GegnerW�hlt();
            GewinnVergleich();
            buttonBeenden.Visible = true;
        }

        void EingabeButtonsVerschwinden()
        {
            buttonSchere.Visible = false;
            buttonStein.Visible = false;
            buttonPapier.Visible = false;
        }

        void GegnerW�hlt()
        {
            Random rnd = new Random();
            gegnerWahl = rnd.Next(1, 4); //1 = Schere, 2 = Stein, 3 = Papier
            labelGegnerWahl.Visible = true;

            if (gegnerWahl == 1)
            {
                labelGegnerWahl.Text = "Der Gegner hat Schere gew�hlt!";
            }
            if (gegnerWahl == 2)
            {
                labelGegnerWahl.Text = "Der Gegner hat Stein gew�hlt!";
            }
            if (gegnerWahl == 3)
            {
                labelGegnerWahl.Text = "Der Gegner hat Papier gew�hlt!";
            }
        }

        void GewinnVergleich()
        {
            if (benutzerWahl == 1 && gegnerWahl == 1 ||
                benutzerWahl == 2 && gegnerWahl == 2 ||
                benutzerWahl == 3 && gegnerWahl == 3)
            {
                labelGewinner.Visible = true;
                labelGewinner.Text = "UNENTSCHIEDEN!";
            }
            if (benutzerWahl == 1 && gegnerWahl == 3 ||
                benutzerWahl == 2 && gegnerWahl == 1 ||
                benutzerWahl == 3 && gegnerWahl == 2)
            {
                labelGewinner.Visible = true;
                labelGewinner.Text = "Du hast GEWONNEN!";
            }
            if (benutzerWahl == 3 && gegnerWahl == 1 ||
                benutzerWahl == 1 && gegnerWahl == 2 ||
                benutzerWahl == 2 && gegnerWahl == 3)
            {
                labelGewinner.Visible = true;
                labelGewinner.Text = "Du hast VERLOREN!";
            }
        }

        private void buttonBeenden_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}