namespace LogicLayer
{
    public struct Tile
    {
        private Layer _laag;

        public Tile(Layer laag)
        {
            _laag = laag;
        }

        public Layer Laag { get => _laag; set => _laag = value; }
    }
}
