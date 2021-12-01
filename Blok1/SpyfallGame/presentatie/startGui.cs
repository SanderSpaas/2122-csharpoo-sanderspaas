using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using static Rollen;
using static Speler;
using static SpyfallMain;

namespace SpyfallGame
{
    public partial class Spyfall : Form
    {
        //de array waar we onze errors gaan insteken
        public static ArrayList errorArray = new ArrayList();
        private ArrayList rollenListSpel;

        public Spyfall()
        {
            InitializeComponent();
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
            //de errors gaan tonen
            foreach (string error in errorArray)
            {
                textBox1.Text = textBox1.Text + error;
            }
            //als er geen errors zijn dingen voor het spel beginnen klaarzetten
            if(errorArray.Count == 0)
            {
                KiesRadomRol(@"data\SpyfallData.csv");
                //spelerobjecten gaan aanmaken
                SetAantalspelers((int)aantalSpelers.Value);
                SetAantalspionnen((int)aantalSpionnen.Value);
                rollenListSpel = rollenList;
                for (int aantalSpelers = 0; aantalSpelers < GetAantalspelers()-GetAantalspionnen(); aantalSpelers++)
                {
                    //als er geen originele rollen meer overzijn de lijst gewoon opnieuw vullen met alle mogelijkheden
                    if (rollenList.Count == 0)
                    {
                        rollenListSpel = rollenList;
                    }
                    Random random = new Random();
                    //random gaan genereren
                    int randomRol = random.Next(0, rollenListSpel.Count);
                    Speler speler = new Speler(rollenListSpel[randomRol].ToString(), Locatie);
                    addSpeler(speler);
                    rollenListSpel.RemoveAt(randomRol); 
                }
                for (int aantalSpionnen = 0; aantalSpionnen < GetAantalspionnen(); aantalSpionnen++)
                {
                    Speler speler = new Speler("Spion", "Onbekend");
                    addSpeler(speler);
                }
            }
            
            foreach (Speler speler in Spelers)
            {
                textBox1.Text = textBox1.Text + speler.getRol() + "    ";
            }
            textBox1.Text = textBox1.Text + Locatie;

            //aantal spelers gaan setten

            //lijst van spelers gaan maken 
            for(int i = 0; i < GetAantalspelers(); i++)
            {

            }

            //code voor spelers
            //aantal spelers = aantal spelers - het aantal spionnen
            //het totaal aantal spelers bepaalt hoeveel spelerobjecten er aan gemaakt gaan worden
            //code voor spionnen
            //door de tijdelijke array gaan loopen en objecten gaan aanmaken met de data en in de echte array gaan zetten




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
    }
}
