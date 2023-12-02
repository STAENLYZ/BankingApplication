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
    public class PelangganRepository
    {
        private SQLiteConnection _conn;

        public PelangganRepository(DbContext context)
        {
            _conn = context.Conn;
        }
        public int Create(Pelanggan plg)
        {
            int result = 0;

            string sql = @"insert into Pelanggan (NamaPelanggan, AlamatPelanggan, NoTelp, EmailPelanggan, Password, IdPelanggan, TanggalBuka, NoRekening) 
                     values (@NamaPelanggan, @AlamatPelanggan, @NoTelp, @EmailPelanggan, @Password, @IdPelanggan, @TanggalBuka, @NoRekening)";

            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@NamaPelanggan", plg.NamaPelanggan);
                cmd.Parameters.AddWithValue("@AlamatPelanggan", plg.AlamatPelanggan);
                cmd.Parameters.AddWithValue("@NoTelp", plg.NoTelp);
                cmd.Parameters.AddWithValue("@EmailPelanggan", plg.EmailPelanggan);
                cmd.Parameters.AddWithValue("@Password", plg.IdPelanggan);
                cmd.Parameters.AddWithValue("@Password", plg.TanggalBuka);
                cmd.Parameters.AddWithValue("@Password", plg.NoRekening);
                cmd.Parameters.AddWithValue("@Password", plg.Password);

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

        public List<Pelanggan> ReadAll()
        {
            List<Pelanggan> list = new List<Pelanggan>();

            try
            {
                string sql = @"select NamaPelanggan, AlamatPelanggan, NoTelp, EmailPelanggan, Password, IdPelanggan, TanggalBuka, NoRekening
                            from Pelanggan order by NamaPelanggan";

                using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
                {

                    using (SQLiteDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            Pelanggan plg = new Pelanggan();
                            plg.NamaPelanggan = dtr["IdPelanggan"].ToString();
                            plg.AlamatPelanggan = dtr["AlamatPelanggan"].ToString();
                            plg.NoTelp = dtr["NoTelp"].ToString();
                            plg.EmailPelanggan = dtr["TanggalBuka"].ToString();
                            plg.IdPelanggan = dtr["SaldoPelanggan"].ToString();
                            plg.TanggalBuka = dtr["TanggalBuka"].ToString();
                            plg.NoRekening = dtr["NoRekening"].ToString();
                            plg.Password = dtr["Password"].ToString();
                            list.Add(plg);
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
