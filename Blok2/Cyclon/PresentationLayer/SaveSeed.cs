using DataAccessLayer;
using LogicLayer;

namespace PresentationLayer;
public partial class SaveSeed : Form
{
    private readonly string _seed;
    private readonly SeedData _seedDataObj = new();
    public SaveSeed(string seed)
    {
        InitializeComponent();
        Icon = new Icon("Assets/Cyclon.ico");
        _seed = seed;
        SeedInput.Text = _seed;
    }

    private void SaveSeedButton_Click(object sender, EventArgs e)
    {
        if (SeedInput.Text != "" && SeedNameInput.Text != "" && SeedDescInput.Text != "")
        {
            var seed = new Seed(SeedInput.Text, SeedNameInput.Text, SeedDescInput.Text);
            _seedDataObj.SaveSeed(seed);
            Hide();
        }
        else
        {
            ErrorLabel.ForeColor = Color.Red;
            ErrorLabel.Text = "Zorg dat je alle velden ingevuld hebt met text";
        }
    }
}
