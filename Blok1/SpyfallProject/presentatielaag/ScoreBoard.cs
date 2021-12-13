using SpyfallProject.datalaag;
using SpyfallProject.logischelaag;

namespace SpyfallProject.presentatielaag
{
    public partial class ScoreBoard : Form
    {
        private readonly DataVerwerker _data = new();
        public ScoreBoard(SpyfallMain spel, string gewonnen)
        {
            InitializeComponent();
            Icon = new Icon("datalaag/spy.ico");
            DayOfWeek day = DateTime.Today.DayOfWeek;
            Days dag = Days.Dinsdag;
            switch (day)
            {
                case DayOfWeek.Monday:
                    dag = Days.Maandag;
                    break;
                case DayOfWeek.Tuesday:
                    dag = Days.Dinsdag;
                    break;
                case DayOfWeek.Wednesday:
                    dag = Days.Woensdag;
                    break;
                case DayOfWeek.Thursday:
                    dag = Days.Donderdag;
                    break;
                case DayOfWeek.Friday:
                    dag = Days.Vrijdag;
                    break;
                case DayOfWeek.Saturday:
                    dag = Days.Zaterdag;
                    break;
                case DayOfWeek.Sunday:
                    dag = Days.Zondag;
                    break;
                default:
                    break;
            }

            //huidige info gaan toevoegen 
            _data.AddToFile("datalaag/ScoreData.csv", "Winnaar: " + gewonnen + "   Aantal spelers: " + spel.Aantalspelers + "   Aantal spionnen: " + spel.Aantalspionnen + "    Aantal tijd: " + spel.AantalTijd + "min    De locatie: " + spel.Locatie + "    Op: " + dag.ToString() + "/" + DateTime.Today.Month + "/" + DateTime.Today.Year);

            //alles gaan uitlezen
            var lines = _data.ReadFileContent("datalaag/ScoreData.csv");
            foreach (var line in lines)
            {
                Scores.Text += line + "\r\n";
            }
        }
    }
}
