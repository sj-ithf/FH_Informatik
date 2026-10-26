using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aufgabe1_BMI_Rechner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnCalculate_click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtWeight.Text, out double Weight))
            {
                MessageBox.Show("Ungültiges Gewicht");
            }
            if (!double.TryParse(txtHight.Text, out double Hight))
            {
                MessageBox.Show("Ungültige Grösse");
            }
            double CalculatetBMI = Weight / (Hight * Hight);
            lblBmi.Text = $"Dein MBI ist {CalculatetBMI:F2}";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }

}
