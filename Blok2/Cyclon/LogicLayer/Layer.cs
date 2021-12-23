using Globals.Interfaces;

namespace LogicLayer;

public class Layer : ILogic
{
    private TerrainType _naamLaag;
    private Color _kleur;
    private int _height;
    private char _teken;

    public Layer()
    {

    }
    public Layer(TerrainType naamLaag, Color kleur, int height, Char teken)
    {
        NaamLaag = naamLaag;
        Kleur = kleur;
        Height = height;
        Teken = teken;
    }


    public TerrainType NaamLaag { get => _naamLaag; set => _naamLaag = value; }
    public Color Kleur { get => _kleur; set => _kleur = value; }
    public char Teken { get => _teken; set => _teken = value; }
    public int Height { get => _height; set => _height = value; }


}
