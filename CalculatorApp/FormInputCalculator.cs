using CalculatorApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class FormInputCalculator : Form
    {
        public delegate void CreateUpdateEventHandler(Calculator cal);
        public event CreateUpdateEventHandler OnCreate;
        public event CreateUpdateEventHandler OnUpdate;
        private bool isNewData = true;
        private Calculator cal;

        public FormInputCalculator()
        {
            InitializeComponent(); 

        }
        public FormInputCalculator(string title) : this()
        {
            this.Text = title;
        }

        private void FormInputCal_Load(object sender, EventArgs e)
        {

        }

        private void cmbOperasi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnProses_Click(object sender, EventArgs e)
        {
            if (isNewData) cal = new Calculator();
            if (txtNilaiA.Text == "" || txtNilaiB.Text == "")
            {
                MessageBox.Show("Datamu belum ke-isi nih !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNilaiA.Focus();
            }
            else if (cmbOperasi.Text=="")
            {
                MessageBox.Show("Silahkan Pilih Operasi !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbOperasi.Focus();
            }
            else
            {
                if (cmbOperasi.Text == "Penjumlahan")
                {
                    cal.Hasil = "Hasil Penjumlahan " + txtNilaiA.Text + " + " + txtNilaiB.Text + " = " + (int.Parse(txtNilaiA.Text) + int.Parse(txtNilaiB.Text));
                }
                else if (cmbOperasi.Text == "Pengurangan")
                {
                    cal.Hasil = "Hasil Pengurangan " + txtNilaiA.Text + " - " + txtNilaiB.Text + " = " + (int.Parse(txtNilaiA.Text) - int.Parse(txtNilaiB.Text));
                }
                else if (cmbOperasi.Text == "Perkalian")
                {
                    cal.Hasil = "Hasil Perkalian " + txtNilaiA.Text + " x " + txtNilaiB.Text + " = " + (int.Parse(txtNilaiA.Text) * int.Parse(txtNilaiB.Text));
                }
                else if (cmbOperasi.Text == "Pembagian")
                {
                    cal.Hasil = "Hasil Pembagian " + txtNilaiA.Text + " : " + txtNilaiB.Text + " = " + (Convert.ToDouble(txtNilaiA.Text) / Convert.ToDouble(txtNilaiB.Text));
                }
                if (isNewData) 
                {
                    OnCreate(cal);
                }
                else 
                {
                    OnUpdate(cal); 
                    this.Close();
                }
            }
        }
    }
}