using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace P6_3_714240059
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

        private void txtHuruf_Leave(object sender, EventArgs e)
        {
            if (txtHuruf.Text == "")
            {
                SetErrorMessage(txtHuruf, "Textbox Huruf tidak boleh kosong!", "", "");
            }
            else if (txtHuruf.Text.All(Char.IsLetter)) 
            {
                SetErrorMessage(txtHuruf, "", "", "Betul!");
            }
            else
            {
                SetErrorMessage(txtHuruf, "", "Inputan hanya boleh huruf!", "");
            }
        }

        private void txtAngka_TextChanged(object sender, EventArgs e)
        {
            if (txtAngka.Text == "")
            {
                SetErrorMessage(txtAngka, "Textbox Angka tidak boleh kosong!", "", "");
            }
            else if (txtAngka.Text.All(Char.IsNumber)) 
            {
                SetErrorMessage(txtAngka, "", "", "Betul!");
            }
            else
            {
                SetErrorMessage(txtAngka, "", "Inputan hanya boleh angka!", "");
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                SetErrorMessage(txtEmail, "Textbox Email tidak boleh kosong!", "", "");
            }
            // Regex validasi email sederhana
            else if (Regex.IsMatch(txtEmail.Text, @"^[^@\s]+@[^@\s]+(\.[^@\s]+)+$"))
            {
                SetErrorMessage(txtEmail, "", "", "Betul!");
            }
            else
            {
                SetErrorMessage(txtEmail, "", "Format email salah!\nContoh: a@b.c", "");
            }    
        }

        private void txtAngka1_Leave(object sender, EventArgs e)
        {
            if (txtAngka1.Text == "")
            {
                SetErrorMessage(txtAngka1, "Textbox Angka 1 tidak boleh kosong!", "", "");
                return;
            }

            if (!txtAngka1.Text.All(Char.IsNumber))
            {
                SetErrorMessage(txtAngka1, "", "Inputan hanya boleh angka!", "");
                return;
            }

            if (txtAngka2.Text != "" && txtAngka2.Text.All(Char.IsNumber))
            {
                BandingkanAngka();
            }
            else
            {
                // Jika Angka 2 belum ada, Angka 1 dianggap benar sementara
                SetErrorMessage(txtAngka1, "", "", "Betul!");
            }
        }

        private void txtAngka2_Leave(object sender, EventArgs e)
        {
            if (txtAngka2.Text == "")
            {
                SetErrorMessage(txtAngka2, "Textbox Angka 2 tidak boleh kosong!", "", "");
                return;
            }

            if (!txtAngka2.Text.All(Char.IsNumber))
            {
                SetErrorMessage(txtAngka2, "", "Inputan hanya boleh angka!", "");
                return;
            }

            if (txtAngka1.Text != "" && txtAngka1.Text.All(Char.IsNumber))
            {
                BandingkanAngka();
            }
            else
            {
                SetErrorMessage(txtAngka2, "", "", "Betul!");
            }
        }
        private void BandingkanAngka()
        {
            int angka1 = int.Parse(txtAngka1.Text);
            int angka2 = int.Parse(txtAngka2.Text);

            if (angka1 > angka2)
            {
                SetErrorMessage(txtAngka1, "", "", "Betul!");
                SetErrorMessage(txtAngka2, "", "", "Betul!");
            }
            else
            {
                SetErrorMessage(txtAngka1, "", "Angka 1 harus lebih besar dari Angka 2", "");
                SetErrorMessage(txtAngka2, "", "Angka 1 harus lebih besar dari Angka 2", "");
            }
        }
    }
}
