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
    public class TabunganController
    {
        private TabunganRepository _TabunganRepository;

        public List<Tabungan> ReadAll()
        {
            List<Tabungan> list = new List<Tabungan>();

            using (DbContext context = new DbContext())
            {
                _TabunganRepository = new TabunganRepository(context);

                list = _TabunganRepository.ReadAll();
            }

            return list;
        }

        public int Create(Tabungan tbn)
        {
            int result = 0;

            if (string.IsNullOrEmpty(tbn.NoRekening))
            {
                MessageBox.Show("Nomor Rekening Tujuan harus diisi !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(tbn.JenisTabungan))
            {
                MessageBox.Show("Jenis Tabungan harus dipilih !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            using (DbContext context = new DbContext())
            {
                _TabunganRepository = new TabunganRepository(context);

                result = _TabunganRepository.Create(tbn);
            }

            if (result > 0)
            {
                MessageBox.Show("Data Tabungan berhasil disimpan !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data Tabungan gagal disimpan !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }

    }
}
