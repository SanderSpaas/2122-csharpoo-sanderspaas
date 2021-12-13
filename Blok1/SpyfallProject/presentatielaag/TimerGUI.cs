using SpyfallProject.logischelaag;

namespace SpyfallProject.presentatielaag
{
    public partial class TimerGUI : Form
    {
        private readonly DateTime _endTime;
        private readonly Random _random = new();
        private SpyfallMain _spel;
        public TimerGUI(SpyfallMain spel)
        {
            InitializeComponent();
            Icon = new Icon("datalaag/spy.ico");
            _spel = spel;
            var minutes = spel.AantalTijd;
            var start = DateTime.UtcNow;
            _endTime = start.AddMinutes(minutes);
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan remainingTime = _endTime - DateTime.UtcNow;
            if (remainingTime < TimeSpan.Zero)
            {
                EndTimerAction();
            }
            else
            {
                TimerLabel.Text = $"{(int)remainingTime.TotalMinutes}:{remainingTime.Seconds:00}";
                Color kleur = Color.FromArgb(_random.Next(256), _random.Next(256), _random.Next(256));
                ColorPanel.BackColor = kleur;
                ColorPanel1.BackColor = kleur;
            }
        }

        private void StopTimerButton_Click(object sender, EventArgs e)
        {
            EndTimerAction();
        }

        private void EndTimerAction()
        {
            TimerLabel.Text = "0:00";
            timer1.Enabled = false;
            StemLabel.Visible = true;
            StopTimerButton.Visible = false;
            Spionnen.Visible = true;
            Spelers.Visible = true;
            GewonnenLabel.Visible = true;
        }

        private void Spelers_Click(object sender, EventArgs e)
        {
            NextGui("Spelers");
        }

        private void Spionnen_Click(object sender, EventArgs e)
        {
            NextGui("Spionnen");
        }
        private void NextGui(string gewonnen)
        {
            SpyfallMain spel = new();
            Hide();
            new ScoreBoard(_spel, gewonnen, spel).ShowDialog();
        }
    }
}
