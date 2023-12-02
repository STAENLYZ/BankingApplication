using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankingApplication.Model.Entity;
using BankingApplication.Model.Repository;
using BankingApplication.Model.Context;
using System.Windows.Forms;

namespace BankingApplication.Controller
{
    public class TransaksiController
    {
        private TransaksiRepository _transaksirepository;

        public List<Transaksi> ReadAll()
        {
            List<Transaksi> list = new List<Transaksi>();

            using (DbContext context = new DbContext())
            {
                _transaksirepository = new TransaksiRepository(context);

                list = _transaksirepository.ReadAll();
            }

            return list;
        }

        public int Create(Transaksi trn)
        {
            int result = 0;

            if (string.IsNullOrEmpty(trn.NoRekening))
            {
                MessageBox.Show("Nomor Rekening Tujuan harus diisi !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(trn.JenisTransaksi))
            {
                MessageBox.Show("Jenis Transaksi harus dipilih !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            using (DbContext context = new DbContext())
            {
                _transaksirepository = new TransaksiRepository(context);

                result = _transaksirepository.Create(trn);
            }

            if (result > 0)
            {
                MessageBox.Show("Data Transaksi berhasil disimpan !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data Transaksi gagal disimpan !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }
    }
}
