using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class Pacijent
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime Datum_rodjenja { get; set; }
        public string Pol { get; set; }
        public string Telefon { get; set; }
        public string Adresa { get; set; }
        public string Krvna_grupa { get; set; }
    }
}
