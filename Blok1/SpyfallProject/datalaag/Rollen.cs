namespace SpyfallProject.datalaag
{
    public class Rollen : IDataVerwerker
    {
        public Rollen()
        {
        }
        public Rollen(String rol)
        {
            Rol = rol;
        }
        public void KiesRandomRol(String filePath)
        {
            //alle lijnen in het document gaan lezen
            string[] lines = File.ReadAllLines(filePath);
            Random random = new();
            int randomGetal = random.Next(0, lines.Length);
            //de random gekozen lijn gaan splitsen op basis van een delimiter in een tijdelijke list
            string[] rollenListString = lines[randomGetal].Split(';');
            foreach (string rolLijst in rollenListString)
            {
                var rol = new Rollen(rolLijst);
                RollenList.Add(rol);
            }
        }
        public List<Rollen> RollenList { get; set; } = new();
        public string Rol { get; set; }

        public void SetRollenList(List<Rollen> value)
        {
            if (value != null)
            {
                RollenList = value;
            }
        }
    }
}