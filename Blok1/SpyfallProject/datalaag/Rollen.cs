using System.Collections;
namespace SpyfallProject.datalaag
{
    public class Rollen
    {
        private string _Locatie = "";
        private static ArrayList rollenList;

        public Rollen()
        {
        }

        public void KiesRandomRol(String filePath)
        {
            //tijdelijke arraylist
            ArrayList rollenListString = new ArrayList();

            //alle lijnen in het document gaan lezen
            var lines = File.ReadAllLines(filePath);
            Random random = new();
            int randomGetal = random.Next(0, lines.Count());

            //de random gekozen lijn gaan splitsen op basis van een delimiter in een tijdelijke arraylist
            rollenListString.AddRange(lines[randomGetal].Split(';'));

            //de locatie gaan vastzetten en daarna verwijderen uit de array
            _Locatie = rollenListString[0].ToString();
            rollenListString.RemoveAt(0);

            //data gaan vastzetten
            RollenList = rollenListString;
        }

        public ArrayList RollenList { get => rollenList; set => rollenList = value; }
        public string Locatie { get => _Locatie; set => _Locatie = value; }
    }
}