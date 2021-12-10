using SpyfallProject.datalaag;
using SpyfallProject.logischelaag;
using System.Collections;
namespace SpyfallProject.presentatielaag
{
    public partial class startGui : Form
    {
        //de array waar we onze errors gaan insteken
        private readonly ArrayList _errorArray = new();
        private readonly SpyfallMain _spel = new();
        private string _filePath = "";
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
            _filePath = _spel.FilePath;
            textBox1.Text = "";
            //data die de speler geselecteerd heeft gaan controleren en eventueel errors tonen
            textBox1.BackColor = Color.FromArgb(240, 240, 240);
            textBox1.ForeColor = Color.Red;
            if (aantalSpionnen.Value >= aantalSpelers.Value)
            {
                _errorArray.Add("Je kan niet meer of evenveel spionnen als het aantal spelers hebben. \n");
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
            //als er geen errors zijn naar de volgende form gaan
            if (_errorArray.Count == 0)
            {
                //de volgende form gaan tonen bye bye o/ :)
                Hide();
                new ShowRolesGui((int)aantalSpelers.Value, (int)aantalSpionnen.Value, (int)aantalTijd.Value, _filePath).Show();
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
