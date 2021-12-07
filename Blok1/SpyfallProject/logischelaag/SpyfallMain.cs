using SpyfallProject.datalaag;
using System.Collections;
namespace SpyfallProject.logischelaag
{
    internal class SpyfallMain
    {
        private static int _Aantalspelers;
        private static int _Aantalspionnen;
        private readonly Random _Random = new();
        private ArrayList _RollenListSpel = new();
        private static ArrayList _SpelerList = new();
        private readonly Random random = new();
        public SpyfallMain()
        {
        }

        public int Aantalspelers { get => _Aantalspelers; set => _Aantalspelers = value; }
        public int Aantalspionnen { get => _Aantalspionnen; set => _Aantalspionnen = value; }
        public ArrayList SpelerList { get => _SpelerList; set => _SpelerList = value; }

        public void Voegtoe(Speler speler)
        {
            SpelerList.Add(speler);
        }
        public void MaakUsers(string filePath)
        {
            Rollen _Rol = new();
            for (int aantalSpelers = 0; aantalSpelers < Aantalspelers - Aantalspionnen; aantalSpelers++)
            {
                //als er geen originele rollen meer overzijn de lijst gewoon opnieuw vullen met alle mogelijkheden
                //hiermee word de lijst ook origineel gevuld
                if (_RollenListSpel.Count == 0)
                {
                    _RollenListSpel.AddRange(_Rol.RollenList);
                }
                int randomRol = _Random.Next(0, _RollenListSpel.Count);

                //spelerobjecten gaan aanmaken
                Speler speler = new(_RollenListSpel[randomRol].ToString(), _Rol.Locatie);
                Voegtoe(speler);
                //de rol gaan verwijderen uit de tijdelijke array zodat hij niet nog is gekozen word
                _RollenListSpel.RemoveAt(randomRol);
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
                int j = random.Next(i, lijst.Count);
                Speler tempSpeler = (Speler)lijst[i];
                lijst[i] = lijst[j];
                lijst[j] = tempSpeler;
            }
        }
    }
    //    public static void SetAantalspelers(int value)
    //    {
    //        Aantalspelers = value;
    //        try
    //        {
    //            if (value > 10)
    //            {
    //                throw new ArgumentException("Het aantal spelers kan niet groter dan 10 en niet kleiner dan 4 zijn");
    //            }
    //            if (value <= 4)
    //            {
    //                throw new ArgumentException("Het aantal spelers kan niet groter dan 10 en niet kleiner dan 4 zijn");
    //            }

    //        }
    //        finally { Aantalspelers = value; };
    //    }

    //    public static void SetAantalspionnen(int value)
    //    {
    //        try
    //        {
    //            if (value == 0)
    //            {
    //                throw new ArgumentException("Het aantal spionnen kan niet 0 zijn");
    //            }
    //        }
    //        finally { Aantalspionnen = value; };
    //    }
    //}

}
