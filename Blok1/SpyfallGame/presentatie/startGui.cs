using SpyfallGame.presentatie;
using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using static Rollen;
using static Speler;
using static SpyfallGame.logica.Shuffle;
using static SpyfallMain;

namespace SpyfallGame
{
    public partial class Spyfall : Form
    {
        //de array waar we onze errors gaan insteken
        public static ArrayList errorArray = new ArrayList();
        private ArrayList rollenListSpel = new ArrayList();
        private string filePath = @"data\SpyfallData.csv";

        public Spyfall()
        {
            InitializeComponent();
            Icon = new Icon("data/spy.ico");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorArray.Clear();
            textBox1.Text = "";
            //data die de speler geselecteerd heeft gaan controleren en eventueel errors tonen
            //zoeken waarom kleur niet werkt
            textBox1.ForeColor = Color.Red;
            if (aantalSpelers.Value < 4)
            {
                errorArray.Add("Je moet dit spel met 4 of meer spelen. \n");
            }
            if (aantalSpelers.Value > 10)
            {
                errorArray.Add("Je kan dit spel met niet meer dan 10 spelers spelen. \n");
            }
            if (aantalSpionnen.Value == 0)
            {
                errorArray.Add("Je moet minstens 1 spion hebben. \n");
            }
            if (aantalSpionnen.Value >= aantalSpelers.Value)
            {
                errorArray.Add("Je kan niet meer of evenveel spionnen als spelers hebben. \n");
            }

            //gaan kijken of er costum data gekozen is en anders de default data gaan gebruiken
            if (TestData(filePath))
            {
                KiesRandomRol(filePath);
            }
            else
            {
                errorArray.Add("Het gekozen databestand is ongeldig");
            }

            //de errors gaan tonen
            foreach (string error in errorArray)
            {
                textBox1.Text = textBox1.Text + error;
            }

            //als er geen errors zijn dingen voor het spel beginnen klaarzetten
            if (errorArray.Count == 0)
            {
                //random data uit ons bestand gaan laden en in de rollenlist gaan zetten

                //het aantal spelers en spionnen gaan vastzetten
                SetAantalspelers((int)aantalSpelers.Value);
                SetAantalspionnen((int)aantalSpionnen.Value);

                //code voor spelers
                //het totaal aantal spelers bepaalt hoeveel spelerobjecten er aan gemaakt gaan worden
                //aantal spelers = aantal spelers - het aantal spionnen
                int aantalSpelersTeller = GetAantalspelers();
                int aantalSpionnenTeller = GetAantalspionnen();
                Random random = new Random();
                for (int aantalSpelers = 0; aantalSpelers < aantalSpelersTeller - aantalSpionnenTeller; aantalSpelers++)
                {
                    //als er geen originele rollen meer overzijn de lijst gewoon opnieuw vullen met alle mogelijkheden
                    //hiermee word de lijst ook origineel gevuld
                    if (rollenListSpel.Count == 0)
                    {
                        rollenListSpel.AddRange(rollenList);
                        //textBox1.Text = textBox1.Text +  "rollenlist aangevuld";
                    }

                    //random gaan genereren
                    int randomRol = random.Next(0, rollenListSpel.Count);

                    //spelerobjecten gaan aanmaken
                    Speler speler = new Speler(rollenListSpel[randomRol].ToString(), Locatie);
                    addSpeler(speler);

                    //de rol gaan verwijderen uit de tijdelijke array zodat hij niet nog is gekozen word
                    rollenListSpel.RemoveAt(randomRol);
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
                textBox1.Text = textBox1.Text + speler.GetRol() + "    ";
            }
            //de locatie ook gaan tonen in het errorvak
            textBox1.Text = textBox1.Text + Locatie;

        }

        //de user zelf een databestand laten kiezen
        private void dataFileButton_Click(object sender, EventArgs e)
        {
            filePath = FileSelector();
            textBox1.Text = "Costum data geselecteerd";
        }

        //button die de spelregelsGUI gaat openen
        private void SpelRegelsButton_Click(object sender, EventArgs e)
        {
            new Spelregels().Show();
        }
        //button die de spelbestandmaker gaat openen
        private void SpelBestandButton_Click(object sender, EventArgs e)
        {
            new SpelMaker().Show();
        }

        private void Spyfall_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void aantalSpelers_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


    }
}
