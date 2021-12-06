using System;
using System.Collections;
using System.IO;
using System.Windows.Forms;

public class DataVerwerker
{
    public static String FileSelector()
    {
        using (OpenFileDialog openFileDialog = new OpenFileDialog())
        {
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "csv files (*.csv)|*.csv";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                return openFileDialog.FileName;
            }
            return null;
        }
    }

    public static bool TestData(String filePath)
    {
        //een tijdelijke arraylist om data om na te kijken in te zetten
        ArrayList checkList = new ArrayList();
        //eerst kijken of het bestand wel bestaat
        try
        {
            if (!File.Exists(filePath))
                throw new FileNotFoundException($"Het bestand bestaat niet op de opgegeven locatie: {filePath}");
        }
        catch (FileNotFoundException)
        {
            return false;
        }

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
                    if (rol == "" || rol == null)
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
}
