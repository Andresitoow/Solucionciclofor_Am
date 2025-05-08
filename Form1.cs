using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solucionciclofor_Am
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (int.TryParse(txtNumero1.Text, out int num))
            {
                for (int i = 1; i < 10; i++)
                {
                    listBox1.Items.Add($"Número: {num} * {i} = {i*num}");
                }
            }
            else
            {
                MessageBox.Show("Ingrese un número valido");
            }

        }
    }
}
