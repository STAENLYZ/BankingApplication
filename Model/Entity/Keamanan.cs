using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplication.Model.Entity
{
    public class Keamanan
    {
        public string IdPelanggan { get; set; }
        public string Password { get; set; }
        public string NamaPelanggan { get; set; }
        public string EmailPelanggan { get; set; }
        public string NoRekening{ get; set; }
        public string LastAccesed { get; set; }
        public string AccessHistory { get; set; }
    }
}
