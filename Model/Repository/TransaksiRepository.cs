using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using BankingApplication.Model.Entity;
using BankingApplication.Model.Context;

namespace BankingApplication.Model.Repository
{
    public  class TransaksiRepository
    {
        private SQLiteConnection _conn;

        public TransaksiRepository(DbContext context)
        {
            _conn = context.Conn;
        }
    }
    
}
