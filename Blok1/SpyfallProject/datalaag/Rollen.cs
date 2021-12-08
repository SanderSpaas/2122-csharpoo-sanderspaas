using System.Collections;
namespace SpyfallProject.datalaag
{
    public class Rollen
    {
        private static ArrayList _rollenList = new();

        public Rollen()
        {
        }
        public void KiesRandomRol(String filePath)
        {
            //tijdelijke arraylist
            ArrayList rollenListString = new();

            //alle lijnen in het document gaan lezen
            var lines = File.ReadAllLines(filePath);
            Random random = new();
            int randomGetal = random.Next(0, lines.Length);

            //de random gekozen lijn gaan splitsen op basis van een delimiter in een tijdelijke arraylist
            rollenListString.AddRange(lines[randomGetal].Split(';'));

            //data gaan vastzetten
            SetRollenList(rollenListString);
        }

        public ArrayList GetRollenList()
        {
            return _rollenList;
        }

        public void SetRollenList(ArrayList value)
        {
            if (value != null)
            {
                _rollenList = value;
            }
        }
    }
}