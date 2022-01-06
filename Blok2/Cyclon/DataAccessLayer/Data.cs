using Globals.Interfaces;
using LogicLayer;
using System.Text.Json;
using System.Windows.Forms;

namespace DataAccessLayer
{
    public class Data : IData
    {
        public Data()
        {

        }
        public void SaveMap(Map map, RichTextBox box)
        {
            string jsonString = JsonSerializer.Serialize(map);
            box.Text = jsonString;
        }
    }
}