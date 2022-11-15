using System;
using System.Runtime.ConstrainedExecution;

namespace Gebrauchtwagenhaendler.Klassen
{
    public class Auto
    {
        
        public string hersteller;
        public string model;
        public string kilometer;
        public string besonderheiten;

        public Auto(string hersteller, string model, string kilometer, string besonderheiten)
        {
            this.hersteller = hersteller;
            this.model = model;
            this.kilometer = kilometer;
            this.besonderheiten = besonderheiten;
        }

        public void Cars()
        {

        }
    }
}

