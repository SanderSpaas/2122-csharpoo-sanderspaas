
//using Spyfall.Logica;
using System;
using System.Windows.Forms;

namespace Spyfall
{
    public partial class MainForm : Form
    {
        //private readonly SpyfallLogica logica;

        public MainForm()
        {
            InitializeComponent();
            //logica = new SpyfallLogica();
        }


        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            // Read the file and display it line by line.  
            foreach (string line in System.IO.File.ReadLines(@"resources\SpyfallData.csv"))
            {
           
                textBox1.AppendText(line);
             
            }
            
        }
    }
}
