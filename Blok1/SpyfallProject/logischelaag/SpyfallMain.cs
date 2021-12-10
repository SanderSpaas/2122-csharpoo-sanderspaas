using System.Collections;
namespace SpyfallProject.logischelaag
{
    public class SpyfallMain
    {
        private int _aantalSpelers;
        private int _aantalSpionnen;
        private int _aantalTijd;
        private string _locatie = "";
        private readonly Random _random = new();
        private readonly ArrayList _rollenListSpel = new();
        private ArrayList _spelerList = new();
        private string _filePath = @"datalaag\SpyfallData.csv";
        public SpyfallMain()
        {
        }
        public SpyfallMain(int aantalSpelers, int aantalSpionnen, int aantalTijd, string locatie, string filePath)
        {
            _aantalSpelers = (aantalSpelers <= 10 && aantalSpelers >= 4) ? aantalSpelers : throw new ArgumentException("Aantal spelers mag niet meer dan 10 en niet minder dan 4 zijn"); ;
            _aantalSpionnen = (aantalSpionnen != 0) ? aantalSpionnen : throw new ArgumentException("Aantal spionnen mag niet 0 zijn");
            _aantalTijd = aantalTijd;
            _locatie = (!string.IsNullOrWhiteSpace(locatie)) ? locatie : throw new ArgumentException("Locatie mag niet leeg zijn");
            _filePath = (!string.IsNullOrWhiteSpace(filePath)) ? filePath : throw new ArgumentException("FilePath mag niet leeg zijn");
        }

        public int Aantalspelers { get => _aantalSpelers; }
        public int Aantalspionnen { get => _aantalSpionnen; }
        public int AantalTijd { get => _aantalTijd; }
        public string Locatie { get => _locatie; }
        public string FilePath { get => _filePath; }
        public ArrayList SpelerList { get => _spelerList; set => _spelerList = value ?? throw new ArgumentException("Spelerlijst mag niet leeg zijn"); }

        public void Voegtoe(Speler speler)
        {
            SpelerList.Add(speler);
        }
        public void MaakUsers(ArrayList rollenList)
        {
            for (int aantalSpelersAangemaakt = 0; aantalSpelersAangemaakt < _aantalSpelers - _aantalSpionnen; aantalSpelersAangemaakt++)
            {
                //als er geen originele rollen meer overzijn de lijst gewoon opnieuw vullen met alle mogelijkheden
                //hiermee word de lijst ook origineel gevuld
                if (_rollenListSpel.Count == 0)
                {
                    _rollenListSpel.AddRange(rollenList);
                }
                int randomRol = _random.Next(0, _rollenListSpel.Count);

                //spelerobjecten gaan aanmaken
                Speler speler = new(rol: _rollenListSpel[randomRol].ToString());
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
