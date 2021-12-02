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

namespace P4_3_1204013
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       
        

        private void Huruf_Leave(object sender, EventArgs e)
        {
            if (Huruf.Text == "")
            {
                epWarning.SetError(Huruf, "Textbox Huruf tidak boleh kosong");

            }
            else
            {
                if ((Huruf.Text).All(Char.IsLetter))
                {

                    epCorrect.SetError(Huruf, "Betul!");
                }
                else
                {
                    epWrong.SetError(Huruf, "inputan hanya boleh huruf!");

                }
            }
        }

        private void Angka_Leave(object sender, EventArgs e)
        {
            if ((Angka.Text).All(Char.IsNumber))
            {
                epCorrect.SetError(Angka, "Betul!");
            }

            else if (Angka.Text == "")
            {
                epWarning.SetError(Angka, "Textbox Huruf tidak boleh kosong");
            }

            else
            {
                epWrong.SetError(Angka, "inputan hanya boleh Angka!");
            }
        }

        private void Email_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(Email.Text, @"^^[^@\s]+@[^@\s]+(\.[^@\s]+)+$"))
            {
                epCorrect.SetError(Email, "Betul!");
            }

            else if (Email.Text == "")
            {
                epWarning.SetError(Email, "Textbox Huruf tidak boleh kosong");

            }

            else
            {
                epWrong.SetError(Email, "Format email salah !\nContoh: a@b.c");
            }
        }

        private void Angka1_Leave(object sender, EventArgs e)
        {
            if ((Angka1.Text).All(Char.IsNumber))
            {
                if (Angka2.Text == "")
                {
                    epWarning.SetError(Angka1, "Angka 2 Belum terisi");
                }

                else
                {
                    epCorrect.SetError(Angka1, "Angka 2 Terisi");
                }
            }

            else if (Angka1.Text == "")
            {
                epWarning.SetError(Angka1, "Textbox Huruf tidak boleh kosong");

            }

            else
            {
                epWrong.SetError(Angka1, "inputan hanya boleh Angka!");
            }

        }
        private void Angka2_Leave(object sender, EventArgs e)
        {
            if ((Angka2.Text).All(Char.IsNumber))
            {
                int angka1 = int.Parse(Angka1.Text);
                int angka2 = int.Parse(Angka2.Text);
                if (angka1 > angka2)
                {
                    epCorrect.SetError(Angka2, "Angka 1 lebih besar dari angka 2 ");
                }
            }

            else if ((Angka2.Text == ""))
            {
                epWarning.SetError(Angka2, "Textbox Huruf tidak boleh kosong");

            }

            else
            {
                epWrong.SetError(Angka2, "inputan hanya boleh Angka!");
            }
        }

    }
}
