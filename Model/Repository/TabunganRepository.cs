using BankingApplication.Model.Entity;
using BankingApplication.Model.Context;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplication.Model.Repository
{
    public class TabunganRepository
    {
        private SQLiteConnection _conn;

        public TabunganRepository(DbContext context)
        {
            _conn = context.Conn;
        }
        public int Create(Tabungan tbn)
        {
            int result = 0;

            string sql = @"insert into Tabungan (IdTabungan, NoRekening, JenisTabungan, TanggalBuka, SaldoTabungan) 
                     values (@IdTabungan, @NoRekening, @JenisTabungan, @TanggalBuka, @SaldoTabungan)";

            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@IdTabungan", tbn.IdTabungan);
                cmd.Parameters.AddWithValue("@NoRekening", tbn.NoRekening);
                cmd.Parameters.AddWithValue("@JenisTabungan", tbn.JenisTabungan);
                cmd.Parameters.AddWithValue("@TanggalBuka", tbn.TanggalBuka);
                cmd.Parameters.AddWithValue("@SaldoTabungan", tbn.SaldoTabungan);

                try
                {
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Create error: {0}", ex.Message);
                }
            }
            return result;
        }

        public List<Tabungan> ReadAll()
        {
            List<Tabungan> list = new List<Tabungan>();

            try
            {
                string sql = @"select IdTabungan, NoRekening, JenisTabungan, TanggalBuka, SaldoTabungan
                            from Tabungan order by TanggalBuka";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
                {

                    using (SQLiteDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            Tabungan tbn = new Tabungan();
                            tbn.IdTabungan = dtr["IdTabungan"].ToString();
                            tbn.NoRekening = dtr["NoRekening"].ToString();
                            tbn.JenisTabungan = dtr["JenisTabungan"].ToString();
                            tbn.JenisTabungan = dtr["TanggalBuka"].ToString();
                            tbn.JenisTabungan = dtr["SaldoTabungan"].ToString();
                            list.Add(tbn);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadAll error: {0}", ex.Message);
            }
            return list;
        }


    }
}
