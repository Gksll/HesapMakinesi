using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Decimal AraToplam = 0;
        Decimal AraToplam2 = 0;
        String Operation = "";
        Boolean durum = false;
        private void btnSayilar_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;

            if (durum == true && sender != null)
            {
                durum = false;
                textBox.Text = string.Empty;
                if (textBox.Text == "0" && btn.Text == "0")
                {
                    return;
                }
                if (btn.Text == "," && textBox.Text.Contains(","))
                {
                    return;
                }
                textBox.Text += btn.Text;
                AraToplam2 = Convert.ToDecimal(textBox.Text);
            }
            else
            {
                if (textBox.Text == "0" && btn.Text == "0")
                {
                    return;
                }
                if (btn.Text == "," && textBox.Text.Contains(","))
                {
                    return;
                }
                textBox.Text += btn.Text;
                AraToplam2 = Convert.ToDecimal(textBox.Text);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lbl.Text = string.Empty;
            textBox.Text = string.Empty;
        }

        private void btnArti_Click(object sender, EventArgs e)
        {

            var btn = (Button)sender;
            Operation = btn.Text;
            lbl.Text += $"{textBox.Text}{Operation}";
            AraToplam = Convert.ToDecimal(textBox.Text);
            textBox.Text = string.Empty;

        }


        private void btnEsittir_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            Hesapla();
            textBox.Text = AraToplam.ToString();
            lbl.Text = string.Empty;
            durum = true;

        }
        public void Hesapla()
        {
            switch (Operation)
            {
                case "+":
                    AraToplam += Convert.ToDecimal(textBox.Text);
                    break;
                case "-":
                    AraToplam -= Convert.ToDecimal(textBox.Text);
                    break;
                case "*":
                    AraToplam *= Convert.ToDecimal(textBox.Text);
                    break;
                case "/":
                    AraToplam /= Convert.ToDecimal(textBox.Text);
                    break;
            }
        }
    }
}
