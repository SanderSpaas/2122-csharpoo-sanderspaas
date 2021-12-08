namespace SpyfallProject.presentatielaag
{
    public partial class TimerGUI : Form
    {
        private readonly DateTime _endTime;
        private readonly Random _random = new();
        public TimerGUI()
        {
            InitializeComponent();
            Icon = new Icon("datalaag/spy.ico");
            var minutes = 8;
            var start = DateTime.UtcNow;
            _endTime = start.AddMinutes(minutes);
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan remainingTime = _endTime - DateTime.UtcNow;
            if (remainingTime < TimeSpan.Zero)
            {
                TimerLabel.Text = "0:00";
                timer1.Enabled = false;
                StemLabel.Visible = true;
            }
            else
            {
                TimerLabel.Text = $"{(int)remainingTime.TotalMinutes}:{remainingTime.Seconds:00}";
                Color kleur = Color.FromArgb(_random.Next(256), _random.Next(256), _random.Next(256));
                ColorPanel.BackColor = kleur;
                ColorPanel1.BackColor = kleur;
            }
        }
    }
}
