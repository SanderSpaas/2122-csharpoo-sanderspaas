using SpyfallProject.datalaag;
using SpyfallProject.logischelaag;

namespace SpyfallProject.presentatielaag
{
    public partial class ScoreBoard : Form
    {
        private DataVerwerker _data = new();
        public ScoreBoard(SpyfallMain spel)
        {
            InitializeComponent();
            Icon = new Icon("datalaag/spy.ico");
            //vorige spelsessies info gaan tonen

            //huidige info gaan toevoegen 
            _data.AddToFile("datalaag/ScoreData.csv", "Aantal spelers: " + spel.Aantalspelers + " Aantal spionnen: " + spel.Aantalspionnen + " Aantal tijd: " + spel.AantalTijd + "Minuten De locatie: " + spel.Locatie);

            //alles gaan uitlezen
            var lines = _data.ReadFileContent("datalaag/ScoreData.csv");
            foreach (var line in lines)
            {
                Scores.Text += line;
            }
        }
    }
}
