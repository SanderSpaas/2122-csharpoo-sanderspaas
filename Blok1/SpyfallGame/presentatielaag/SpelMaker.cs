using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using static SpyfallMain;

namespace SpyfallGame.presentatie
{
    public partial class SpelMaker : Form
    {
        public SpelMaker()
        {
            InitializeComponent();
            Icon = new Icon("datalaag/spy.ico");

        }
        //variables
        String dataCSVLocation;
        String dataCSVRoles;
        String filePath;

        //knop die de ingegeven data gaat opslaan in vars zodat ze later eventueel in bestand gezet kunnen worden
        private void AddButton_Click(object sender, EventArgs e)
        {
            if (CheckInput(LocatieTextbox.Text))
            {
                dataCSVLocation = LocatieTextbox.Text.Trim();
            }
            if (CheckInput(RolTextBox.Text))
            {
                dataCSVRoles = dataCSVRoles + ";" + RolTextBox.Text.Trim();
            }
            RolTextBox.Text = "";
            OutputTextBox.Text = $"De locatie is: {dataCSVLocation} De rollen zijn: {dataCSVRoles}";
        }
        //het CSV bestand gaan aanmaken 
        private void GenereerBestand_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "csv files (*.csv)|*.csv";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //geen data gaan schrijven gewoon het bestand al selecteren
                filePath = saveFileDialog1.FileName;
                //het bestand gaan aanmaken
                File.Create(saveFileDialog1.FileName).Close();
                showFileContent(filePath, false);
                EnableInput();
            }

        }
        //een bestaand bestand gaan selecteren om dingen aan toe te voegen
        private void LaadBestandButton_Click(object sender, EventArgs e)
        {
            filePath = FileSelector();
            showFileContent(filePath, true);
            EnableInput();
        }

        //button die de data gaat laten toevoegen
        private void VoegToeButton_Click(object sender, EventArgs e)
        {
            addToFile(filePath);
        }

        //methode die een bestand gaat uitlezen
        private void showFileContent(String filePath, bool read)
        {
            if (!TestData(filePath))
            {
                OutputTextBox.Text = "Het gekozen databestand is ongeldig. \r\n";
            }
            else
            {
                OutputTextBox.Text = "Bestand geselecteerd. \r\n";
                if (read)
                {
                    //alle lijnen in het document gaan lezen
                    var lines = File.ReadAllLines(filePath);
                    foreach (var line in lines)
                    {
                        OutputTextBox.Text = OutputTextBox.Text + line + "\r\n";
                    }
                }
                GeselecteerdeBestandTextBox.Text = filePath;
            }
        }

        //methode die data naar een bestand gaat schrijven
        private void addToFile(String filePath)
        {
            File.AppendAllText(filePath, dataCSVLocation + dataCSVRoles + Environment.NewLine);
            dataCSVLocation = "";
            dataCSVRoles = "";
            OutputTextBox.Text = "";
            LocatieTextbox.Text = "";
            OutputTextBox.Text = "Data naar bestand geschreven. \r\n";
            showFileContent(filePath, true);
        }

        //saniteer data die binnenkomt 
        private bool CheckInput(String input)
        {
            input = input.Trim();
            if (input == null)
            {
                return false;
            }
            if (input == "")
            {
                return false;
            }
            if (input.Contains(";"))
            {
                return false;
            }
            return true;
        }

        private void EnableInput()
        {
            LocatieTextbox.Enabled = true;
            RolTextBox.Enabled = true;
            AddButton.Enabled = true;
        }
    }
}
