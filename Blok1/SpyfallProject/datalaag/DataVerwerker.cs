using System.Collections;

namespace SpyfallProject.datalaag
{
    public interface IDataVerwerker
    {
        public bool TestData(String filePath)
        {
            //een tijdelijke arraylist om data om na te kijken in te zetten
            ArrayList checkList = new();
            //eerst kijken of het bestand wel bestaat
            if (!File.Exists(filePath)) return false;
            /// <summary>Gaan kijken of een bestand in gebruik is door een ander procces.
            /// <see cref="https://stackoverflow.com/questions/876473/is-there-a-way-to-check-if-a-file-is-in-use" />
            /// Geraadpleegd op 13 december 2021.
            /// Code lichtjes bewerkt om het werkend te krijgen, filepath werd origineel niet meegegeven
            /// </summary>
            try
            {
                using FileStream bestand = File.Open(filePath, FileMode.Open, FileAccess.Read, FileShare.None);
                bestand.Close();
            }
            catch (IOException)
            {
                //the file is unavailable because it is:
                //still being written to
                //or being processed by another thread
                //or does not exist (has already been processed)
                return false;
            }

            //kijken of er geen lege velden zijn in de data
            try
            {
                //alle lijnen in het document gaan lezen
                foreach (String line in File.ReadAllLines(filePath))
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
            return true;
        }

        //methode die een bestand gaat maken
        public void CreateFile(String filePath)
        {
            try
            {
                File.Create(filePath).Close();
            }
            catch (Exception)
            {
                throw new ArgumentNullException("FilePath was null");
            }
        }

        //methode die een bestand gaat uitlezen
        public string[] ReadFileContent(String filePath)
        {
            //alle lijnen in het document gaan lezen
            var lines = File.ReadAllLines(filePath);
            return lines;
        }

        //methode die data naar een bestand gaat schrijven
        public bool AddToFile(String filePath, String data)
        {
            try
            {
                File.AppendAllText(filePath, data + Environment.NewLine);
                return true;
            }
            catch (Exception)
            {

                throw new FileLoadException("Fout bij het schrijven naar het bestand");
            }
        }
    }
}