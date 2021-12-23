namespace LogicLayer;

internal class Layer
{
    private List<Layer> _layers = new List<Layer>();
    private TerrainType _naamLaag;
    private Color _kleur;
    private char _teken;

    public Layer()
    {
    }
    public Layer(TerrainType naamLaag, Color kleur, Char teken)
    {
        _naamLaag = naamLaag;
        _kleur = kleur;
        _teken = teken;
    }

    internal List<Layer> Layers { get => _layers; set => _layers = value; }

    private void Addlaag(Layer laag)
    {
        if (laag == null)
        {
            throw new ArgumentNullException(nameof(laag));
        }
        else
        {
            Layers.Add(laag);
        }
    }
}
