using DataAccessLayer;

namespace PresentationLayer;
public partial class LoadSeed : Form
{
    private readonly ISeedData _seedData;
    public LoadSeed(ISeedData seedData)
    {
        InitializeComponent();
        Icon = new Icon("Assets/Cyclon.ico");
        _seedData = seedData;

        if (_seedData.ReadSeeds() != null)
        {
            DataGrid.DataSource = _seedData.ReadSeeds();
        }
        else
        {
            DataGrid.Visible = false;
        }
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
                Clipboard.SetText(DataGrid.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
        Hide();
    }
}
