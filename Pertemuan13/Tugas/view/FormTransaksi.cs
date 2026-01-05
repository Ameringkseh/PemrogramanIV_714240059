using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using P9_714240059.controller;
using P9_714240059.lib;
using P9_714240059.model;

namespace P9_714240059.view
{
    public partial class FormTransaksi : Form
    {
        Koneksi koneksi = new Koneksi();
        M_transaksi m_transaksi = new M_transaksi();
        Transaksi transaksi = new Transaksi();
        DataTable dtBarang;
        string id_transaksi;
        public FormTransaksi()
        {
            InitializeComponent();
        }

        public void Tampil()
        {
            DataTransaksi.DataSource = transaksi.Tampil();

            DataTransaksi.Columns[0].HeaderText = "ID Transaksi";
            DataTransaksi.Columns[1].HeaderText = "ID Barang";
            DataTransaksi.Columns[2].HeaderText = "Nama Barang";
            DataTransaksi.Columns[3].HeaderText = "Harga";
            DataTransaksi.Columns[4].HeaderText = "Qty";
            DataTransaksi.Columns[5].HeaderText = "Total";

            DataTransaksi.Columns[3].DefaultCellStyle.Format = "Rp #,###";
            DataTransaksi.Columns[5].DefaultCellStyle.Format = "Rp #,###";

        }

        public void LoadBarang()
        {
            dtBarang = (DataTable)koneksi.ShowData("SELECT * FROM t_barang");

            comboBoxIdBarang.DataSource = dtBarang;
            comboBoxIdBarang.DisplayMember = "id_barang";
            comboBoxIdBarang.ValueMember = "id_barang";

            comboBoxIdBarang.SelectedIndex = -1;
        }

        private void FormTransaksi_Load(object sender, EventArgs e)
        {
            LoadBarang();
            Tampil();
        }

        public void ResetForm()
        {
            comboBoxIdBarang.SelectedIndex = -1;
            txtBoxBarang.Text = "";
            textBoxHargaBarang.Text = "";
            textBoxQuantity.Text = "";
            textBoxTotal.Text = "";
            textBoxData.Text = "";
            id_transaksi = "";
        }


        private void comboBoxIdBarang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxIdBarang.SelectedIndex != -1)
            {
                try
                {
                    DataRow[] rows = dtBarang.Select("id_barang=" + comboBoxIdBarang.SelectedValue.ToString());
                    if (rows.Length > 0)
                    {
                        txtBoxBarang.Text = rows[0]["nama_barang"].ToString();
                        textBoxHargaBarang.Text = rows[0]["harga"].ToString(); 
                    }
                    HitungTotal();
                }
                catch (Exception ex) { }
            }
        }

        private void textBoxQuantity_TextChanged(object sender, EventArgs e)
        {
            HitungTotal();
        }

        private void HitungTotal()
        {
            int harga = 0;
            int qty = 0;

            if (int.TryParse(textBoxHargaBarang.Text, out harga) && int.TryParse(textBoxQuantity.Text, out qty))
            {
                int total = harga * qty;
                textBoxTotal.Text = total.ToString(); 
            }
            else
            {
                textBoxTotal.Text = "0";
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (comboBoxIdBarang.SelectedIndex == -1 || textBoxQuantity.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            m_transaksi.Id_barang = comboBoxIdBarang.SelectedValue.ToString();
            m_transaksi.Qty = textBoxQuantity.Text;
            m_transaksi.Total = textBoxTotal.Text; 

            if (transaksi.Insert(m_transaksi))
            {
                ResetForm();
                Tampil();
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (id_transaksi == "")
            {
                MessageBox.Show("Pilih data transaksi terlebih dahulu", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            m_transaksi.Id_barang = comboBoxIdBarang.SelectedValue.ToString();
            m_transaksi.Qty = textBoxQuantity.Text;
            m_transaksi.Total = textBoxTotal.Text;

            if (transaksi.Update(m_transaksi, id_transaksi))
            {
                ResetForm();
                Tampil();
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (id_transaksi == "")
            {
                MessageBox.Show("Pilih data transaksi terlebih dahulu", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult pesan = MessageBox.Show("Apakah yakin akan menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (pesan == DialogResult.Yes)
            {
                if (transaksi.Delete(id_transaksi))
                {
                    ResetForm();
                    Tampil();
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ResetForm();
            Tampil();
        }

        private void DataTransaksi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            id_transaksi = DataTransaksi.Rows[e.RowIndex].Cells[0].Value.ToString();

            comboBoxIdBarang.SelectedValue = DataTransaksi.Rows[e.RowIndex].Cells[1].Value;

            textBoxQuantity.Text = DataTransaksi.Rows[e.RowIndex].Cells[4].Value.ToString();

        }

        private void textBoxData_TextChanged(object sender, EventArgs e)
        {
            string keyword = textBoxData.Text.Trim();
            if (keyword == "") { Tampil(); return; }

            string sql = "SELECT t_transaksi.id_transaksi, t_transaksi.id_barang, t_barang.nama_barang, t_barang.harga, t_transaksi.qty, t_transaksi.total " +
                         "FROM t_transaksi JOIN t_barang ON t_transaksi.id_barang = t_barang.id_barang " +
                         "WHERE t_barang.nama_barang LIKE @search OR t_transaksi.id_transaksi LIKE @search";

            // Casting ke DataTable karena Koneksi.ShowDataParam mengembalikan object
            DataTransaksi.DataSource = (DataTable)koneksi.ShowDataParam(sql, new MySqlParameter("@search", "%" + keyword + "%"));
        }

        private void btnExport2_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Excel Documents (*.xlsx)|*.xlsx";
            save.FileName = "Report Transaksi.xlsx";
            save.OverwritePrompt = false;

            if (save.ShowDialog() == DialogResult.OK)
            {
                string filePath = save.FileName;

                if (File.Exists(filePath))
                    File.Delete(filePath);

                Excel excel_lib = new Excel();

                excel_lib.ExportToExcel(DataTransaksi, filePath);

                MessageBox.Show("Data berhasil diekspor ke file Excel.",
                    "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
