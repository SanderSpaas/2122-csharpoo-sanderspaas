using SpyfallProject.logischelaag;
using System.Collections;
using static SpyfallProject.datalaag.DataVerwerker;
using static SpyfallProject.datalaag.Rollen;
using static SpyfallProject.logischelaag.Shuffle;
using static SpyfallProject.logischelaag.Speler;
using static SpyfallProject.presentatielaag.FilePicker;
namespace SpyfallProject.presentatielaag
{
    public partial class startGui : Form
    {
        //de array waar we onze errors gaan insteken
        private ArrayList _ErrorArray = new();
        private ArrayList _RollenListSpel = new();
        private string _FilePath = @"datalaag\SpyfallData.csv";

        public startGui()
        {
            InitializeComponent();
            Icon = new Icon("datalaag/spy.ico");
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            _ErrorArray.Clear();
            textBox1.Text = "";
            //data die de speler geselecteerd heeft gaan controleren en eventueel errors tonen
            //zoeken waarom kleur niet werkt
            textBox1.ForeColor = Color.Red;
            if (aantalSpelers.Value < 4)
            {
                _ErrorArray.Add("Je moet dit spel met 4 of meer spelen. \n");
            }
            if (aantalSpelers.Value > 10)
            {
                _ErrorArray.Add("Je kan dit spel met niet meer dan 10 spelers spelen. \n");
            }
            if (aantalSpionnen.Value == 0)
            {
                _ErrorArray.Add("Je moet minstens 1 spion hebben. \n");
            }
            if (aantalSpionnen.Value >= aantalSpelers.Value)
            {
                _ErrorArray.Add("Je kan niet meer of evenveel spionnen als spelers hebben. \n");
            }

            //gaan kijken of er costum data gekozen is en anders de default data gaan gebruiken
            if (TestData(_FilePath))
            {
                KiesRandomRol(_FilePath);
            }
            else
            {
                _ErrorArray.Add("Het gekozen databestand is ongeldig");
            }

            //de errors gaan tonen
            foreach (string error in _ErrorArray)
            {
                textBox1.Text = textBox1.Text + error;
            }

            //als er geen errors zijn dingen voor het spel beginnen klaarzetten
            if (_ErrorArray.Count == 0)
            {
                //random data uit ons bestand gaan laden en in de rollenlist gaan zetten

                //het aantal spelers en spionnen gaan vastzetten
                Aantalspelers = ((int)aantalSpelers.Value);
                Aantalspionnen = ((int)aantalSpionnen.Value);

                //code voor spelers
                //het totaal aantal spelers bepaalt hoeveel spelerobjecten er aan gemaakt gaan worden
                //aantal spelers = aantal spelers - het aantal spionnen
                int aantalSpelersTeller = Aantalspelers;
                int aantalSpionnenTeller = Aantalspionnen;
                Random random = new();
                for (int aantalSpelers = 0; aantalSpelers < aantalSpelersTeller - aantalSpionnenTeller; aantalSpelers++)
                {
                    //als er geen originele rollen meer overzijn de lijst gewoon opnieuw vullen met alle mogelijkheden
                    //hiermee word de lijst ook origineel gevuld
                    if (_RollenListSpel.Count == 0)
                    {
                        _RollenListSpel.AddRange(RollenList);
                        //textBox1.Text = textBox1.Text +  "rollenlist aangevuld";
                    }

                    //random gaan genereren
                    int randomRol = random.Next(0, _RollenListSpel.Count);

                    //spelerobjecten gaan aanmaken
                    Speler speler = new Speler(_RollenListSpel[randomRol].ToString(), Locatie);
                    addSpeler(speler);

                    //de rol gaan verwijderen uit de tijdelijke array zodat hij niet nog is gekozen word
                    _RollenListSpel.RemoveAt(randomRol);
                }
                //code voor spionnen
                for (int aantalSpionnen = 0; aantalSpionnen < aantalSpionnenTeller; aantalSpionnen++)
                {
                    Speler speler = new Speler("Spion", "Onbekend");
                    addSpeler(speler);
                }
                //de spelerarray gaan shuffelen
                ShuffleList(Spelers);

                //de volgende form gaan tonen bye bye o/ :)
                //de huidige form gaan hiden
                Hide();
                new showRolesGui().Show();
            }
            //debug om spelers met hun rollen te zien in het errorvak
            foreach (Speler speler in Spelers)
            {
                textBox1.Text += speler.Rol + "    ";
            }
            //de locatie ook gaan tonen in het errorvak
            textBox1.Text += Locatie;

        }

        //de user zelf een databestand laten kiezen
        private void dataFileButton_Click(object sender, EventArgs e)
        {
            _FilePath = FileSelector();
            textBox1.Text = "Costum data geselecteerd";
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
