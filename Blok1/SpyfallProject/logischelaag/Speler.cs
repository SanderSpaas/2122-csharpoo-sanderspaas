using System.Collections;
namespace SpyfallProject.logischelaag
{
    public class Speler
    {
        private readonly string _Rol = "";
        private readonly string _Locatie = "";
        private static int _Aantalspelers;
        private static int _Aantalspionnen;
        private static readonly ArrayList spelers = new();

        public Speler(string rol, string locatie)
        {
            if (!string.IsNullOrWhiteSpace(rol))
            {
                _Rol = rol;
            }
            if (!string.IsNullOrWhiteSpace(locatie))
            {
                _Locatie = locatie;
            }

        }

        public static int Aantalspionnen { get => _Aantalspionnen; set => _Aantalspionnen = value; }
        public static int Aantalspelers { get => _Aantalspelers; set => _Aantalspelers = value; }
        public static ArrayList Spelers { get => spelers; }
        public string Locatie { get => _Locatie; }
        public string Rol { get => _Rol; }

        public static void AddSpeler(Speler speler)
        {
            Spelers.Add(speler);
        }

        public static void SetAantalspelers(int value)
        {
            Aantalspelers = value;
            try
            {
                if (value > 10)
                {
                    throw new ArgumentException("Het aantal spelers kan niet groter dan 10 en niet kleiner dan 4 zijn");
                }
                if (value <= 4)
                {
                    throw new ArgumentException("Het aantal spelers kan niet groter dan 10 en niet kleiner dan 4 zijn");
                }

            }
            finally { Aantalspelers = value; };
        }

        public static void SetAantalspionnen(int value)
        {
            try
            {
                if (value == 0)
                {
                    throw new ArgumentException("Het aantal spionnen kan niet 0 zijn");
                }
            }
            finally { Aantalspionnen = value; };
        }
    }
}