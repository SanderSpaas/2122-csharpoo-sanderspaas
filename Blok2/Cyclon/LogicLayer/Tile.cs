namespace LogicLayer
{
    public class Tile
    {
        private Layer _laag;

        public Tile()
        {
        }
        public Tile(Layer laag)
        {
            Laag = laag;
        }

        public Layer Laag { get => _laag; set => _laag = value; }
    }
}
