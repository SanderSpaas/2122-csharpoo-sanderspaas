using System;
using System.Windows.Forms;
using static Rollen;

namespace SpyfallGame
{
    public partial class Form1 : Form
    {
        //public static ArrayList rollenList = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReturnRandomRolllen(@"data\SpyfallData.csv");
            foreach (Rollen rol in rollenList)
            {
                textBox1.Text = textBox1.Text + rol.Naam + " ";
            }
            textBox1.Text = textBox1.Text + rollenList.Count;
            textBox1.Text = textBox1.Text + Locatie;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
