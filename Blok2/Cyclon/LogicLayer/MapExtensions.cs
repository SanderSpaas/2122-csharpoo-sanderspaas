namespace LogicLayer
{
    public static class MapExtensions
    {
        public static void PrintTerrainOld(this Map map, RichTextBox box, int x, int y, int fontSize)
        {
            AppendText(map, box, fontSize, x, y, false);
        }
        public static void PrintTerrainModern(this Map map, Graphics paint, int x, int y, int tile, CheckBox checkDebug)
        {
            paint.DrawRectangle(new Pen(map.Tiles[x, y].Color, tile), x * tile, y * tile, tile, tile);
            if (checkDebug.Checked)
            {
                paint.DrawString(((int)map.NoiseValues[x, y]).ToString(), new Font("Arial", tile / 6), new SolidBrush(Color.Black), x * tile, y * tile);
            }
        }
        public static void AppendText(this Map map, RichTextBox box, int fontSize, int x, int y, bool newline)
        {
            if (box.InvokeRequired)
            {
                box.Invoke(new MethodInvoker(delegate
                {
                    var currentFont = box.SelectionFont;
                    var newFontStyle = currentFont.Style | FontStyle.Bold;
                    box.SelectionFont = new Font(currentFont.FontFamily, fontSize, newFontStyle);
                    box.SelectionStart = box.TextLength;
                    box.SelectionLength = 0;
                    if (newline)
                    {
                        box.SelectionColor = Color.Blue;
                        box.AppendText("\r\n");
                    }
                    else
                    {
                        box.SelectionColor = map.Tiles[x, y].Color;
                        box.AppendText(map.Tiles[x, y].Laag.Teken.ToString());
                    }
                    box.SelectionColor = box.ForeColor;
                }));
            }
        }
    }
}
