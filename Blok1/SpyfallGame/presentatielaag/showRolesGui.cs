using SpyfallGame.presentatielaag;
using System;
using System.Drawing;
using System.Windows.Forms;
using static Speler;

namespace SpyfallGame.presentatie
{
    public partial class showRolesGui : Form
    {
        //global variables
        private int counter = 0;
        private int counter2 = 0;

        public showRolesGui()
        {
            InitializeComponent();
            Icon = new Icon("datalaag/spy.ico");
            Text = "Rollen GUI";
            LabelClear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int maxPlayers = Spelers.Count;
            rolLabel1.Text = "Jouw rol";
            locatieLabel1.Text = "De locatie";
            if (counter < (maxPlayers * 2) - 1)
            {
                counter++;
                if (counter % 2 == 0)
                {
                    ColorPanel.BackColor = Color.FromArgb(240, 240, 240);
                    ColorPanel1.BackColor = Color.FromArgb(240, 240, 240);
                    nextPlayerButton.Text = "Klik hier als je de info wilt zien";
                    LabelClear();
                }
                else
                {
                    Random random = new Random();
                    Color kleur = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
                    ColorPanel.BackColor = kleur;
                    ColorPanel1.BackColor = kleur;
                    nextPlayerButton.Text = "Ik heb mijn rol en de locatie gezien";
                    Speler speler = (Speler)Spelers[counter2];
                    rolLabel.Text = speler.GetRol();
                    locatieLabel.Text = speler.GetLocatie();
                    counter2++;
                }
            }
            else
            {
                LabelClear();
                nextPlayerButton.Text = "Start het spel";
            }

            if (nextPlayerButton.Text == "Start het spel")
            {
                Hide();
                new TimerGUI().Show();
            }

        }

        //labelclear functie
        private void LabelClear()
        {
            rolLabel.Text = "";
            locatieLabel.Text = "";
            rolLabel1.Text = "";
            locatieLabel1.Text = "";
        }
    }
}
