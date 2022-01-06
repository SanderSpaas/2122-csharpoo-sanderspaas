using Globals.Interfaces;

namespace LogicLayer
{
    public struct Tile : ILogic
    {
        public Tile(Layer laag)
        {
            Laag = laag;
            Color = Laag.Kleur;
        }

        public Layer Laag { get; set; }
        public Color Color { get; set; }
    }
}
