using SpyfallProject.datalaag;
using SpyfallProject.logischelaag;

namespace SpyfallProject.presentatielaag
{
    public partial class ShowRolesGui : Form
    {
        //global variables
        private int _counter1 = 0;
        private int _counter2 = 0;
        private readonly Random _random = new();
        private SpyfallMain _spel = new();
        private readonly Rollen _rol = new();
        public ShowRolesGui()
        {
            InitializeComponent();
            Icon = new Icon("datalaag/spy.ico");
            Text = "Rollen GUI";
            LabelClear();

            //een rollenlijst laten aanmaken
            _rol.KiesRandomRol(_spel.FilePath);

            _spel.Locatie = _rol.GetRollenList()[0].ToString();
            var list = _rol.GetRollenList();
            list.RemoveAt(0);
            _rol.SetRollenList(list);
            //spelers de rollen gaan toewijzen
            _spel.MaakUsers();
            //de spelerarray gaan shuffelen
            _spel.ShuffleList(_spel.SpelerList);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int maxPlayers = _spel.Aantalspelers;
            rolLabel1.Text = "Jouw rol";
            locatieLabel1.Text = "De locatie";
            if (_counter1 < (maxPlayers * 2) - 1)
            {
                _counter1++;
                if (_counter1 % 2 == 0)
                {
                    SetColor(Color.FromArgb(240, 240, 240));
                    nextPlayerButton.Text = "Klik hier als je de info wilt zien";
                    LabelClear();
                }
                else
                {
                    SetColor(Color.FromArgb(_random.Next(256), _random.Next(256), _random.Next(256)));
                    nextPlayerButton.Text = "Ik heb mijn rol en de locatie gezien";
                    Speler speler = (Speler)_spel.SpelerList[_counter2];
                    rolLabel.Text = speler.Rol;
                    locatieLabel.Text = _spel.Locatie;
                    _counter2++;
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
