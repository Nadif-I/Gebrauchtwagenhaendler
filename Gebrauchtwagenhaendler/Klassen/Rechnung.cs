using System;
using System.Runtime.ConstrainedExecution;

namespace Gebrauchtwagenhaendler
{
    public class Rechnung
    {

        public string kunde;
        public string auto;
        public DateOnly datum;
        public float preis;
        public string anzahlRG; // Static machen

        public Rechnung(string kunde, string auto, DateOnly datum, float preis, string anzahlRG)
        {
            this.kunde = kunde;
            this.auto = auto;
            this.datum = datum;
            this.preis = preis;
            this.anzahlRG = anzahlRG;
        }

        public void Invoices()
        {

        }
    }
}

