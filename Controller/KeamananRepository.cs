using BankingApplication.Model.Entity;
using BankingApplication.Model.Repository;
using BankingApplication.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingApplication.Controller
{
    public class KeamananController
    {
        private KeamananRepository _KeamananRepository;

        public List<Keamanan> ReadAll()
        {
            List<Keamanan> list = new List<Keamanan>();

            using (DbContext context = new DbContext())
            {
                _KeamananRepository = new KeamananRepository(context);

                list = _KeamananRepository.ReadAll();
            }

            return list;
        }

        public int Create(Keamanan plg)
        {
            int result = 0;

            if (string.IsNullOrEmpty(plg.NamaPelanggan))
            {
                MessageBox.Show("Nama harus diisi !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(plg.EmailPelanggan))
            {
                MessageBox.Show("Email harus diisi !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(plg.Password))
            {
                MessageBox.Show(" Password harus diisi !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(plg.LastAccesed))
            {
                MessageBox.Show("Belum Pernah Diakses !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(plg.AccessHistory))
            {
                MessageBox.Show("Belum Pernah Diakses !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(plg.IdPelanggan))
            {
                MessageBox.Show("Id Tidak Ada !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(plg.TanggalBuka))
            {
                MessageBox.Show("Tidak Pernah Dibuka !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(plg.NoRekening))
            {
                MessageBox.Show("Nomor Rekening Tidak Ada !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }


            using (DbContext context = new DbContext())
            {
                _KeamananRepository = new KeamananRepository(context);

                result = _KeamananRepository.Create(plg);
            }

            if (result > 0)
            {
                MessageBox.Show("Data Pelanggan berhasil disimpan !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data Pelanggan gagal disimpan !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }

    }
}
