using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplication.Model.Entity
{
    public class Pelanggan
    {
        public string NamaPelanggan { get; set; }
        public string AlamatPelanggan { get; set;}
        public string NoTelp { get; set; }
        public string EmailPelanggan { get; set; }
        public string Password { get; set; }
        public string IdPelanggan { get; set; }
        public string TanggalBuka { get; set; }
        public string NoRekening { get; set; }
    }
}
