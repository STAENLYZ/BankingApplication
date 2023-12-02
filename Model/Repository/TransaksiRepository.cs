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
    public class TransaksiRepository
    {
        private SQLiteConnection _conn;

        public TransaksiRepository(DbContext context)
        {
            _conn = context.Conn;
        }
        public int Create(Transaksi trn)
        {
            int result = 0;

            string sql = @"insert into Transaksi (IdTransaksi, NoRekening, JenisTransaksi, TanggalTransaksi, DeskripsiTransaksi) 
                     values (@IdTransaksi, @NoRekening, @JenisTransaksi, @TanggalTransaksi, @DeskripsiTransaksi";

            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@IdTransaksi", trn.IdTransaksi);
                cmd.Parameters.AddWithValue("@NoRekening", trn.NoRekening);
                cmd.Parameters.AddWithValue("@JenisTransaksi", trn.JenisTransaksi);
                cmd.Parameters.AddWithValue("@TanggalTransaksi", trn.TanggalTransaksi);
                cmd.Parameters.AddWithValue("@DeskripsiTransaksi", trn.DeskripsiTransaksi);

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

        public List<Transaksi> ReadAll()
        {
            List<Transaksi> list = new List<Transaksi>();

            try
            {
                string sql = @"select IdTransaksi, NoRekening, JenisTransaksi, TanggalTransaksi, DeskripsiTransaksi
                            from Transaksi order by TanggalTransaksi";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
                {

                    using (SQLiteDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            Transaksi trn = new Transaksi();
                            trn.IdTransaksi = dtr["IdTransaksi"].ToString();
                            trn.NoRekening = dtr["NoRekening"].ToString();
                            trn.JenisTransaksi = dtr["JenisTransaksi"].ToString();
                            trn.JenisTransaksi = dtr["TanggalTransaksi"].ToString();
                            trn.JenisTransaksi = dtr["DeskripsiTransaksi"].ToString();
                            list.Add(trn);
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
