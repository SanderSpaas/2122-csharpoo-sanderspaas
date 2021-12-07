namespace SpyfallProject.logischelaag
{
    public class Speler
    {
        private readonly string _Rol = "";
        private readonly string _Locatie = "";

        public Speler()
        {
        }
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

        public string Locatie { get => _Locatie; }
        public string Rol { get => _Rol; }

    }
}