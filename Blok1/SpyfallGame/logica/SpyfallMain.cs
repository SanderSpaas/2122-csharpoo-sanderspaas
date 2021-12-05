using System;
using System.Windows.Forms;

public class SpyfallMain
{
    public SpyfallMain()
    {

    }
    private static int aantalspelers;
    private static int aantalspionnen;

    public static int GetAantalspelers()
    {
        return aantalspelers;
    }

    public static void SetAantalspelers(int value)
    {
        aantalspelers = value;
    }

    public static int GetAantalspionnen()
    {
        return aantalspionnen;
    }

    public static void SetAantalspionnen(int value)
    {
        aantalspionnen = value;
    }

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

}
