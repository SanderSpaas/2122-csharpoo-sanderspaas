using DataAccessLayer;

namespace PresentationLayer;
public partial class LoadSeed : Form
{
    public LoadSeed()
    {
        InitializeComponent();
        Icon = new Icon("Assets/Cyclon.ico");
        //DataGrid.Rows.Add("Seed", "Naam", "Beschrijving");
        SeedData seedDataObj = new();
        DataGrid.DataSource = seedDataObj.ReadSeeds();
        DataGrid.RowHeadersVisible = false;
        DataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        DataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
    }

    private void UseSelectedSeedButton_Click(object sender, EventArgs e)
    {
        foreach (DataGridViewRow row in DataGrid.Rows)
        {
            if (DataGrid.SelectedRows.Count == 1)
            {
                string text = DataGrid.SelectedRows[0].Cells[0].Value.ToString();
                Clipboard.SetText(text);
            }
        }
        Hide();
    }
}
