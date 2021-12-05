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
            Icon = new Icon("data/spy.ico");

        }
        //variables
        String dataCSVLocation;
        String dataCSVRoles;
        String filePath;

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (LocatieTextbox.Text != null && LocatieTextbox.Text != "")
            {
                dataCSVLocation = LocatieTextbox.Text.Trim();
            }
            if (RolTextBox.Text != null && RolTextBox.Text != "")
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

            }

        }
        //een al bestaan bestand gaan bijwerken met extra data
        private void LaadBestandButton_Click(object sender, EventArgs e)
        {
            filePath = FileSelector();
            showFileContent(filePath, true);
        }
        private void VoegToeButton_Click(object sender, EventArgs e)
        {
            addToFile(filePath);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void OutputTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void showFileContent(String filePath, bool read)
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
    }
}
