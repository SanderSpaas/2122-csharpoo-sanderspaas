namespace SpyfallProject.logischelaag
{
    public class Speler
    {
        public Speler(string rol)
        {
            if (!string.IsNullOrWhiteSpace(rol))
            {
                Rol = rol;
            }
        }
        public string Rol { get; } = "";

    }
}