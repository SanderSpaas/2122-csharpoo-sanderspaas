using SpyfallProject.datalaag;
using System.Collections;
namespace SpyfallProject.logischelaag
{
    public class SpyfallMain
    {
        private static int _aantalspelers;
        private static int _aantalspionnen;
        private static string _locatie;
        private readonly Random _random = new();
        private readonly ArrayList _rollenListSpel = new();
        private static ArrayList _spelerList = new();
        private readonly Rollen _rol = new();
        public SpyfallMain()
        {
        }

        public int Aantalspelers { get => _aantalspelers; set => _aantalspelers = value; }
        public int Aantalspionnen { get => _aantalspionnen; set => _aantalspionnen = value; }
        public string Locatie { get => _locatie; set => _locatie = value; }
        public ArrayList SpelerList { get => _spelerList; set => _spelerList = value; }

        public void Voegtoe(Speler speler)
        {
            SpelerList.Add(speler);
        }
        public void MaakUsers(string filePath)
        {

            for (int aantalSpelers = 0; aantalSpelers < Aantalspelers - Aantalspionnen; aantalSpelers++)
            {
                //als er geen originele rollen meer overzijn de lijst gewoon opnieuw vullen met alle mogelijkheden
                //hiermee word de lijst ook origineel gevuld
                if (_rollenListSpel.Count == 0)
                {
                    _rollenListSpel.AddRange(_rol.GetRollenList());
                }
                int randomRol = _random.Next(0, _rollenListSpel.Count);

                //spelerobjecten gaan aanmaken
                Speler speler = new(_rollenListSpel[randomRol].ToString(), Locatie);
                Voegtoe(speler);
                //de rol gaan verwijderen uit de tijdelijke array zodat hij niet nog is gekozen word
                _rollenListSpel.RemoveAt(randomRol);
            }

            //code voor spionnen
            for (int aantalSpionnen = 0; aantalSpionnen < Aantalspionnen; aantalSpionnen++)
            {
                Speler speler = new("Spion", "Onbekend");
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
