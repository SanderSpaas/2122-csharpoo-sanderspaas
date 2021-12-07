using SpyfallProject.logischelaag;

namespace SpyfallProject.presentatielaag
{
    public partial class showRolesGui : Form
    {
        //global variables
        private int _Counter = 0;
        private int _Counter2 = 0;
        private readonly Random _Random = new();
        private Speler _SpelerObject = new();
        private SpyfallMain spel = new();
        public showRolesGui()
        {
            InitializeComponent();
            Icon = new Icon("datalaag/spy.ico");
            Text = "Rollen GUI";
            LabelClear();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int maxPlayers = spel.Aantalspelers;
            rolLabel1.Text = "Jouw rol";
            locatieLabel1.Text = "De locatie";
            if (_Counter < (maxPlayers * 2) - 1)
            {
                _Counter++;
                if (_Counter % 2 == 0)
                {
                    ColorPanel.BackColor = Color.FromArgb(240, 240, 240);
                    ColorPanel1.BackColor = Color.FromArgb(240, 240, 240);
                    nextPlayerButton.Text = "Klik hier als je de info wilt zien";
                    LabelClear();
                }
                else
                {
                    Color kleur = Color.FromArgb(_Random.Next(256), _Random.Next(256), _Random.Next(256));
                    ColorPanel.BackColor = kleur;
                    ColorPanel1.BackColor = kleur;
                    nextPlayerButton.Text = "Ik heb mijn rol en de locatie gezien";
                    Speler speler = (Speler)spel.SpelerList[_Counter2];
                    rolLabel.Text = speler.Rol;
                    locatieLabel.Text = speler.Locatie;
                    _Counter2++;
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
                new TimerGUI().ShowDialog();
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
