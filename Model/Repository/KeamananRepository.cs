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
    public class KeamananRepository
    {
        private SQLiteConnection _conn;

        public KeamananRepository(DbContext context)
        {
            _conn = context.Conn;
        }
        public int Create(Keamanan kmn)
        {
            int result = 0;

            string sql = @"insert into Keamanan (NamaPelanggan, Password, IdPelanggan, TanggalBuka, NoRekening, LastAccesed, AccessHistory) 
                     values (@NamaPelanggan, @AlamatPelanggan, @Password, @IdPelanggan, @TanggalBuka, @NoRekening, @LastAccesed, @AccessHistory)";

            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@NamaPelanggan", kmn.NamaPelanggan);
                cmd.Parameters.AddWithValue("@LastAccesed", kmn.LastAccesed);
                cmd.Parameters.AddWithValue("@AccessHistory", kmn.AccessHistory);
                cmd.Parameters.AddWithValue("@EmailPelanggan", kmn.EmailPelanggan);
                cmd.Parameters.AddWithValue("@IdPelanggan", kmn.IdPelanggan);
                cmd.Parameters.AddWithValue("@TanggalBuka", kmn.TanggalBuka);
                cmd.Parameters.AddWithValue("@NoRekening", kmn.NoRekening);
                cmd.Parameters.AddWithValue("@Password", kmn.Password);

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

        public List<Keamanan> ReadAll()
        {
            List<Keamanan> list = new List<Keamanan>();

            try
            {
                string sql = @"select NamaPelanggan, Password, IdPelanggan, TanggalBuka, NoRekening, LastAccesed, AccessHistory
                            from Pelanggan order by IdPelanggan";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
                {

                    using (SQLiteDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            Keamanan kmn = new Keamanan();
                            kmn.NamaPelanggan = dtr["IdPelanggan"].ToString();
                            kmn.LastAccesed = dtr["LastAccesed"].ToString();
                            kmn.AccessHistory = dtr["AccessHistory"].ToString();
                            kmn.EmailPelanggan = dtr["TanggalBuka"].ToString();
                            kmn.IdPelanggan = dtr["SaldoPelanggan"].ToString();
                            kmn.TanggalBuka = dtr["TanggalBuka"].ToString();
                            kmn.NoRekening = dtr["NoRekening"].ToString();
                            kmn.Password = dtr["Password"].ToString();
                            list.Add(kmn);
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
