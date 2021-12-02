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
            this.Icon = new Icon("data/spy.ico");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void locatieLabel_Click(object sender, EventArgs e)
        {

        }

        private void showRolesGui_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int maxPlayers = Spelers.Count;
            rolLabel1.Text = "Jouw rol";
            locatieLabel1.Text = "De locatie";
            if (counter < maxPlayers * 2)
            {
                counter++;
                if (counter % 2 == 0)
                {
                    nextPlayerButton.Text = "Klik hier als je de info wilt zien";
                    rolLabel.Text = "";
                    locatieLabel.Text = "";
                    rolLabel1.Text = "";
                    locatieLabel1.Text = "";
                }
                else
                {
                    nextPlayerButton.Text = "Ik heb mijn rol en de locatie gezien";
                    Speler speler = (Speler)Spelers[counter2];
                    rolLabel.Text = speler.GetRol();
                    locatieLabel.Text = speler.GetLocatie();
                    counter2++;
                }

            }

        }
    }
}
