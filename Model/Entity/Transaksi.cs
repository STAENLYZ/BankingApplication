using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplication.Model.Entity
{
    public class Transaksi
    {
        public string IdTransaksi { get; set; }
        public string NoRekening { get; set; }
        public string JenisTransaksi { get; set; }
        public string TanggalTransaksi { get; set; }
        public string DeskripsiTransaksi { get; set; }
    }
}
