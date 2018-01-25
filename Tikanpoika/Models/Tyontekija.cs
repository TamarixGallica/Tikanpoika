using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tikanpoika.Models
{
    public class Tyontekija
    {
        public int TyontekijaID { get; set; }

        public String Etunimi { get; set; }

        public String Sukunimi { get; set; }

        public String Puhelin { get; set; }

        public String Osoite { get; set; }

        public String Tyokuvaus { get; set; }

        public int Osasto { get; set; }

        public Tyontekija()
        {

        }
    }
}