using System;
using System.Drawing;
using System.Windows.Forms;

namespace SpyfallGame.presentatielaag
{
    public partial class TimerGUI : Form
    {
        private DateTime endTime;
        Random random = new Random();
        public TimerGUI()
        {
            InitializeComponent();
            Icon = new Icon("datalaag/spy.ico");
            var minutes = 8;
            var start = DateTime.UtcNow;
            endTime = start.AddMinutes(minutes);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan remainingTime = endTime - DateTime.UtcNow;
            if (remainingTime < TimeSpan.Zero)
            {
                TimerLabel.Text = "Done!";
                timer1.Enabled = false;
            }
            else
            {
                TimerLabel.Text = $"{(int)remainingTime.TotalMinutes}:{remainingTime.Seconds:00}";
                Color kleur = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
                ColorPanel.BackColor = kleur;
                ColorPanel1.BackColor = kleur;
            }
        }
    }
}
