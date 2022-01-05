using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Transfer
    {
        public int Sifra { get; set; }
        public DateTime Datum_transfera { get; set; }
        public string Ime_pacijenta { get; set; }
        public string Krvna_grupa { get; set; }

    }
}
