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
    public partial class FormCalculator : Form
    {
        private IList<Calculator> listOfCalculator = new List<Calculator>();
        public FormCalculator()
        {
            InitializeComponent();
        }

        private void FormInput_OnCreate(Calculator cal)
        {
            listOfCalculator.Add(cal);
            lstHasil.Items.Add(cal.Hasil);
        }

        private void lstHasil_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            FormInputCalculator formInput = new FormInputCalculator("Calculator");
            formInput.OnCreate += FormInput_OnCreate;
            formInput.ShowDialog();
        }
    }
}