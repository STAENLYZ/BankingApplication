using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplication.Model.Entity
{
    public class Tabungan
    {
        public int IdTabungan{ get; set; }
        public string NoRekening {  get; set; }
        public string JenisTabungan { get; set; }   
        public double SaldoTabungan { get; set; }
        public string TanggalBuka { get; set; }
    }
}
