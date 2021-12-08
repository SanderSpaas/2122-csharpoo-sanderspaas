using System.Collections;
namespace SpyfallProject.logischelaag
{
    public class SpyfallMain
    {
        private int _aantalspelers;
        private int _aantalspionnen;
        private string _locatie;
        private readonly Random _random = new();
        private readonly ArrayList _rollenListSpel = new();
        private ArrayList _spelerList = new();
        private string _filePath = @"datalaag\SpyfallData.csv";
        public SpyfallMain()
        {
        }

        public int Aantalspelers { get => _aantalspelers; set => _aantalspelers = (value < 10 && value > 4) ? value : throw new ArgumentException("Aantal spionnen mag niet meer dan 10 en niet minder dan 4 zijn"); }
        public int Aantalspionnen { get => _aantalspionnen; set => _aantalspionnen = (value != 0) ? value : throw new ArgumentException("Aantal spionnen mag niet 0 zijn"); }
        public string Locatie { get => _locatie; set => _locatie = (!string.IsNullOrWhiteSpace(value)) ? value : throw new ArgumentException("Locatie mag niet leeg zijn"); }
        public ArrayList SpelerList { get => _spelerList; set => _spelerList = value ?? throw new ArgumentException("Spelerlijst mag niet leeg zijn"); }
        public string FilePath { get => _filePath; set => _filePath = (!string.IsNullOrWhiteSpace(value)) ? value : throw new ArgumentException("FilePath mag niet leeg zijn"); }

        public void Voegtoe(Speler speler)
        {
            SpelerList.Add(speler);
        }
        public void MaakUsers(ArrayList rollenList)
        {
            for (int aantalSpelers = 0; aantalSpelers < Aantalspelers - Aantalspionnen; aantalSpelers++)
            {
                //als er geen originele rollen meer overzijn de lijst gewoon opnieuw vullen met alle mogelijkheden
                //hiermee word de lijst ook origineel gevuld
                if (_rollenListSpel.Count == 0)
                {
                    _rollenListSpel.AddRange(rollenList);
                }
                int randomRol = _random.Next(0, _rollenListSpel.Count);

                //spelerobjecten gaan aanmaken
                Speler speler = new(_rollenListSpel[randomRol].ToString());
                Voegtoe(speler);
                //de rol gaan verwijderen uit de tijdelijke array zodat hij niet nog is gekozen word
                _rollenListSpel.RemoveAt(randomRol);
            }
            //code voor spionnen
            for (int aantalSpionnen = 0; aantalSpionnen < Aantalspionnen; aantalSpionnen++)
            {
                Speler speler = new("Spion");
                Voegtoe(speler);
            }
        }

        public void ShuffleList(ArrayList lijst)
        {
            //de data gaan shufflen in de array
            for (int i = 0; i < lijst.Count - 1; i++)
            {
                int j = _random.Next(i, lijst.Count);
                Speler tempSpeler = (Speler)lijst[i];
                lijst[i] = lijst[j];
                lijst[j] = tempSpeler;
            }
        }
    }
}
