using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using P9_714240059.model;

namespace P9_714240059.Controller
{
    class Barang
    {
        Koneksi koneksi = new Koneksi();

        // Method Insert
        public bool Insert(M_barang barang)
        {
            bool status = false;
            try
            {
                koneksi.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(
                    "INSERT INTO t_barang (nama_barang, harga) VALUES (@nama_barang, @harga)"
                );
                cmd.Parameters.AddWithValue("@nama_barang", barang.Nama_barang);
                cmd.Parameters.AddWithValue("@harga", barang.Harga);

                koneksi.ExecuteQuery(cmd);
                status = true;
                MessageBox.Show("Data berhasil ditambahkan", "Informasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();
            }
            catch (Exception e)
            {
                koneksi.CloseConnection();
                MessageBox.Show(e.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }

        // Method Update
        public bool Update(M_barang barang, string id)
        {
            bool status = false;
            try
            {
                koneksi.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(
                    "UPDATE t_barang SET nama_barang=@nama_barang, harga=@harga WHERE id_barang=@id"
                );
                cmd.Parameters.AddWithValue("@nama_barang", barang.Nama_barang);
                cmd.Parameters.AddWithValue("@harga", barang.Harga);
                cmd.Parameters.AddWithValue("@id", id);

                koneksi.ExecuteQuery(cmd);
                status = true;
                MessageBox.Show("Data berhasil diubah", "Informasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();
            }
            catch (Exception e)
            {
                koneksi.CloseConnection();
                MessageBox.Show(e.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }

        // Method Delete
        public bool Delete(string id)
        {
            bool status = false;
            try
            {
                koneksi.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(
                    "DELETE FROM t_barang WHERE id_barang=@id"
                );
                cmd.Parameters.AddWithValue("@id", id);

                koneksi.ExecuteQuery(cmd);
                status = true;
                MessageBox.Show("Data berhasil dihapus", "Informasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();
            }
            catch (Exception e)
            {
                koneksi.CloseConnection();
                // Menangani error jika data sedang digunakan di tabel transaksi (Foreign Key)
                if (e.Message.Contains("foreign key constraint"))
                {
                    MessageBox.Show("Data tidak bisa dihapus karena sedang digunakan di Transaksi.", "Gagal Hapus", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(e.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return status;
        }
    }
}