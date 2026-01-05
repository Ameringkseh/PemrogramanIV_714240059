using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using MySql.Data.MySqlClient;
using P9_714240059.Controller;
using P9_714240059.model;

namespace P9_714240059.view
{
    public partial class FormBarang : Form
    {
        Koneksi koneksi = new Koneksi();
        M_barang m_barang = new M_barang();
        Barang barang = new Barang(); 
        string id_barang;

        public FormBarang()
        {
            InitializeComponent();
        }

        public void Tampil()
        {
            DataBarang.DataSource = koneksi.ShowData("SELECT * FROM t_barang");

            DataBarang.Columns[0].HeaderText = "ID";
            DataBarang.Columns[1].HeaderText = "Nama Barang";
            DataBarang.Columns[2].HeaderText = "Harga";
            DataBarang.Columns[2].DefaultCellStyle.Format = "Rp #,###";
        }

        public void ResetForm()
        {
            textBoxNamaBarang.Text = "";
            textBoxHarga.Text = "";
            textBoxCariData.Text = "";
            id_barang = ""; 
        }

        private void FormBarang_Load(object sender, EventArgs e)
        {
            Tampil();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            ResetForm();
            Tampil();
        }

        private void DataBarang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; 

            id_barang = DataBarang.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBoxNamaBarang.Text = DataBarang.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxHarga.Text = DataBarang.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void textBoxCariData_TextChanged(object sender, EventArgs e)
        {
            string keyword = textBoxCariData.Text.Trim();

            if (keyword == "")
            {
                Tampil();
                return;
            }

            string sql = "SELECT * FROM t_barang WHERE nama_barang LIKE @search OR harga LIKE @search";

            DataBarang.DataSource = koneksi.ShowDataParam(
                sql,
                new MySqlParameter("@search", "%" + keyword + "%")
            );
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            if (textBoxNamaBarang.Text == "" || textBoxHarga.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                m_barang.Nama_barang = textBoxNamaBarang.Text;
                m_barang.Harga = textBoxHarga.Text;

                barang.Insert(m_barang);

                ResetForm();
                Tampil();
            }
        }

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            if (textBoxNamaBarang.Text == "" || textBoxHarga.Text == "" || string.IsNullOrEmpty(id_barang))
            {
                MessageBox.Show("Data tidak boleh kosong atau belum dipilih", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Masukkan data ke Model
                m_barang.Nama_barang = textBoxNamaBarang.Text;
                m_barang.Harga = textBoxHarga.Text;

                // Panggil Controller Update
                barang.Update(m_barang, id_barang);

                ResetForm();
                Tampil();
            }
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(id_barang))
            {
                MessageBox.Show("Pilih data yang ingin dihapus terlebih dahulu", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult pesan = MessageBox.Show("Apakah yakin akan menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (pesan == DialogResult.Yes)
            {
                // Panggil Controller Delete
                barang.Delete(id_barang);

                ResetForm();
                Tampil();
            }
        }
    }
}
