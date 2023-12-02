using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplication.Model.Entity
{
    public class Keamanan
    {
        public string IdKeamanan { get; set; }
        public string NoRekening{ get; set; }
        public string LastAccesed { get; set; }
        public string AccessHistory { get; set; }
    }
}
