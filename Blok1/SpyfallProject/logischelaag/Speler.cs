namespace SpyfallProject.logischelaag
{
    public class Speler
    {
        private readonly string _rol = "";
        public Speler()
        {
        }
        public Speler(string rol)
        {
            if (!string.IsNullOrWhiteSpace(rol))
            {
                _rol = rol;
            }
        }
        public string Rol { get => _rol; }

    }
}