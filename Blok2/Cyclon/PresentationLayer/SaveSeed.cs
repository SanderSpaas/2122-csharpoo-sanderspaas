using DataAccessLayer;
using LogicLayer;

namespace PresentationLayer;
public partial class SaveSeed : Form
{
    private readonly string _seed;
    private readonly SeedData _seedData;
    public SaveSeed(string seed, SeedData seedData)
    {
        InitializeComponent();
        Icon = new Icon("Assets/Cyclon.ico");
        _seedData = seedData;
        _seed = seed;
        SeedInput.Text = _seed;
    }

    private void SaveSeedButton_Click(object sender, EventArgs e)
    {
        if (!String.IsNullOrWhiteSpace(SeedInput.Text) && !String.IsNullOrWhiteSpace(SeedNameInput.Text) && !String.IsNullOrWhiteSpace(SeedDescInput.Text))
        {
            var seed = new Seed(SeedInput.Text, SeedNameInput.Text, SeedDescInput.Text);
            _seedData.SaveSeed(seed);
            Hide();
        }
        else
        {
            ErrorLabel.ForeColor = Color.Red;
            ErrorLabel.Text = "Zorg dat je alle velden ingevuld hebt met text";
        }
    }
}
