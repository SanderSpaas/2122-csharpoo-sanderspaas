using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpyfallGame.presentatie
{
    public partial class Spelregels : Form
    {
        public Spelregels()
        {
            InitializeComponent();
            Icon = new Icon("data/spy.ico");
            Text = "Spelregels";
            SpelregelsTextBox.Text = "Spyfall is een hidden deductie game. " +
                "In het spel probeert een groep spelers uit te vogelen wie van hen een spion is, en de spion probeert erachter te komen op welke locatie hij/zij is. Elke ronde van het spel is extreem eenvoudig. Elke speler krijgt aan het begin van een ronde een kaart. Het merendeel van de spelers krijgt een kaart met een locatie erop. " +
                "Locaties in het spel zijn bijvoorbeeld een dierentuin, space station en politie station. Een speler krijgt een spy kaart. Vervolgens begint de speler die de kaarten gedeeld heeft met het stellen van een vraag aan een andere speler. Gedurende de 8 minuten die een ronde duurt mag een speler een vraag stellen aan een andere speler. " +
                "Er mogen alleen ja nee vragen gesteld worden. De antwoorden die spelers kunnen geven zijn vrij. Spelers moeten opletten de spion niet teveel informatie te geven." +
                "Na het antwoord, mag de speler die het antwoord gaf een vraag stellen aan een andere speler dan die hem net een vraag stelde. Maakt de Spion een fout en verraadt deze zich, dan kan de rest van de groep winnen door tijdens de ronde een speler te beschuldigen van spion zijn." +
                "Elke speler mag 1x per ronde een stemming initiëren. Als alle andere spelers het daarmee eens zijn, is het spel over en kijk je of de speler inderdaad de spion was.Klopt dit? Wint de groep, anders de spy.Een andere manier om het spel te winnen is voor de spy." +
                "Weet de spy gedurende het spel 100 % zeker wat de locatie is, mag hij zijn kaart laten zien en de locatie noemen. Klopt het? Dan wint de spy. Na afloop van de 8 minuten krijgt de groep nog één kans om iemand unaniem te beschuldigen. Is dat de spy? Dan wint de groep, anders wint de spy.";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SpelregelsTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
