using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using P9_714240059.model;
using System.Data;

namespace P9_714240059.controller
{
    internal class Transaksi
    {
        Koneksi koneksi = new Koneksi();

        public DataTable Tampil()
        {
            string query = "SELECT t_transaksi.id_transaksi, t_transaksi.id_barang, t_barang.nama_barang, t_barang.harga, t_transaksi.qty, t_transaksi.total " +
                           "FROM t_transaksi " +
                           "JOIN t_barang ON t_transaksi.id_barang = t_barang.id_barang";

            return (DataTable)koneksi.ShowData(query);
        }

        public bool Insert(M_transaksi transaksi)
        {
            string cekQuery = "SELECT * FROM t_transaksi WHERE id_barang = @id_barang";

            DataTable dt = (DataTable)koneksi.ShowDataParam(cekQuery, new MySqlParameter("@id_barang", transaksi.Id_barang));

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Barang ini sudah ada di transaksi! Silakan gunakan tombol Ubah.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            bool status = false;
            try
            {
                koneksi.OpenConnection();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO t_transaksi (id_barang, qty, total) VALUES (@id_barang, @qty, @total)");

                cmd.Parameters.AddWithValue("@id_barang", transaksi.Id_barang);
                cmd.Parameters.AddWithValue("@qty", transaksi.Qty);
                cmd.Parameters.AddWithValue("@total", transaksi.Total);

                koneksi.ExecuteQuery(cmd);

                status = true;
                MessageBox.Show("Data Transaksi Berhasil Disimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                koneksi.CloseConnection();
            }
            catch (Exception e)
            {
                koneksi.CloseConnection();
                MessageBox.Show(e.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }

        public bool Update(M_transaksi transaksi, string id_transaksi)
        {
            bool status = false;
            try
            {
                koneksi.OpenConnection();
                MySqlCommand cmd = new MySqlCommand("UPDATE t_transaksi SET id_barang=@id_barang, qty=@qty, total=@total WHERE id_transaksi=@id");

                cmd.Parameters.AddWithValue("@id_barang", transaksi.Id_barang);
                cmd.Parameters.AddWithValue("@qty", transaksi.Qty);
                cmd.Parameters.AddWithValue("@total", transaksi.Total);
                cmd.Parameters.AddWithValue("@id", id_transaksi);

                koneksi.ExecuteQuery(cmd);

                status = true;
                MessageBox.Show("Data Transaksi Berhasil Diubah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                koneksi.CloseConnection();
            }
            catch (Exception e)
            {
                koneksi.CloseConnection();
                MessageBox.Show(e.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }

        public bool Delete(string id_transaksi)
        {
            bool status = false;
            try
            {
                koneksi.OpenConnection();
                MySqlCommand cmd = new MySqlCommand("DELETE FROM t_transaksi WHERE id_transaksi=@id");

                cmd.Parameters.AddWithValue("@id", id_transaksi);

                koneksi.ExecuteQuery(cmd);

                status = true;
                MessageBox.Show("Data Transaksi Berhasil Dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                koneksi.CloseConnection();
            }
            catch (Exception e)
            {
                koneksi.CloseConnection();
                MessageBox.Show(e.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }
    }
}
