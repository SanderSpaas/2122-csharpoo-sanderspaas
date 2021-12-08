using System.Collections;
namespace SpyfallProject.datalaag
{
    public interface IDataVerwerker
    {
        public static bool TestData(String filePath)
        {
            //een tijdelijke arraylist om data om na te kijken in te zetten
            ArrayList checkList = new();
            //eerst kijken of het bestand wel bestaat
            if (!File.Exists(filePath)) return false;

            //kijken of er geen lege velden zijn in de data
            try
            {

                //alle lijnen in het document gaan lezen
                var lines = File.ReadAllLines(filePath);
                foreach (String line in lines)
                {
                    checkList.AddRange(line.Split(';'));
                    if (checkList == null)
                    {
                        throw new ArgumentException("Het bestand heeft een incorrecte data-opbouw");
                    }
                    foreach (String rol in checkList)
                    {
                        //gaan checken of de elementen leeg zijn
                        if (string.IsNullOrWhiteSpace(rol))
                        {
                            throw new ArgumentException("Het bestand heeft een incorrecte data-opbouw, de locatie of rol kan niet leeg zijn");
                        }
                    }
                    //lijst gaan clearen zodat we de volgende lijn kunnen gaan checken
                    checkList.Clear();
                }
            }
            catch (ArgumentException)
            {
                return false;
            }
            //als alles in orde is returnen we true
            return true;
        }

        //methode die een bestand gaat maken
        public static void CreateFile(String filePath)
        {
            File.Create(filePath).Close();
        }

        //methode die een bestand gaat uitlezen
        public static string[] ReadFileContent(String filePath)
        {
            //alle lijnen in het document gaan lezen
            var lines = File.ReadAllLines(filePath);
            return lines;
        }

        //methode die data naar een bestand gaat schrijven
        public static bool AddToFile(String filePath, String _DataCSVLocation, String _DataCSVRoles)
        {
            try
            {
                File.AppendAllText(filePath, _DataCSVLocation + _DataCSVRoles + Environment.NewLine);
                return true;
            }
            catch (Exception)
            {

                throw new FileLoadException("Fout bij het schrijven naar het bestand");
            }
        }
    }
}