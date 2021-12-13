using SpyfallProject.datalaag;
namespace SpyfallProject.presentatielaag
{
    public partial class SpelMaker : Form, IDataVerwerker
    {
        //variables
        private string _dataCSVLocation = "";
        private string _dataCSVRoles = "";
        private string _filePath = "";
        private readonly FilePicker _filePicker = new();
        private readonly IDataVerwerker _dataVerwerker;

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
                _dataCSVLocation = LocatieTextbox.Text.Trim();
            }
            if (CheckInput(RolTextBox.Text))
            {
                _dataCSVRoles = _dataCSVRoles + ";" + RolTextBox.Text.Trim();
            }
            RolTextBox.Text = "";
            OutputTextBox.Text = $"De locatie is: {_dataCSVLocation} De rollen zijn: {_dataCSVRoles}";
        }
        //het CSV bestand gaan aanmaken 
        private void GenereerBestand_Click(object sender, EventArgs e)
        {
            String check = _filePicker.OpenSaveDialog();
            if (check != null)
            {
                _filePath = check;
                //het bestand gaan aanmaken
                _dataVerwerker.CreateFile(_filePath);
                OutputTextBox.Text = "Bestand geselecteerd. \r\n";
                GeselecteerdeBestandTextBox.Text = _filePath;
                EnableInput();
            }
        }

        //een bestaand bestand gaan selecteren om dingen aan toe te voegen
        private void LaadBestandButton_Click(object sender, EventArgs e)
        {
            _filePath = _filePicker.FileSelector();
            if (!_dataVerwerker.TestData(_filePath))
            {
                OutputTextBox.Text = "Het gekozen databestand is ongeldig. \r\n";
            }
            else
            {
                OutputTextBox.Text = "Bestand geselecteerd. \r\n";
                ShowData(_dataVerwerker.ReadFileContent(_filePath));
                GeselecteerdeBestandTextBox.Text = _filePath;
                EnableInput();
            }
        }

        //button die de data gaat laten toevoegen
        private void VoegToeButton_Click(object sender, EventArgs e)
        {
            if (_dataVerwerker.AddToFile(_filePath, _dataCSVLocation + _dataCSVRoles))
            {
                OutputTextBox.Text = "Data naar bestand geschreven. \r\n";
            }
            ClearFields();
            ShowData(_dataVerwerker.ReadFileContent(_filePath));
        }

        //saniteer data die binnenkomt 
        private static bool CheckInput(string input)
        {
            if (string.IsNullOrWhiteSpace(input.Trim()))
            {
                return false;
            }
            if (input.Trim().Contains(";"))
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
            _dataCSVLocation = "";
            _dataCSVRoles = "";
            OutputTextBox.Text = "";
            LocatieTextbox.Text = "";
        }
        private void ShowData(string[] lines)
        {
            foreach (var line in lines)
            {
                OutputTextBox.Text = OutputTextBox.Text + line + "\r\n";
            }
        }
    }
}
