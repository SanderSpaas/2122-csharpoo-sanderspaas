using SpyfallProject.datalaag;
using SpyfallProject.logischelaag;
using System.Collections;
namespace SpyfallProject.presentatielaag
{
    public partial class startGui : Form
    {
        //de array waar we onze errors gaan insteken
        private readonly ArrayList _errorArray = new();
        private string _filePath = @"datalaag\SpyfallData.csv";
        private readonly SpyfallMain _spel = new();
        private readonly Rollen _rol = new();
        private readonly FilePicker _filePicker = new();
        private readonly DataVerwerker _dataVerwerker = new();
        public startGui()
        {
            InitializeComponent();
            Icon = new Icon("datalaag/spy.ico");
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            _errorArray.Clear();
            textBox1.Text = "";
            //data die de speler geselecteerd heeft gaan controleren en eventueel errors tonen
            textBox1.BackColor = Color.FromArgb(240, 240, 240);
            textBox1.ForeColor = Color.Red;
            if (aantalSpelers.Value < 4)
            {
                _errorArray.Add("Je moet dit spel met 4 of meer spelen. \n");
            }
            if (aantalSpelers.Value > 10)
            {
                _errorArray.Add("Je kan dit spel met niet meer dan 10 spelers spelen. \n");
            }
            if (aantalSpionnen.Value == 0)
            {
                _errorArray.Add("Je moet minstens 1 spion hebben. \n");
            }
            if (aantalSpionnen.Value >= aantalSpelers.Value)
            {
                _errorArray.Add("Je kan niet meer of evenveel spionnen als spelers hebben. \n");
            }
            if (!_dataVerwerker.TestData(_filePath))
            {
                _errorArray.Add("Het gekozen databestand is ongeldig");
            }

            //de errors gaan tonen
            foreach (string error in _errorArray)
            {
                textBox1.Text = $"{textBox1.Text}{error}";
            }

            //als er geen errors zijn dingen voor het spel beginnen klaarzetten
            if (_errorArray.Count == 0)
            {
                //het aantal spelers en spionnen gaan vastzetten
                _spel.Aantalspelers = (int)aantalSpelers.Value;
                _spel.Aantalspionnen = (int)aantalSpionnen.Value;

                //een rollenlijst laten aanmaken
                _rol.KiesRandomRol(_filePath);

                _spel.Locatie = _rol.GetRollenList()[0].ToString();
                var list = _rol.GetRollenList();
                list.RemoveAt(0);
                _rol.SetRollenList(list);
                //spelers de rollen gaan toewijzen
                _spel.MaakUsers(_filePath);
                //de spelerarray gaan shuffelen
                _spel.ShuffleList(_spel.SpelerList);

                //de volgende form gaan tonen bye bye o/ :)
                Hide();
                new showRolesGui().ShowDialog();
            }
        }

        //de user zelf een databestand laten kiezen
        private void DataFileButton_Click(object sender, EventArgs e)
        {
            _filePath = _filePicker.FileSelector();
            textBox1.ForeColor = Color.Black;
            textBox1.Text = "Data geselecteerd";
        }

        //button die de spelregelsGUI gaat openen
        private void SpelRegelsButton_Click(object sender, EventArgs e)
        {
            new Spelregels().ShowDialog();
        }

        //button die de spelbestandmaker gaat openen
        private void SpelBestandButton_Click(object sender, EventArgs e)
        {
            new SpelMaker().ShowDialog();
        }
    }
}
