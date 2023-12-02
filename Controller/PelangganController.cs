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
    public class PelangganController
    {
        private PelangganRepository _PelangganRepository;

        public List<Pelanggan> ReadAll()
        {
            List<Pelanggan> list = new List<Pelanggan>();

            using (DbContext context = new DbContext())
            {
                _PelangganRepository = new PelangganRepository(context);

                list = _PelangganRepository.ReadAll();
            }

            return list;
        }

        public int Create(Pelanggan plg)
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

            if (string.IsNullOrEmpty(plg.NoTelp))
            {
                MessageBox.Show("Nomer Telepon harus diisi !!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }


            using (DbContext context = new DbContext())
            {
                _PelangganRepository = new PelangganRepository(context);

                result = _PelangganRepository.Create(plg);
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
