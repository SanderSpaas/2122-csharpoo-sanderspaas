using static DataVerwerker;
using static SpyfallProject.presentatielaag.FilePicker;
namespace SpyfallProject.presentatielaag

{
    public partial class SpelMaker : Form
    {
        //variables
        private string _DataCSVLocation = "";
        private string _DataCSVRoles = "";
        private string _FilePath = "";

        public SpelMaker()
        {
            InitializeComponent();
            Icon = new Icon("datalaag/spy.ico");

        }

        //knop die de ingegeven data gaat opslaan in vars zodat ze later eventueel in bestand gezet kunnen worden
        private void AddButton_Click(object sender, EventArgs e)
        {
            if (CheckInput(LocatieTextbox.Text))
            {
                _DataCSVLocation = LocatieTextbox.Text.Trim();
            }
            if (CheckInput(RolTextBox.Text))
            {
                _DataCSVRoles = _DataCSVRoles + ";" + RolTextBox.Text.Trim();
            }
            RolTextBox.Text = "";
            OutputTextBox.Text = $"De locatie is: {_DataCSVLocation} De rollen zijn: {_DataCSVRoles}";
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
                _FilePath = saveFileDialog1.FileName;
                //het bestand gaan aanmaken
                CreateFile(_FilePath);
                OutputTextBox.Text = "Bestand geselecteerd. \r\n";
                GeselecteerdeBestandTextBox.Text = _FilePath;
                EnableInput();
            }

        }
        //een bestaand bestand gaan selecteren om dingen aan toe te voegen
        private void LaadBestandButton_Click(object sender, EventArgs e)
        {
            _FilePath = FileSelector();
            if (!TestData(_FilePath))
            {
                OutputTextBox.Text = "Het gekozen databestand is ongeldig. \r\n";
            }
            else
            {
                var lines = showFileContent(_FilePath);
                OutputTextBox.Text = "Bestand geselecteerd. \r\n";
                ShowData(lines);
                GeselecteerdeBestandTextBox.Text = _FilePath;
                EnableInput();
            }
        }

        //button die de data gaat laten toevoegen
        private void VoegToeButton_Click(object sender, EventArgs e)
        {
            if (addToFile(_FilePath, _DataCSVLocation, _DataCSVRoles))
            {
                OutputTextBox.Text = "Data naar bestand geschreven. \r\n";
            }
            ClearFields();
            var lines = showFileContent(_FilePath);
            ShowData(lines);
        }

        //saniteer data die binnenkomt 
        private bool CheckInput(String input)
        {
            input = input.Trim();
            if (string.IsNullOrWhiteSpace(input))
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
            VoegToeButton.Enabled = true;
        }
        private void ClearFields()
        {
            _DataCSVLocation = "";
            _DataCSVRoles = "";
            OutputTextBox.Text = "";
            LocatieTextbox.Text = "";
        }
        private void ShowData(String[] lines)
        {
            foreach (var line in lines)
            {
                OutputTextBox.Text = OutputTextBox.Text + line + "\r\n";
            }
        }
    }
}
