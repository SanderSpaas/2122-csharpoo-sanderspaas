using SpyfallProject.logischelaag;

namespace SpyfallProject.presentatielaag
{
    public partial class showRolesGui : Form
    {
        //global variables
        private int _Counter = 0;
        private int _Counter2 = 0;
        private readonly Random _Random = new();
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
                    SetColor(Color.FromArgb(240, 240, 240));
                    nextPlayerButton.Text = "Klik hier als je de info wilt zien";
                    LabelClear();
                }
                else
                {
                    SetColor(Color.FromArgb(_Random.Next(256), _Random.Next(256), _Random.Next(256)));
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
                nextPlayerButton.Hide();
                StartButton.Show();
            }
        }
        private void StartButton_Click(object sender, EventArgs e)
        {
            Hide();
            new TimerGUI().ShowDialog();
        }

        //labelclear functie
        private void LabelClear()
        {
            rolLabel.Text = "";
            locatieLabel.Text = "";
            rolLabel1.Text = "";
            locatieLabel1.Text = "";
        }
        private void SetColor(Color color)
        {
            ColorPanel.BackColor = color;
            ColorPanel1.BackColor = color;
        }
    }
}
