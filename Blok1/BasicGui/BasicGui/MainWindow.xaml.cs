using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BasicGui
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            foreach (string line in System.IO.File.ReadLines(@"resources\SpyfallData.csv"))
            {
                
                dataOutput.Text = dataOutput.Text + line;
            }
            using (var reader = new StreamReader(@"resources\SpyfallData.csv"))
            {
                List<string> locaties = new List<string>();
                List<string> rollen = new List<string>();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');

                    locaties.Add(values[0]);
                    rollen.Add(values[1]);
                }
            }
        }
    }
}
