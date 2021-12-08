﻿using SpyfallProject.datalaag;
using SpyfallProject.logischelaag;
using System.Collections;
using static SpyfallProject.datalaag.IDataVerwerker;
namespace SpyfallProject.presentatielaag
{
    public partial class startGui : Form
    {
        //de array waar we onze errors gaan insteken
        private readonly ArrayList _ErrorArray = new();
        private readonly ArrayList _RollenListSpel = new();
        private string _FilePath = @"datalaag\SpyfallData.csv";
        private SpyfallMain spel = new();
        private Rollen _Rol = new();
        private FilePicker _FilePicker = new();
        //private static readonly ArrayList RollenList = new();
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
            textBox1.BackColor = Color.FromArgb(240, 240, 240);
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
            if (!TestData(_FilePath))
            {
                _ErrorArray.Add("Het gekozen databestand is ongeldig");
            }

            //de errors gaan tonen
            foreach (string error in _ErrorArray)
            {
                textBox1.Text = $"{textBox1.Text}{error}";
            }

            //als er geen errors zijn dingen voor het spel beginnen klaarzetten
            if (_ErrorArray.Count == 0)
            {
                //het aantal spelers en spionnen gaan vastzetten
                spel.Aantalspelers = (int)aantalSpelers.Value;
                spel.Aantalspionnen = (int)aantalSpionnen.Value;
                //een rollenlijst laten aanmaken
                _Rol.KiesRandomRol(_FilePath);
                //spelers de rollen gaan toewijzen
                spel.MaakUsers(_FilePath);
                //de spelerarray gaan shuffelen
                spel.ShuffleList(spel.SpelerList);

                //de volgende form gaan tonen bye bye o/ :)
                Hide();
                new showRolesGui().ShowDialog();
            }
        }

        //de user zelf een databestand laten kiezen
        private void DataFileButton_Click(object sender, EventArgs e)
        {
            _FilePath = _FilePicker.FileSelector();
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
