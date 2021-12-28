using Globals.Interfaces;

namespace LogicLayer;

public class Layer : ILogic
{
    public Layer(TerrainType naamLaag, Color kleur, int height, char teken)
    {
        NaamLaag = naamLaag;
        Kleur = kleur;
        Height = height;
        Teken = teken;
    }

    public TerrainType NaamLaag { get; set; }
    public Color Kleur { get; set; }
    public char Teken { get; set; }
    public int Height { get; set; }

}
