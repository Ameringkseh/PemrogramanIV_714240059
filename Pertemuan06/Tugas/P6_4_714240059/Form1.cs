using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P6_4_714240059
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SetErrorMessage(TextBox textBox, string warningMessage, string wrongMessage, string correctMessage)
        {
            epWarning.SetError(textBox, warningMessage);
            epWrong.SetError(textBox, wrongMessage);
            epCorrect.SetError(textBox, correctMessage);
        }

        private void txtNama_Leave(object sender, EventArgs e)
        {
            if (txtNama.Text == "")
            {
                SetErrorMessage(txtNama, "Nama Lengkap Wajib diisi!", "", "");
            }
            else
            {
                SetErrorMessage(txtNama, "", "", "Betul!");
            }
        }

        private void txtHuruf_Leave(object sender, EventArgs e)
        {
            if (txtHuruf.Text == "")
            {
                SetErrorMessage(txtHuruf, "Nama Samaran belum diisi!", "", "");
            }
            else if (txtHuruf.Text.All(Char.IsLetter))
            {
                SetErrorMessage(txtHuruf, "", "", "Betul!");
            }
            else
            {
                SetErrorMessage(txtHuruf, "", "Nama samaran hanya boleh huruf!", "");
            }
        }

        private void txtAngka_TextChanged(object sender, EventArgs e)
        {
            if (txtAngka.Text == "")
            {
                SetErrorMessage(txtAngka, "Umur belum diisi!", "", "");
            }
            else if (txtAngka.Text.All(Char.IsNumber))
            {
                SetErrorMessage(txtAngka, "", "", "Betul!");
            }
            else
            {
                SetErrorMessage(txtAngka, "", "Umur hanya boleh angka!", "");
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                SetErrorMessage(txtEmail, "Email belum diisi!", "", "");
            }
            else if (Regex.IsMatch(txtEmail.Text, @"^[^@\s]+@[^@\s]+(\.[^@\s]+)+$"))
            {
                SetErrorMessage(txtEmail, "", "", "Betul!");
            }
            else
            {
                SetErrorMessage(txtEmail, "", "Format email salah!\nContoh: agen@cyberops.com", "");
            }
        }

        private void txtTelepon_TextChanged(object sender, EventArgs e)
        {
            if (txtTelepon.Text == "")
            {
                SetErrorMessage(txtTelepon, "No HP belum diisi!", "", "");
                return;
            }
            if (!txtTelepon.Text.All(Char.IsNumber))
            {
                SetErrorMessage(txtTelepon, "", "No HP harus angka!", "");
                return;
            }

            if (txtTelepon.Text.Length >= 10 && txtTelepon.Text.Length <= 13)
            {
                SetErrorMessage(txtTelepon, "", "", "Betul!");
            }
            else
            {
                SetErrorMessage(txtTelepon, "", "No HP harus 10-13 digit!", "");
            }
        }

        private void BandingkanPassword()
        {
            if (txtPass1.Text != "" && txtPass2.Text != "")
            {
                if (txtPass1.Text == txtPass2.Text)
                {
                    SetErrorMessage(txtPass1, "", "", "Betul!");
                    SetErrorMessage(txtPass2, "", "", "Betul!");
                }
                else
                {
                    SetErrorMessage(txtPass1, "", "Password tidak sama!", "");
                    SetErrorMessage(txtPass2, "", "Password tidak sama!", "");
                }
            }
            else
            {
                if (txtPass1.Text == "") SetErrorMessage(txtPass1, "Password wajib diisi!", "", "");
                if (txtPass2.Text == "") SetErrorMessage(txtPass2, "Konfirmasi wajib diisi!", "", "");
            }
        }

        private void txtPass1_TextChanged(object sender, EventArgs e)
        {
            BandingkanPassword();
        }

        private void txtPass2_TextChanged(object sender, EventArgs e)
        {
            BandingkanPassword();
        }

        private void txtKodeMisi_TextChanged(object sender, EventArgs e)
        {
            if (txtKodeMisi.Text == "")
                SetErrorMessage(txtKodeMisi, "Kode Misi harus diisi!", "", "");
            else
                SetErrorMessage(txtKodeMisi, "", "", "Betul!");
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
                SetErrorMessage(txtUsername, "Username harus diisi!", "", "");
            else
                SetErrorMessage(txtUsername, "", "", "Betul!");
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (epCorrect.GetError(txtNama) == "Betul!" &&
                epCorrect.GetError(txtHuruf) == "Betul!" &&
                epCorrect.GetError(txtAngka) == "Betul!" &&
                epCorrect.GetError(txtEmail) == "Betul!" &&
                epCorrect.GetError(txtTelepon) == "Betul!" &&
                epCorrect.GetError(txtPass1) == "Betul!" &&
                epCorrect.GetError(txtPass2) == "Betul!" &&
                epCorrect.GetError(txtKodeMisi) == "Betul!" &&
                epCorrect.GetError(txtUsername) == "Betul!")
            {
                MessageBox.Show(
                    $"Pendaftaran Diterima!\n\nNama: {txtNama.Text}\nKode: {txtKodeMisi.Text}",
                    "CyberOps Agency", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Masih ada data yang belum valid!\nPeriksa tanda peringatan.",
                    "Gagal Submit", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtNama;
        }

        private void chkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            // Jika Mata Dicentang (Aktif) -> Tampilkan Password
            if (chkShowPass.Checked)
            {
                // '\0' adalah kode untuk "NULL" (tidak ada sensor)
                txtPass1.PasswordChar = '\0';
                txtPass2.PasswordChar = '\0';
            }
            // Jika Tidak Dicentang -> Sensor lagi
            else
            {
                txtPass1.PasswordChar = '*';
                txtPass2.PasswordChar = '*';
            }
        }
    }
}
