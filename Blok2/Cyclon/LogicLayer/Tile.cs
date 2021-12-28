namespace LogicLayer
{
    public struct Tile
    {
        private Layer _laag;
        private Color _color;

        public Tile(Layer laag)
        {
            _laag = laag;
            _color = _laag.Kleur;
        }

        public Layer Laag { get => _laag; set => _laag = value; }
        public Color Color { get => _color; set => _color = value; }
    }
}
