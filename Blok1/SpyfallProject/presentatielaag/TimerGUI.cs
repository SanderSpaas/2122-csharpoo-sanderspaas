namespace SpyfallProject.presentatielaag
{
    public partial class TimerGUI : Form
    {
        private readonly DateTime _EndTime;
        private readonly Random random = new();
        public TimerGUI()
        {
            InitializeComponent();
            Icon = new Icon("datalaag/spy.ico");
            var minutes = 8;
            var start = DateTime.UtcNow;
            _EndTime = start.AddMinutes(minutes);
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan remainingTime = _EndTime - DateTime.UtcNow;
            if (remainingTime < TimeSpan.Zero)
            {
                TimerLabel.Text = "0:00";
                timer1.Enabled = false;
                StemLabel.Visible = true;
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
