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
        private readonly Rollen _rol = new();
        private readonly SpyfallMain _spel;
        public ShowRolesGui(int aantalSpelers, int aantalSpionnen, int aantalTijd, string filePath)
        {
            InitializeComponent();
            Icon = new Icon("datalaag/spy.ico");
            Text = "Rollen GUI";
            LabelClear();
            //een rollenlijst laten aanmaken
            _rol.KiesRandomRol(filePath);
            _spel = new(aantalSpelers, aantalSpionnen, aantalTijd, _rol.RollenList[0].ToString(), filePath);

            var list = _rol.RollenList;
            list.RemoveAt(0);
            _rol.SetRollenList(list);
            //spelers de rollen gaan toewijzen
            _spel.MaakUsers(_rol.RollenList);
            _spel.ShuffleList(_spel.SpelerList);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int maxPlayers = _spel.Aantalspelers;
            rolLabelTitel.Text = "Jouw rol";
            locatieLabelTitel.Text = "De locatie";
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
                    if (speler.Rol == "Spion")
                    {
                        locatieLabel.Text = "onbekend";
                    }
                    else
                    {
                        locatieLabel.Text = _spel.Locatie;
                    }
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
            new TimerGUI(_spel).Show();
        }
        private void LabelClear()
        {
            rolLabel.Text = "";
            locatieLabel.Text = "";
            rolLabelTitel.Text = "";
            locatieLabelTitel.Text = "";
        }
        private void SetColor(Color color)
        {
            ColorPanel.BackColor = color;
            ColorPanel1.BackColor = color;
        }
    }
}
